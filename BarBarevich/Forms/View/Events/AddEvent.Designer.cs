namespace BarBarevich.Forms.View.Events
{
    partial class AddEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEvent));
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxEvent = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.datePickerEventDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.timePickerEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.timePickerStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHint = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonBack = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxID = new Guna.UI2.WinForms.Guna2TextBox();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(17, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "Меропритие";
            // 
            // comboBoxEvent
            // 
            this.comboBoxEvent.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxEvent.BorderRadius = 10;
            this.comboBoxEvent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEvent.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxEvent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxEvent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxEvent.ItemHeight = 30;
            this.comboBoxEvent.Location = new System.Drawing.Point(21, 37);
            this.comboBoxEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxEvent.Name = "comboBoxEvent";
            this.comboBoxEvent.Size = new System.Drawing.Size(469, 36);
            this.comboBoxEvent.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(348, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 55;
            this.label10.Text = "Дата";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(166, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 16);
            this.label9.TabIndex = 54;
            this.label9.Text = "по";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(17, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 53;
            this.label8.Text = "Время начала";
            // 
            // datePickerEventDate
            // 
            this.datePickerEventDate.BorderRadius = 10;
            this.datePickerEventDate.Checked = true;
            this.datePickerEventDate.FillColor = System.Drawing.Color.White;
            this.datePickerEventDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datePickerEventDate.ForeColor = System.Drawing.Color.Black;
            this.datePickerEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePickerEventDate.Location = new System.Drawing.Point(350, 110);
            this.datePickerEventDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePickerEventDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePickerEventDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePickerEventDate.Name = "datePickerEventDate";
            this.datePickerEventDate.Size = new System.Drawing.Size(139, 36);
            this.datePickerEventDate.TabIndex = 52;
            this.datePickerEventDate.Value = new System.DateTime(2024, 6, 14, 4, 5, 9, 926);
            // 
            // timePickerEnd
            // 
            this.timePickerEnd.BorderRadius = 10;
            this.timePickerEnd.Checked = true;
            this.timePickerEnd.FillColor = System.Drawing.Color.White;
            this.timePickerEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timePickerEnd.ForeColor = System.Drawing.Color.Black;
            this.timePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.timePickerEnd.Location = new System.Drawing.Point(193, 110);
            this.timePickerEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timePickerEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timePickerEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timePickerEnd.Name = "timePickerEnd";
            this.timePickerEnd.Size = new System.Drawing.Size(139, 36);
            this.timePickerEnd.TabIndex = 51;
            this.timePickerEnd.Value = new System.DateTime(2024, 6, 14, 4, 5, 9, 926);
            // 
            // timePickerStart
            // 
            this.timePickerStart.BorderRadius = 10;
            this.timePickerStart.Checked = true;
            this.timePickerStart.FillColor = System.Drawing.Color.White;
            this.timePickerStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timePickerStart.ForeColor = System.Drawing.Color.Black;
            this.timePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.timePickerStart.Location = new System.Drawing.Point(20, 110);
            this.timePickerStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timePickerStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timePickerStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timePickerStart.Name = "timePickerStart";
            this.timePickerStart.Size = new System.Drawing.Size(139, 36);
            this.timePickerStart.TabIndex = 50;
            this.timePickerStart.Value = new System.DateTime(2024, 6, 14, 4, 5, 9, 926);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHint});
            this.statusStrip.Location = new System.Drawing.Point(0, 243);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(518, 26);
            this.statusStrip.TabIndex = 60;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelHint
            // 
            this.toolStripStatusLabelHint.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripStatusLabelHint.ForeColor = System.Drawing.Color.Gray;
            this.toolStripStatusLabelHint.Name = "toolStripStatusLabelHint";
            this.toolStripStatusLabelHint.Size = new System.Drawing.Size(498, 20);
            this.toolStripStatusLabelHint.Spring = true;
            this.toolStripStatusLabelHint.Text = "F1 — справка   |   Enter — добавить   |   Esc — назад";
            this.toolStripStatusLabelHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.buttonBack.Location = new System.Drawing.Point(279, 171);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(210, 46);
            this.buttonBack.TabIndex = 59;
            this.buttonBack.Text = "Назад";
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
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
            this.buttonAdd.Location = new System.Drawing.Point(21, 171);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(211, 46);
            this.buttonAdd.TabIndex = 58;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.BorderRadius = 10;
            this.textBoxID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxID.DefaultText = "";
            this.textBoxID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxID.Location = new System.Drawing.Point(410, -5);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.PasswordChar = '\0';
            this.textBoxID.PlaceholderText = "";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.SelectedText = "";
            this.textBoxID.Size = new System.Drawing.Size(79, 36);
            this.textBoxID.TabIndex = 61;
            this.textBoxID.Visible = false;
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 269);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxEvent);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.datePickerEventDate);
            this.Controls.Add(this.timePickerEnd);
            this.Controls.Add(this.timePickerStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(536, 316);
            this.MinimumSize = new System.Drawing.Size(536, 316);
            this.Name = "AddEvent";
            this.Text = "Добавить мероприятие";
            this.Load += new System.EventHandler(this.AddEvent_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxEvent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker datePickerEventDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker timePickerEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker timePickerStart;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHint;
        private Guna.UI2.WinForms.Guna2Button buttonBack;
        private Guna.UI2.WinForms.Guna2Button buttonAdd;
        private Guna.UI2.WinForms.Guna2TextBox textBoxID;
    }
}