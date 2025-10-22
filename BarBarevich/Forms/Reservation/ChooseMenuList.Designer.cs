namespace BarBarevich.Forms.ActivityReservation
{
    partial class ChooseMenuList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseMenuList));
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSave = new Guna.UI2.WinForms.Guna2Button();
            this.buttonBack = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewMenuList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMenuInOrder = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonClean = new Guna.UI2.WinForms.Guna2Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHint = new System.Windows.Forms.ToolStripStatusLabel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grams_ml = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenuList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenuInOrder)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(893, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Общая стоимость (руб.)";
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotalPrice.BorderRadius = 10;
            this.textBoxTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTotalPrice.DefaultText = "";
            this.textBoxTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTotalPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTotalPrice.Location = new System.Drawing.Point(897, 502);
            this.textBoxTotalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.PasswordChar = '\0';
            this.textBoxTotalPrice.PlaceholderText = "";
            this.textBoxTotalPrice.ReadOnly = true;
            this.textBoxTotalPrice.SelectedText = "";
            this.textBoxTotalPrice.Size = new System.Drawing.Size(348, 36);
            this.textBoxTotalPrice.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Список меню";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BorderRadius = 10;
            this.buttonSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(897, 550);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(489, 46);
            this.buttonSave.TabIndex = 24;
            this.buttonSave.Text = "Сохранить и выйти";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.BorderRadius = 10;
            this.buttonBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonBack.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonBack.ForeColor = System.Drawing.Color.DimGray;
            this.buttonBack.Location = new System.Drawing.Point(897, 608);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(489, 46);
            this.buttonBack.TabIndex = 25;
            this.buttonBack.Text = "Отменить";
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dataGridViewMenuList
            // 
            this.dataGridViewMenuList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewMenuList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMenuList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMenuList.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMenuList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMenuList.ColumnHeadersHeight = 25;
            this.dataGridViewMenuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewMenuList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.category,
            this.grams_ml,
            this.calories,
            this.price});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMenuList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMenuList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewMenuList.Location = new System.Drawing.Point(15, 31);
            this.dataGridViewMenuList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMenuList.Name = "dataGridViewMenuList";
            this.dataGridViewMenuList.ReadOnly = true;
            this.dataGridViewMenuList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMenuList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewMenuList.RowHeadersVisible = false;
            this.dataGridViewMenuList.RowHeadersWidth = 51;
            this.dataGridViewMenuList.RowTemplate.Height = 28;
            this.dataGridViewMenuList.Size = new System.Drawing.Size(867, 622);
            this.dataGridViewMenuList.TabIndex = 26;
            this.dataGridViewMenuList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewMenuList.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewMenuList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewMenuList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridViewMenuList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewMenuList.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewMenuList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewMenuList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridViewMenuList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewMenuList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewMenuList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewMenuList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewMenuList.ThemeStyle.HeaderStyle.Height = 25;
            this.dataGridViewMenuList.ThemeStyle.ReadOnly = true;
            this.dataGridViewMenuList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewMenuList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewMenuList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewMenuList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewMenuList.ThemeStyle.RowsStyle.Height = 28;
            this.dataGridViewMenuList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridViewMenuList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewMenuList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenuList_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(893, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Добавить к бронированию";
            // 
            // dataGridViewMenuInOrder
            // 
            this.dataGridViewMenuInOrder.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewMenuInOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewMenuInOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMenuInOrder.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMenuInOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewMenuInOrder.ColumnHeadersHeight = 25;
            this.dataGridViewMenuInOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewMenuInOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colQuantity,
            this.colPrice});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMenuInOrder.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewMenuInOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewMenuInOrder.Location = new System.Drawing.Point(897, 31);
            this.dataGridViewMenuInOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMenuInOrder.Name = "dataGridViewMenuInOrder";
            this.dataGridViewMenuInOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMenuInOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewMenuInOrder.RowHeadersVisible = false;
            this.dataGridViewMenuInOrder.RowHeadersWidth = 51;
            this.dataGridViewMenuInOrder.RowTemplate.Height = 28;
            this.dataGridViewMenuInOrder.Size = new System.Drawing.Size(489, 434);
            this.dataGridViewMenuInOrder.TabIndex = 29;
            this.dataGridViewMenuInOrder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewMenuInOrder.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewMenuInOrder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewMenuInOrder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridViewMenuInOrder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewMenuInOrder.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewMenuInOrder.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewMenuInOrder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridViewMenuInOrder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewMenuInOrder.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewMenuInOrder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewMenuInOrder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewMenuInOrder.ThemeStyle.HeaderStyle.Height = 25;
            this.dataGridViewMenuInOrder.ThemeStyle.ReadOnly = false;
            this.dataGridViewMenuInOrder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewMenuInOrder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewMenuInOrder.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewMenuInOrder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewMenuInOrder.ThemeStyle.RowsStyle.Height = 28;
            this.dataGridViewMenuInOrder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridViewMenuInOrder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewMenuInOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenuInOrder_CellContentClick);
            this.dataGridViewMenuInOrder.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenuInOrder_CellValueChanged);
            this.dataGridViewMenuInOrder.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewMenuInOrder_EditingControlShowing);
            // 
            // colName
            // 
            this.colName.DataPropertyName = "name";
            this.colName.HeaderText = "Наименование";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Количество";
            this.colQuantity.MaxInputLength = 2;
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Цена (руб.)";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            // 
            // buttonClean
            // 
            this.buttonClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClean.BorderRadius = 10;
            this.buttonClean.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonClean.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonClean.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonClean.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonClean.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonClean.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonClean.ForeColor = System.Drawing.Color.DimGray;
            this.buttonClean.Location = new System.Drawing.Point(1251, 502);
            this.buttonClean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(136, 36);
            this.buttonClean.TabIndex = 30;
            this.buttonClean.Text = "Очистить";
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHint});
            this.statusStrip.Location = new System.Drawing.Point(0, 671);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1400, 26);
            this.statusStrip.TabIndex = 64;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelHint
            // 
            this.toolStripStatusLabelHint.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripStatusLabelHint.ForeColor = System.Drawing.Color.Gray;
            this.toolStripStatusLabelHint.Name = "toolStripStatusLabelHint";
            this.toolStripStatusLabelHint.Size = new System.Drawing.Size(1380, 20);
            this.toolStripStatusLabelHint.Spring = true;
            this.toolStripStatusLabelHint.Text = "F1 — справка   |   Enter — сохранить и выйти   |   Esc — назад";
            this.toolStripStatusLabelHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_item";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Наименование";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // category
            // 
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "Категория";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // grams_ml
            // 
            this.grams_ml.DataPropertyName = "grams_ml";
            this.grams_ml.HeaderText = "Гр./Мл.";
            this.grams_ml.MinimumWidth = 6;
            this.grams_ml.Name = "grams_ml";
            this.grams_ml.ReadOnly = true;
            // 
            // calories
            // 
            this.calories.DataPropertyName = "calories";
            this.calories.HeaderText = "Ккал";
            this.calories.MinimumWidth = 6;
            this.calories.Name = "calories";
            this.calories.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Цена (руб.)";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // ChooseMenuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 697);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.dataGridViewMenuInOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMenuList);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTotalPrice);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1415, 734);
            this.Name = "ChooseMenuList";
            this.Text = "Выбор списка меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.ActivityMenuList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenuList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenuInOrder)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox textBoxTotalPrice;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button buttonSave;
        private Guna.UI2.WinForms.Guna2Button buttonBack;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewMenuList;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewMenuInOrder;
        private Guna.UI2.WinForms.Guna2Button buttonClean;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn grams_ml;
        private System.Windows.Forms.DataGridViewTextBoxColumn calories;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}