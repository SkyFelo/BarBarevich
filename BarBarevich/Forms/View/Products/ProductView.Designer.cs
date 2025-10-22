namespace BarBarevich.Forms.View.Products
{
    partial class ProductView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductView));
            this.buttonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.buttonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.buttonBack = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonWriteOffView = new Guna.UI2.WinForms.Guna2Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHint = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxReservation = new Guna.UI2.WinForms.Guna2GroupBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.buttonRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.groupBoxReservation.SuspendLayout();
            this.SuspendLayout();
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
            this.buttonDelete.Location = new System.Drawing.Point(284, 12);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(117, 36);
            this.buttonDelete.TabIndex = 11;
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
            this.buttonEdit.Location = new System.Drawing.Point(147, 12);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(117, 36);
            this.buttonEdit.TabIndex = 10;
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
            this.buttonAdd.Location = new System.Drawing.Point(13, 12);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(117, 36);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
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
            this.buttonBack.Location = new System.Drawing.Point(970, 12);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(117, 36);
            this.buttonBack.TabIndex = 27;
            this.buttonBack.Text = "Назад";
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
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
            this.id_product,
            this.product_name,
            this.unit,
            this.stock_quantity});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 62);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.dataGridView1.Size = new System.Drawing.Size(749, 457);
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
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_product
            // 
            this.id_product.DataPropertyName = "id_product";
            this.id_product.HeaderText = "ID";
            this.id_product.MinimumWidth = 6;
            this.id_product.Name = "id_product";
            this.id_product.ReadOnly = true;
            this.id_product.Visible = false;
            // 
            // product_name
            // 
            this.product_name.DataPropertyName = "product_name";
            this.product_name.HeaderText = "Продукт";
            this.product_name.MinimumWidth = 6;
            this.product_name.Name = "product_name";
            this.product_name.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "unit";
            this.unit.HeaderText = "Единица измерения";
            this.unit.MinimumWidth = 6;
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // stock_quantity
            // 
            this.stock_quantity.DataPropertyName = "stock_quantity";
            this.stock_quantity.HeaderText = "Количество на складе";
            this.stock_quantity.MinimumWidth = 6;
            this.stock_quantity.Name = "stock_quantity";
            this.stock_quantity.ReadOnly = true;
            // 
            // buttonWriteOffView
            // 
            this.buttonWriteOffView.BorderRadius = 10;
            this.buttonWriteOffView.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonWriteOffView.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonWriteOffView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonWriteOffView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonWriteOffView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonWriteOffView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonWriteOffView.ForeColor = System.Drawing.Color.Black;
            this.buttonWriteOffView.Location = new System.Drawing.Point(424, 12);
            this.buttonWriteOffView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonWriteOffView.Name = "buttonWriteOffView";
            this.buttonWriteOffView.Size = new System.Drawing.Size(325, 36);
            this.buttonWriteOffView.TabIndex = 29;
            this.buttonWriteOffView.Text = "Просмотр списанных продуктов";
            this.buttonWriteOffView.Click += new System.EventHandler(this.buttonWriteOffView_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHint});
            this.statusStrip.Location = new System.Drawing.Point(0, 533);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1101, 26);
            this.statusStrip.TabIndex = 30;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelHint
            // 
            this.toolStripStatusLabelHint.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripStatusLabelHint.ForeColor = System.Drawing.Color.Gray;
            this.toolStripStatusLabelHint.Name = "toolStripStatusLabelHint";
            this.toolStripStatusLabelHint.Size = new System.Drawing.Size(1081, 20);
            this.toolStripStatusLabelHint.Spring = true;
            this.toolStripStatusLabelHint.Text = "F1 — справка   |   Esc — назад";
            this.toolStripStatusLabelHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxReservation
            // 
            this.groupBoxReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxReservation.BorderRadius = 10;
            this.groupBoxReservation.Controls.Add(this.textBoxSearch);
            this.groupBoxReservation.Controls.Add(this.labelSearch);
            this.groupBoxReservation.Controls.Add(this.buttonRefresh);
            this.groupBoxReservation.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.groupBoxReservation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxReservation.ForeColor = System.Drawing.Color.Gray;
            this.groupBoxReservation.Location = new System.Drawing.Point(763, 320);
            this.groupBoxReservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxReservation.Name = "groupBoxReservation";
            this.groupBoxReservation.Size = new System.Drawing.Size(324, 199);
            this.groupBoxReservation.TabIndex = 31;
            this.groupBoxReservation.Text = "Отбор информации";
            this.groupBoxReservation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.Location = new System.Drawing.Point(11, 51);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(241, 20);
            this.labelSearch.TabIndex = 12;
            this.labelSearch.Text = "Необходимо ввести наименование продукта";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BorderRadius = 10;
            this.buttonRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonRefresh.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonRefresh.ForeColor = System.Drawing.Color.Gray;
            this.buttonRefresh.Location = new System.Drawing.Point(15, 133);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(294, 46);
            this.buttonRefresh.TabIndex = 11;
            this.buttonRefresh.Text = "Сброс";
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderRadius = 10;
            this.textBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSearch.DefaultText = "";
            this.textBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSearch.Location = new System.Drawing.Point(15, 75);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.PlaceholderText = "";
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.Size = new System.Drawing.Size(294, 36);
            this.textBoxSearch.TabIndex = 15;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 559);
            this.Controls.Add(this.groupBoxReservation);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonWriteOffView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(918, 541);
            this.Name = "ProductView";
            this.Text = "Продукты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.ProductView_Load);
            this.VisibleChanged += new System.EventHandler(this.ProductView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBoxReservation.ResumeLayout(false);
            this.groupBoxReservation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button buttonDelete;
        private Guna.UI2.WinForms.Guna2Button buttonEdit;
        private Guna.UI2.WinForms.Guna2Button buttonAdd;
        private Guna.UI2.WinForms.Guna2Button buttonBack;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button buttonWriteOffView;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHint;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_quantity;
        private Guna.UI2.WinForms.Guna2GroupBox groupBoxReservation;
        private System.Windows.Forms.Label labelSearch;
        private Guna.UI2.WinForms.Guna2Button buttonRefresh;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSearch;
    }
}