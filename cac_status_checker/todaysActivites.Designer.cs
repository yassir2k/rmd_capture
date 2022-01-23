namespace cac_status_checker
{
    partial class todaysActivites
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.closeNewForm = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.dirSubGroupBox = new System.Windows.Forms.GroupBox();
            this.compGridView = new System.Windows.Forms.DataGridView();
            this.colSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDirSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShareType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colshareAllot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.dirSubGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compGridView)).BeginInit();
            this.SuspendLayout();
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
            this.closeNewForm.TabIndex = 43;
            this.closeNewForm.Text = "X";
            this.closeNewForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeNewForm.UseCompatibleTextRendering = true;
            this.closeNewForm.UseVisualStyleBackColor = false;
            this.closeNewForm.Visible = false;
            this.closeNewForm.Click += new System.EventHandler(this.closeNewForm_Click);
            this.closeNewForm.MouseLeave += new System.EventHandler(this.closeNewForm_MouseLeave);
            this.closeNewForm.MouseHover += new System.EventHandler(this.closeNewForm_MouseHover);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label19.Location = new System.Drawing.Point(7, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(544, 23);
            this.label19.TabIndex = 44;
            this.label19.Text = "STAFF ACTIVITIES FOR TODAY (NEW COMPANIES CAPTURED)";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // dirSubGroupBox
            // 
            this.dirSubGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.dirSubGroupBox.Controls.Add(this.compGridView);
            this.dirSubGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirSubGroupBox.Location = new System.Drawing.Point(235, 120);
            this.dirSubGroupBox.Name = "dirSubGroupBox";
            this.dirSubGroupBox.Size = new System.Drawing.Size(948, 352);
            this.dirSubGroupBox.TabIndex = 45;
            this.dirSubGroupBox.TabStop = false;
            this.dirSubGroupBox.Text = "Companies Captured";
            this.dirSubGroupBox.Enter += new System.EventHandler(this.dirSubGroupBox_Enter);
            // 
            // compGridView
            // 
            this.compGridView.AllowUserToAddRows = false;
            this.compGridView.AllowUserToDeleteRows = false;
            this.compGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.compGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.compGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.compGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.compGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSN,
            this.colDirSub,
            this.colSubAddress,
            this.colSubType,
            this.colShareType,
            this.colshareAllot,
            this.colRemark});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.compGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.compGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compGridView.Location = new System.Drawing.Point(3, 16);
            this.compGridView.Name = "compGridView";
            this.compGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.compGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.compGridView.RowHeadersWidth = 30;
            this.compGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.compGridView.Size = new System.Drawing.Size(942, 333);
            this.compGridView.TabIndex = 1;
            this.compGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.compGridView_CellContentClick);
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
            // userComboBox
            // 
            this.userComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(564, 74);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(290, 21);
            this.userComboBox.TabIndex = 46;
            this.userComboBox.SelectedIndexChanged += new System.EventHandler(this.userComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(669, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 47;
            this.label1.Text = "Select User";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.ForeColor = System.Drawing.Color.Black;
            this.countLabel.Location = new System.Drawing.Point(234, 485);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(20, 12);
            this.countLabel.TabIndex = 48;
            this.countLabel.Text = "     ";
            this.countLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.countLabel.Click += new System.EventHandler(this.countLabel_Click);
            // 
            // todaysActivites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(1356, 605);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userComboBox);
            this.Controls.Add(this.dirSubGroupBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.closeNewForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "todaysActivites";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Activities For NEw Companies Captured (For Today)";
            this.Load += new System.EventHandler(this.todaysActivites_Load);
            this.dirSubGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.compGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeNewForm;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox dirSubGroupBox;
        private System.Windows.Forms.DataGridView compGridView;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDirSub;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShareType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colshareAllot;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
    }
}