namespace BarBarevich.Forms.Docs
{
    partial class DocWriteOff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocWriteOff));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateTimePickerStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.buttonBack = new Guna.UI2.WinForms.Guna2Button();
            this.buttonCreate = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 16);
            this.label4.TabIndex = 70;
            this.label4.Text = "Необходимо выбрать отчетный промежуток времени:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 88;
            this.label1.Text = "по";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.BorderRadius = 10;
            this.dateTimePickerEnd.Checked = true;
            this.dateTimePickerEnd.FillColor = System.Drawing.Color.White;
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(352, 33);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(281, 44);
            this.dateTimePickerEnd.TabIndex = 87;
            this.dateTimePickerEnd.Value = new System.DateTime(2024, 5, 4, 10, 53, 31, 727);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.BorderRadius = 10;
            this.dateTimePickerStart.Checked = true;
            this.dateTimePickerStart.FillColor = System.Drawing.Color.White;
            this.dateTimePickerStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerStart.Location = new System.Drawing.Point(12, 33);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(281, 44);
            this.dateTimePickerStart.TabIndex = 86;
            this.dateTimePickerStart.Value = new System.DateTime(2024, 5, 4, 10, 53, 31, 727);
            // 
            // buttonBack
            // 
            this.buttonBack.BorderRadius = 10;
            this.buttonBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonBack.FillColor = System.Drawing.Color.Gainsboro;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonBack.ForeColor = System.Drawing.Color.Gray;
            this.buttonBack.Location = new System.Drawing.Point(329, 105);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(304, 46);
            this.buttonBack.TabIndex = 85;
            this.buttonBack.Text = "Вернуться назад";
            this.buttonBack.Click += new System.EventHandler(this.labelBack_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.BorderRadius = 10;
            this.buttonCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonCreate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCreate.ForeColor = System.Drawing.Color.White;
            this.buttonCreate.Location = new System.Drawing.Point(12, 105);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(304, 46);
            this.buttonCreate.TabIndex = 84;
            this.buttonCreate.Text = "Создать документ";
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // DocWriteOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 171);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(663, 218);
            this.MinimumSize = new System.Drawing.Size(663, 218);
            this.Name = "DocWriteOff";
            this.Text = "Информация о списанных продуктах";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerStart;
        private Guna.UI2.WinForms.Guna2Button buttonBack;
        private Guna.UI2.WinForms.Guna2Button buttonCreate;
    }
}