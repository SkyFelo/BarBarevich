using BarBarevich.Classes;
using BarBarevich.Forms.ActivityReservation;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace BarBarevich.Forms.Docs
{
    public partial class DocClientsStat : Form
    {
        private DatabaseManager databaseManager;
        private MainForm lastForm;

        public DocClientsStat(MainForm lastForm)
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
            string start = startDate.ToString("yyyy-MM-dd");
            string end = endDate.ToString("yyyy-MM-dd");

            var wordApp = new Microsoft.Office.Interop.Word.Application();
            Document doc = wordApp.Documents.Add();
            wordApp.Visible = false;

            void AddParagraph(string text, WdParagraphAlignment align 
                = WdParagraphAlignment.wdAlignParagraphLeft, bool bold = false)
            {
                Paragraph p = doc.Paragraphs.Add();
                p.Range.Text = text;
                p.Range.ParagraphFormat.Alignment = align;
                p.Range.Font.Bold = bold ? 1 : 0;
                p.Range.InsertParagraphAfter();

                p.Range.Font.Bold = 0;
            }

            string exePath = System.Windows.Forms.Application.StartupPath;
            string imagePath = Path.Combine(exePath, "Resources", "logo.jpg");
            InlineShape imageShape = doc.InlineShapes.AddPicture(imagePath);
            imageShape.Height = 100;
            imageShape.Width = 100;
            imageShape.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

            doc.Paragraphs.Add();  

            AddParagraph("Информация о посещениях и вкусовых предпочтениях",
                WdParagraphAlignment.wdAlignParagraphCenter, true);

            AddParagraph($"Документ составлен: {DateTime.Now:dd.MM.yy}. " +
                $"Отчётный период: {startDate:dd.MM.yy} — {endDate:dd.MM.yy}.");

            AddParagraph($"Настоящий отчёт подготовлен на основании данных о заказах, " +
                $"совершённых в баре «Бар Баревич» за период с {startDate:dd.MM.yy} по {endDate:dd.MM.yy}." +
                " В ходе анализа рассмотрены ключевые тенденции спроса на позиции меню.");

            string queryOrders = $@"
        SELECT COUNT(r.id_reservation) AS total_orders,
               SUM(CASE WHEN r.people_count = 1 THEN 1 ELSE 0 END) AS individual_orders,
               SUM(CASE WHEN r.people_count > 1 THEN 1 ELSE 0 END) AS group_orders
        FROM reservation r
        WHERE r.date BETWEEN '{start}' AND '{end}'";

            var orderData = databaseManager.GetData(queryOrders);
            int totalOrders = Convert.ToInt32(orderData.Rows[0]["total_orders"]);
            int individualOrders = Convert.ToInt32(orderData.Rows[0]["individual_orders"]);
            int groupOrders = Convert.ToInt32(orderData.Rows[0]["group_orders"]);

            AddParagraph("1. Общая динамика заказов", bold: true);

            AddParagraph($"За отчётный период оформлено {totalOrders} заказов:\n" +
                $"Индивидуальные — {individualOrders * 100 / totalOrders}%\n" +
                $"Групповые — {groupOrders * 100 / totalOrders}%", bold: false);

            string queryCheck = $@"
        SELECT AVG(pl.price * mo.quantity) AS avg_check
        FROM menu_in_order mo
        JOIN price_list pl ON mo.id_price = pl.id_price
        WHERE mo.id_reservation IN (
            SELECT id_reservation FROM reservation WHERE date BETWEEN '{start}' AND '{end}'
        )";

            var checkData = databaseManager.GetData(queryCheck);
            decimal avgCheck = Convert.ToDecimal(checkData.Rows[0]["avg_check"]);

            AddParagraph($"Средний чек: {avgCheck:F2} рублей.");

            string queryTopMenu = $@"
        SELECT mi.name, SUM(mo.quantity) AS total_quantity
        FROM menu_items mi
        JOIN price_list pl ON mi.id_item = pl.id_item
        JOIN menu_in_order mo ON pl.id_price = mo.id_price
        WHERE mo.id_reservation IN (
            SELECT id_reservation FROM reservation WHERE date BETWEEN '{start}' AND '{end}'
        )
        AND mo.id_complete_status = 2 
        GROUP BY mi.id_item
        ORDER BY total_quantity DESC
        LIMIT 5";

            var topMenuItems = databaseManager.GetData(queryTopMenu);

            AddParagraph("2. Топ-5 самых заказываемых блюд и напитков", bold: true);

            Table menuTable = doc.Tables.Add(doc.Bookmarks.get_Item("\\endofdoc").Range, topMenuItems.Rows.Count + 1, 2);
            menuTable.Borders.Enable = 1;
            menuTable.Cell(1, 1).Range.Text = "Название блюда";
            menuTable.Cell(1, 2).Range.Text = "Количество заказов";

            int rowIndex = 2;
            foreach (DataRow row in topMenuItems.Rows)
            {
                menuTable.Cell(rowIndex, 1).Range.Text = row["name"].ToString();
                menuTable.Cell(rowIndex, 2).Range.Text = row["total_quantity"].ToString();
                rowIndex++;
            }

            AddParagraph("");
            AddParagraph("Подпись:_____________                                                                М.П.: ", 
                WdParagraphAlignment.wdAlignParagraphRight);

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Word Document (*.docx)|*.docx";
                saveDialog.FileName = $"Отчёт_по_удержанию_и_предпочтению_клиентов_{startDate:yyyyMMdd}_{endDate:yyyyMMdd}.docx";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        doc.SaveAs2(saveDialog.FileName);
                        MessageBox.Show("Документ успешно сохранён.", 
                            "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(DocClientsStat));
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
