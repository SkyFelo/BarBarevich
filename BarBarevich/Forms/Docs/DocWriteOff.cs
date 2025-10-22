using BarBarevich.Classes;
using BarBarevich.Forms.ActivityReservation;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace BarBarevich.Forms.Docs
{
    public partial class DocWriteOff : Form
    {
        private DatabaseManager databaseManager;
        private MainForm lastForm;

        public DocWriteOff(MainForm lastForm)
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
            this.lastForm = lastForm;

            dateTimePickerStart.Value = DateTime.Now.AddMonths(-1);
            dateTimePickerEnd.Value = DateTime.Now;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;

            if (startDate > endDate)
            {
                MessageBox.Show("Начальная дата не может быть позже конечной.", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CreateWordDocument(startDate, endDate);
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            this.Close();
            lastForm.Show();
        }

        private void CreateWordDocument(DateTime startDate, DateTime endDate)
        {
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            Document doc = wordApp.Documents.Add();

            void AddParagraph(string text, WdParagraphAlignment align = WdParagraphAlignment.wdAlignParagraphLeft, bool bold = false)
            {
                Paragraph p = doc.Paragraphs.Add();
                p.Range.Text = text;
                p.Range.Font.Bold = bold ? 1 : 0;
                p.Range.ParagraphFormat.Alignment = align;
                p.Range.InsertParagraphAfter();
            }
            wordApp.Visible = false;

      /*      string exePath = System.Windows.Forms.Application.StartupPath;
            string imagePath = Path.Combine(exePath, "Resources", "logo.jpg");
            MessageBox.Show(exePath);
            InlineShape imageShape = doc.InlineShapes.AddPicture(imagePath);
            imageShape.Height = 100;
            imageShape.Width = 100;
            imageShape.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; 

            doc.Paragraphs.Add(); */

            AddParagraph("Информация о списанных продуктах", WdParagraphAlignment.wdAlignParagraphCenter, true);
            AddParagraph($"Документ составлен {DateTime.Now:dd.MM.yy}", WdParagraphAlignment.wdAlignParagraphCenter);
            AddParagraph($"Настоящий отчёт подготовлен на основании данных о списании и утилизации товарных позиций " +
                $"в баре «Бар Баревич» за период с {startDate:dd.MM} по {endDate:dd.MM}. В отчёте представлены сведения " +
                $"о причинах списания, объёмах потерь, категориях товаров, подлежащих утилизации, а также анализ факторов, " +
                $"влияющих на эффективность товарного учёта.");

            AddParagraph("1. Общие сведения о списании товаров", bold: true);

            string groupedTotalQuery = $@"
    SELECT u.unit, SUM(wp.quantity) AS total_quantity
    FROM written_off_products wp
    JOIN product p ON wp.id_product = p.id_product
    JOIN s_units u ON p.id_unit = u.id_unit
    WHERE wp.write_off_date BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}'
    GROUP BY u.unit";

            System.Data.DataTable groupedTable = databaseManager.GetData(groupedTotalQuery);

            if (groupedTable.Rows.Count > 0)
            {
                AddParagraph("За отчётный период было списано следующего количества продукции по типам измерения:");
                foreach (DataRow row in groupedTable.Rows)
                {
                    string unit = row["unit"].ToString();
                    double quantity = Convert.ToDouble(row["total_quantity"]);
                    AddParagraph($"- {quantity} {unit}");
                }
            }
            else
            {
                AddParagraph("Нет данных о списании продукции за выбранный период.");
            }

            AddParagraph("2. Причины списания", bold: true);
            AddParagraph("Распределение списания по основным причинам:");

            string reasonQuery = $@"
        SELECT swt.writeoff_type, COUNT(*) AS reason_count
        FROM written_off_products wp
        JOIN s_writeoff_type swt ON swt.id_writeoff_type = wp.id_write_off_type
        WHERE wp.write_off_date BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}'
        GROUP BY swt.writeoff_type";

            System.Data.DataTable reasonTable = databaseManager.GetData(reasonQuery);
            int totalReasons = 0;
            foreach (DataRow row in reasonTable.Rows)
                totalReasons += Convert.ToInt32(row["reason_count"]);

            foreach (DataRow row in reasonTable.Rows)
            {
                string reason = row["writeoff_type"].ToString();
                int count = Convert.ToInt32(row["reason_count"]);
                double percent = Math.Round((double)count / totalReasons * 100, 2);
                AddParagraph($"- {reason} — {percent}%");
            }

            AddParagraph("3. Таблица списанных товаров", bold: true);

            string tableQuery = $@"
        SELECT w.id_written_off_product, p.product_name, u.unit, w.quantity, w.write_off_date, t.writeoff_type
        FROM written_off_products w
        JOIN product p ON w.id_product = p.id_product
        JOIN s_writeoff_type t ON w.id_write_off_type = t.id_writeoff_type
        JOIN s_units u ON u.id_unit = p.id_unit 
        WHERE w.write_off_date BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}'
        ORDER BY w.write_off_date";

            System.Data.DataTable tableData = databaseManager.GetData(tableQuery);

            if (tableData.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Word.Table table = doc.Tables.Add(doc.Paragraphs.Add().Range, tableData.Rows.Count + 1, 5);
                table.Borders.Enable = 1;
                table.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

                string[] headers = { "Наименование товара", "Единица измеренения", "Количество", "Дата списания", "Причина" };
                for (int i = 0; i < headers.Length; i++)
                {
                    var cell = table.Cell(1, i + 1).Range;
                    cell.Text = headers[i];
                    cell.Bold = 1; 
                }

                for (int i = 0; i < tableData.Rows.Count; i++)
                {
                    DataRow row = tableData.Rows[i];

                    for (int j = 0; j < headers.Length; j++)
                    {
                        table.Cell(i + 2, j + 1).Range.Bold = 0;
                    }

                    table.Cell(i + 2, 1).Range.Text = row["product_name"].ToString();
                    table.Cell(i + 2, 2).Range.Text = row["unit"].ToString();
                    table.Cell(i + 2, 3).Range.Text = row["quantity"].ToString();
                    table.Cell(i + 2, 4).Range.Text = Convert.ToDateTime(row["write_off_date"]).ToString("dd.MM.yyyy HH:mm");
                    table.Cell(i + 2, 5).Range.Text = row["writeoff_type"].ToString(); 
                }

            }
            else
            {
                AddParagraph("Нет данных для выбранного периода.");
            }

            AddParagraph("");
            AddParagraph("Подпись:_____________                                                                М.П.:",
                WdParagraphAlignment.wdAlignParagraphLeft);

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Word Document (*.docx)|*.docx";
                saveDialog.FileName = $"Списание_{startDate:yyyyMMdd}_{endDate:yyyyMMdd}.docx";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        doc.SaveAs2(saveDialog.FileName);
                        MessageBox.Show("Документ успешно сохранён.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при сохранении документа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            doc.Close(false);
            wordApp.Quit();
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(DocWriteOff));
                return true;
            }

            if (keyData == Keys.Enter)
            {
                buttonCreate.PerformClick();
                return true;
            }

            if (keyData == Keys.Escape)
            {
                lastForm.StartPosition = FormStartPosition.Manual;
                lastForm.Location = this.Location;
                this.Close();
                lastForm.Show();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                lastForm.StartPosition = FormStartPosition.Manual;
                lastForm.Location = this.Location;
                lastForm.Show();
            }
        }
    }

}
