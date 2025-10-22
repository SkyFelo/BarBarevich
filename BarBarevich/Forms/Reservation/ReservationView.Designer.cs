namespace BarBarevich.Forms.View
{
    partial class ReservationView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationView));
            this.dataGridViewReservation = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewMenu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupBoxReservation = new Guna.UI2.WinForms.Guna2GroupBox();
            this.buttonRefreshing = new Guna.UI2.WinForms.Guna2Button();
            this.dateTimePickerStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateTimePickerEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.buttonRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSearch = new Guna.UI2.WinForms.Guna2Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelPo = new System.Windows.Forms.Label();
            this.buttonBack = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewTables = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id_table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seats_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.buttonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.buttonConfirmMenu = new Guna.UI2.WinForms.Guna2Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHint = new System.Windows.Forms.ToolStripStatusLabel();
            this.id_reservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_complete_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.people_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extra_info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            this.groupBoxReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewReservation
            // 
            this.dataGridViewReservation.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewReservation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReservation.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewReservation.ColumnHeadersHeight = 50;
            this.dataGridViewReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_reservation,
            this.id_complete_status,
            this.id_employee,
            this.id_client,
            this.full_name,
            this.phone,
            this.people_count,
            this.date,
            this.time,
            this.deposit,
            this.extra_info,
            this.first_name});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReservation.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewReservation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewReservation.Location = new System.Drawing.Point(0, 62);
            this.dataGridViewReservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewReservation.Name = "dataGridViewReservation";
            this.dataGridViewReservation.ReadOnly = true;
            this.dataGridViewReservation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReservation.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewReservation.RowHeadersVisible = false;
            this.dataGridViewReservation.RowHeadersWidth = 51;
            this.dataGridViewReservation.RowTemplate.Height = 28;
            this.dataGridViewReservation.Size = new System.Drawing.Size(940, 751);
            this.dataGridViewReservation.TabIndex = 2;
            this.dataGridViewReservation.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewReservation.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewReservation.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewReservation.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridViewReservation.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewReservation.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewReservation.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewReservation.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridViewReservation.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewReservation.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewReservation.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewReservation.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewReservation.ThemeStyle.HeaderStyle.Height = 50;
            this.dataGridViewReservation.ThemeStyle.ReadOnly = true;
            this.dataGridViewReservation.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewReservation.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewReservation.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewReservation.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewReservation.ThemeStyle.RowsStyle.Height = 28;
            this.dataGridViewReservation.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridViewReservation.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewReservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewActivity_CellClick);
            this.dataGridViewReservation.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewReservation_CellFormatting);
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewMenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMenu.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewMenu.ColumnHeadersHeight = 25;
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namee,
            this.quantity,
            this.price});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMenu.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewMenu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewMenu.Location = new System.Drawing.Point(956, 62);
            this.dataGridViewMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.ReadOnly = true;
            this.dataGridViewMenu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewMenu.RowHeadersVisible = false;
            this.dataGridViewMenu.RowHeadersWidth = 51;
            this.dataGridViewMenu.RowTemplate.Height = 28;
            this.dataGridViewMenu.Size = new System.Drawing.Size(416, 228);
            this.dataGridViewMenu.TabIndex = 3;
            this.dataGridViewMenu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewMenu.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewMenu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewMenu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridViewMenu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewMenu.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMenu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewMenu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridViewMenu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewMenu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewMenu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewMenu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewMenu.ThemeStyle.HeaderStyle.Height = 25;
            this.dataGridViewMenu.ThemeStyle.ReadOnly = true;
            this.dataGridViewMenu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewMenu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewMenu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewMenu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewMenu.ThemeStyle.RowsStyle.Height = 28;
            this.dataGridViewMenu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridViewMenu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // groupBoxReservation
            // 
            this.groupBoxReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxReservation.BorderRadius = 10;
            this.groupBoxReservation.Controls.Add(this.buttonRefreshing);
            this.groupBoxReservation.Controls.Add(this.dateTimePickerStart);
            this.groupBoxReservation.Controls.Add(this.dateTimePickerEnd);
            this.groupBoxReservation.Controls.Add(this.buttonRefresh);
            this.groupBoxReservation.Controls.Add(this.buttonSearch);
            this.groupBoxReservation.Controls.Add(this.labelSearch);
            this.groupBoxReservation.Controls.Add(this.labelPo);
            this.groupBoxReservation.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.groupBoxReservation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxReservation.ForeColor = System.Drawing.Color.Gray;
            this.groupBoxReservation.Location = new System.Drawing.Point(957, 604);
            this.groupBoxReservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxReservation.Name = "groupBoxReservation";
            this.groupBoxReservation.Size = new System.Drawing.Size(415, 208);
            this.groupBoxReservation.TabIndex = 25;
            this.groupBoxReservation.Text = "Отбор информации";
            this.groupBoxReservation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonRefreshing
            // 
            this.buttonRefreshing.BorderRadius = 10;
            this.buttonRefreshing.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonRefreshing.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonRefreshing.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonRefreshing.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonRefreshing.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonRefreshing.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonRefreshing.ForeColor = System.Drawing.Color.DimGray;
            this.buttonRefreshing.Location = new System.Drawing.Point(215, 142);
            this.buttonRefreshing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefreshing.Name = "buttonRefreshing";
            this.buttonRefreshing.Size = new System.Drawing.Size(184, 46);
            this.buttonRefreshing.TabIndex = 31;
            this.buttonRefreshing.Text = "Сброс";
            this.buttonRefreshing.Click += new System.EventHandler(this.buttonRefreshing_Click);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.BorderRadius = 10;
            this.dateTimePickerStart.Checked = true;
            this.dateTimePickerStart.FillColor = System.Drawing.Color.White;
            this.dateTimePickerStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerStart.Location = new System.Drawing.Point(17, 79);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(176, 36);
            this.dateTimePickerStart.TabIndex = 29;
            this.dateTimePickerStart.Value = new System.DateTime(2024, 6, 17, 13, 56, 3, 655);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.BorderRadius = 10;
            this.dateTimePickerEnd.Checked = true;
            this.dateTimePickerEnd.FillColor = System.Drawing.Color.White;
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(223, 79);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(176, 36);
            this.dateTimePickerEnd.TabIndex = 28;
            this.dateTimePickerEnd.Value = new System.DateTime(2024, 6, 17, 13, 56, 3, 655);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BorderRadius = 10;
            this.buttonRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonRefresh.FillColor = System.Drawing.Color.White;
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonRefresh.ForeColor = System.Drawing.Color.Gray;
            this.buttonRefresh.Location = new System.Drawing.Point(45, 288);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(197, 46);
            this.buttonRefresh.TabIndex = 11;
            this.buttonRefresh.Text = "Сброс";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BorderRadius = 10;
            this.buttonSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(17, 142);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(184, 46);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.Location = new System.Drawing.Point(12, 57);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(267, 20);
            this.labelSearch.TabIndex = 8;
            this.labelSearch.Text = "Необходимо выбрать искомый период времени";
            // 
            // labelPo
            // 
            this.labelPo.AutoSize = true;
            this.labelPo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPo.Location = new System.Drawing.Point(195, 85);
            this.labelPo.Name = "labelPo";
            this.labelPo.Size = new System.Drawing.Size(27, 20);
            this.labelPo.TabIndex = 30;
            this.labelPo.Text = "по";
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.BorderRadius = 10;
            this.buttonBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonBack.ForeColor = System.Drawing.Color.Black;
            this.buttonBack.Location = new System.Drawing.Point(1256, 12);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(117, 36);
            this.buttonBack.TabIndex = 27;
            this.buttonBack.Text = "Назад";
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(955, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Список меню:";
            // 
            // dataGridViewTables
            // 
            this.dataGridViewTables.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewTables.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTables.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTables.ColumnHeadersHeight = 25;
            this.dataGridViewTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewTables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_table,
            this.seats_count});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTables.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTables.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewTables.Location = new System.Drawing.Point(957, 373);
            this.dataGridViewTables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTables.Name = "dataGridViewTables";
            this.dataGridViewTables.ReadOnly = true;
            this.dataGridViewTables.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTables.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTables.RowHeadersVisible = false;
            this.dataGridViewTables.RowHeadersWidth = 51;
            this.dataGridViewTables.RowTemplate.Height = 28;
            this.dataGridViewTables.Size = new System.Drawing.Size(416, 212);
            this.dataGridViewTables.TabIndex = 30;
            this.dataGridViewTables.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewTables.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewTables.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewTables.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridViewTables.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewTables.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTables.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewTables.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridViewTables.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewTables.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewTables.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewTables.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewTables.ThemeStyle.HeaderStyle.Height = 25;
            this.dataGridViewTables.ThemeStyle.ReadOnly = true;
            this.dataGridViewTables.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewTables.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewTables.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewTables.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewTables.ThemeStyle.RowsStyle.Height = 28;
            this.dataGridViewTables.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridViewTables.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // id_table
            // 
            this.id_table.DataPropertyName = "id_table";
            this.id_table.FillWeight = 133.9572F;
            this.id_table.HeaderText = "Номер стола";
            this.id_table.MinimumWidth = 6;
            this.id_table.Name = "id_table";
            this.id_table.ReadOnly = true;
            // 
            // seats_count
            // 
            this.seats_count.DataPropertyName = "seats_count";
            this.seats_count.HeaderText = "Количество мест";
            this.seats_count.MinimumWidth = 6;
            this.seats_count.Name = "seats_count";
            this.seats_count.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(955, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Столы:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BorderRadius = 10;
            this.buttonDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDelete.FillColor = System.Drawing.Color.DarkSalmon;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDelete.Location = new System.Drawing.Point(285, 12);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(117, 36);
            this.buttonDelete.TabIndex = 34;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BorderRadius = 10;
            this.buttonEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonEdit.FillColor = System.Drawing.Color.Khaki;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEdit.Location = new System.Drawing.Point(149, 12);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(117, 36);
            this.buttonEdit.TabIndex = 33;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BorderRadius = 10;
            this.buttonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAdd.FillColor = System.Drawing.Color.YellowGreen;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAdd.Location = new System.Drawing.Point(15, 12);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(117, 36);
            this.buttonAdd.TabIndex = 32;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonConfirmMenu
            // 
            this.buttonConfirmMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfirmMenu.BorderRadius = 10;
            this.buttonConfirmMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonConfirmMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonConfirmMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonConfirmMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonConfirmMenu.FillColor = System.Drawing.Color.YellowGreen;
            this.buttonConfirmMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonConfirmMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonConfirmMenu.Location = new System.Drawing.Point(956, 309);
            this.buttonConfirmMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConfirmMenu.Name = "buttonConfirmMenu";
            this.buttonConfirmMenu.Size = new System.Drawing.Size(416, 36);
            this.buttonConfirmMenu.TabIndex = 35;
            this.buttonConfirmMenu.Text = "Подтвердить выдачу меню";
            this.buttonConfirmMenu.Click += new System.EventHandler(this.buttonConfirmMenu_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHint});
            this.statusStrip.Location = new System.Drawing.Point(0, 831);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1387, 26);
            this.statusStrip.TabIndex = 36;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelHint
            // 
            this.toolStripStatusLabelHint.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripStatusLabelHint.ForeColor = System.Drawing.Color.Gray;
            this.toolStripStatusLabelHint.Name = "toolStripStatusLabelHint";
            this.toolStripStatusLabelHint.Size = new System.Drawing.Size(1367, 20);
            this.toolStripStatusLabelHint.Spring = true;
            this.toolStripStatusLabelHint.Text = "F1 — справка   |   Esc — назад";
            this.toolStripStatusLabelHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // id_reservation
            // 
            this.id_reservation.DataPropertyName = "id_reservation";
            this.id_reservation.FillWeight = 97.33777F;
            this.id_reservation.HeaderText = "ID";
            this.id_reservation.MinimumWidth = 6;
            this.id_reservation.Name = "id_reservation";
            this.id_reservation.ReadOnly = true;
            this.id_reservation.Visible = false;
            // 
            // id_complete_status
            // 
            this.id_complete_status.DataPropertyName = "id_complete_status";
            this.id_complete_status.HeaderText = "id_complete_status";
            this.id_complete_status.MinimumWidth = 6;
            this.id_complete_status.Name = "id_complete_status";
            this.id_complete_status.ReadOnly = true;
            this.id_complete_status.Visible = false;
            // 
            // id_employee
            // 
            this.id_employee.DataPropertyName = "id_employee";
            this.id_employee.HeaderText = "id_employee";
            this.id_employee.MinimumWidth = 6;
            this.id_employee.Name = "id_employee";
            this.id_employee.ReadOnly = true;
            this.id_employee.Visible = false;
            // 
            // id_client
            // 
            this.id_client.DataPropertyName = "id_client";
            this.id_client.HeaderText = "id_client";
            this.id_client.MinimumWidth = 6;
            this.id_client.Name = "id_client";
            this.id_client.ReadOnly = true;
            this.id_client.Visible = false;
            // 
            // full_name
            // 
            this.full_name.DataPropertyName = "full_name";
            this.full_name.FillWeight = 101.5963F;
            this.full_name.HeaderText = "Клиент";
            this.full_name.MinimumWidth = 6;
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Номер клиента";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // people_count
            // 
            this.people_count.DataPropertyName = "people_count";
            this.people_count.FillWeight = 96.25668F;
            this.people_count.HeaderText = "Количество гостей";
            this.people_count.MinimumWidth = 6;
            this.people_count.Name = "people_count";
            this.people_count.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.FillWeight = 101.5963F;
            this.date.HeaderText = "Дата бронирования";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // time
            // 
            this.time.DataPropertyName = "time";
            this.time.FillWeight = 101.5963F;
            this.time.HeaderText = "Время бронирования";
            this.time.MinimumWidth = 6;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // deposit
            // 
            this.deposit.DataPropertyName = "deposit";
            this.deposit.FillWeight = 101.5963F;
            this.deposit.HeaderText = "Депозит (руб.)";
            this.deposit.MinimumWidth = 6;
            this.deposit.Name = "deposit";
            this.deposit.ReadOnly = true;
            // 
            // extra_info
            // 
            this.extra_info.DataPropertyName = "extra_info";
            this.extra_info.FillWeight = 101.5963F;
            this.extra_info.HeaderText = "Дополнительная информация";
            this.extra_info.MinimumWidth = 6;
            this.extra_info.Name = "extra_info";
            this.extra_info.ReadOnly = true;
            // 
            // first_name
            // 
            this.first_name.DataPropertyName = "first_name";
            this.first_name.FillWeight = 101.5963F;
            this.first_name.HeaderText = "Сотрудник";
            this.first_name.MinimumWidth = 6;
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            // 
            // namee
            // 
            this.namee.DataPropertyName = "name";
            this.namee.FillWeight = 133.9572F;
            this.namee.HeaderText = "Пункт меню";
            this.namee.MinimumWidth = 6;
            this.namee.Name = "namee";
            this.namee.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Количество";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.FillWeight = 133.9572F;
            this.price.HeaderText = "Цена (руб.)";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // ReservationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1387, 857);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonConfirmMenu);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewTables);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBoxReservation);
            this.Controls.Add(this.dataGridViewMenu);
            this.Controls.Add(this.dataGridViewReservation);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1402, 888);
            this.Name = "ReservationView";
            this.Text = "Просмотр бронирования";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.ActivityView_Load);
            this.VisibleChanged += new System.EventHandler(this.ReservationView_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            this.groupBoxReservation.ResumeLayout(false);
            this.groupBoxReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewReservation;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewMenu;
        private Guna.UI2.WinForms.Guna2GroupBox groupBoxReservation;
        private Guna.UI2.WinForms.Guna2Button buttonRefresh;
        private Guna.UI2.WinForms.Guna2Button buttonSearch;
        private System.Windows.Forms.Label labelSearch;
        private Guna.UI2.WinForms.Guna2Button buttonBack;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerStart;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label labelPo;
        private Guna.UI2.WinForms.Guna2Button buttonRefreshing;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewTables;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn seats_count;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button buttonDelete;
        private Guna.UI2.WinForms.Guna2Button buttonEdit;
        private Guna.UI2.WinForms.Guna2Button buttonAdd;
        private Guna.UI2.WinForms.Guna2Button buttonConfirmMenu;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHint;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_reservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_complete_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn people_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn deposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn extra_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn namee;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}