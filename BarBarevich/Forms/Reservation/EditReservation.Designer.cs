namespace BarBarevich.Forms.Reservation
{
    partial class EditReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditReservation));
            this.groupBoxExtra = new Guna.UI2.WinForms.Guna2GroupBox();
            this.checkBoxExtra = new System.Windows.Forms.CheckBox();
            this.labelExtraInfo2 = new System.Windows.Forms.Label();
            this.comboBoxEmployee = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelExtraInfo1 = new System.Windows.Forms.Label();
            this.textBoxExtra = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSave = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxDeposit = new Guna.UI2.WinForms.Guna2TextBox();
            this.timePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.textBoxGuestCount = new Guna.UI2.WinForms.Guna2TextBox();
            this.datePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.buttonChooseClient = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonBack = new Guna.UI2.WinForms.Guna2Button();
            this.buttonEditTables = new Guna.UI2.WinForms.Guna2Button();
            this.buttonEditMenu = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxActualGuestCount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHint = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxExtra.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxExtra
            // 
            this.groupBoxExtra.BackColor = System.Drawing.Color.White;
            this.groupBoxExtra.BorderRadius = 10;
            this.groupBoxExtra.Controls.Add(this.checkBoxExtra);
            this.groupBoxExtra.Controls.Add(this.labelExtraInfo2);
            this.groupBoxExtra.Controls.Add(this.comboBoxEmployee);
            this.groupBoxExtra.Controls.Add(this.labelExtraInfo1);
            this.groupBoxExtra.Controls.Add(this.textBoxExtra);
            this.groupBoxExtra.CustomBorderColor = System.Drawing.Color.Silver;
            this.groupBoxExtra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBoxExtra.ForeColor = System.Drawing.Color.DimGray;
            this.groupBoxExtra.Location = new System.Drawing.Point(437, 11);
            this.groupBoxExtra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxExtra.Name = "groupBoxExtra";
            this.groupBoxExtra.Size = new System.Drawing.Size(397, 356);
            this.groupBoxExtra.TabIndex = 30;
            this.groupBoxExtra.Text = "Дополнительная информация";
            // 
            // checkBoxExtra
            // 
            this.checkBoxExtra.AutoSize = true;
            this.checkBoxExtra.BackColor = System.Drawing.Color.Silver;
            this.checkBoxExtra.Location = new System.Drawing.Point(371, 17);
            this.checkBoxExtra.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxExtra.Name = "checkBoxExtra";
            this.checkBoxExtra.Size = new System.Drawing.Size(18, 17);
            this.checkBoxExtra.TabIndex = 18;
            this.checkBoxExtra.UseVisualStyleBackColor = false;
            this.checkBoxExtra.CheckedChanged += new System.EventHandler(this.checkBoxExtra_CheckedChanged);
            // 
            // labelExtraInfo2
            // 
            this.labelExtraInfo2.AutoSize = true;
            this.labelExtraInfo2.BackColor = System.Drawing.Color.White;
            this.labelExtraInfo2.Location = new System.Drawing.Point(21, 263);
            this.labelExtraInfo2.Name = "labelExtraInfo2";
            this.labelExtraInfo2.Size = new System.Drawing.Size(190, 20);
            this.labelExtraInfo2.TabIndex = 20;
            this.labelExtraInfo2.Text = "Ответственный сотрудник";
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxEmployee.BorderRadius = 10;
            this.comboBoxEmployee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployee.Enabled = false;
            this.comboBoxEmployee.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxEmployee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxEmployee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxEmployee.ItemHeight = 30;
            this.comboBoxEmployee.Location = new System.Drawing.Point(25, 286);
            this.comboBoxEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(352, 36);
            this.comboBoxEmployee.TabIndex = 19;
            // 
            // labelExtraInfo1
            // 
            this.labelExtraInfo1.AutoSize = true;
            this.labelExtraInfo1.BackColor = System.Drawing.Color.White;
            this.labelExtraInfo1.ForeColor = System.Drawing.Color.DimGray;
            this.labelExtraInfo1.Location = new System.Drawing.Point(23, 58);
            this.labelExtraInfo1.Name = "labelExtraInfo1";
            this.labelExtraInfo1.Size = new System.Drawing.Size(215, 20);
            this.labelExtraInfo1.TabIndex = 3;
            this.labelExtraInfo1.Text = "Информация о мероприятии";
            // 
            // textBoxExtra
            // 
            this.textBoxExtra.BackColor = System.Drawing.Color.White;
            this.textBoxExtra.BorderRadius = 10;
            this.textBoxExtra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxExtra.DefaultText = "";
            this.textBoxExtra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxExtra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxExtra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxExtra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxExtra.Enabled = false;
            this.textBoxExtra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxExtra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxExtra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxExtra.Location = new System.Drawing.Point(27, 80);
            this.textBoxExtra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxExtra.MaxLength = 250;
            this.textBoxExtra.Multiline = true;
            this.textBoxExtra.Name = "textBoxExtra";
            this.textBoxExtra.PasswordChar = '\0';
            this.textBoxExtra.PlaceholderText = "";
            this.textBoxExtra.SelectedText = "";
            this.textBoxExtra.Size = new System.Drawing.Size(349, 170);
            this.textBoxExtra.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(221, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Время визита";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(19, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Дата визита";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(277, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Депозит (руб.)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(19, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Кол-во гостей";
            // 
            // buttonSave
            // 
            this.buttonSave.BorderRadius = 10;
            this.buttonSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSave.FillColor = System.Drawing.Color.YellowGreen;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSave.Location = new System.Drawing.Point(16, 391);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(192, 55);
            this.buttonSave.TabIndex = 25;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxDeposit
            // 
            this.textBoxDeposit.BorderRadius = 10;
            this.textBoxDeposit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDeposit.DefaultText = "";
            this.textBoxDeposit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxDeposit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxDeposit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDeposit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDeposit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDeposit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxDeposit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDeposit.Location = new System.Drawing.Point(281, 331);
            this.textBoxDeposit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDeposit.MaxLength = 10;
            this.textBoxDeposit.Name = "textBoxDeposit";
            this.textBoxDeposit.PasswordChar = '\0';
            this.textBoxDeposit.PlaceholderText = "";
            this.textBoxDeposit.SelectedText = "";
            this.textBoxDeposit.Size = new System.Drawing.Size(136, 36);
            this.textBoxDeposit.TabIndex = 24;
            // 
            // timePicker
            // 
            this.timePicker.BorderRadius = 10;
            this.timePicker.Checked = true;
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.FillColor = System.Drawing.Color.White;
            this.timePicker.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.timePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timePicker.ForeColor = System.Drawing.Color.Black;
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.timePicker.Location = new System.Drawing.Point(225, 260);
            this.timePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(189, 36);
            this.timePicker.TabIndex = 22;
            this.timePicker.Value = new System.DateTime(2024, 6, 14, 4, 5, 0, 0);
            // 
            // textBoxGuestCount
            // 
            this.textBoxGuestCount.BorderRadius = 10;
            this.textBoxGuestCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxGuestCount.DefaultText = "";
            this.textBoxGuestCount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxGuestCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxGuestCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxGuestCount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxGuestCount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxGuestCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxGuestCount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxGuestCount.Location = new System.Drawing.Point(16, 331);
            this.textBoxGuestCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGuestCount.MaxLength = 2;
            this.textBoxGuestCount.Name = "textBoxGuestCount";
            this.textBoxGuestCount.PasswordChar = '\0';
            this.textBoxGuestCount.PlaceholderText = "";
            this.textBoxGuestCount.SelectedText = "";
            this.textBoxGuestCount.Size = new System.Drawing.Size(120, 36);
            this.textBoxGuestCount.TabIndex = 21;
            // 
            // datePicker
            // 
            this.datePicker.BorderRadius = 10;
            this.datePicker.Checked = true;
            this.datePicker.FillColor = System.Drawing.Color.White;
            this.datePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datePicker.ForeColor = System.Drawing.Color.Black;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePicker.Location = new System.Drawing.Point(13, 260);
            this.datePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(195, 36);
            this.datePicker.TabIndex = 20;
            this.datePicker.Value = new System.DateTime(2024, 6, 14, 4, 5, 9, 926);
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.White;
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.Controls.Add(this.buttonChooseClient);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.textBoxPhone);
            this.guna2GroupBox1.Controls.Add(this.textBoxName);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 11);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(405, 218);
            this.guna2GroupBox1.TabIndex = 19;
            this.guna2GroupBox1.Text = "Контактная информация о клиенте";
            // 
            // buttonChooseClient
            // 
            this.buttonChooseClient.BackColor = System.Drawing.Color.White;
            this.buttonChooseClient.BorderRadius = 10;
            this.buttonChooseClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonChooseClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonChooseClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonChooseClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonChooseClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonChooseClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonChooseClient.ForeColor = System.Drawing.Color.White;
            this.buttonChooseClient.Location = new System.Drawing.Point(287, 80);
            this.buttonChooseClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChooseClient.Name = "buttonChooseClient";
            this.buttonChooseClient.Size = new System.Drawing.Size(96, 36);
            this.buttonChooseClient.TabIndex = 17;
            this.buttonChooseClient.Text = "Обзор...";
            this.buttonChooseClient.Click += new System.EventHandler(this.buttonChooseClient_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(21, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер телефона";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(21, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.Color.White;
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
            this.textBoxPhone.Location = new System.Drawing.Point(27, 155);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPhone.MaxLength = 11;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.PasswordChar = '\0';
            this.textBoxPhone.PlaceholderText = "";
            this.textBoxPhone.SelectedText = "";
            this.textBoxPhone.Size = new System.Drawing.Size(357, 36);
            this.textBoxPhone.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.White;
            this.textBoxName.BorderRadius = 10;
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.DefaultText = "";
            this.textBoxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.Location = new System.Drawing.Point(27, 80);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.MaxLength = 45;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.PlaceholderText = "";
            this.textBoxName.SelectedText = "";
            this.textBoxName.Size = new System.Drawing.Size(247, 36);
            this.textBoxName.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.White;
            this.buttonBack.BorderRadius = 10;
            this.buttonBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonBack.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.Color.DimGray;
            this.buttonBack.Location = new System.Drawing.Point(647, 391);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(188, 55);
            this.buttonBack.TabIndex = 29;
            this.buttonBack.Text = "Назад";
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonEditTables
            // 
            this.buttonEditTables.BorderRadius = 10;
            this.buttonEditTables.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonEditTables.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonEditTables.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonEditTables.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonEditTables.FillColor = System.Drawing.Color.Khaki;
            this.buttonEditTables.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditTables.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEditTables.Location = new System.Drawing.Point(227, 391);
            this.buttonEditTables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditTables.Name = "buttonEditTables";
            this.buttonEditTables.Size = new System.Drawing.Size(189, 55);
            this.buttonEditTables.TabIndex = 31;
            this.buttonEditTables.Text = "Редактор столов";
            this.buttonEditTables.Click += new System.EventHandler(this.buttonEditTables_Click);
            // 
            // buttonEditMenu
            // 
            this.buttonEditMenu.BorderRadius = 10;
            this.buttonEditMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonEditMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonEditMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonEditMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonEditMenu.FillColor = System.Drawing.Color.Khaki;
            this.buttonEditMenu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEditMenu.Location = new System.Drawing.Point(437, 391);
            this.buttonEditMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditMenu.Name = "buttonEditMenu";
            this.buttonEditMenu.Size = new System.Drawing.Size(188, 55);
            this.buttonEditMenu.TabIndex = 32;
            this.buttonEditMenu.Text = "Редактор меню";
            this.buttonEditMenu.Click += new System.EventHandler(this.buttonEditMenu_Click);
            // 
            // textBoxActualGuestCount
            // 
            this.textBoxActualGuestCount.BorderRadius = 10;
            this.textBoxActualGuestCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxActualGuestCount.DefaultText = "";
            this.textBoxActualGuestCount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxActualGuestCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxActualGuestCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxActualGuestCount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxActualGuestCount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxActualGuestCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxActualGuestCount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxActualGuestCount.Location = new System.Drawing.Point(149, 331);
            this.textBoxActualGuestCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxActualGuestCount.MaxLength = 2;
            this.textBoxActualGuestCount.Name = "textBoxActualGuestCount";
            this.textBoxActualGuestCount.PasswordChar = '\0';
            this.textBoxActualGuestCount.PlaceholderText = "";
            this.textBoxActualGuestCount.SelectedText = "";
            this.textBoxActualGuestCount.Size = new System.Drawing.Size(120, 36);
            this.textBoxActualGuestCount.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(147, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 34;
            this.label7.Text = "Итог. кол-во";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHint});
            this.statusStrip.Location = new System.Drawing.Point(0, 455);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(849, 26);
            this.statusStrip.TabIndex = 62;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelHint
            // 
            this.toolStripStatusLabelHint.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripStatusLabelHint.ForeColor = System.Drawing.Color.Gray;
            this.toolStripStatusLabelHint.Name = "toolStripStatusLabelHint";
            this.toolStripStatusLabelHint.Size = new System.Drawing.Size(829, 20);
            this.toolStripStatusLabelHint.Spring = true;
            this.toolStripStatusLabelHint.Text = "F1 — справка   |   Enter — сохранить   |   Esc — назад";
            this.toolStripStatusLabelHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EditReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(849, 481);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxActualGuestCount);
            this.Controls.Add(this.buttonEditMenu);
            this.Controls.Add(this.buttonEditTables);
            this.Controls.Add(this.groupBoxExtra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxDeposit);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.textBoxGuestCount);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.buttonBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(867, 528);
            this.MinimumSize = new System.Drawing.Size(867, 528);
            this.Name = "EditReservation";
            this.Text = "Редактирование бронирования";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.EditReservation_Load);
            this.groupBoxExtra.ResumeLayout(false);
            this.groupBoxExtra.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox groupBoxExtra;
        private System.Windows.Forms.CheckBox checkBoxExtra;
        private System.Windows.Forms.Label labelExtraInfo2;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxEmployee;
        private System.Windows.Forms.Label labelExtraInfo1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxExtra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button buttonSave;
        private Guna.UI2.WinForms.Guna2TextBox textBoxDeposit;
        private Guna.UI2.WinForms.Guna2DateTimePicker timePicker;
        private Guna.UI2.WinForms.Guna2TextBox textBoxGuestCount;
        private Guna.UI2.WinForms.Guna2DateTimePicker datePicker;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button buttonChooseClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPhone;
        private Guna.UI2.WinForms.Guna2TextBox textBoxName;
        private Guna.UI2.WinForms.Guna2Button buttonBack;
        private Guna.UI2.WinForms.Guna2Button buttonEditTables;
        private Guna.UI2.WinForms.Guna2Button buttonEditMenu;
        private Guna.UI2.WinForms.Guna2TextBox textBoxActualGuestCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHint;
    }
}