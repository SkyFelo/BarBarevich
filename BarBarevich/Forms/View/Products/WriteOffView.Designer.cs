namespace BarBarevich.Forms.View.Products
{
    partial class WriteOffView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriteOffView));
            this.dataGridViewWriteOffProducts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.comboBoxWriteOffType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxReservation = new Guna.UI2.WinForms.Guna2GroupBox();
            this.buttonRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.buttonBack = new Guna.UI2.WinForms.Guna2Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHint = new System.Windows.Forms.ToolStripStatusLabel();
            this.id_written_off_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.write_off_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writeoff_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWriteOffProducts)).BeginInit();
            this.groupBoxReservation.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewWriteOffProducts
            // 
            this.dataGridViewWriteOffProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewWriteOffProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewWriteOffProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewWriteOffProducts.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewWriteOffProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewWriteOffProducts.ColumnHeadersHeight = 25;
            this.dataGridViewWriteOffProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewWriteOffProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_written_off_product,
            this.product_name,
            this.quantity,
            this.write_off_date,
            this.writeoff_type});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewWriteOffProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewWriteOffProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewWriteOffProducts.Location = new System.Drawing.Point(3, 0);
            this.dataGridViewWriteOffProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewWriteOffProducts.Name = "dataGridViewWriteOffProducts";
            this.dataGridViewWriteOffProducts.ReadOnly = true;
            this.dataGridViewWriteOffProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewWriteOffProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewWriteOffProducts.RowHeadersVisible = false;
            this.dataGridViewWriteOffProducts.RowHeadersWidth = 51;
            this.dataGridViewWriteOffProducts.RowTemplate.Height = 28;
            this.dataGridViewWriteOffProducts.Size = new System.Drawing.Size(933, 594);
            this.dataGridViewWriteOffProducts.TabIndex = 29;
            this.dataGridViewWriteOffProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewWriteOffProducts.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewWriteOffProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewWriteOffProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridViewWriteOffProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewWriteOffProducts.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewWriteOffProducts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewWriteOffProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridViewWriteOffProducts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewWriteOffProducts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewWriteOffProducts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewWriteOffProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewWriteOffProducts.ThemeStyle.HeaderStyle.Height = 25;
            this.dataGridViewWriteOffProducts.ThemeStyle.ReadOnly = true;
            this.dataGridViewWriteOffProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewWriteOffProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewWriteOffProducts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewWriteOffProducts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewWriteOffProducts.ThemeStyle.RowsStyle.Height = 28;
            this.dataGridViewWriteOffProducts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridViewWriteOffProducts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // comboBoxWriteOffType
            // 
            this.comboBoxWriteOffType.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxWriteOffType.BorderRadius = 10;
            this.comboBoxWriteOffType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxWriteOffType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWriteOffType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxWriteOffType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxWriteOffType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxWriteOffType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxWriteOffType.ItemHeight = 30;
            this.comboBoxWriteOffType.Location = new System.Drawing.Point(20, 76);
            this.comboBoxWriteOffType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxWriteOffType.Name = "comboBoxWriteOffType";
            this.comboBoxWriteOffType.Size = new System.Drawing.Size(251, 36);
            this.comboBoxWriteOffType.TabIndex = 45;
            this.comboBoxWriteOffType.SelectedIndexChanged += new System.EventHandler(this.comboBoxWriteOffType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(17, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Тип списания";
            // 
            // groupBoxReservation
            // 
            this.groupBoxReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxReservation.BorderRadius = 10;
            this.groupBoxReservation.Controls.Add(this.buttonRefresh);
            this.groupBoxReservation.Controls.Add(this.comboBoxWriteOffType);
            this.groupBoxReservation.Controls.Add(this.label3);
            this.groupBoxReservation.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.groupBoxReservation.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxReservation.ForeColor = System.Drawing.Color.Gray;
            this.groupBoxReservation.Location = new System.Drawing.Point(949, 400);
            this.groupBoxReservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxReservation.Name = "groupBoxReservation";
            this.groupBoxReservation.Size = new System.Drawing.Size(292, 194);
            this.groupBoxReservation.TabIndex = 46;
            this.groupBoxReservation.Text = "Отбор информации";
            this.groupBoxReservation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.buttonRefresh.Location = new System.Drawing.Point(21, 127);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(251, 46);
            this.buttonRefresh.TabIndex = 11;
            this.buttonRefresh.Text = "Сброс";
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
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
            this.buttonBack.Location = new System.Drawing.Point(1124, 7);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(117, 36);
            this.buttonBack.TabIndex = 47;
            this.buttonBack.Text = "Назад";
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHint});
            this.statusStrip.Location = new System.Drawing.Point(0, 610);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1253, 26);
            this.statusStrip.TabIndex = 48;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelHint
            // 
            this.toolStripStatusLabelHint.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripStatusLabelHint.ForeColor = System.Drawing.Color.Gray;
            this.toolStripStatusLabelHint.Name = "toolStripStatusLabelHint";
            this.toolStripStatusLabelHint.Size = new System.Drawing.Size(1233, 20);
            this.toolStripStatusLabelHint.Spring = true;
            this.toolStripStatusLabelHint.Text = "F1 — справка   |   Esc — назад";
            this.toolStripStatusLabelHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // id_written_off_product
            // 
            this.id_written_off_product.DataPropertyName = "id_written_off_product";
            this.id_written_off_product.HeaderText = "ID";
            this.id_written_off_product.MinimumWidth = 6;
            this.id_written_off_product.Name = "id_written_off_product";
            this.id_written_off_product.ReadOnly = true;
            this.id_written_off_product.Visible = false;
            // 
            // product_name
            // 
            this.product_name.DataPropertyName = "product_name";
            this.product_name.HeaderText = "Продукт";
            this.product_name.MinimumWidth = 6;
            this.product_name.Name = "product_name";
            this.product_name.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Количество";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // write_off_date
            // 
            this.write_off_date.DataPropertyName = "write_off_date";
            this.write_off_date.HeaderText = "Дата списания";
            this.write_off_date.MinimumWidth = 6;
            this.write_off_date.Name = "write_off_date";
            this.write_off_date.ReadOnly = true;
            // 
            // writeoff_type
            // 
            this.writeoff_type.DataPropertyName = "writeoff_type";
            this.writeoff_type.HeaderText = "Тип списания";
            this.writeoff_type.MinimumWidth = 6;
            this.writeoff_type.Name = "writeoff_type";
            this.writeoff_type.ReadOnly = true;
            // 
            // WriteOffView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1253, 636);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBoxReservation);
            this.Controls.Add(this.dataGridViewWriteOffProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1261, 653);
            this.Name = "WriteOffView";
            this.Text = "Просмотр списанных продуктов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.WriteOffView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWriteOffProducts)).EndInit();
            this.groupBoxReservation.ResumeLayout(false);
            this.groupBoxReservation.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewWriteOffProducts;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxWriteOffType;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GroupBox groupBoxReservation;
        private Guna.UI2.WinForms.Guna2Button buttonRefresh;
        private Guna.UI2.WinForms.Guna2Button buttonBack;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHint;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_written_off_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn write_off_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn writeoff_type;
    }
}