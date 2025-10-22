namespace BarBarevich.Forms.View.SupplyOrder
{
    partial class ProductOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductOrder));
            this.numericUpDownQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.numericUpDownPrice = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelProductName = new System.Windows.Forms.Label();
            this.buttonCancel = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHint = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDownQuantity.BorderRadius = 10;
            this.numericUpDownQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericUpDownQuantity.Location = new System.Drawing.Point(18, 50);
            this.numericUpDownQuantity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(142, 39);
            this.numericUpDownQuantity.TabIndex = 1;
            this.numericUpDownQuantity.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numericUpDownQuantity.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDownPrice.BorderRadius = 10;
            this.numericUpDownPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericUpDownPrice.Location = new System.Drawing.Point(178, 50);
            this.numericUpDownPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(142, 39);
            this.numericUpDownPrice.TabIndex = 2;
            this.numericUpDownPrice.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numericUpDownPrice.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.ForeColor = System.Drawing.Color.DimGray;
            this.labelProductName.Location = new System.Drawing.Point(15, 7);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(56, 14);
            this.labelProductName.TabIndex = 16;
            this.labelProductName.Text = "Продукт";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BorderRadius = 10;
            this.buttonCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCancel.FillColor = System.Drawing.Color.DimGray;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(18, 162);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(302, 37);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Отмена поставки";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BorderRadius = 10;
            this.buttonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(18, 107);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(302, 39);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Подтвердить";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(176, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Цена (руб.)";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHint});
            this.statusStrip.Location = new System.Drawing.Point(0, 215);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(338, 22);
            this.statusStrip.TabIndex = 24;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelHint
            // 
            this.toolStripStatusLabelHint.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripStatusLabelHint.ForeColor = System.Drawing.Color.Gray;
            this.toolStripStatusLabelHint.Name = "toolStripStatusLabelHint";
            this.toolStripStatusLabelHint.Size = new System.Drawing.Size(323, 17);
            this.toolStripStatusLabelHint.Spring = true;
            this.toolStripStatusLabelHint.Text = "F1 — справка   |   Enter — подтвердить   |   Esc — назад";
            this.toolStripStatusLabelHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(338, 237);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProductOrder";
            this.Text = "Подтверждение поставки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2NumericUpDown numericUpDownQuantity;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Label labelProductName;
        private Guna.UI2.WinForms.Guna2Button buttonCancel;
        private Guna.UI2.WinForms.Guna2Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHint;
    }
}