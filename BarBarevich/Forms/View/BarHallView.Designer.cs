namespace BarBarevich.Forms.View
{
    partial class BarHallView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarHallView));
            this.datePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.buttonView = new Guna.UI2.WinForms.Guna2Button();
            this.image = new Guna.UI2.WinForms.Guna2PictureBox();
            this.table7Button = new Guna.UI2.WinForms.Guna2Button();
            this.table8Button = new Guna.UI2.WinForms.Guna2Button();
            this.table9Button = new Guna.UI2.WinForms.Guna2Button();
            this.table10Button = new Guna.UI2.WinForms.Guna2Button();
            this.table2Button = new Guna.UI2.WinForms.Guna2Button();
            this.table11Button = new Guna.UI2.WinForms.Guna2Button();
            this.table12Button = new Guna.UI2.WinForms.Guna2Button();
            this.table13Button = new Guna.UI2.WinForms.Guna2Button();
            this.table14Button = new Guna.UI2.WinForms.Guna2Button();
            this.table15Button = new Guna.UI2.WinForms.Guna2Button();
            this.table5Button = new Guna.UI2.WinForms.Guna2Button();
            this.table6Button = new Guna.UI2.WinForms.Guna2Button();
            this.table16Button = new Guna.UI2.WinForms.Guna2Button();
            this.table1Button = new Guna.UI2.WinForms.Guna2Button();
            this.table3Button = new Guna.UI2.WinForms.Guna2Button();
            this.table4Button = new Guna.UI2.WinForms.Guna2Button();
            this.groupBoxReservation = new Guna.UI2.WinForms.Guna2GroupBox();
            this.textBoxReservationTime = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDeposit = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxGuestsCount = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxClientPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxClientName = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonBack = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHint = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.groupBoxReservation.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.BorderRadius = 10;
            this.datePicker.Checked = true;
            this.datePicker.FillColor = System.Drawing.SystemColors.Control;
            this.datePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePicker.Location = new System.Drawing.Point(12, 12);
            this.datePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(321, 36);
            this.datePicker.TabIndex = 0;
            this.datePicker.Value = new System.DateTime(2024, 6, 14, 4, 42, 48, 921);
            // 
            // buttonView
            // 
            this.buttonView.BorderRadius = 10;
            this.buttonView.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonView.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonView.ForeColor = System.Drawing.Color.White;
            this.buttonView.Location = new System.Drawing.Point(352, 12);
            this.buttonView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(277, 36);
            this.buttonView.TabIndex = 1;
            this.buttonView.Text = "Просмотреть занятые столы";
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // image
            // 
            this.image.Image = ((System.Drawing.Image)(resources.GetObject("image.Image")));
            this.image.ImageRotate = 0F;
            this.image.Location = new System.Drawing.Point(12, 64);
            this.image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(853, 430);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 2;
            this.image.TabStop = false;
            // 
            // table7Button
            // 
            this.table7Button.BorderThickness = 2;
            this.table7Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.table7Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.table7Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.table7Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.table7Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(158)))));
            this.table7Button.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.table7Button.ForeColor = System.Drawing.Color.Black;
            this.table7Button.Location = new System.Drawing.Point(181, 207);
            this.table7Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table7Button.Name = "table7Button";
            this.table7Button.Size = new System.Drawing.Size(51, 64);
            this.table7Button.TabIndex = 3;
            this.table7Button.Text = "7";
            this.table7Button.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // table8Button
            // 
            this.table8Button.BorderThickness = 2;
            this.table8Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.table8Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.table8Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.table8Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.table8Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(158)))));
            this.table8Button.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.table8Button.ForeColor = System.Drawing.Color.Black;
            this.table8Button.Location = new System.Drawing.Point(237, 207);
            this.table8Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table8Button.Name = "table8Button";
            this.table8Button.Size = new System.Drawing.Size(51, 64);
            this.table8Button.TabIndex = 4;
            this.table8Button.Text = "8";
            this.table8Button.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // table9Button
            // 
            this.table9Button.BorderThickness = 2;
            this.table9Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.table9Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.table9Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.table9Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.table9Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(158)))));
            this.table9Button.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.table9Button.ForeColor = System.Drawing.Color.Black;
            this.table9Button.Location = new System.Drawing.Point(295, 207);
            this.table9Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table9Button.Name = "table9Button";
            this.table9Button.Size = new System.Drawing.Size(99, 36);
            this.table9Button.TabIndex = 5;
            this.table9Button.Text = "9";
            this.table9Button.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // table10Button
            // 
            this.table10Button.BorderThickness = 2;
            this.table10Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.table10Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.table10Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.table10Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.table10Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(158)))));
            this.table10Button.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.table10Button.ForeColor = System.Drawing.Color.Black;
            this.table10Button.Location = new System.Drawing.Point(295, 258);
            this.table10Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table10Button.Name = "table10Button";
            this.table10Button.Size = new System.Drawing.Size(99, 36);
            this.table10Button.TabIndex = 6;
            this.table10Button.Text = "10";
            this.table10Button.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // table2Button
            // 
            this.table2Button.BorderThickness = 2;
            this.table2Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.table2Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.table2Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.table2Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.table2Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(158)))));
            this.table2Button.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.table2Button.ForeColor = System.Drawing.Color.Black;
            this.table2Button.Location = new System.Drawing.Point(272, 142);
            this.table2Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table2Button.Name = "table2Button";
            this.table2Button.Size = new System.Drawing.Size(99, 36);
            this.table2Button.TabIndex = 7;
            this.table2Button.Text = "2";
            this.table2Button.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // table11Button
            // 
            this.table11Button.BorderThickness = 2;
            this.table11Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.table11Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.table11Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.table11Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.table11Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(158)))));
            this.table11Button.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.table11Button.ForeColor = System.Drawing.Color.Black;
            this.table11Button.Location = new System.Drawing.Point(461, 322);
            this.table11Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table11Button.Name = "table11Button";
            this.table11Button.Size = new System.Drawing.Size(99, 36);
            this.table11Button.TabIndex = 8;
            this.table11Button.Text = "11";
            this.table11Button.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // table12Button
            // 
            this.table12Button.BorderThickness = 2;
            this.table12Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.table12Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.table12Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.table12Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.table12Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(158)))));
            this.table12Button.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.table12Button.ForeColor = System.Drawing.Color.Black;
            this.table12Button.Location = new System.Drawing.Point(615, 207);
            this.table12Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table12Button.Name = "table12Button";
            this.table12Button.Size = new System.Drawing.Size(99, 36);
            this.table12Button.TabIndex = 9;
            this.table12Button.Text = "12";
            this.table12Button.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // table13Button
            // 
            this.table13Button.BorderThickness = 2;
            this.table13Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.table13Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.table13Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.table13Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.table13Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(158)))));
            this.table13Button.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.table13Button.ForeColor = System.Drawing.Color.Black;
            this.table13Button.Location = new System.Drawing.Point(615, 258);
            this.table13Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table13Button.Name = "table13Button";
            this.table13Button.Size = new System.Drawing.Size(99, 36);
            this.table13Button.TabIndex = 10;
            this.table13Button.Text = "13";
            this.table13Button.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // table14Button
            // 
            this.table14Button.BorderThickness = 2;
            this.table14Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.table14Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.table14Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.table14Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.table14Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(158)))));
            this.table14Button.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.table14Button.ForeColor = System.Drawing.Color.Black;
            this.table14Button.Location = new System.Drawing.Point(615, 310);
            this.table14Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table14Button.Name = "table14Button";
            this.table14Button.Size = new System.Drawing.Size(99, 36);
            this.table14Button.TabIndex = 11;
            this.table14Button.Text = "14";
            this.table14Button.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // table15Button
            // 
            this.table15Button.BorderThickness = 2;
            this.table15Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.table15Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.table15Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.table15Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.table15Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(158)))));
            this.table15Button.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.table15Button.ForeColor = System.Drawing.Color.Black;
            this.table15Button.Location = new System.Drawing.Point(615, 361);
            this.table15Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table15Button.Name = "table15Button";
            this.table15Button.Size = new System.Drawing.Size(99, 36);
            this.table15Button.TabIndex = 12;
            this.table15Button.Text = "15";
            this.table15Button.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // table5Button
            // 
            this.table5Button.BorderThickness = 2;
            this.table5Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.table5Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.table5Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.table5Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.table5Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(158)))));
            this.table5Button.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.table5Button.ForeColor = System.Drawing.Color.Black;
            this.table5Button.Location = new System.Drawing.Point(795, 236);
            this.table5Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table5Button.Name = "table5Button";
            this.table5Button.Size = new System.Drawing.Size(51, 65);
            this.table5Button.TabIndex = 13;
            this.table5Button.Text = "5";
            this.table5Button.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // table6Button
            // 
            this.table6Button.BorderThickness = 2;
            this.table6Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.table6Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.table6Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.table6Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.table6Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(158)))));
            this.table6Button.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.table6Button.ForeColor = System.Drawing.Color.Black;
            this.table6Button.Location = new System.Drawing.Point(795, 310);
            this.table6Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table6Button.Name = "table6Button";
            this.table6Button.Size = new System.Drawing.Size(51, 65);
            this.table6Button.TabIndex = 14;
            this.table6Button.Text = "6";
            this.table6Button.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // table16Button
            // 
            this.table16Button.BorderThickness = 2;
            this.table16Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.table16Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.table16Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.table16Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.table16Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(158)))));
            this.table16Button.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.table16Button.ForeColor = System.Drawing.Color.Black;
            this.table16Button.Location = new System.Drawing.Point(717, 407);
            this.table16Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table16Button.Name = "table16Button";
            this.table16Button.Size = new System.Drawing.Size(63, 71);
            this.table16Button.TabIndex = 15;
            this.table16Button.Text = "16";
            this.table16Button.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // table1Button
            // 
            this.table1Button.BorderThickness = 2;
            this.table1Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.table1Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.table1Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.table1Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.table1Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(158)))));
            this.table1Button.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.table1Button.ForeColor = System.Drawing.Color.Black;
            this.table1Button.Location = new System.Drawing.Point(51, 78);
            this.table1Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table1Button.Name = "table1Button";
            this.table1Button.Size = new System.Drawing.Size(107, 36);
            this.table1Button.TabIndex = 16;
            this.table1Button.Text = "1";
            this.table1Button.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // table3Button
            // 
            this.table3Button.BorderRadius = 30;
            this.table3Button.BorderThickness = 2;
            this.table3Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.table3Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.table3Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.table3Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.table3Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(158)))));
            this.table3Button.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.table3Button.ForeColor = System.Drawing.Color.Black;
            this.table3Button.Location = new System.Drawing.Point(461, 197);
            this.table3Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table3Button.Name = "table3Button";
            this.table3Button.Size = new System.Drawing.Size(97, 85);
            this.table3Button.TabIndex = 19;
            this.table3Button.Text = "3";
            this.table3Button.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // table4Button
            // 
            this.table4Button.BorderRadius = 30;
            this.table4Button.BorderThickness = 2;
            this.table4Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.table4Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.table4Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.table4Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.table4Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(158)))));
            this.table4Button.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.table4Button.ForeColor = System.Drawing.Color.Black;
            this.table4Button.Location = new System.Drawing.Point(737, 142);
            this.table4Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table4Button.Name = "table4Button";
            this.table4Button.Size = new System.Drawing.Size(97, 85);
            this.table4Button.TabIndex = 20;
            this.table4Button.Text = "4";
            this.table4Button.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // groupBoxReservation
            // 
            this.groupBoxReservation.BorderRadius = 10;
            this.groupBoxReservation.Controls.Add(this.textBoxReservationTime);
            this.groupBoxReservation.Controls.Add(this.label5);
            this.groupBoxReservation.Controls.Add(this.label4);
            this.groupBoxReservation.Controls.Add(this.label3);
            this.groupBoxReservation.Controls.Add(this.label2);
            this.groupBoxReservation.Controls.Add(this.label1);
            this.groupBoxReservation.Controls.Add(this.textBoxDeposit);
            this.groupBoxReservation.Controls.Add(this.textBoxGuestsCount);
            this.groupBoxReservation.Controls.Add(this.textBoxClientPhone);
            this.groupBoxReservation.Controls.Add(this.textBoxClientName);
            this.groupBoxReservation.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.groupBoxReservation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxReservation.ForeColor = System.Drawing.Color.Gray;
            this.groupBoxReservation.Location = new System.Drawing.Point(883, 64);
            this.groupBoxReservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxReservation.Name = "groupBoxReservation";
            this.groupBoxReservation.Size = new System.Drawing.Size(292, 382);
            this.groupBoxReservation.TabIndex = 21;
            this.groupBoxReservation.Text = "Бронирование";
            this.groupBoxReservation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.groupBoxReservation.Visible = false;
            // 
            // textBoxReservationTime
            // 
            this.textBoxReservationTime.BorderRadius = 10;
            this.textBoxReservationTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxReservationTime.DefaultText = "";
            this.textBoxReservationTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxReservationTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxReservationTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxReservationTime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxReservationTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxReservationTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxReservationTime.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxReservationTime.Location = new System.Drawing.Point(13, 265);
            this.textBoxReservationTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxReservationTime.Name = "textBoxReservationTime";
            this.textBoxReservationTime.PasswordChar = '\0';
            this.textBoxReservationTime.PlaceholderText = "";
            this.textBoxReservationTime.ReadOnly = true;
            this.textBoxReservationTime.SelectedText = "";
            this.textBoxReservationTime.Size = new System.Drawing.Size(261, 31);
            this.textBoxReservationTime.TabIndex = 11;
            this.textBoxReservationTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Депозит";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Время визита";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Количество гостей";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Телефон";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя";
            // 
            // textBoxDeposit
            // 
            this.textBoxDeposit.BorderRadius = 10;
            this.textBoxDeposit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDeposit.DefaultText = "";
            this.textBoxDeposit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxDeposit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxDeposit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDeposit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDeposit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDeposit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxDeposit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDeposit.Location = new System.Drawing.Point(13, 327);
            this.textBoxDeposit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDeposit.Name = "textBoxDeposit";
            this.textBoxDeposit.PasswordChar = '\0';
            this.textBoxDeposit.PlaceholderText = "";
            this.textBoxDeposit.ReadOnly = true;
            this.textBoxDeposit.SelectedText = "";
            this.textBoxDeposit.Size = new System.Drawing.Size(261, 31);
            this.textBoxDeposit.TabIndex = 4;
            this.textBoxDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxGuestsCount
            // 
            this.textBoxGuestsCount.BorderRadius = 10;
            this.textBoxGuestsCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxGuestsCount.DefaultText = "";
            this.textBoxGuestsCount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxGuestsCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxGuestsCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxGuestsCount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxGuestsCount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxGuestsCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxGuestsCount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxGuestsCount.Location = new System.Drawing.Point(13, 199);
            this.textBoxGuestsCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGuestsCount.Name = "textBoxGuestsCount";
            this.textBoxGuestsCount.PasswordChar = '\0';
            this.textBoxGuestsCount.PlaceholderText = "";
            this.textBoxGuestsCount.ReadOnly = true;
            this.textBoxGuestsCount.SelectedText = "";
            this.textBoxGuestsCount.Size = new System.Drawing.Size(261, 31);
            this.textBoxGuestsCount.TabIndex = 2;
            this.textBoxGuestsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxClientPhone
            // 
            this.textBoxClientPhone.BorderRadius = 10;
            this.textBoxClientPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxClientPhone.DefaultText = "";
            this.textBoxClientPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxClientPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxClientPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxClientPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxClientPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxClientPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxClientPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxClientPhone.Location = new System.Drawing.Point(13, 135);
            this.textBoxClientPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxClientPhone.Name = "textBoxClientPhone";
            this.textBoxClientPhone.PasswordChar = '\0';
            this.textBoxClientPhone.PlaceholderText = "";
            this.textBoxClientPhone.ReadOnly = true;
            this.textBoxClientPhone.SelectedText = "";
            this.textBoxClientPhone.Size = new System.Drawing.Size(261, 32);
            this.textBoxClientPhone.TabIndex = 1;
            this.textBoxClientPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.BorderRadius = 10;
            this.textBoxClientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxClientName.DefaultText = "";
            this.textBoxClientName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxClientName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxClientName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxClientName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxClientName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxClientName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxClientName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxClientName.Location = new System.Drawing.Point(13, 73);
            this.textBoxClientName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.PasswordChar = '\0';
            this.textBoxClientName.PlaceholderText = "";
            this.textBoxClientName.ReadOnly = true;
            this.textBoxClientName.SelectedText = "";
            this.textBoxClientName.Size = new System.Drawing.Size(261, 32);
            this.textBoxClientName.TabIndex = 0;
            this.textBoxClientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonBack
            // 
            this.buttonBack.BorderRadius = 10;
            this.buttonBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonBack.ForeColor = System.Drawing.Color.Black;
            this.buttonBack.Location = new System.Drawing.Point(1059, 12);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(117, 36);
            this.buttonBack.TabIndex = 22;
            this.buttonBack.Text = "Назад";
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.guna2PictureBox1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(883, 64);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(292, 382);
            this.guna2GroupBox1.TabIndex = 22;
            this.guna2GroupBox1.Text = "Бронирование";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label7.Location = new System.Drawing.Point(61, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 91);
            this.label7.TabIndex = 12;
            this.label7.Text = "Необходимо выбрать стол для дополнительной информации";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(61, 78);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(176, 263);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 23;
            this.guna2PictureBox1.TabStop = false;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHint});
            this.statusStrip.Location = new System.Drawing.Point(0, 493);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1187, 26);
            this.statusStrip.TabIndex = 23;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelHint
            // 
            this.toolStripStatusLabelHint.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripStatusLabelHint.ForeColor = System.Drawing.Color.Gray;
            this.toolStripStatusLabelHint.Name = "toolStripStatusLabelHint";
            this.toolStripStatusLabelHint.Size = new System.Drawing.Size(1167, 20);
            this.toolStripStatusLabelHint.Spring = true;
            this.toolStripStatusLabelHint.Text = "F1 — справка   |   Enter — просмотреть занятые столы   |   Esc — назад";
            this.toolStripStatusLabelHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BarHallView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1187, 519);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.table4Button);
            this.Controls.Add(this.groupBoxReservation);
            this.Controls.Add(this.table3Button);
            this.Controls.Add(this.table1Button);
            this.Controls.Add(this.table16Button);
            this.Controls.Add(this.table6Button);
            this.Controls.Add(this.table5Button);
            this.Controls.Add(this.table15Button);
            this.Controls.Add(this.table14Button);
            this.Controls.Add(this.table13Button);
            this.Controls.Add(this.table12Button);
            this.Controls.Add(this.table11Button);
            this.Controls.Add(this.table2Button);
            this.Controls.Add(this.table10Button);
            this.Controls.Add(this.table9Button);
            this.Controls.Add(this.table8Button);
            this.Controls.Add(this.table7Button);
            this.Controls.Add(this.image);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.guna2GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1205, 566);
            this.MinimumSize = new System.Drawing.Size(1205, 566);
            this.Name = "BarHallView";
            this.Text = "Просмотр зала";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.BarHallView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.groupBoxReservation.ResumeLayout(false);
            this.groupBoxReservation.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker datePicker;
        private Guna.UI2.WinForms.Guna2Button buttonView;
        private Guna.UI2.WinForms.Guna2PictureBox image;
        private Guna.UI2.WinForms.Guna2Button table7Button;
        private Guna.UI2.WinForms.Guna2Button table8Button;
        private Guna.UI2.WinForms.Guna2Button table9Button;
        private Guna.UI2.WinForms.Guna2Button table10Button;
        private Guna.UI2.WinForms.Guna2Button table2Button;
        private Guna.UI2.WinForms.Guna2Button table11Button;
        private Guna.UI2.WinForms.Guna2Button table12Button;
        private Guna.UI2.WinForms.Guna2Button table13Button;
        private Guna.UI2.WinForms.Guna2Button table14Button;
        private Guna.UI2.WinForms.Guna2Button table15Button;
        private Guna.UI2.WinForms.Guna2Button table5Button;
        private Guna.UI2.WinForms.Guna2Button table6Button;
        private Guna.UI2.WinForms.Guna2Button table16Button;
        private Guna.UI2.WinForms.Guna2Button table1Button;
        private Guna.UI2.WinForms.Guna2Button table3Button;
        private Guna.UI2.WinForms.Guna2Button table4Button;
        private Guna.UI2.WinForms.Guna2GroupBox groupBoxReservation;
        private Guna.UI2.WinForms.Guna2TextBox textBoxClientName;
        private Guna.UI2.WinForms.Guna2TextBox textBoxGuestsCount;
        private Guna.UI2.WinForms.Guna2TextBox textBoxClientPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxDeposit;
        private Guna.UI2.WinForms.Guna2TextBox textBoxReservationTime;
        private Guna.UI2.WinForms.Guna2Button buttonBack;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHint;
    }
}