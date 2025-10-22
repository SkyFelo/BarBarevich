namespace BarBarevich.Forms.View.Products
{
    partial class WriteOffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriteOffForm));
            this.comboBoxWriteOffType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBack = new Guna.UI2.WinForms.Guna2Button();
            this.buttonConfirmWriteOff = new Guna.UI2.WinForms.Guna2Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHint = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.comboBoxWriteOffType.Location = new System.Drawing.Point(15, 36);
            this.comboBoxWriteOffType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxWriteOffType.Name = "comboBoxWriteOffType";
            this.comboBoxWriteOffType.Size = new System.Drawing.Size(387, 36);
            this.comboBoxWriteOffType.TabIndex = 43;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.ForeColor = System.Drawing.Color.DimGray;
            this.labelProductName.Location = new System.Drawing.Point(12, 90);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(242, 16);
            this.labelProductName.TabIndex = 42;
            this.labelProductName.Text = "Количество под списание продукта";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.BorderRadius = 10;
            this.textBoxQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxQuantity.DefaultText = "";
            this.textBoxQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxQuantity.Location = new System.Drawing.Point(15, 110);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxQuantity.MaxLength = 8;
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.PasswordChar = '\0';
            this.textBoxQuantity.PlaceholderText = "";
            this.textBoxQuantity.SelectedText = "";
            this.textBoxQuantity.Size = new System.Drawing.Size(387, 36);
            this.textBoxQuantity.TabIndex = 41;
            this.textBoxQuantity.TextChanged += new System.EventHandler(this.textBoxQuantity_TextChanged);
            this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProductQuantity_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Тип списания";
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
            this.buttonBack.Location = new System.Drawing.Point(221, 171);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(180, 46);
            this.buttonBack.TabIndex = 45;
            this.buttonBack.Text = "Назад";
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonConfirmWriteOff
            // 
            this.buttonConfirmWriteOff.BorderRadius = 10;
            this.buttonConfirmWriteOff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonConfirmWriteOff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonConfirmWriteOff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonConfirmWriteOff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonConfirmWriteOff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonConfirmWriteOff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonConfirmWriteOff.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmWriteOff.Location = new System.Drawing.Point(15, 171);
            this.buttonConfirmWriteOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConfirmWriteOff.Name = "buttonConfirmWriteOff";
            this.buttonConfirmWriteOff.Size = new System.Drawing.Size(180, 46);
            this.buttonConfirmWriteOff.TabIndex = 44;
            this.buttonConfirmWriteOff.Text = "Списать";
            this.buttonConfirmWriteOff.Click += new System.EventHandler(this.buttonConfirmWriteOff_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHint});
            this.statusStrip.Location = new System.Drawing.Point(0, 225);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(417, 26);
            this.statusStrip.TabIndex = 46;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelHint
            // 
            this.toolStripStatusLabelHint.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripStatusLabelHint.ForeColor = System.Drawing.Color.Gray;
            this.toolStripStatusLabelHint.Name = "toolStripStatusLabelHint";
            this.toolStripStatusLabelHint.Size = new System.Drawing.Size(397, 20);
            this.toolStripStatusLabelHint.Spring = true;
            this.toolStripStatusLabelHint.Text = "F1 — справка   |   Enter — списать   |   Esc — назад";
            this.toolStripStatusLabelHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WriteOffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(417, 251);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonConfirmWriteOff);
            this.Controls.Add(this.comboBoxWriteOffType);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(435, 298);
            this.MinimumSize = new System.Drawing.Size(435, 298);
            this.Name = "WriteOffForm";
            this.Text = "Списание продукта";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.WriteOffForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox comboBoxWriteOffType;
        private System.Windows.Forms.Label labelProductName;
        private Guna.UI2.WinForms.Guna2TextBox textBoxQuantity;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button buttonBack;
        private Guna.UI2.WinForms.Guna2Button buttonConfirmWriteOff;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHint;
    }
}