namespace BarBarevich.Forms.View.Employee
{
    partial class EditEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEmployee));
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new Guna.UI2.WinForms.Guna2Button();
            this.buttonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonAddShift = new Guna.UI2.WinForms.Guna2Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.datePickerShiftDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.timePickerEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.timePickerStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dataGridViewShifts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_employee2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHint = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShifts)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(227, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Пароль";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderRadius = 10;
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.DefaultText = "";
            this.textBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.Location = new System.Drawing.Point(229, 395);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPassword.MaxLength = 11;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '\0';
            this.textBoxPassword.PlaceholderText = "";
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.Size = new System.Drawing.Size(180, 36);
            this.textBoxPassword.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(21, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Логин";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BorderRadius = 10;
            this.textBoxLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxLogin.DefaultText = "";
            this.textBoxLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxLogin.Location = new System.Drawing.Point(24, 395);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLogin.MaxLength = 11;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.PasswordChar = '\0';
            this.textBoxLogin.PlaceholderText = "";
            this.textBoxLogin.SelectedText = "";
            this.textBoxLogin.Size = new System.Drawing.Size(180, 36);
            this.textBoxLogin.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(21, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Должность";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxRole.BorderRadius = 10;
            this.comboBoxRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxRole.ItemHeight = 30;
            this.comboBoxRole.Location = new System.Drawing.Point(24, 242);
            this.comboBoxRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(391, 36);
            this.comboBoxRole.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(20, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Телефон";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BorderRadius = 10;
            this.textBoxPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPhone.DefaultText = "";
            this.textBoxPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPhone.Location = new System.Drawing.Point(24, 321);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPhone.MaxLength = 11;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.PasswordChar = '\0';
            this.textBoxPhone.PlaceholderText = "";
            this.textBoxPhone.SelectedText = "";
            this.textBoxPhone.Size = new System.Drawing.Size(389, 36);
            this.textBoxPhone.TabIndex = 34;
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Имя";
            // 
            // buttonBack
            // 
            this.buttonBack.BorderRadius = 10;
            this.buttonBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonBack.FillColor = System.Drawing.Color.DimGray;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(232, 459);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(180, 46);
            this.buttonBack.TabIndex = 31;
            this.buttonBack.Text = "Назад";
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BorderRadius = 10;
            this.buttonEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(23, 459);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(180, 46);
            this.buttonEdit.TabIndex = 30;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BorderRadius = 10;
            this.textBoxFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxFirstName.DefaultText = "";
            this.textBoxFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxFirstName.Location = new System.Drawing.Point(23, 36);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFirstName.MaxLength = 45;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.PasswordChar = '\0';
            this.textBoxFirstName.PlaceholderText = "";
            this.textBoxFirstName.SelectedText = "";
            this.textBoxFirstName.Size = new System.Drawing.Size(387, 36);
            this.textBoxFirstName.TabIndex = 29;
            this.textBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFirstName_KeyPress);
            // 
            // textBoxID
            // 
            this.textBoxID.BorderRadius = 10;
            this.textBoxID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxID.DefaultText = "";
            this.textBoxID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxID.Location = new System.Drawing.Point(331, -7);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.PasswordChar = '\0';
            this.textBoxID.PlaceholderText = "";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.SelectedText = "";
            this.textBoxID.Size = new System.Drawing.Size(79, 36);
            this.textBoxID.TabIndex = 28;
            this.textBoxID.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(21, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "Отчество";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.BorderRadius = 10;
            this.textBoxMiddleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMiddleName.DefaultText = "";
            this.textBoxMiddleName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxMiddleName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxMiddleName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxMiddleName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxMiddleName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxMiddleName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxMiddleName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxMiddleName.Location = new System.Drawing.Point(23, 174);
            this.textBoxMiddleName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMiddleName.MaxLength = 45;
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.PasswordChar = '\0';
            this.textBoxMiddleName.PlaceholderText = "";
            this.textBoxMiddleName.SelectedText = "";
            this.textBoxMiddleName.Size = new System.Drawing.Size(387, 36);
            this.textBoxMiddleName.TabIndex = 44;
            this.textBoxMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLastName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Фамилия";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BorderRadius = 10;
            this.textBoxLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxLastName.DefaultText = "";
            this.textBoxLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxLastName.Location = new System.Drawing.Point(23, 103);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLastName.MaxLength = 45;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.PasswordChar = '\0';
            this.textBoxLastName.PlaceholderText = "";
            this.textBoxLastName.SelectedText = "";
            this.textBoxLastName.Size = new System.Drawing.Size(387, 36);
            this.textBoxLastName.TabIndex = 42;
            this.textBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMiddleName_KeyPress);
            // 
            // buttonAddShift
            // 
            this.buttonAddShift.BorderRadius = 10;
            this.buttonAddShift.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAddShift.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAddShift.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAddShift.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAddShift.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonAddShift.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAddShift.ForeColor = System.Drawing.Color.White;
            this.buttonAddShift.Location = new System.Drawing.Point(916, 395);
            this.buttonAddShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddShift.Name = "buttonAddShift";
            this.buttonAddShift.Size = new System.Drawing.Size(51, 36);
            this.buttonAddShift.TabIndex = 53;
            this.buttonAddShift.Text = "+";
            this.buttonAddShift.Click += new System.EventHandler(this.buttonAddShift_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(757, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 52;
            this.label10.Text = "Дата";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(575, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 16);
            this.label9.TabIndex = 51;
            this.label9.Text = "по";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(427, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 50;
            this.label8.Text = "Время смены";
            // 
            // datePickerShiftDate
            // 
            this.datePickerShiftDate.BorderRadius = 10;
            this.datePickerShiftDate.Checked = true;
            this.datePickerShiftDate.FillColor = System.Drawing.Color.White;
            this.datePickerShiftDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datePickerShiftDate.ForeColor = System.Drawing.Color.Black;
            this.datePickerShiftDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePickerShiftDate.Location = new System.Drawing.Point(760, 395);
            this.datePickerShiftDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePickerShiftDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePickerShiftDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePickerShiftDate.Name = "datePickerShiftDate";
            this.datePickerShiftDate.Size = new System.Drawing.Size(139, 36);
            this.datePickerShiftDate.TabIndex = 49;
            this.datePickerShiftDate.Value = new System.DateTime(2024, 6, 14, 4, 5, 9, 926);
            // 
            // timePickerEnd
            // 
            this.timePickerEnd.BorderRadius = 10;
            this.timePickerEnd.Checked = true;
            this.timePickerEnd.FillColor = System.Drawing.Color.White;
            this.timePickerEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timePickerEnd.ForeColor = System.Drawing.Color.Black;
            this.timePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.timePickerEnd.Location = new System.Drawing.Point(603, 395);
            this.timePickerEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timePickerEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timePickerEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timePickerEnd.Name = "timePickerEnd";
            this.timePickerEnd.Size = new System.Drawing.Size(139, 36);
            this.timePickerEnd.TabIndex = 48;
            this.timePickerEnd.Value = new System.DateTime(2024, 6, 14, 4, 5, 9, 926);
            // 
            // timePickerStart
            // 
            this.timePickerStart.BorderRadius = 10;
            this.timePickerStart.Checked = true;
            this.timePickerStart.FillColor = System.Drawing.Color.White;
            this.timePickerStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timePickerStart.ForeColor = System.Drawing.Color.Black;
            this.timePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.timePickerStart.Location = new System.Drawing.Point(429, 395);
            this.timePickerStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timePickerStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timePickerStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timePickerStart.Name = "timePickerStart";
            this.timePickerStart.Size = new System.Drawing.Size(139, 36);
            this.timePickerStart.TabIndex = 47;
            this.timePickerStart.Value = new System.DateTime(2024, 6, 14, 4, 5, 9, 926);
            // 
            // dataGridViewShifts
            // 
            this.dataGridViewShifts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewShifts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewShifts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewShifts.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShifts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewShifts.ColumnHeadersHeight = 25;
            this.dataGridViewShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewShifts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.id_employee2,
            this.date,
            this.start,
            this.end});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewShifts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewShifts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewShifts.Location = new System.Drawing.Point(429, 16);
            this.dataGridViewShifts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewShifts.Name = "dataGridViewShifts";
            this.dataGridViewShifts.ReadOnly = true;
            this.dataGridViewShifts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShifts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewShifts.RowHeadersVisible = false;
            this.dataGridViewShifts.RowHeadersWidth = 51;
            this.dataGridViewShifts.RowTemplate.Height = 28;
            this.dataGridViewShifts.Size = new System.Drawing.Size(539, 341);
            this.dataGridViewShifts.TabIndex = 46;
            this.dataGridViewShifts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewShifts.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewShifts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewShifts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridViewShifts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewShifts.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewShifts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewShifts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridViewShifts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewShifts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewShifts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewShifts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewShifts.ThemeStyle.HeaderStyle.Height = 25;
            this.dataGridViewShifts.ThemeStyle.ReadOnly = true;
            this.dataGridViewShifts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewShifts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewShifts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewShifts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewShifts.ThemeStyle.RowsStyle.Height = 28;
            this.dataGridViewShifts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridViewShifts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewShifts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShifts_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // id_employee2
            // 
            this.id_employee2.DataPropertyName = "id_employee";
            this.id_employee2.HeaderText = "id_employee2";
            this.id_employee2.MinimumWidth = 6;
            this.id_employee2.Name = "id_employee2";
            this.id_employee2.ReadOnly = true;
            this.id_employee2.Visible = false;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Дата";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // start
            // 
            this.start.DataPropertyName = "start_time";
            this.start.HeaderText = "Начало смены";
            this.start.MinimumWidth = 6;
            this.start.Name = "start";
            this.start.ReadOnly = true;
            // 
            // end
            // 
            this.end.DataPropertyName = "end_time";
            this.end.HeaderText = "Конец смены";
            this.end.MinimumWidth = 6;
            this.end.Name = "end";
            this.end.ReadOnly = true;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHint});
            this.statusStrip.Location = new System.Drawing.Point(0, 523);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(988, 26);
            this.statusStrip.TabIndex = 54;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelHint
            // 
            this.toolStripStatusLabelHint.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripStatusLabelHint.ForeColor = System.Drawing.Color.Gray;
            this.toolStripStatusLabelHint.Name = "toolStripStatusLabelHint";
            this.toolStripStatusLabelHint.Size = new System.Drawing.Size(968, 20);
            this.toolStripStatusLabelHint.Spring = true;
            this.toolStripStatusLabelHint.Text = "F1 — справка   |   Enter — изменить   |   Esc — назад";
            this.toolStripStatusLabelHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 549);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonAddShift);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.datePickerShiftDate);
            this.Controls.Add(this.timePickerEnd);
            this.Controls.Add(this.timePickerStart);
            this.Controls.Add(this.dataGridViewShifts);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1006, 596);
            this.MinimumSize = new System.Drawing.Size(1005, 596);
            this.Name = "EditEmployee";
            this.Text = "Изменить запись о сотруднике";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.EditEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShifts)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPassword;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox textBoxLogin;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxRole;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPhone;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button buttonBack;
        private Guna.UI2.WinForms.Guna2Button buttonEdit;
        private Guna.UI2.WinForms.Guna2TextBox textBoxFirstName;
        private Guna.UI2.WinForms.Guna2TextBox textBoxID;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox textBoxMiddleName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox textBoxLastName;
        private Guna.UI2.WinForms.Guna2Button buttonAddShift;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker datePickerShiftDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker timePickerEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker timePickerStart;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewShifts;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_employee2;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn start;
        private System.Windows.Forms.DataGridViewTextBoxColumn end;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHint;
    }
}