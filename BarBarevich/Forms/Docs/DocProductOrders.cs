using BarBarevich.Classes;
using BarBarevich.Forms.ActivityReservation;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace BarBarevich.Forms.Docs
{
    public partial class DocProductOrders : Form
    {
        private DatabaseManager databaseManager;
        private MainForm lastForm;
        public DocProductOrders(MainForm lastForm)
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
                MessageBox.Show("Начальная дата не может быть позже конечной даты.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GenerateProductOrderDoc(startDate, endDate);
        }

        public static void GenerateProductOrderDoc(DateTime startDate, DateTime endDate)
        {
            DatabaseManager db = new DatabaseManager(); 

            string totalQuery = $@"
        SELECT 
    u.unit AS 'Единица измерения', 
    SUM(pis.quantity) AS total_quantity, 
    SUM(pis.price) AS total_cost
FROM product_in_supply pis
JOIN product p ON pis.id_product = p.id_product
JOIN s_units u ON p.id_unit = u.id_unit
JOIN supply sup ON pis.id_supply = sup.id_supply
JOIN purchase_order po ON sup.id_purchase_order = po.id_purchase_order
WHERE po.purchase_date BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}'
  AND sup.id_complete_status = 2
GROUP BY u.unit
ORDER BY u.unit;
";

            string suppliersQuery = $@"
        SELECT DISTINCT s.supplier_name
        FROM suppliers s
        JOIN purchase_order po ON s.id_supplier = po.id_supplier
        WHERE po.purchase_date BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}'";

            string detailsQuery = $@"
SELECT 
    sup.invoice_number,
    po.purchase_date,
    sup.supply_date,
    s.supplier_name,
    pr.product_name,
    u.unit,
    pis.quantity,
    pis.price
FROM product_in_order pio
JOIN product pr ON pio.id_product = pr.id_product
JOIN purchase_order po ON pio.id_purchase_order = po.id_purchase_order
JOIN suppliers s ON po.id_supplier = s.id_supplier
JOIN supply sup ON po.id_purchase_order = sup.id_purchase_order
JOIN product_in_supply pis 
  ON sup.id_supply = pis.id_supply AND pr.id_product = pis.id_product
JOIN s_units u ON pr.id_unit = u.id_unit
WHERE po.purchase_date BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}'
AND sup.id_complete_status = 2 
ORDER BY po.purchase_date ASC";



            System.Data.DataTable totalTable = db.GetData(totalQuery);
            System.Data.DataTable suppliersTable = db.GetData(suppliersQuery);
            System.Data.DataTable detailsTable = db.GetData(detailsQuery);

            Microsoft.Office.Interop.Word.Application wordApp = new Word.Application();
            Microsoft.Office.Interop.Word.Document doc = wordApp.Documents.Add();
            wordApp.Visible = false;

            string exePath = System.Windows.Forms.Application.StartupPath;
            string imagePath = Path.Combine(exePath, "Resources", "logo.jpg");
            InlineShape imageShape = doc.InlineShapes.AddPicture(imagePath);
            imageShape.Height = 100;
            imageShape.Width = 100;
            imageShape.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

            doc.Paragraphs.Add();

            void AddParagraph(string text, Word.WdParagraphAlignment align = Word.WdParagraphAlignment.wdAlignParagraphLeft, bool bold = false)
            {
                Word.Paragraph p = doc.Paragraphs.Add();
                p.Range.Text = text;
                p.Range.ParagraphFormat.Alignment = align;
                p.Range.Font.Bold = bold ? 1 : 0;
                p.Range.InsertParagraphAfter();
            }

            AddParagraph("РЕЕСТР ЗАКАЗОВ ПРОДУКЦИИ", Word.WdParagraphAlignment.wdAlignParagraphCenter, true);
            AddParagraph($"Документ составлен {DateTime.Now:dd.MM.yy}");
            AddParagraph($"Настоящий отчёт составлен на основании данных о закупках продукции в баре «Бар Баревич» за период с " +
                $"{startDate:dd.MM} по {endDate:dd.MM}.");

            int grandTotalQty = 0;
            decimal grandTotalSum = 0;

            foreach (DataRow row in totalTable.Rows)
            {
                if (int.TryParse(row["total_quantity"].ToString(), out int qty))
                    grandTotalQty += qty;

                if (decimal.TryParse(row["total_cost"].ToString(), out decimal cost))
                    grandTotalSum += cost;
            }


            AddParagraph("1. Общие показатели закупок", bold: true);


            AddParagraph($"1.1. Общий объём закупок\nЗа период закуплено продукции на сумму {grandTotalSum:F2} руб.");


            AddParagraph("2. Реестр поставщиков", bold: true);
            AddParagraph($"В отчётный период сотрудничество велось с {suppliersTable.Rows.Count} поставщиками:");
            int supplierIndex = 1;
            foreach (DataRow row in suppliersTable.Rows)
            {
                AddParagraph($"{supplierIndex++}) {row["supplier_name"]}");
            }


            AddParagraph("3. Детализация заказов", bold: true);

            var groupedByInvoice = detailsTable.AsEnumerable()
                .GroupBy(row => row["invoice_number"].ToString());

            int tableCounter = 1;

            foreach (var invoiceGroup in groupedByInvoice)
            {
                var firstRow = invoiceGroup.First();
                string invoice = firstRow["invoice_number"].ToString();
                string purchaseDate = Convert.ToDateTime(firstRow["purchase_date"]).ToShortDateString();
                string supplyDate = Convert.ToDateTime(firstRow["supply_date"]).ToShortDateString();
                string supplier = firstRow["supplier_name"].ToString();

                AddParagraph($"{tableCounter++}) Накладная: {invoice} | Дата заказа: {purchaseDate} | Дата доставки: " +
                    $"{supplyDate} | Поставщик: {supplier}", bold: false);

                string[] headers = { "№", "Наименование", "Ед.", "Кол-во", "Цена (руб.)" };
                Table table = doc.Tables.Add(doc.Paragraphs.Add().Range, invoiceGroup.Count() + 1, headers.Length);

                table.Borders.Enable = 1;

                for (int i = 0; i < headers.Length; i++)
                {
                    var cell = table.Cell(1, i + 1).Range;
                    cell.Text = headers[i];
                    cell.Bold = 1;
                }

                int itemIndex = 1;
                foreach (var row in invoiceGroup)
                {
                    table.Cell(itemIndex + 1, 1).Range.Text = itemIndex.ToString();
                    table.Cell(itemIndex + 1, 2).Range.Text = row["product_name"].ToString();
                    table.Cell(itemIndex + 1, 3).Range.Text = row["unit"].ToString();
                    table.Cell(itemIndex + 1, 4).Range.Text = row["quantity"].ToString();
                    table.Cell(itemIndex + 1, 5).Range.Text = Convert.ToDecimal(row["price"]).ToString("F2");


                    for (int col = 1; col <= headers.Length; col++)
                    {
                        table.Cell(itemIndex + 1, col).Range.Bold = 0;
                    }

                    itemIndex++;
                }
            }



            AddParagraph("");
            AddParagraph("Подпись:_____________                                                                М.П.:",
                WdParagraphAlignment.wdAlignParagraphLeft);

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Word Document (*.docx)|*.docx";
                saveDialog.FileName = $"Заказы_продукции_{startDate:yyyyMMdd}_{endDate:yyyyMMdd}.docx";

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

        private void labelBack_Click(object sender, EventArgs e)
        {
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            this.Close();
            lastForm.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                HelpManager.ShowHelp(nameof(DocProductOrders));
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
