namespace cac_status_checker
{
    partial class dsoToday
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
            this.colPurpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colreceipt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPresenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.closeNewForm = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.dirSubGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dirSubGroupBox
            // 
            this.dirSubGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.dirSubGroupBox.Controls.Add(this.compGridView);
            this.dirSubGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirSubGroupBox.Location = new System.Drawing.Point(83, 122);
            this.dirSubGroupBox.Name = "dirSubGroupBox";
            this.dirSubGroupBox.Size = new System.Drawing.Size(1179, 352);
            this.dirSubGroupBox.TabIndex = 51;
            this.dirSubGroupBox.TabStop = false;
            this.dirSubGroupBox.Text = "Details of activities carried out";
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
            this.colPurpose,
            this.colRC,
            this.colreceipt,
            this.colAmount,
            this.colPresenter,
            this.colActDate,
            this.colUser});
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
            this.compGridView.Size = new System.Drawing.Size(1173, 333);
            this.compGridView.TabIndex = 1;
            // 
            // colPurpose
            // 
            this.colPurpose.FillWeight = 1F;
            this.colPurpose.Frozen = true;
            this.colPurpose.HeaderText = "Activity Carried Out";
            this.colPurpose.Name = "colPurpose";
            this.colPurpose.ReadOnly = true;
            this.colPurpose.Width = 300;
            // 
            // colRC
            // 
            this.colRC.HeaderText = "Company RC Number";
            this.colRC.MaxInputLength = 250;
            this.colRC.Name = "colRC";
            this.colRC.ReadOnly = true;
            this.colRC.Width = 150;
            // 
            // colreceipt
            // 
            this.colreceipt.HeaderText = "Receipt No";
            this.colreceipt.MaxInputLength = 500;
            this.colreceipt.Name = "colreceipt";
            this.colreceipt.ReadOnly = true;
            this.colreceipt.Width = 150;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount Paid";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAmount.Width = 130;
            // 
            // colPresenter
            // 
            this.colPresenter.HeaderText = "Agent ID";
            this.colPresenter.Name = "colPresenter";
            this.colPresenter.ReadOnly = true;
            this.colPresenter.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPresenter.Width = 120;
            // 
            // colActDate
            // 
            this.colActDate.HeaderText = "Activity Date";
            this.colActDate.MaxInputLength = 20;
            this.colActDate.Name = "colActDate";
            this.colActDate.ReadOnly = true;
            this.colActDate.Width = 160;
            // 
            // colUser
            // 
            this.colUser.HeaderText = "User ID";
            this.colUser.Name = "colUser";
            this.colUser.ReadOnly = true;
            this.colUser.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colUser.Width = 120;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(7, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(267, 23);
            this.label19.TabIndex = 50;
            this.label19.Text = "STAFF ACTIVITIES FOR TODAY";
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
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.ForeColor = System.Drawing.Color.Black;
            this.countLabel.Location = new System.Drawing.Point(82, 486);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(20, 12);
            this.countLabel.TabIndex = 54;
            this.countLabel.Text = "     ";
            this.countLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(671, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 12);
            this.label1.TabIndex = 53;
            this.label1.Text = "Select User:";
            // 
            // userComboBox
            // 
            this.userComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(566, 83);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(290, 21);
            this.userComboBox.TabIndex = 52;
            this.userComboBox.SelectedIndexChanged += new System.EventHandler(this.userComboBox_SelectedIndexChanged);
            // 
            // dsoToday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 605);
            this.Controls.Add(this.dirSubGroupBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.closeNewForm);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "dsoToday";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Staff Activities For Today";
            this.Load += new System.EventHandler(this.dsoToday_Load);
            this.dirSubGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.compGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox dirSubGroupBox;
        private System.Windows.Forms.DataGridView compGridView;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button closeNewForm;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colreceipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPresenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
    }
}