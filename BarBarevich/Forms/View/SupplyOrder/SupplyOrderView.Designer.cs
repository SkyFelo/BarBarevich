namespace BarBarevich.Forms.View.SupplyOrder
{
    partial class SupplyOrderView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplyOrderView));
            this.buttonBack = new Guna.UI2.WinForms.Guna2Button();
            this.buttonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.buttonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id_purchase_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_complete_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoice_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supply_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonConfirmSupply = new Guna.UI2.WinForms.Guna2Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHint = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxReservation = new Guna.UI2.WinForms.Guna2GroupBox();
            this.buttonRefreshing = new Guna.UI2.WinForms.Guna2Button();
            this.dateTimePickerStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateTimePickerEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.buttonRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSearch = new Guna.UI2.WinForms.Guna2Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelPo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.groupBoxReservation.SuspendLayout();
            this.SuspendLayout();
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
            this.buttonBack.Location = new System.Drawing.Point(824, 9);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(88, 29);
            this.buttonBack.TabIndex = 32;
            this.buttonBack.Text = "Назад";
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
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
            this.buttonDelete.Location = new System.Drawing.Point(215, 10);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(88, 29);
            this.buttonDelete.TabIndex = 31;
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
            this.buttonEdit.Location = new System.Drawing.Point(112, 10);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(88, 29);
            this.buttonEdit.TabIndex = 30;
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
            this.buttonAdd.Location = new System.Drawing.Point(12, 10);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 29);
            this.buttonAdd.TabIndex = 29;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_purchase_order,
            this.id_complete_status,
            this.invoice_number,
            this.supplier_name,
            this.purchase_date,
            this.supply_date});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(1, 51);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(586, 480);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 25;
            this.dataGridView1.ThemeStyle.ReadOnly = true;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 28;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id_purchase_order
            // 
            this.id_purchase_order.DataPropertyName = "id_purchase_order";
            this.id_purchase_order.HeaderText = "ID";
            this.id_purchase_order.MinimumWidth = 6;
            this.id_purchase_order.Name = "id_purchase_order";
            this.id_purchase_order.ReadOnly = true;
            this.id_purchase_order.Visible = false;
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
            // invoice_number
            // 
            this.invoice_number.DataPropertyName = "invoice_number";
            this.invoice_number.FillWeight = 200F;
            this.invoice_number.HeaderText = "Номер накладной";
            this.invoice_number.MinimumWidth = 6;
            this.invoice_number.Name = "invoice_number";
            this.invoice_number.ReadOnly = true;
            // 
            // supplier_name
            // 
            this.supplier_name.DataPropertyName = "supplier_name";
            this.supplier_name.HeaderText = "Поставщик";
            this.supplier_name.MinimumWidth = 6;
            this.supplier_name.Name = "supplier_name";
            this.supplier_name.ReadOnly = true;
            // 
            // purchase_date
            // 
            this.purchase_date.DataPropertyName = "purchase_date";
            this.purchase_date.HeaderText = "Дата заказа";
            this.purchase_date.MinimumWidth = 6;
            this.purchase_date.Name = "purchase_date";
            this.purchase_date.ReadOnly = true;
            // 
            // supply_date
            // 
            this.supply_date.DataPropertyName = "supply_date";
            this.supply_date.HeaderText = "Дата доставки";
            this.supply_date.MinimumWidth = 6;
            this.supply_date.Name = "supply_date";
            this.supply_date.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.ColumnHeadersHeight = 25;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Product,
            this.unit,
            this.Quantity});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView2.Location = new System.Drawing.Point(601, 51);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(311, 295);
            this.dataGridView2.TabIndex = 33;
            this.dataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView2.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView2.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridView2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView2.ThemeStyle.HeaderStyle.Height = 25;
            this.dataGridView2.ThemeStyle.ReadOnly = true;
            this.dataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView2.ThemeStyle.RowsStyle.Height = 28;
            this.dataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_purchase_order";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Product
            // 
            this.Product.DataPropertyName = "product_name";
            this.Product.HeaderText = "Продукт";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "unit";
            this.unit.HeaderText = "Ед. изм.";
            this.unit.MinimumWidth = 6;
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "quantity";
            this.Quantity.HeaderText = "Количество";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // buttonConfirmSupply
            // 
            this.buttonConfirmSupply.BorderRadius = 10;
            this.buttonConfirmSupply.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonConfirmSupply.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonConfirmSupply.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonConfirmSupply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonConfirmSupply.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonConfirmSupply.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonConfirmSupply.ForeColor = System.Drawing.Color.Black;
            this.buttonConfirmSupply.Location = new System.Drawing.Point(318, 10);
            this.buttonConfirmSupply.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConfirmSupply.Name = "buttonConfirmSupply";
            this.buttonConfirmSupply.Size = new System.Drawing.Size(170, 29);
            this.buttonConfirmSupply.TabIndex = 34;
            this.buttonConfirmSupply.Text = "Подтвердить поставку";
            this.buttonConfirmSupply.Click += new System.EventHandler(this.buttonConfirmSupply_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHint});
            this.statusStrip.Location = new System.Drawing.Point(0, 537);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(921, 22);
            this.statusStrip.TabIndex = 35;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelHint
            // 
            this.toolStripStatusLabelHint.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripStatusLabelHint.ForeColor = System.Drawing.Color.Gray;
            this.toolStripStatusLabelHint.Name = "toolStripStatusLabelHint";
            this.toolStripStatusLabelHint.Size = new System.Drawing.Size(906, 17);
            this.toolStripStatusLabelHint.Spring = true;
            this.toolStripStatusLabelHint.Text = "F1 — справка   |   Esc — назад";
            this.toolStripStatusLabelHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.groupBoxReservation.Location = new System.Drawing.Point(601, 362);
            this.groupBoxReservation.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxReservation.Name = "groupBoxReservation";
            this.groupBoxReservation.Size = new System.Drawing.Size(311, 169);
            this.groupBoxReservation.TabIndex = 36;
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
            this.buttonRefreshing.Location = new System.Drawing.Point(161, 115);
            this.buttonRefreshing.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefreshing.Name = "buttonRefreshing";
            this.buttonRefreshing.Size = new System.Drawing.Size(138, 37);
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
            this.dateTimePickerStart.Location = new System.Drawing.Point(13, 64);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(132, 29);
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
            this.dateTimePickerEnd.Location = new System.Drawing.Point(167, 64);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(132, 29);
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
            this.buttonRefresh.Location = new System.Drawing.Point(34, 234);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(148, 37);
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
            this.buttonSearch.Location = new System.Drawing.Point(13, 115);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(138, 37);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.Location = new System.Drawing.Point(9, 46);
            this.labelSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(209, 15);
            this.labelSearch.TabIndex = 8;
            this.labelSearch.Text = "Необходимо выбрать искомый период времени";
            // 
            // labelPo
            // 
            this.labelPo.AutoSize = true;
            this.labelPo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPo.Location = new System.Drawing.Point(146, 69);
            this.labelPo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPo.Name = "labelPo";
            this.labelPo.Size = new System.Drawing.Size(21, 15);
            this.labelPo.TabIndex = 30;
            this.labelPo.Text = "по";
            // 
            // SupplyOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 559);
            this.Controls.Add(this.groupBoxReservation);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonConfirmSupply);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(904, 521);
            this.Name = "SupplyOrderView";
            this.Text = "Заказы продуктов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.SupplyOrderView_Load);
            this.VisibleChanged += new System.EventHandler(this.SupplyOrderView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBoxReservation.ResumeLayout(false);
            this.groupBoxReservation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button buttonBack;
        private Guna.UI2.WinForms.Guna2Button buttonDelete;
        private Guna.UI2.WinForms.Guna2Button buttonEdit;
        private Guna.UI2.WinForms.Guna2Button buttonAdd;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView2;
        private Guna.UI2.WinForms.Guna2Button buttonConfirmSupply;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHint;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_purchase_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_complete_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn supply_date;
        private Guna.UI2.WinForms.Guna2GroupBox groupBoxReservation;
        private Guna.UI2.WinForms.Guna2Button buttonRefreshing;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerStart;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerEnd;
        private Guna.UI2.WinForms.Guna2Button buttonRefresh;
        private Guna.UI2.WinForms.Guna2Button buttonSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelPo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}