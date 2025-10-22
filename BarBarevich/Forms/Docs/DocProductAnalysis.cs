using BarBarevich.Classes;
using Microsoft.Office.Interop.Word;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace BarBarevich.Forms.Docs
{
    public partial class DocProductAnalysis : Form
    {
        private DatabaseManager databaseManager;
        private MainForm lastForm;

        public DocProductAnalysis(MainForm lastForm)
        {
            InitializeComponent();
            this.databaseManager = new DatabaseManager();
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
                MessageBox.Show("Начальная дата не может быть позже конечной.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Word.Application wordApp = new Word.Application();
            Document doc = wordApp.Documents.Add();

            string exePath = System.Windows.Forms.Application.StartupPath;
            string imagePath = Path.Combine(exePath, "Resources", "logo.jpg");

            InlineShape image = doc.InlineShapes.AddPicture(imagePath);
            image.Height = 100;
            image.Width = 100;
            image.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

            doc.Paragraphs.Add();

            Paragraph title = doc.Paragraphs.Add();
            title.Range.Text = "Информация о производственном расходе продуктов";
            title.Range.Font.Size = 14;
            title.Range.Bold = 1;
            title.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            title.Range.InsertParagraphAfter();

            Paragraph dateInfo = doc.Paragraphs.Add();
            dateInfo.Range.Text = $"Документ составлен {DateTime.Now:dd.MM.yyyy}";
            dateInfo.Range.Font.Bold = 0;
            dateInfo.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            dateInfo.Range.InsertParagraphAfter();

            string countQuery = $@"
SELECT COUNT(*) 
FROM reservation r, menu_in_order m
WHERE r.date BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}'
AND r.id_reservation = m.id_reservation
AND m.id_complete_status = 2";

            System.Data.DataTable countTable = databaseManager.GetData(countQuery);
            int reservationCount = 0;

            if (countTable.Rows.Count > 0)
            {
                reservationCount = Convert.ToInt32(countTable.Rows[0][0]);
            }


            Paragraph intro = doc.Paragraphs.Add();
            string word = GetWordForm(reservationCount, "выдача", "выдачи", "выдач");
            intro.Range.Text = $"Настоящий документ отражает данные по производственному расходу продуктов " +
                $"в период с {startDate:dd.MM} по {endDate:dd.MM}, включая {reservationCount} {word} заказов по меню.";


            intro.Range.Font.Bold = 0;
            intro.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify;
            intro.Range.InsertParagraphAfter();

            AddBoldHeading(doc, "1. Расход продуктов");

            string expenseQuery = $@"
SELECT 
    p.product_name,
    r.date AS expense_date,
    SUM(pimi.quantity * mo.quantity) AS total_quantity,
    u.unit
FROM reservation r
JOIN menu_in_order mo ON r.id_reservation = mo.id_reservation
JOIN price_list pl ON mo.id_price = pl.id_price
JOIN menu_items mi ON pl.id_item = mi.id_item
JOIN product_in_menu_items pimi ON mi.id_item = pimi.id_item
JOIN product p ON pimi.id_product = p.id_product
JOIN s_units u ON p.id_unit = u.id_unit
WHERE r.date BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}'
  AND mo.id_complete_status != 1
GROUP BY p.product_name, r.date, u.unit
ORDER BY r.date, p.product_name;";

            System.Data.DataTable expenseTable = databaseManager.GetData(expenseQuery);
            AddTableToWord(doc, expenseTable, new[] {
                "Продукт", "Дата траты", "Потрачено (ед.)", "Ед. изм."
            });

            Paragraph signature = doc.Paragraphs.Add();
            signature.Range.Text = "\nПодпись: _____________                            М.П.: ";
            signature.Range.InsertParagraphAfter();

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Word Document (*.docx)|*.docx";
                saveDialog.FileName = $"Расход_продуктов_{startDate:yyyyMMdd}_{endDate:yyyyMMdd}.docx";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        doc.SaveAs2(saveDialog.FileName);
                        MessageBox.Show("Документ успешно сохранён.", "Успешно",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при сохранении документа." ,
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            doc.Close(false);
            wordApp.Quit();
        }

        private string GetWordForm(int number, string nominative, string genitiveSingular, string genitivePlural)
        {
            number = Math.Abs(number) % 100;
            int lastDigit = number % 10;

            if (number > 10 && number < 20)
                return genitivePlural;
            if (lastDigit == 1)
                return nominative;
            if (lastDigit >= 2 && lastDigit <= 4)
                return genitiveSingular;
            return genitivePlural;
        }

        private void AddBoldHeading(Document doc, string text)
        {
            Paragraph heading = doc.Paragraphs.Add();
            heading.Range.Text = text;
            heading.Range.Bold = 1;
            heading.Range.Font.Size = 12;
            heading.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
            heading.Range.InsertParagraphAfter();
        }

        private void AddTableToWord(Document doc, System.Data.DataTable table, string[] headers)
        {
            Table wordTable = doc.Tables.Add(doc.Paragraphs.Add().Range, table.Rows.Count + 1, headers.Length);
            wordTable.Borders.Enable = 1;

            for (int i = 0; i < headers.Length; i++)
            {
                var cell = wordTable.Cell(1, i + 1).Range;
                cell.Text = headers[i];
                cell.Bold = 1;
                cell.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            }

            for (int row = 0; row < table.Rows.Count; row++)
            {
                for (int col = 0; col < headers.Length; col++)
                {
                    var value = table.Rows[row][col];
                    var cell = wordTable.Cell(row + 2, col + 1).Range;

                    if (value is DateTime dt)
                        cell.Text = dt.ToString("dd.MM.yyyy");
                    else
                        cell.Text = value.ToString();

                    cell.Bold = 0;
                    cell.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(DocProductAnalysis));
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
