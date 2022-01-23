namespace cac_status_checker
{
    partial class editSecretaryForm
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
            this.officeGbox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.secRemark = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.secDateRes = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.secAddress = new System.Windows.Forms.TextBox();
            this.secName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.paymentGroupBox = new System.Windows.Forms.GroupBox();
            this.newRRRNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.newAmountPaid = new System.Windows.Forms.TextBox();
            this.newPresenterName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.newAccrNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.updateSecretary = new System.Windows.Forms.Button();
            this.rcSearchBox = new System.Windows.Forms.TextBox();
            this.searchRC = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.companyGroupBox = new System.Windows.Forms.GroupBox();
            this.rrrNumber = new System.Windows.Forms.TextBox();
            this.amountPaid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.presenterName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.accrNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.compName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rcNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.closeNewForm = new System.Windows.Forms.Button();
            this.compName_ = new System.Windows.Forms.Label();
            this.officeGbox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.paymentGroupBox.SuspendLayout();
            this.companyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // officeGbox
            // 
            this.officeGbox.BackColor = System.Drawing.SystemColors.Control;
            this.officeGbox.Controls.Add(this.groupBox2);
            this.officeGbox.Controls.Add(this.paymentGroupBox);
            this.officeGbox.Controls.Add(this.updateSecretary);
            this.officeGbox.Enabled = false;
            this.officeGbox.Location = new System.Drawing.Point(110, 294);
            this.officeGbox.Name = "officeGbox";
            this.officeGbox.Size = new System.Drawing.Size(1150, 291);
            this.officeGbox.TabIndex = 41;
            this.officeGbox.TabStop = false;
            this.officeGbox.Text = "Secretary Update Form";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.secRemark);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.secDateRes);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.secAddress);
            this.groupBox2.Controls.Add(this.secName);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(539, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 141);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Secretary Information";
            // 
            // secRemark
            // 
            this.secRemark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.secRemark.FormattingEnabled = true;
            this.secRemark.Items.AddRange(new object[] {
            "Appointed",
            "Reappointed",
            "Removed"});
            this.secRemark.Location = new System.Drawing.Point(295, 81);
            this.secRemark.Name = "secRemark";
            this.secRemark.Size = new System.Drawing.Size(252, 21);
            this.secRemark.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(295, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "*Remark:";
            // 
            // secDateRes
            // 
            this.secDateRes.Location = new System.Drawing.Point(295, 40);
            this.secDateRes.MaxDate = new System.DateTime(2099, 12, 9, 0, 0, 0, 0);
            this.secDateRes.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.secDateRes.Name = "secDateRes";
            this.secDateRes.Size = new System.Drawing.Size(252, 20);
            this.secDateRes.TabIndex = 8;
            this.secDateRes.Value = new System.DateTime(2019, 12, 9, 0, 0, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(295, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "*Resolution Date:";
            // 
            // secAddress
            // 
            this.secAddress.Location = new System.Drawing.Point(6, 81);
            this.secAddress.Multiline = true;
            this.secAddress.Name = "secAddress";
            this.secAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.secAddress.Size = new System.Drawing.Size(267, 49);
            this.secAddress.TabIndex = 7;
            // 
            // secName
            // 
            this.secName.Location = new System.Drawing.Point(6, 41);
            this.secName.Name = "secName";
            this.secName.Size = new System.Drawing.Size(267, 20);
            this.secName.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "*Secretary\'s Address:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "*Secretary\'s Name:";
            // 
            // paymentGroupBox
            // 
            this.paymentGroupBox.BackColor = System.Drawing.Color.White;
            this.paymentGroupBox.Controls.Add(this.newRRRNumber);
            this.paymentGroupBox.Controls.Add(this.label8);
            this.paymentGroupBox.Controls.Add(this.newAmountPaid);
            this.paymentGroupBox.Controls.Add(this.newPresenterName);
            this.paymentGroupBox.Controls.Add(this.label7);
            this.paymentGroupBox.Controls.Add(this.label9);
            this.paymentGroupBox.Controls.Add(this.newAccrNumber);
            this.paymentGroupBox.Controls.Add(this.label10);
            this.paymentGroupBox.Location = new System.Drawing.Point(15, 31);
            this.paymentGroupBox.Name = "paymentGroupBox";
            this.paymentGroupBox.Size = new System.Drawing.Size(518, 204);
            this.paymentGroupBox.TabIndex = 33;
            this.paymentGroupBox.TabStop = false;
            this.paymentGroupBox.Text = "Payment and Presenter\'s Details";
            // 
            // newRRRNumber
            // 
            this.newRRRNumber.Location = new System.Drawing.Point(6, 41);
            this.newRRRNumber.MaxLength = 200;
            this.newRRRNumber.Name = "newRRRNumber";
            this.newRRRNumber.Size = new System.Drawing.Size(455, 20);
            this.newRRRNumber.TabIndex = 0;
            this.newRRRNumber.TextChanged += new System.EventHandler(this.newRRRNumber_TextChanged);
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
            // newAmountPaid
            // 
            this.newAmountPaid.Location = new System.Drawing.Point(6, 82);
            this.newAmountPaid.Name = "newAmountPaid";
            this.newAmountPaid.Size = new System.Drawing.Size(455, 20);
            this.newAmountPaid.TabIndex = 1;
            // 
            // newPresenterName
            // 
            this.newPresenterName.Enabled = false;
            this.newPresenterName.Location = new System.Drawing.Point(6, 164);
            this.newPresenterName.Name = "newPresenterName";
            this.newPresenterName.Size = new System.Drawing.Size(455, 20);
            this.newPresenterName.TabIndex = 5;
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
            // newAccrNumber
            // 
            this.newAccrNumber.Location = new System.Drawing.Point(6, 123);
            this.newAccrNumber.Name = "newAccrNumber";
            this.newAccrNumber.Size = new System.Drawing.Size(455, 20);
            this.newAccrNumber.TabIndex = 4;
            this.newAccrNumber.Leave += new System.EventHandler(this.newAccrNumber_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Name of Presenter:";
            // 
            // updateSecretary
            // 
            this.updateSecretary.Image = global::cac_status_checker.Properties.Resources.save_modification;
            this.updateSecretary.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateSecretary.Location = new System.Drawing.Point(945, 195);
            this.updateSecretary.Name = "updateSecretary";
            this.updateSecretary.Size = new System.Drawing.Size(154, 42);
            this.updateSecretary.TabIndex = 30;
            this.updateSecretary.Text = "Update Office Address";
            this.updateSecretary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateSecretary.UseVisualStyleBackColor = true;
            this.updateSecretary.Click += new System.EventHandler(this.updateSecretary_Click);
            // 
            // rcSearchBox
            // 
            this.rcSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcSearchBox.Location = new System.Drawing.Point(500, 16);
            this.rcSearchBox.Multiline = true;
            this.rcSearchBox.Name = "rcSearchBox";
            this.rcSearchBox.Size = new System.Drawing.Size(212, 35);
            this.rcSearchBox.TabIndex = 40;
            // 
            // searchRC
            // 
            this.searchRC.Image = global::cac_status_checker.Properties.Resources.search_record;
            this.searchRC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchRC.Location = new System.Drawing.Point(713, 15);
            this.searchRC.Name = "searchRC";
            this.searchRC.Size = new System.Drawing.Size(138, 37);
            this.searchRC.TabIndex = 39;
            this.searchRC.Text = "Search RC Number";
            this.searchRC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchRC.UseVisualStyleBackColor = true;
            this.searchRC.Click += new System.EventHandler(this.searchRC_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label19.Location = new System.Drawing.Point(7, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(210, 23);
            this.label19.TabIndex = 38;
            this.label19.Text = "EDIT SECRETARY FORM";
            // 
            // companyGroupBox
            // 
            this.companyGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.companyGroupBox.Controls.Add(this.rrrNumber);
            this.companyGroupBox.Controls.Add(this.amountPaid);
            this.companyGroupBox.Controls.Add(this.label6);
            this.companyGroupBox.Controls.Add(this.presenterName);
            this.companyGroupBox.Controls.Add(this.label5);
            this.companyGroupBox.Controls.Add(this.accrNumber);
            this.companyGroupBox.Controls.Add(this.label4);
            this.companyGroupBox.Controls.Add(this.label3);
            this.companyGroupBox.Controls.Add(this.compName);
            this.companyGroupBox.Controls.Add(this.label2);
            this.companyGroupBox.Controls.Add(this.rcNumber);
            this.companyGroupBox.Controls.Add(this.label1);
            this.companyGroupBox.Enabled = false;
            this.companyGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.companyGroupBox.Location = new System.Drawing.Point(109, 111);
            this.companyGroupBox.Name = "companyGroupBox";
            this.companyGroupBox.Size = new System.Drawing.Size(1150, 165);
            this.companyGroupBox.TabIndex = 37;
            this.companyGroupBox.TabStop = false;
            this.companyGroupBox.Text = "Company information";
            // 
            // rrrNumber
            // 
            this.rrrNumber.Location = new System.Drawing.Point(15, 41);
            this.rrrNumber.MaxLength = 12;
            this.rrrNumber.Name = "rrrNumber";
            this.rrrNumber.ReadOnly = true;
            this.rrrNumber.Size = new System.Drawing.Size(455, 20);
            this.rrrNumber.TabIndex = 0;
            // 
            // amountPaid
            // 
            this.amountPaid.Location = new System.Drawing.Point(15, 82);
            this.amountPaid.Name = "amountPaid";
            this.amountPaid.ReadOnly = true;
            this.amountPaid.Size = new System.Drawing.Size(455, 20);
            this.amountPaid.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "*Receipt Number (RRR):";
            // 
            // presenterName
            // 
            this.presenterName.Enabled = false;
            this.presenterName.Location = new System.Drawing.Point(584, 123);
            this.presenterName.Name = "presenterName";
            this.presenterName.ReadOnly = true;
            this.presenterName.Size = new System.Drawing.Size(455, 20);
            this.presenterName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "*Amount Paid";
            // 
            // accrNumber
            // 
            this.accrNumber.Location = new System.Drawing.Point(584, 82);
            this.accrNumber.Name = "accrNumber";
            this.accrNumber.ReadOnly = true;
            this.accrNumber.Size = new System.Drawing.Size(455, 20);
            this.accrNumber.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name of Presenter:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "*Accreditation Number:";
            // 
            // compName
            // 
            this.compName.Enabled = false;
            this.compName.Location = new System.Drawing.Point(584, 41);
            this.compName.Name = "compName";
            this.compName.ReadOnly = true;
            this.compName.Size = new System.Drawing.Size(455, 20);
            this.compName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "*Company Name:";
            // 
            // rcNumber
            // 
            this.rcNumber.Location = new System.Drawing.Point(15, 123);
            this.rcNumber.MaxLength = 10;
            this.rcNumber.Name = "rcNumber";
            this.rcNumber.ReadOnly = true;
            this.rcNumber.Size = new System.Drawing.Size(455, 20);
            this.rcNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "*RC Number:";
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
            this.closeNewForm.TabIndex = 42;
            this.closeNewForm.Text = "X";
            this.closeNewForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeNewForm.UseCompatibleTextRendering = true;
            this.closeNewForm.UseVisualStyleBackColor = false;
            this.closeNewForm.Visible = false;
            this.closeNewForm.Click += new System.EventHandler(this.closeNewForm_Click);
            this.closeNewForm.MouseLeave += new System.EventHandler(this.closeNewForm_MouseLeave);
            this.closeNewForm.MouseHover += new System.EventHandler(this.closeNewForm_MouseHover);
            // 
            // compName_
            // 
            this.compName_.AutoSize = true;
            this.compName_.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compName_.ForeColor = System.Drawing.Color.White;
            this.compName_.Location = new System.Drawing.Point(497, 67);
            this.compName_.Name = "compName_";
            this.compName_.Size = new System.Drawing.Size(45, 16);
            this.compName_.TabIndex = 43;
            this.compName_.Text = "label3";
            // 
            // editSecretaryForm
            // 
            this.AcceptButton = this.searchRC;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 642);
            this.Controls.Add(this.compName_);
            this.Controls.Add(this.closeNewForm);
            this.Controls.Add(this.officeGbox);
            this.Controls.Add(this.rcSearchBox);
            this.Controls.Add(this.searchRC);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.companyGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "editSecretaryForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Secretary Form";
            this.Load += new System.EventHandler(this.editSecretaryForm_Load);
            this.officeGbox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.paymentGroupBox.ResumeLayout(false);
            this.paymentGroupBox.PerformLayout();
            this.companyGroupBox.ResumeLayout(false);
            this.companyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox officeGbox;
        private System.Windows.Forms.GroupBox paymentGroupBox;
        private System.Windows.Forms.TextBox newRRRNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox newAmountPaid;
        private System.Windows.Forms.TextBox newPresenterName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox newAccrNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button updateSecretary;
        private System.Windows.Forms.TextBox rcSearchBox;
        private System.Windows.Forms.Button searchRC;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox companyGroupBox;
        private System.Windows.Forms.TextBox rrrNumber;
        private System.Windows.Forms.TextBox amountPaid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox presenterName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox accrNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox compName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rcNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox secRemark;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker secDateRes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox secAddress;
        private System.Windows.Forms.TextBox secName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button closeNewForm;
        private System.Windows.Forms.Label compName_;
    }
}