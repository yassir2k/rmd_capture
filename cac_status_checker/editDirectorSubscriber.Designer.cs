namespace cac_status_checker
{
    partial class editDirectorSubscriber
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
            this.dirSubGroupBox = new System.Windows.Forms.GroupBox();
            this.dirsubGridView = new System.Windows.Forms.DataGridView();
            this.colSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDirSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShareType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colshareAllot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subGroupBox = new System.Windows.Forms.GroupBox();
            this.updateDirSub = new System.Windows.Forms.Button();
            this.resetDirSub = new System.Windows.Forms.Button();
            this.subPhone = new System.Windows.Forms.TextBox();
            this.subResDate = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.subRemark = new System.Windows.Forms.ComboBox();
            this.subShareType = new System.Windows.Forms.ComboBox();
            this.subscriberType = new System.Windows.Forms.ComboBox();
            this.subscriberAddr = new System.Windows.Forms.TextBox();
            this.subAddress = new System.Windows.Forms.Label();
            this.subShareAllot = new System.Windows.Forms.TextBox();
            this.subscriberName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.updateAllDirSub = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rcSearchBox = new System.Windows.Forms.TextBox();
            this.searchRC = new System.Windows.Forms.Button();
            this.closeNewForm = new System.Windows.Forms.Button();
            this.paymentGroupBox = new System.Windows.Forms.GroupBox();
            this.rrrNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.amountPaid = new System.Windows.Forms.TextBox();
            this.presenterName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.accrNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.compName = new System.Windows.Forms.Label();
            this.dirSubGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dirsubGridView)).BeginInit();
            this.subGroupBox.SuspendLayout();
            this.paymentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dirSubGroupBox
            // 
            this.dirSubGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.dirSubGroupBox.Controls.Add(this.dirsubGridView);
            this.dirSubGroupBox.Enabled = false;
            this.dirSubGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirSubGroupBox.Location = new System.Drawing.Point(88, 87);
            this.dirSubGroupBox.Name = "dirSubGroupBox";
            this.dirSubGroupBox.Size = new System.Drawing.Size(1202, 194);
            this.dirSubGroupBox.TabIndex = 6;
            this.dirSubGroupBox.TabStop = false;
            this.dirSubGroupBox.Text = "Directors/Subscribers Captured";
            // 
            // dirsubGridView
            // 
            this.dirsubGridView.AllowUserToAddRows = false;
            this.dirsubGridView.AllowUserToDeleteRows = false;
            this.dirsubGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dirsubGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dirsubGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dirsubGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dirsubGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSN,
            this.colDirSub,
            this.colSubAddress,
            this.colSubType,
            this.colShareType,
            this.colPhone,
            this.colshareAllot,
            this.colRemark,
            this.colResDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dirsubGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dirsubGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dirsubGridView.Location = new System.Drawing.Point(3, 16);
            this.dirsubGridView.Name = "dirsubGridView";
            this.dirsubGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dirsubGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dirsubGridView.RowHeadersWidth = 30;
            this.dirsubGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dirsubGridView.Size = new System.Drawing.Size(1196, 175);
            this.dirsubGridView.TabIndex = 1;
            this.dirsubGridView.SelectionChanged += new System.EventHandler(this.dirsubGridView_SelectionChanged);
            // 
            // colSN
            // 
            this.colSN.FillWeight = 1F;
            this.colSN.Frozen = true;
            this.colSN.HeaderText = "SN";
            this.colSN.Name = "colSN";
            this.colSN.ReadOnly = true;
            this.colSN.Visible = false;
            this.colSN.Width = 5;
            // 
            // colDirSub
            // 
            this.colDirSub.HeaderText = "Name of Director Subscriber";
            this.colDirSub.MaxInputLength = 250;
            this.colDirSub.Name = "colDirSub";
            this.colDirSub.ReadOnly = true;
            this.colDirSub.Width = 200;
            // 
            // colSubAddress
            // 
            this.colSubAddress.HeaderText = "Subscriber Address";
            this.colSubAddress.MaxInputLength = 500;
            this.colSubAddress.Name = "colSubAddress";
            this.colSubAddress.ReadOnly = true;
            this.colSubAddress.Width = 290;
            // 
            // colSubType
            // 
            this.colSubType.HeaderText = "Subscriber Type";
            this.colSubType.Name = "colSubType";
            this.colSubType.ReadOnly = true;
            this.colSubType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSubType.Width = 130;
            // 
            // colShareType
            // 
            this.colShareType.HeaderText = "Type of Share";
            this.colShareType.Name = "colShareType";
            this.colShareType.ReadOnly = true;
            this.colShareType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colShareType.Width = 120;
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "Phone Number";
            this.colPhone.MaxInputLength = 13;
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            this.colPhone.Visible = false;
            // 
            // colshareAllot
            // 
            this.colshareAllot.HeaderText = "Share Allotment";
            this.colshareAllot.MaxInputLength = 20;
            this.colshareAllot.Name = "colshareAllot";
            this.colshareAllot.ReadOnly = true;
            this.colshareAllot.Width = 120;
            // 
            // colRemark
            // 
            this.colRemark.HeaderText = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.ReadOnly = true;
            this.colRemark.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colResDate
            // 
            this.colResDate.HeaderText = "Resolution Date";
            this.colResDate.MaxInputLength = 32000;
            this.colResDate.Name = "colResDate";
            this.colResDate.ReadOnly = true;
            this.colResDate.Width = 190;
            // 
            // subGroupBox
            // 
            this.subGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.subGroupBox.Controls.Add(this.updateDirSub);
            this.subGroupBox.Controls.Add(this.resetDirSub);
            this.subGroupBox.Controls.Add(this.subPhone);
            this.subGroupBox.Controls.Add(this.subResDate);
            this.subGroupBox.Controls.Add(this.label20);
            this.subGroupBox.Controls.Add(this.subRemark);
            this.subGroupBox.Controls.Add(this.subShareType);
            this.subGroupBox.Controls.Add(this.subscriberType);
            this.subGroupBox.Controls.Add(this.subscriberAddr);
            this.subGroupBox.Controls.Add(this.subAddress);
            this.subGroupBox.Controls.Add(this.subShareAllot);
            this.subGroupBox.Controls.Add(this.subscriberName);
            this.subGroupBox.Controls.Add(this.label16);
            this.subGroupBox.Controls.Add(this.label15);
            this.subGroupBox.Controls.Add(this.label13);
            this.subGroupBox.Controls.Add(this.label14);
            this.subGroupBox.Controls.Add(this.label12);
            this.subGroupBox.Controls.Add(this.label10);
            this.subGroupBox.Enabled = false;
            this.subGroupBox.Location = new System.Drawing.Point(88, 284);
            this.subGroupBox.Name = "subGroupBox";
            this.subGroupBox.Size = new System.Drawing.Size(757, 256);
            this.subGroupBox.TabIndex = 5;
            this.subGroupBox.TabStop = false;
            this.subGroupBox.Text = "Director/Subscriber Information:";
            // 
            // updateDirSub
            // 
            this.updateDirSub.Location = new System.Drawing.Point(163, 227);
            this.updateDirSub.Name = "updateDirSub";
            this.updateDirSub.Size = new System.Drawing.Size(156, 23);
            this.updateDirSub.TabIndex = 21;
            this.updateDirSub.Text = "Modify Director/Subscriber";
            this.updateDirSub.UseVisualStyleBackColor = true;
            this.updateDirSub.Click += new System.EventHandler(this.updateDirSub_Click);
            // 
            // resetDirSub
            // 
            this.resetDirSub.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resetDirSub.Location = new System.Drawing.Point(411, 226);
            this.resetDirSub.Name = "resetDirSub";
            this.resetDirSub.Size = new System.Drawing.Size(156, 23);
            this.resetDirSub.TabIndex = 21;
            this.resetDirSub.Text = "Reset Entries";
            this.resetDirSub.UseVisualStyleBackColor = true;
            // 
            // subPhone
            // 
            this.subPhone.Location = new System.Drawing.Point(66, 201);
            this.subPhone.MaxLength = 13;
            this.subPhone.Name = "subPhone";
            this.subPhone.Size = new System.Drawing.Size(253, 20);
            this.subPhone.TabIndex = 14;
            // 
            // subResDate
            // 
            this.subResDate.Location = new System.Drawing.Point(411, 200);
            this.subResDate.MaxDate = new System.DateTime(2099, 12, 9, 0, 0, 0, 0);
            this.subResDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.subResDate.Name = "subResDate";
            this.subResDate.Size = new System.Drawing.Size(252, 20);
            this.subResDate.TabIndex = 19;
            this.subResDate.Value = new System.DateTime(2019, 12, 9, 0, 0, 0, 0);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(68, 184);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(176, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Director/Subscriber Phone Number:";
            // 
            // subRemark
            // 
            this.subRemark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subRemark.FormattingEnabled = true;
            this.subRemark.Items.AddRange(new object[] {
            "Appointed",
            "Reappointed",
            "Removed",
            "-"});
            this.subRemark.Location = new System.Drawing.Point(411, 160);
            this.subRemark.Name = "subRemark";
            this.subRemark.Size = new System.Drawing.Size(252, 21);
            this.subRemark.TabIndex = 18;
            // 
            // subShareType
            // 
            this.subShareType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subShareType.Enabled = false;
            this.subShareType.FormattingEnabled = true;
            this.subShareType.Items.AddRange(new object[] {
            "Ordinary"});
            this.subShareType.Location = new System.Drawing.Point(411, 81);
            this.subShareType.Name = "subShareType";
            this.subShareType.Size = new System.Drawing.Size(252, 21);
            this.subShareType.TabIndex = 16;
            // 
            // subscriberType
            // 
            this.subscriberType.BackColor = System.Drawing.Color.White;
            this.subscriberType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subscriberType.FormattingEnabled = true;
            this.subscriberType.Items.AddRange(new object[] {
            "Director",
            "Director/Subscriber",
            "Subscriber"});
            this.subscriberType.Location = new System.Drawing.Point(411, 41);
            this.subscriberType.Name = "subscriberType";
            this.subscriberType.Size = new System.Drawing.Size(252, 21);
            this.subscriberType.TabIndex = 15;
            this.subscriberType.SelectedIndexChanged += new System.EventHandler(this.subscriberType_SelectedIndexChanged);
            // 
            // subscriberAddr
            // 
            this.subscriberAddr.Location = new System.Drawing.Point(65, 82);
            this.subscriberAddr.Multiline = true;
            this.subscriberAddr.Name = "subscriberAddr";
            this.subscriberAddr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.subscriberAddr.Size = new System.Drawing.Size(253, 99);
            this.subscriberAddr.TabIndex = 13;
            // 
            // subAddress
            // 
            this.subAddress.AutoSize = true;
            this.subAddress.Location = new System.Drawing.Point(68, 66);
            this.subAddress.Name = "subAddress";
            this.subAddress.Size = new System.Drawing.Size(159, 13);
            this.subAddress.TabIndex = 6;
            this.subAddress.Text = "*Address of Director/Subscriber:";
            // 
            // subShareAllot
            // 
            this.subShareAllot.Enabled = false;
            this.subShareAllot.Location = new System.Drawing.Point(411, 121);
            this.subShareAllot.Name = "subShareAllot";
            this.subShareAllot.Size = new System.Drawing.Size(253, 20);
            this.subShareAllot.TabIndex = 17;
            // 
            // subscriberName
            // 
            this.subscriberName.Location = new System.Drawing.Point(65, 42);
            this.subscriberName.Name = "subscriberName";
            this.subscriberName.Size = new System.Drawing.Size(253, 20);
            this.subscriberName.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(411, 184);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "*Resolution Date:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(411, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "*Remark:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(411, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "*Type of Share:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(411, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "*Share Allotment:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(68, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "*Name of Director/Subscriber:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(411, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "*Type of Subscriber:";
            // 
            // updateAllDirSub
            // 
            this.updateAllDirSub.Enabled = false;
            this.updateAllDirSub.Image = global::cac_status_checker.Properties.Resources.save_modification;
            this.updateAllDirSub.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateAllDirSub.Location = new System.Drawing.Point(1114, 487);
            this.updateAllDirSub.Name = "updateAllDirSub";
            this.updateAllDirSub.Size = new System.Drawing.Size(176, 49);
            this.updateAllDirSub.TabIndex = 20;
            this.updateAllDirSub.Text = "Update Director/Subscriber";
            this.updateAllDirSub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateAllDirSub.UseVisualStyleBackColor = true;
            this.updateAllDirSub.Click += new System.EventHandler(this.updateAllDirSub_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "EDIT DIRECTOR/SUBCRIBER";
            // 
            // rcSearchBox
            // 
            this.rcSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcSearchBox.Location = new System.Drawing.Point(500, 16);
            this.rcSearchBox.Name = "rcSearchBox";
            this.rcSearchBox.Size = new System.Drawing.Size(212, 35);
            this.rcSearchBox.TabIndex = 37;
            // 
            // searchRC
            // 
            this.searchRC.Image = global::cac_status_checker.Properties.Resources.search_record;
            this.searchRC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchRC.Location = new System.Drawing.Point(713, 15);
            this.searchRC.Name = "searchRC";
            this.searchRC.Size = new System.Drawing.Size(138, 37);
            this.searchRC.TabIndex = 36;
            this.searchRC.Text = "Search RC Number";
            this.searchRC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchRC.UseVisualStyleBackColor = true;
            this.searchRC.Click += new System.EventHandler(this.searchRC_Click);
            // 
            // closeNewForm
            // 
            this.closeNewForm.BackColor = System.Drawing.Color.Firebrick;
            this.closeNewForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeNewForm.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeNewForm.ForeColor = System.Drawing.Color.White;
            this.closeNewForm.Location = new System.Drawing.Point(1328, 15);
            this.closeNewForm.Name = "closeNewForm";
            this.closeNewForm.Size = new System.Drawing.Size(24, 24);
            this.closeNewForm.TabIndex = 38;
            this.closeNewForm.Text = "X";
            this.closeNewForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeNewForm.UseCompatibleTextRendering = true;
            this.closeNewForm.UseVisualStyleBackColor = false;
            this.closeNewForm.Visible = false;
            this.closeNewForm.Click += new System.EventHandler(this.closeNewForm_Click);
            this.closeNewForm.MouseLeave += new System.EventHandler(this.closeNewForm_MouseLeave);
            this.closeNewForm.MouseHover += new System.EventHandler(this.closeNewForm_MouseHover);
            // 
            // paymentGroupBox
            // 
            this.paymentGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.paymentGroupBox.Controls.Add(this.rrrNumber);
            this.paymentGroupBox.Controls.Add(this.label8);
            this.paymentGroupBox.Controls.Add(this.amountPaid);
            this.paymentGroupBox.Controls.Add(this.presenterName);
            this.paymentGroupBox.Controls.Add(this.label7);
            this.paymentGroupBox.Controls.Add(this.label9);
            this.paymentGroupBox.Controls.Add(this.accrNumber);
            this.paymentGroupBox.Controls.Add(this.label2);
            this.paymentGroupBox.Enabled = false;
            this.paymentGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paymentGroupBox.Location = new System.Drawing.Point(851, 284);
            this.paymentGroupBox.Name = "paymentGroupBox";
            this.paymentGroupBox.Size = new System.Drawing.Size(439, 197);
            this.paymentGroupBox.TabIndex = 39;
            this.paymentGroupBox.TabStop = false;
            this.paymentGroupBox.Text = "Payment and Presenter\'s Details";
            // 
            // rrrNumber
            // 
            this.rrrNumber.Location = new System.Drawing.Point(6, 41);
            this.rrrNumber.MaxLength = 200;
            this.rrrNumber.Name = "rrrNumber";
            this.rrrNumber.Size = new System.Drawing.Size(409, 20);
            this.rrrNumber.TabIndex = 0;
            this.rrrNumber.TextChanged += new System.EventHandler(this.rrrNumber_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "*Receipt Number (RRR):";
            // 
            // amountPaid
            // 
            this.amountPaid.Location = new System.Drawing.Point(6, 82);
            this.amountPaid.Name = "amountPaid";
            this.amountPaid.Size = new System.Drawing.Size(409, 20);
            this.amountPaid.TabIndex = 1;
            // 
            // presenterName
            // 
            this.presenterName.Enabled = false;
            this.presenterName.Location = new System.Drawing.Point(6, 164);
            this.presenterName.Name = "presenterName";
            this.presenterName.ReadOnly = true;
            this.presenterName.Size = new System.Drawing.Size(409, 20);
            this.presenterName.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "*Amount Paid";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Accreditation Number:";
            // 
            // accrNumber
            // 
            this.accrNumber.Location = new System.Drawing.Point(6, 123);
            this.accrNumber.Name = "accrNumber";
            this.accrNumber.Size = new System.Drawing.Size(409, 20);
            this.accrNumber.TabIndex = 4;
            this.accrNumber.Leave += new System.EventHandler(this.accrNumber_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name of Presenter:";
            // 
            // compName
            // 
            this.compName.AutoSize = true;
            this.compName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compName.ForeColor = System.Drawing.Color.White;
            this.compName.Location = new System.Drawing.Point(497, 56);
            this.compName.Name = "compName";
            this.compName.Size = new System.Drawing.Size(45, 16);
            this.compName.TabIndex = 40;
            this.compName.Text = "label3";
            // 
            // editDirectorSubscriber
            // 
            this.AcceptButton = this.searchRC;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1356, 605);
            this.Controls.Add(this.compName);
            this.Controls.Add(this.paymentGroupBox);
            this.Controls.Add(this.closeNewForm);
            this.Controls.Add(this.rcSearchBox);
            this.Controls.Add(this.updateAllDirSub);
            this.Controls.Add(this.searchRC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dirSubGroupBox);
            this.Controls.Add(this.subGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "editDirectorSubscriber";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Director/Subscriber Form";
            this.Load += new System.EventHandler(this.editDirectorSubscriber_Load);
            this.dirSubGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dirsubGridView)).EndInit();
            this.subGroupBox.ResumeLayout(false);
            this.subGroupBox.PerformLayout();
            this.paymentGroupBox.ResumeLayout(false);
            this.paymentGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox dirSubGroupBox;
        private System.Windows.Forms.GroupBox subGroupBox;
        private System.Windows.Forms.TextBox subPhone;
        private System.Windows.Forms.Button resetDirSub;
        private System.Windows.Forms.Button updateAllDirSub;
        private System.Windows.Forms.DateTimePicker subResDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox subRemark;
        private System.Windows.Forms.ComboBox subShareType;
        private System.Windows.Forms.ComboBox subscriberType;
        private System.Windows.Forms.TextBox subscriberAddr;
        private System.Windows.Forms.Label subAddress;
        private System.Windows.Forms.TextBox subShareAllot;
        private System.Windows.Forms.TextBox subscriberName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rcSearchBox;
        private System.Windows.Forms.Button searchRC;
        private System.Windows.Forms.Button closeNewForm;
        private System.Windows.Forms.DataGridView dirsubGridView;
        private System.Windows.Forms.Button updateDirSub;
        private System.Windows.Forms.GroupBox paymentGroupBox;
        private System.Windows.Forms.TextBox rrrNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox amountPaid;
        private System.Windows.Forms.TextBox presenterName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox accrNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label compName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDirSub;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShareType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colshareAllot;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResDate;
    }
}