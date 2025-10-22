namespace BarBarevich.Forms.Docs
{
    partial class DocJournal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocJournal));
            this.dateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonBack = new Guna.UI2.WinForms.Guna2Button();
            this.buttonCreate = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.BorderRadius = 10;
            this.dateTimePicker.Checked = true;
            this.dateTimePicker.FillColor = System.Drawing.Color.White;
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker.Location = new System.Drawing.Point(12, 34);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(621, 44);
            this.dateTimePicker.TabIndex = 59;
            this.dateTimePicker.Value = new System.DateTime(2024, 5, 4, 10, 53, 31, 727);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 16);
            this.label4.TabIndex = 58;
            this.label4.Text = "Необходимо выбрать дату бронирования столов:";
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
            this.buttonBack.Location = new System.Drawing.Point(329, 103);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(304, 46);
            this.buttonBack.TabIndex = 73;
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
            this.buttonCreate.Location = new System.Drawing.Point(12, 103);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(304, 46);
            this.buttonCreate.TabIndex = 72;
            this.buttonCreate.Text = "Создать документ";
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // DocJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 171);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(663, 218);
            this.MinimumSize = new System.Drawing.Size(663, 218);
            this.Name = "DocJournal";
            this.Text = "Журнал бронирования";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private Guna.UI2.WinForms.Guna2Button buttonBack;
        private Guna.UI2.WinForms.Guna2Button buttonCreate;
    }
}