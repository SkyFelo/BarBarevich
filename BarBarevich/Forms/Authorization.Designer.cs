namespace BarBarevich
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.textBoxLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEnter = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.showPassword = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHint = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BorderRadius = 10;
            this.textBoxLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxLogin.DefaultText = "";
            this.textBoxLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxLogin.Location = new System.Drawing.Point(25, 244);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.PasswordChar = '\0';
            this.textBoxLogin.PlaceholderText = "";
            this.textBoxLogin.SelectedText = "";
            this.textBoxLogin.Size = new System.Drawing.Size(380, 39);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderRadius = 10;
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.DefaultText = "";
            this.textBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.Location = new System.Drawing.Point(25, 320);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '\0';
            this.textBoxPassword.PlaceholderText = "";
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.Size = new System.Drawing.Size(380, 39);
            this.textBoxPassword.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // buttonEnter
            // 
            this.buttonEnter.BorderRadius = 10;
            this.buttonEnter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonEnter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonEnter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonEnter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonEnter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonEnter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnter.ForeColor = System.Drawing.Color.White;
            this.buttonEnter.Location = new System.Drawing.Point(61, 410);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(298, 56);
            this.buttonEnter.TabIndex = 4;
            this.buttonEnter.Text = "Войти";
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(113, 11);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(210, 210);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 7;
            this.guna2PictureBox1.TabStop = false;
            // 
            // showPassword
            // 
            this.showPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.showPassword.AutoSize = true;
            this.showPassword.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.showPassword.Location = new System.Drawing.Point(279, 363);
            this.showPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showPassword.Name = "showPassword";
            this.showPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.showPassword.Size = new System.Drawing.Size(120, 16);
            this.showPassword.TabIndex = 14;
            this.showPassword.Text = "Показать пароль";
            this.showPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showPassword.Click += new System.EventHandler(this.showPassword_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHint});
            this.statusStrip.Location = new System.Drawing.Point(0, 518);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(435, 26);
            this.statusStrip.TabIndex = 59;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelHint
            // 
            this.toolStripStatusLabelHint.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripStatusLabelHint.ForeColor = System.Drawing.Color.Gray;
            this.toolStripStatusLabelHint.Name = "toolStripStatusLabelHint";
            this.toolStripStatusLabelHint.Size = new System.Drawing.Size(376, 20);
            this.toolStripStatusLabelHint.Spring = true;
            this.toolStripStatusLabelHint.Text = "F1 — справка   |   Enter — войти   |   Esc — назад";
            this.toolStripStatusLabelHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 544);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.guna2PictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Authorization";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Authorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox textBoxLogin;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button buttonEnter;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label showPassword;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHint;
    }
}

