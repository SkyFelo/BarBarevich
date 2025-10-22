namespace BarBarevich.Forms.View.SupplyOrder
{
    partial class AddSupplyOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupplyOrder));
            this.numericUpDownQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.dataGridViewProducts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxSuppliers = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dateTimePickerOrderDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.buttonAddProduct = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAddOrder = new Guna.UI2.WinForms.Guna2Button();
            this.buttonBack = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHint = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDownQuantity.BorderRadius = 10;
            this.numericUpDownQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericUpDownQuantity.Location = new System.Drawing.Point(569, 228);
            this.numericUpDownQuantity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(89, 39);
            this.numericUpDownQuantity.TabIndex = 0;
            this.numericUpDownQuantity.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numericUpDownQuantity.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.BackColor = System.Drawing.Color.Gainsboro;
            this.listBoxProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.Location = new System.Drawing.Point(335, 228);
            this.listBoxProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(220, 91);
            this.listBoxProducts.TabIndex = 1;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProducts.ColumnHeadersHeight = 4;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product,
            this.quantity});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewProducts.Location = new System.Drawing.Point(335, 10);
            this.dataGridViewProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewProducts.RowHeadersVisible = false;
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.Size = new System.Drawing.Size(323, 205);
            this.dataGridViewProducts.TabIndex = 2;
            this.dataGridViewProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewProducts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewProducts.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewProducts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewProducts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewProducts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dataGridViewProducts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewProducts.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridViewProducts.ThemeStyle.ReadOnly = false;
            this.dataGridViewProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewProducts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dataGridViewProducts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewProducts.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridViewProducts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewProducts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // product
            // 
            this.product.HeaderText = "product";
            this.product.MinimumWidth = 6;
            this.product.Name = "product";
            this.product.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // comboBoxSuppliers
            // 
            this.comboBoxSuppliers.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxSuppliers.BorderRadius = 10;
            this.comboBoxSuppliers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSuppliers.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxSuppliers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxSuppliers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxSuppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxSuppliers.ItemHeight = 30;
            this.comboBoxSuppliers.Location = new System.Drawing.Point(17, 23);
            this.comboBoxSuppliers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxSuppliers.Name = "comboBoxSuppliers";
            this.comboBoxSuppliers.Size = new System.Drawing.Size(294, 36);
            this.comboBoxSuppliers.TabIndex = 3;
            // 
            // dateTimePickerOrderDate
            // 
            this.dateTimePickerOrderDate.BorderRadius = 10;
            this.dateTimePickerOrderDate.Checked = true;
            this.dateTimePickerOrderDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dateTimePickerOrderDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePickerOrderDate.ForeColor = System.Drawing.SystemColors.Control;
            this.dateTimePickerOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerOrderDate.Location = new System.Drawing.Point(17, 81);
            this.dateTimePickerOrderDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerOrderDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerOrderDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            this.dateTimePickerOrderDate.Size = new System.Drawing.Size(293, 29);
            this.dateTimePickerOrderDate.TabIndex = 4;
            this.dateTimePickerOrderDate.Value = new System.DateTime(2025, 4, 17, 7, 18, 17, 967);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.BorderRadius = 10;
            this.buttonAddProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAddProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAddProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAddProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAddProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonAddProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAddProduct.ForeColor = System.Drawing.Color.White;
            this.buttonAddProduct.Location = new System.Drawing.Point(569, 282);
            this.buttonAddProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(89, 37);
            this.buttonAddProduct.TabIndex = 5;
            this.buttonAddProduct.Text = "➕";
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.BorderRadius = 10;
            this.buttonAddOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAddOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAddOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAddOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAddOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonAddOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAddOrder.ForeColor = System.Drawing.Color.White;
            this.buttonAddOrder.Location = new System.Drawing.Point(9, 228);
            this.buttonAddOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(302, 39);
            this.buttonAddOrder.TabIndex = 6;
            this.buttonAddOrder.Text = "Добавить заказ";
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
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
            this.buttonBack.Location = new System.Drawing.Point(9, 282);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(302, 37);
            this.buttonBack.TabIndex = 14;
            this.buttonBack.Text = "Назад";
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Поставщик";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(15, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Дата ожидаемой доставки";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHint});
            this.statusStrip.Location = new System.Drawing.Point(0, 328);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(668, 22);
            this.statusStrip.TabIndex = 28;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelHint
            // 
            this.toolStripStatusLabelHint.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripStatusLabelHint.ForeColor = System.Drawing.Color.Gray;
            this.toolStripStatusLabelHint.Name = "toolStripStatusLabelHint";
            this.toolStripStatusLabelHint.Size = new System.Drawing.Size(653, 17);
            this.toolStripStatusLabelHint.Spring = true;
            this.toolStripStatusLabelHint.Text = "F1 — справка   |   Enter — добавить заказ   |   Esc — назад";
            this.toolStripStatusLabelHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddSupplyOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 350);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAddOrder);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.dateTimePickerOrderDate);
            this.Controls.Add(this.comboBoxSuppliers);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(684, 389);
            this.MinimumSize = new System.Drawing.Size(684, 389);
            this.Name = "AddSupplyOrder";
            this.Text = "Формирование заказа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.ListBox listBoxProducts;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewProducts;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxSuppliers;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerOrderDate;
        private Guna.UI2.WinForms.Guna2Button buttonAddProduct;
        private Guna.UI2.WinForms.Guna2Button buttonAddOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private Guna.UI2.WinForms.Guna2Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHint;
    }
}