namespace cac_status_checker
{
    partial class activityDateBased
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
            this.compGridView = new System.Windows.Forms.DataGridView();
            this.colSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDirSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShareType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colshareAllot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.closeNewForm = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dirSubGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dirSubGroupBox
            // 
            this.dirSubGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.dirSubGroupBox.Controls.Add(this.compGridView);
            this.dirSubGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirSubGroupBox.Location = new System.Drawing.Point(237, 181);
            this.dirSubGroupBox.Name = "dirSubGroupBox";
            this.dirSubGroupBox.Size = new System.Drawing.Size(948, 352);
            this.dirSubGroupBox.TabIndex = 51;
            this.dirSubGroupBox.TabStop = false;
            this.dirSubGroupBox.Text = "Companies Captured";
            // 
            // compGridView
            // 
            this.compGridView.AllowUserToAddRows = false;
            this.compGridView.AllowUserToDeleteRows = false;
            this.compGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.compGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.compGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.compGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.compGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSN,
            this.colDirSub,
            this.colSubAddress,
            this.colSubType,
            this.colShareType,
            this.colshareAllot,
            this.colRemark});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.compGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.compGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compGridView.Location = new System.Drawing.Point(3, 16);
            this.compGridView.Name = "compGridView";
            this.compGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.compGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.compGridView.RowHeadersWidth = 30;
            this.compGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.compGridView.Size = new System.Drawing.Size(942, 333);
            this.compGridView.TabIndex = 1;
            // 
            // colSN
            // 
            this.colSN.FillWeight = 1F;
            this.colSN.Frozen = true;
            this.colSN.HeaderText = "Company Name";
            this.colSN.Name = "colSN";
            this.colSN.ReadOnly = true;
            this.colSN.Width = 200;
            // 
            // colDirSub
            // 
            this.colDirSub.HeaderText = "RC Number";
            this.colDirSub.MaxInputLength = 250;
            this.colDirSub.Name = "colDirSub";
            this.colDirSub.ReadOnly = true;
            // 
            // colSubAddress
            // 
            this.colSubAddress.HeaderText = "Receipt No";
            this.colSubAddress.MaxInputLength = 500;
            this.colSubAddress.Name = "colSubAddress";
            this.colSubAddress.ReadOnly = true;
            this.colSubAddress.Width = 120;
            // 
            // colSubType
            // 
            this.colSubType.HeaderText = "Amount Paid";
            this.colSubType.Name = "colSubType";
            this.colSubType.ReadOnly = true;
            this.colSubType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSubType.Width = 130;
            // 
            // colShareType
            // 
            this.colShareType.HeaderText = "Agent ID";
            this.colShareType.Name = "colShareType";
            this.colShareType.ReadOnly = true;
            this.colShareType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colShareType.Width = 120;
            // 
            // colshareAllot
            // 
            this.colshareAllot.HeaderText = "Activity Date";
            this.colshareAllot.MaxInputLength = 20;
            this.colshareAllot.Name = "colshareAllot";
            this.colshareAllot.ReadOnly = true;
            this.colshareAllot.Width = 120;
            // 
            // colRemark
            // 
            this.colRemark.HeaderText = "User ID";
            this.colRemark.Name = "colRemark";
            this.colRemark.ReadOnly = true;
            this.colRemark.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRemark.Width = 120;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label19.Location = new System.Drawing.Point(7, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(653, 23);
            this.label19.TabIndex = 50;
            this.label19.Text = "STAFF ACTIVITIES BASED ON DATE RANGE (NEW COMPANIES CAPTURED)";
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
            this.closeNewForm.TabIndex = 49;
            this.closeNewForm.Text = "X";
            this.closeNewForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeNewForm.UseCompatibleTextRendering = true;
            this.closeNewForm.UseVisualStyleBackColor = false;
            this.closeNewForm.Visible = false;
            this.closeNewForm.Click += new System.EventHandler(this.closeNewForm_Click);
            this.closeNewForm.MouseLeave += new System.EventHandler(this.closeNewForm_MouseLeave);
            this.closeNewForm.MouseHover += new System.EventHandler(this.closeNewForm_MouseHover);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.ForeColor = System.Drawing.Color.Black;
            this.countLabel.Location = new System.Drawing.Point(236, 546);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(20, 12);
            this.countLabel.TabIndex = 54;
            this.countLabel.Text = "     ";
            this.countLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userComboBox
            // 
            this.userComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(562, 150);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(286, 21);
            this.userComboBox.TabIndex = 52;
            this.userComboBox.SelectedIndexChanged += new System.EventHandler(this.userComboBox_SelectedIndexChanged);
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(562, 68);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(286, 20);
            this.dateFrom.TabIndex = 55;
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(562, 109);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(286, 20);
            this.dateTo.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(467, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 12);
            this.label2.TabIndex = 56;
            this.label2.Text = "Activities From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(467, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 12);
            this.label3.TabIndex = 56;
            this.label3.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 12);
            this.label1.TabIndex = 56;
            this.label1.Text = "Select User:";
            // 
            // activityDateBased
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1356, 605);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.dirSubGroupBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.closeNewForm);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.userComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "activityDateBased";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Activities Capturing New Companies (Based on Date Interval)";
            this.Load += new System.EventHandler(this.activityDateBased_Load);
            this.dirSubGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.compGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox dirSubGroupBox;
        private System.Windows.Forms.DataGridView compGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDirSub;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShareType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colshareAllot;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button closeNewForm;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}