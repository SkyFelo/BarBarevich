namespace BarBarevich.Forms.S_Tables.s_employee_role
{
    partial class EditEmployeeRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEmployeeRole));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new Guna.UI2.WinForms.Guna2Button();
            this.buttonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxID = new Guna.UI2.WinForms.Guna2TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHint = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Должность";
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
            this.buttonBack.Location = new System.Drawing.Point(232, 119);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(180, 46);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Назад";
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BorderRadius = 10;
            this.buttonEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(28, 119);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(180, 46);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.BorderRadius = 10;
            this.textBoxInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxInput.DefaultText = "";
            this.textBoxInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxInput.Location = new System.Drawing.Point(28, 54);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxInput.MaxLength = 45;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.PasswordChar = '\0';
            this.textBoxInput.PlaceholderText = "";
            this.textBoxInput.SelectedText = "";
            this.textBoxInput.Size = new System.Drawing.Size(384, 36);
            this.textBoxInput.TabIndex = 7;
            this.textBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInput_KeyPress);
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
            this.textBoxID.Location = new System.Drawing.Point(333, 2);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.PasswordChar = '\0';
            this.textBoxID.PlaceholderText = "";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.SelectedText = "";
            this.textBoxID.Size = new System.Drawing.Size(79, 36);
            this.textBoxID.TabIndex = 6;
            this.textBoxID.Visible = false;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHint});
            this.statusStrip.Location = new System.Drawing.Point(0, 187);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(441, 26);
            this.statusStrip.TabIndex = 57;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelHint
            // 
            this.toolStripStatusLabelHint.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripStatusLabelHint.ForeColor = System.Drawing.Color.Gray;
            this.toolStripStatusLabelHint.Name = "toolStripStatusLabelHint";
            this.toolStripStatusLabelHint.Size = new System.Drawing.Size(421, 20);
            this.toolStripStatusLabelHint.Spring = true;
            this.toolStripStatusLabelHint.Text = "F1 — справка   |   Enter — изменить   |   Esc — назад";
            this.toolStripStatusLabelHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EditEmployeeRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(441, 213);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.textBoxID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(459, 260);
            this.MinimumSize = new System.Drawing.Size(459, 260);
            this.Name = "EditEmployeeRole";
            this.Text = "Изменить должность";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button buttonBack;
        private Guna.UI2.WinForms.Guna2Button buttonEdit;
        private Guna.UI2.WinForms.Guna2TextBox textBoxInput;
        private Guna.UI2.WinForms.Guna2TextBox textBoxID;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHint;
    }
}