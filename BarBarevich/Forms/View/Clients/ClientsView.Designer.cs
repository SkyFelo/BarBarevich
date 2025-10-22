namespace BarBarevich.Forms.View
{
    partial class ClientsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsView));
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.buttonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.buttonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.buttonBack = new Guna.UI2.WinForms.Guna2Button();
            this.groupBoxReservation = new Guna.UI2.WinForms.Guna2GroupBox();
            this.buttonRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSearch = new Guna.UI2.WinForms.Guna2Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBoxChoice = new Guna.UI2.WinForms.Guna2ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHint = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxReservation.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_client,
            this.full_name,
            this.phone});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 59);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(788, 432);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 25;
            this.dataGridView1.ThemeStyle.ReadOnly = true;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 28;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // id_client
            // 
            this.id_client.DataPropertyName = "id_client";
            this.id_client.HeaderText = "ID";
            this.id_client.MinimumWidth = 6;
            this.id_client.Name = "id_client";
            this.id_client.ReadOnly = true;
            this.id_client.Visible = false;
            // 
            // full_name
            // 
            this.full_name.DataPropertyName = "full_name";
            this.full_name.HeaderText = "Имя";
            this.full_name.MinimumWidth = 6;
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Телефон";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BorderRadius = 10;
            this.buttonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAdd.FillColor = System.Drawing.Color.YellowGreen;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAdd.Location = new System.Drawing.Point(12, 12);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(117, 36);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BorderRadius = 10;
            this.buttonEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonEdit.FillColor = System.Drawing.Color.Khaki;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEdit.Location = new System.Drawing.Point(147, 12);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(117, 36);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BorderRadius = 10;
            this.buttonDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDelete.FillColor = System.Drawing.Color.DarkSalmon;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDelete.Location = new System.Drawing.Point(283, 12);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(117, 36);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
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
            this.buttonBack.Location = new System.Drawing.Point(980, 12);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(117, 36);
            this.buttonBack.TabIndex = 23;
            this.buttonBack.Text = "Назад";
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // groupBoxReservation
            // 
            this.groupBoxReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxReservation.BorderRadius = 10;
            this.groupBoxReservation.Controls.Add(this.buttonRefresh);
            this.groupBoxReservation.Controls.Add(this.label2);
            this.groupBoxReservation.Controls.Add(this.buttonSearch);
            this.groupBoxReservation.Controls.Add(this.labelSearch);
            this.groupBoxReservation.Controls.Add(this.textBoxSearch);
            this.groupBoxReservation.Controls.Add(this.comboBoxChoice);
            this.groupBoxReservation.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.groupBoxReservation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxReservation.ForeColor = System.Drawing.Color.Gray;
            this.groupBoxReservation.Location = new System.Drawing.Point(805, 59);
            this.groupBoxReservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxReservation.Name = "groupBoxReservation";
            this.groupBoxReservation.Size = new System.Drawing.Size(292, 358);
            this.groupBoxReservation.TabIndex = 24;
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
            this.buttonRefresh.Location = new System.Drawing.Point(45, 288);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(197, 46);
            this.buttonRefresh.TabIndex = 11;
            this.buttonRefresh.Text = "Сброс";
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Поиск клиентов по";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BorderRadius = 10;
            this.buttonSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(45, 238);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(197, 46);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.Location = new System.Drawing.Point(11, 151);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(220, 20);
            this.labelSearch.TabIndex = 8;
            this.labelSearch.Text = "*Необходимо выбрать фильтр для отбора";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderRadius = 10;
            this.textBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSearch.DefaultText = "";
            this.textBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSearch.Enabled = false;
            this.textBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSearch.Location = new System.Drawing.Point(13, 175);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.PlaceholderText = "";
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.Size = new System.Drawing.Size(261, 32);
            this.textBoxSearch.TabIndex = 7;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // comboBoxChoice
            // 
            this.comboBoxChoice.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxChoice.BorderRadius = 10;
            this.comboBoxChoice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChoice.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxChoice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxChoice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxChoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxChoice.ItemHeight = 30;
            this.comboBoxChoice.Items.AddRange(new object[] {
            "По именени/фамилии",
            "По номеру телефона"});
            this.comboBoxChoice.Location = new System.Drawing.Point(15, 81);
            this.comboBoxChoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxChoice.Name = "comboBoxChoice";
            this.comboBoxChoice.Size = new System.Drawing.Size(260, 36);
            this.comboBoxChoice.TabIndex = 0;
            this.comboBoxChoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoice_SelectedIndexChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHint});
            this.statusStrip.Location = new System.Drawing.Point(0, 511);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1112, 26);
            this.statusStrip.TabIndex = 25;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelHint
            // 
            this.toolStripStatusLabelHint.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripStatusLabelHint.ForeColor = System.Drawing.Color.Gray;
            this.toolStripStatusLabelHint.Name = "toolStripStatusLabelHint";
            this.toolStripStatusLabelHint.Size = new System.Drawing.Size(1092, 20);
            this.toolStripStatusLabelHint.Spring = true;
            this.toolStripStatusLabelHint.Text = "F1 — справка   |   Esc — назад";
            this.toolStripStatusLabelHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ClientsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1112, 537);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBoxReservation);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1127, 574);
            this.Name = "ClientsView";
            this.Text = "Список клиентов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.ClientsView_Load);
            this.VisibleChanged += new System.EventHandler(this.ClientsView_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxReservation.ResumeLayout(false);
            this.groupBoxReservation.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button buttonAdd;
        private Guna.UI2.WinForms.Guna2Button buttonEdit;
        private Guna.UI2.WinForms.Guna2Button buttonDelete;
        private Guna.UI2.WinForms.Guna2Button buttonBack;
        private Guna.UI2.WinForms.Guna2GroupBox groupBoxReservation;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxChoice;
        private Guna.UI2.WinForms.Guna2Button buttonSearch;
        private System.Windows.Forms.Label labelSearch;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSearch;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button buttonRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHint;
    }
}