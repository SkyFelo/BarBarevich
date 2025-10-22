namespace BarBarevich.Forms.View.Tables
{
    partial class EditTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTable));
            this.buttonBack = new Guna.UI2.WinForms.Guna2Button();
            this.buttonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxInfo = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxPeopleCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHint = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPeopleCount)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.buttonBack.Location = new System.Drawing.Point(221, 366);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(180, 46);
            this.buttonBack.TabIndex = 46;
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
            this.buttonEdit.Location = new System.Drawing.Point(12, 366);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(180, 46);
            this.buttonEdit.TabIndex = 45;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Номер стола";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(11, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Описание стола";
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
            this.textBoxID.Location = new System.Drawing.Point(12, 34);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.PasswordChar = '\0';
            this.textBoxID.PlaceholderText = "";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.SelectedText = "";
            this.textBoxID.Size = new System.Drawing.Size(389, 36);
            this.textBoxID.TabIndex = 41;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.BorderRadius = 10;
            this.textBoxInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxInfo.DefaultText = "";
            this.textBoxInfo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxInfo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxInfo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxInfo.Location = new System.Drawing.Point(12, 110);
            this.textBoxInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxInfo.MaxLength = 150;
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.PasswordChar = '\0';
            this.textBoxInfo.PlaceholderText = "";
            this.textBoxInfo.SelectedText = "";
            this.textBoxInfo.Size = new System.Drawing.Size(389, 165);
            this.textBoxInfo.TabIndex = 47;
            // 
            // textBoxPeopleCount
            // 
            this.textBoxPeopleCount.BackColor = System.Drawing.Color.Transparent;
            this.textBoxPeopleCount.BorderRadius = 10;
            this.textBoxPeopleCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPeopleCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxPeopleCount.Location = new System.Drawing.Point(13, 313);
            this.textBoxPeopleCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPeopleCount.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.textBoxPeopleCount.Name = "textBoxPeopleCount";
            this.textBoxPeopleCount.Size = new System.Drawing.Size(388, 36);
            this.textBoxPeopleCount.TabIndex = 48;
            this.textBoxPeopleCount.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBoxPeopleCount.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(9, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Количество мест";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHint});
            this.statusStrip.Location = new System.Drawing.Point(0, 418);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(413, 26);
            this.statusStrip.TabIndex = 50;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelHint
            // 
            this.toolStripStatusLabelHint.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripStatusLabelHint.ForeColor = System.Drawing.Color.Gray;
            this.toolStripStatusLabelHint.Name = "toolStripStatusLabelHint";
            this.toolStripStatusLabelHint.Size = new System.Drawing.Size(393, 20);
            this.toolStripStatusLabelHint.Spring = true;
            this.toolStripStatusLabelHint.Text = "F1 — справка   |   Enter — изменить   |   Esc — назад";
            this.toolStripStatusLabelHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EditTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(413, 444);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPeopleCount);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(431, 491);
            this.MinimumSize = new System.Drawing.Size(431, 491);
            this.Name = "EditTable";
            this.Text = "Изменить описание стола";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPeopleCount)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button buttonBack;
        private Guna.UI2.WinForms.Guna2Button buttonEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxID;
        private Guna.UI2.WinForms.Guna2TextBox textBoxInfo;
        private Guna.UI2.WinForms.Guna2NumericUpDown textBoxPeopleCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHint;
    }
}