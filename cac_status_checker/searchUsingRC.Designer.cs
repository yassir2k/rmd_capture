namespace cac_status_checker
{
    partial class searchUsingRC
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
            this.rcSearchBox = new System.Windows.Forms.TextBox();
            this.searchRC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchGridView = new System.Windows.Forms.DataGridView();
            this.compName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rcSearchBox
            // 
            this.rcSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcSearchBox.Location = new System.Drawing.Point(500, 16);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "SEARCH TASK USING RC NUMBER";
            // 
            // searchGridView
            // 
            this.searchGridView.AllowUserToAddRows = false;
            this.searchGridView.AllowUserToDeleteRows = false;
            this.searchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.compName,
            this.rcNumber,
            this.activity,
            this.activityDate,
            this.userID});
            this.searchGridView.Location = new System.Drawing.Point(54, 119);
            this.searchGridView.Name = "searchGridView";
            this.searchGridView.ReadOnly = true;
            this.searchGridView.Size = new System.Drawing.Size(1249, 150);
            this.searchGridView.TabIndex = 42;
            // 
            // compName
            // 
            this.compName.HeaderText = "Company Name";
            this.compName.MinimumWidth = 400;
            this.compName.Name = "compName";
            this.compName.ReadOnly = true;
            this.compName.Width = 400;
            // 
            // rcNumber
            // 
            this.rcNumber.HeaderText = "RC Number";
            this.rcNumber.MinimumWidth = 50;
            this.rcNumber.Name = "rcNumber";
            this.rcNumber.ReadOnly = true;
            // 
            // activity
            // 
            this.activity.HeaderText = "Activity";
            this.activity.MinimumWidth = 300;
            this.activity.Name = "activity";
            this.activity.ReadOnly = true;
            this.activity.Width = 300;
            // 
            // activityDate
            // 
            this.activityDate.HeaderText = "Activity Date";
            this.activityDate.MinimumWidth = 200;
            this.activityDate.Name = "activityDate";
            this.activityDate.ReadOnly = true;
            this.activityDate.Width = 200;
            // 
            // userID
            // 
            this.userID.HeaderText = "Activity Captured By";
            this.userID.MinimumWidth = 200;
            this.userID.Name = "userID";
            this.userID.ReadOnly = true;
            this.userID.Width = 200;
            // 
            // searchUsingRC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1356, 605);
            this.Controls.Add(this.searchGridView);
            this.Controls.Add(this.rcSearchBox);
            this.Controls.Add(this.searchRC);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "searchUsingRC";
            this.Text = "Search Task Using RC Number";
            this.Load += new System.EventHandler(this.searchUsingRC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rcSearchBox;
        private System.Windows.Forms.Button searchRC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView searchGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn compName;
        private System.Windows.Forms.DataGridViewTextBoxColumn rcNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn activity;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
    }
}