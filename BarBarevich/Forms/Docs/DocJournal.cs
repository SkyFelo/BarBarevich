using Microsoft.Office.Interop.Excel;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BarBarevich.Classes;
using BarBarevich.Forms.ActivityReservation;

namespace BarBarevich.Forms.Docs
{
    public partial class DocJournal : Form
    {
        private DatabaseManager databaseManager;
        private MainForm lastForm;
        public DocJournal(MainForm lastForm)
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
            this.lastForm = lastForm;

            dateTimePicker.Value = DateTime.Now;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker.Value.Date;

            CreateExcelDocument(date);
        }

        private void CreateExcelDocument(DateTime date)
        {
            string formattedDate = date.ToString("yyyy-MM-dd");
            string query = $@"
                WITH all_tables AS (
    SELECT 1 AS id_table UNION ALL
    SELECT 2 UNION ALL
    SELECT 3 UNION ALL
    SELECT 4 UNION ALL
    SELECT 5 UNION ALL
    SELECT 6 UNION ALL
    SELECT 7 UNION ALL
    SELECT 8 UNION ALL
    SELECT 9 UNION ALL
    SELECT 10 UNION ALL
    SELECT 11 UNION ALL
    SELECT 12 UNION ALL
    SELECT 13 UNION ALL
    SELECT 14 UNION ALL
    SELECT 15 UNION ALL
    SELECT 16
),
latest_reservations AS (
    SELECT 
        tr.id_table,
        r.id_reservation,
        r.time,
        r.people_count,
        r.extra_info,
        r.deposit,
        r.id_client,
        ROW_NUMBER() OVER (PARTITION BY tr.id_table ORDER BY r.time) AS rn
    FROM 
        tables_in_reservation tr
    JOIN reservation r ON tr.id_reservation = r.id_reservation
    WHERE r.date = '{formattedDate}'
)
SELECT 
    at.id_table AS 'Номер стола',
    c.full_name AS 'Имя гостя',
    TIME_FORMAT(r.time, '%H:%i') AS 'Время',
    r.people_count AS 'Количество человек',
    c.phone AS 'Номер',
    r.extra_info AS 'Мероприятие',
    r.deposit AS 'Депозит'
FROM 
    all_tables at
LEFT JOIN latest_reservations r ON at.id_table = r.id_table AND r.rn = 1
LEFT JOIN client c ON r.id_client = c.id_client
ORDER BY 
    at.id_table;
;
            ";

            System.Data.DataTable dataTable = databaseManager.GetData(query);

            bool hasRealData = dataTable.AsEnumerable().Any(row =>
    !string.IsNullOrWhiteSpace(row["Имя гостя"]?.ToString()) ||
    !string.IsNullOrWhiteSpace(row["Номер"]?.ToString()) ||
    !string.IsNullOrWhiteSpace(row["Время"]?.ToString())
);

            if (!hasRealData)
            {
                MessageBox.Show("На выбранную дату нет активных бронирований. Отчёт не будет создан.", 
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ExportToExcel(dataTable, "ЖУРНАЛ БРОНИРОВАНИЯ \"БАР БАРЕВИЧ\"", $"{DateTime.Now:dd MMMM yyyy dddd}",
                "Настоящий отчёт подготовлен для просмотра бронирования в баре «Бар Баревич» на момент " +
                "даты: " + date.ToString("dd.MM.yyyy") + ". В отчёте представлены сведения о клиенте, " +
                "номере стола, депозите и информация о бронировании", "Подпись: ", "Печать: ");
        }

        private void ExportToExcel(System.Data.DataTable dataTable, string title, string subtitle, string text, string sign, string print)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = excelApp.Workbooks.Add();
            Worksheet worksheet = workbook.Sheets[1];

            worksheet.Cells[1, 1] = title;
            worksheet.Cells[2, 1] = subtitle;
            worksheet.Cells[3, 1] = text;
            worksheet.Cells[23, 1] = sign;
            worksheet.Cells[23, 5] = print;

            Range titleRange = worksheet.Range["A1", "G1"];
            titleRange.Merge();
            titleRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            titleRange.Font.Bold = true;
            titleRange.Font.Size = 14;

            Range subtitleRange = worksheet.Range["A2", "G2"];
            subtitleRange.Merge();
            subtitleRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            subtitleRange.Font.Size = 12;

            Range textRange = worksheet.Range["A3", "G3"];
            textRange.Merge();
            textRange.HorizontalAlignment = XlHAlign.xlHAlignLeft;
            textRange.Font.Size = 12;
            textRange.RowHeight = 45;
            textRange.WrapText = true;

            worksheet.Cells[4, 1] = "Номер стола";
            worksheet.Cells[4, 2] = "Имя гостя";
            worksheet.Cells[4, 3] = "Время";
            worksheet.Cells[4, 4] = "Количество человек";
            worksheet.Cells[4, 5] = "Номер";
            worksheet.Cells[4, 6] = "Мероприятие";
            worksheet.Cells[4, 7] = "Депозит (руб.)";

            Range headerRange = worksheet.Range["A4", "G4"];
            headerRange.Font.Bold = true;
            headerRange.Interior.Color = XlRgbColor.rgbLightGray;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    worksheet.Cells[i + 5, j + 1] = dataTable.Rows[i][j];
                }
            }

            worksheet.Columns.AutoFit();

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel файлы (*.xlsx)|*.xlsx";
                saveFileDialog.FileName = "Журнал_бронирования_Бар_Баревич_" + dateTimePicker.Value.ToString("yyyy-MM-dd") + ".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Документ успешно сохранён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при сохранении документа." , "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            workbook.Close(false);
            excelApp.Quit();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            GC.Collect();
            GC.WaitForPendingFinalizers();

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
                HelpManager.ShowHelp(nameof(DocJournal));
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
