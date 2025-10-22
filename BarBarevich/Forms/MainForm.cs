using BarBarevich.Classes;
using BarBarevich.Forms.Docs;
using BarBarevich.Forms.S_Tables.s_activity_type;
using BarBarevich.Forms.S_Tables.s_employee_role;
using BarBarevich.Forms.S_Tables.s_menu_category;
using BarBarevich.Forms.S_Tables.s_menu_complete_status;
using BarBarevich.Forms.S_Tables.s_units;
using BarBarevich.Forms.S_Tables.s_writeoff_type;
using BarBarevich.Forms.View;
using BarBarevich.Forms.View.Employee;
using BarBarevich.Forms.View.Products;
using BarBarevich.Forms.View.Supplier;
using BarBarevich.Forms.View.SupplyOrder;
using BarBarevich.Forms.View.Tables;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace BarBarevich.Forms
{
    public partial class MainForm : Form
    {
        private Authorization lastForm;
        private int id_employee_use;
        private int id_employee_role;
        public MainForm(Authorization lastForm, int id_employee, int roleId)
        {
            InitializeComponent();
            this.lastForm = lastForm;
            this.id_employee_use = id_employee;

            if (!(roleId == 2))
            {
                toolStripMenuItemClients.Visible = false;
                toolStripMenuItemEmployees.Visible = false;
                toolStripMenuItemMenuList.Visible = false;
                toolStripMenuItemProducts.Visible = false;
                toolStripMenuItemTables.Visible = false;
                toolStripMenuItemOrders.Visible = false;
                toolStripMenuItemSuppliers.Visible = false;
                buttonImport.Visible = false;
                buttonExport.Visible = false;
            }

            this.id_employee_role = roleId;
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
            lastForm.StartPosition = FormStartPosition.Manual;
            lastForm.Location = this.Location;
            lastForm.Show();
        }

        private void toolStripMenuItemReservation_Click(object sender, EventArgs e)
        {
            NewReservation newReservation = new NewReservation(this);
            newReservation.StartPosition = FormStartPosition.Manual;
            newReservation.Location = this.Location;
            this.Hide();
            newReservation.Show();
        }

        private void toolStripMenuItemScheme_Click(object sender, EventArgs e)
        {
            View.BarHallView barHallView = new View.BarHallView(this);
            barHallView.StartPosition = FormStartPosition.Manual;
            barHallView.Location = this.Location;
            this.Hide();
            barHallView.Show();
        }

        private void toolStripMenuItemClients_Click(object sender, EventArgs e)
        {
            View.ClientsView clientsView = new View.ClientsView(this);
            clientsView.StartPosition = FormStartPosition.Manual;
            clientsView.Location = this.Location;
            this.Hide();
            clientsView.Show();
        }

        private void toolStripMenuItemMenuList_Click(object sender, EventArgs e)
        {
            View.MenuView menuView = new View.MenuView(this);
            menuView.StartPosition = FormStartPosition.Manual;
            menuView.Location = this.Location;
            this.Hide();
            menuView.Show();
        }

        private void toolStripMenuItemReseravtions_Click(object sender, EventArgs e)
        {
            View.ReservationView activityView = new View.ReservationView(this);
            activityView.StartPosition = FormStartPosition.Manual;
            activityView.Location = this.Location;
            this.Hide();
            activityView.Show();
        }

        private void toolStripMenuItemEmployees_Click(object sender, EventArgs e)
        {
            View.Employee.EmployeeView employeeView = new View.Employee.EmployeeView(this);
            employeeView.StartPosition = FormStartPosition.Manual;
            employeeView.Location = this.Location;
            this.Hide();
            employeeView.Show();
        }

        private void toolStripMenuItemTables_Click(object sender, EventArgs e)
        {
            View.Tables.TablesView tablesView = new View.Tables.TablesView(this);
            tablesView.StartPosition = FormStartPosition.Manual;
            tablesView.Location = this.Location;
            this.Hide();
            tablesView.Show();
        }

        private void toolStripMenuItemProducts_Click(object sender, EventArgs e)
        {
            View.Products.ProductView productView = new View.Products.ProductView(this);
            productView.StartPosition = FormStartPosition.Manual;
            productView.Location = this.Location;
            this.Hide();
            productView.Show();
        }

        private void toolStripMenuItemSuppliers_Click(object sender, EventArgs e)
        {
            View.Supplier.SupplierView supplierView = new View.Supplier.SupplierView(this);
            supplierView.StartPosition = FormStartPosition.Manual;
            supplierView.Location = this.Location;
            this.Hide();
            supplierView.Show();
        }

        private void toolStripMenuItemOrders_Click(object sender, EventArgs e)
        {
            View.SupplyOrder.SupplyOrderView supplyOrderView = new View.SupplyOrder.SupplyOrderView(this);
            supplyOrderView.StartPosition = FormStartPosition.Manual;
            supplyOrderView.Location = this.Location;
            this.Hide();
            supplyOrderView.Show();
        }

        private void toolStripMenuItemEvents_Click(object sender, EventArgs e)
        {
            View.Events.EventView eventView = new View.Events.EventView(this);
            eventView.StartPosition = FormStartPosition.Manual;
            eventView.Location = this.Location;
            this.Hide();
            eventView.Show();
        }

        //Справочники

        private void toolStripMenuItemSEvents_Click(object sender, EventArgs e)
        {
            EventForm activityTypeForm = new EventForm(this);
            activityTypeForm.StartPosition = FormStartPosition.Manual;
            activityTypeForm.Location = this.Location;
            this.Hide();
            activityTypeForm.Show();
        }

        private void toolStripMenuItemSRoles_Click(object sender, EventArgs e)
        {
            EmployeeRoleForm employeeRoleForm = new EmployeeRoleForm(this);
            employeeRoleForm.StartPosition = FormStartPosition.Manual;
            employeeRoleForm.Location = this.Location;
            this.Hide();
            employeeRoleForm.Show();
        }

        private void toolStripMenuItemSCategories_Click(object sender, EventArgs e)
        {
            MenuCategory menuCategory = new MenuCategory(this);
            menuCategory.StartPosition = FormStartPosition.Manual;
            menuCategory.Location = this.Location;
            this.Hide();
            menuCategory.Show();
        }

        private void toolStripMenuItemSStatuses_Click(object sender, EventArgs e)
        {
            StatusForm menuStatusForm = new StatusForm(this);
            menuStatusForm.StartPosition = FormStartPosition.Manual;
            menuStatusForm.Location = this.Location;
            this.Hide();
            menuStatusForm.Show();
        }

        private void toolStripMenuItemSUnits_Click(object sender, EventArgs e)
        {
            UnitForm unitForm = new UnitForm(this);
            unitForm.StartPosition = FormStartPosition.Manual;
            unitForm.Location = this.Location;
            this.Hide();
            unitForm.Show();
        }

        private void toolStripMenuItemSWriteOff_Click(object sender, EventArgs e)
        {
            WriteoffTypeForm writeoffTypeForm = new WriteoffTypeForm(this);
            writeoffTypeForm.StartPosition = FormStartPosition.Manual;
            writeoffTypeForm.Location = this.Location;
            this.Hide();
            writeoffTypeForm.Show();
        }

        //Документы

        private void toolStripMenuItemDocJurnal_Click(object sender, EventArgs e)
        {
            Docs.DocJournal docJournal = new Docs.DocJournal(this);
            docJournal.StartPosition = FormStartPosition.Manual;
            docJournal.Location = this.Location;
            this.Hide();
            docJournal.Show();
        }

        private void toolStripMenuItemDocAnalysis_Click(object sender, EventArgs e)
        {
            Docs.DocProductAnalysis docProductAnalysis = new Docs.DocProductAnalysis(this);
            docProductAnalysis.StartPosition = FormStartPosition.Manual;
            docProductAnalysis.Location = this.Location;
            this.Hide();
            docProductAnalysis.Show();
        }

        private void toolStripMenuItemDocClients_Click(object sender, EventArgs e)
        {
            Docs.DocClientsStat docClientsStat = new Docs.DocClientsStat(this);
            docClientsStat.StartPosition = FormStartPosition.Manual;
            docClientsStat.Location = this.Location;
            this.Hide();
            docClientsStat.Show();
        }

        private void toolStripMenuItemDocWriteOff_Click(object sender, EventArgs e)
        {
            Docs.DocWriteOff docWriteOff = new Docs.DocWriteOff(this);
            docWriteOff.StartPosition = FormStartPosition.Manual;
            docWriteOff.Location = this.Location;
            this.Hide();
            docWriteOff.Show();
        }

        private void toolStripMenuItemDocOrders_Click(object sender, EventArgs e)
        {
            Docs.DocProductOrders docProductOrders = new Docs.DocProductOrders(this);
            docProductOrders.StartPosition = FormStartPosition.Manual;
            docProductOrders.Location = this.Location;
            this.Hide();
            docProductOrders.Show();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "SQL файлы (*.sql)|*.sql";
                saveFileDialog.Title = "Сохранить резервную копию базы данных";
                saveFileDialog.FileName = "backup_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".sql";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(DatabaseManager.connectionString))
                        using (MySqlCommand cmd = new MySqlCommand())
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(saveFileDialog.FileName);
                            conn.Close();
                        }

                        MessageBox.Show("Резервная копия успешно создана.", 
                            "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при создании резервной копии.", 
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "SQL файлы (*.sql)|*.sql";
                openFileDialog.Title = "Необходимо выбрать файл резервной копии";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(DatabaseManager.connectionString))
                        using (MySqlCommand cmd = new MySqlCommand())
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ImportFromFile(openFileDialog.FileName);
                            conn.Close();
                        }

                        MessageBox.Show("База данных успешно восстановлена.", 
                            "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при восстановлении базы данных.", 
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                ShowHelp();
                return true;
            }

            if (keyData == Keys.Escape)
            {
                this.Close();
                lastForm.StartPosition = FormStartPosition.Manual;
                lastForm.Location = this.Location;
                lastForm.Show();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void ShowHelp()
        {
            string roleDescription = "Роль: ";
            roleDescription += (toolStripMenuItemClients.Visible ? "Администратор" : "Официант/Менеджер");

            if (id_employee_role == 2)
            {
                string helpText =
                    "Главная форма приложения Бар Баревич\n\n" +
$"{roleDescription}\n\n" +
"Назначение: с этой формы осуществляется переход ко всем ключевым модулям системы управления баром.\n\n" +
"Структура меню:\n" +
"1. Схема зала – визуальное отображение и описание столов\n" +
"2. Бронирования – создание нового бронирования\n" +
"3. Клиенты – работа со списком клиентов\n" +
"4. Сотрудники – управление сотрудниками бара\n" +
"5. Список меню – просмотр и редактирование блюд и напитков\n" +
"6. Продукция – складской учёт товаров\n" +
"7. Поставщики – список поставщиков\n" +
"8. Заказы – оформление и учёт поставок\n" +
"9. Столы в зале – управление размещением и описанием столов\n" +
"10. Справочники – единицы измерения, типы списаний и прочее\n" +
"11. Документы – отчётность, выписки и аналитика\n\n" +
"Дополнительные функции:\n" +
"- Создать резервную копию базы данных\n" +
"- Загрузить копию базы данных\n\n" +
"Горячие клавиши:\n" +
"- F1 — Показать справку\n" +
"- Esc — Выход в окно авторизации";


                MessageBox.Show(helpText, "Справка по главной форме", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string helpText =
                    "Главная форма приложения Бар Баревич\n\n" +
$"{roleDescription}\n\n" +
"Назначение: с этой формы осуществляется переход ко всем ключевым модулям системы управления баром.\n\n" +
"Структура меню:\n" +
"1. Схема зала – визуальное отображение и описание столов\n" +
"2. Бронирования – создание нового бронирования\n" +
"3. Справочники – единицы измерения, типы списаний и прочее\n" +
"4. Документы – отчётность, выписки и аналитика\n\n" +
"Дополнительные функции:\n" +
"- Создать резервную копию базы данных\n" +
"Горячие клавиши:\n" +
"- F1 — Показать справку\n" +
"- Esc — Выход в окно авторизации";
                MessageBox.Show(helpText, "Справка по главной форме", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
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
