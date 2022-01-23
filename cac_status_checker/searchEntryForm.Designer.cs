namespace cac_status_checker
{
    partial class searchEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchEntryForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDirSub = new System.Windows.Forms.ToolStripMenuItem();
            this.editDirSub = new System.Windows.Forms.ToolStripMenuItem();
            this.editSecretary = new System.Windows.Forms.ToolStripMenuItem();
            this.editOfficeAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yourActivitiesTodayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDirectorSubscriberCapturedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yourActivitiesBasedOnSelectedDatesBracketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCompanyCapturedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorsSubscribersSecretariesOfficeAddressesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTaskUsingRCNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutRMDCaptureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabForms = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::cac_status_checker.Properties.Resources.new_32x32;
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDirSub,
            this.editDirSub,
            this.editSecretary,
            this.editOfficeAddress});
            this.editToolStripMenuItem.Image = global::cac_status_checker.Properties.Resources.edit_32x32;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addDirSub
            // 
            this.addDirSub.Name = "addDirSub";
            this.addDirSub.Size = new System.Drawing.Size(247, 22);
            this.addDirSub.Text = "Add New Director/Subscriber";
            this.addDirSub.Click += new System.EventHandler(this.addDirSub_Click);
            // 
            // editDirSub
            // 
            this.editDirSub.Name = "editDirSub";
            this.editDirSub.Size = new System.Drawing.Size(247, 22);
            this.editDirSub.Text = "Edit/Remove Director/Subscriber";
            this.editDirSub.Click += new System.EventHandler(this.editDirSub_Click);
            // 
            // editSecretary
            // 
            this.editSecretary.Name = "editSecretary";
            this.editSecretary.Size = new System.Drawing.Size(247, 22);
            this.editSecretary.Text = "Add/Edit Secretary";
            this.editSecretary.Click += new System.EventHandler(this.editSecretary_Click);
            // 
            // editOfficeAddress
            // 
            this.editOfficeAddress.Name = "editOfficeAddress";
            this.editOfficeAddress.Size = new System.Drawing.Size(247, 22);
            this.editOfficeAddress.Text = "Add/Edit Office Address";
            this.editOfficeAddress.Click += new System.EventHandler(this.editOfficeAddress_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yourActivitiesTodayToolStripMenuItem,
            this.yourActivitiesBasedOnSelectedDatesBracketToolStripMenuItem,
            this.searchTaskUsingRCNumberToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.viewToolStripMenuItem.Text = "Activities";
            this.viewToolStripMenuItem.Visible = false;
            // 
            // yourActivitiesTodayToolStripMenuItem
            // 
            this.yourActivitiesTodayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCompanyToolStripMenuItem,
            this.newDirectorSubscriberCapturedToolStripMenuItem});
            this.yourActivitiesTodayToolStripMenuItem.Image = global::cac_status_checker.Properties.Resources.activity_today;
            this.yourActivitiesTodayToolStripMenuItem.Name = "yourActivitiesTodayToolStripMenuItem";
            this.yourActivitiesTodayToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.yourActivitiesTodayToolStripMenuItem.Text = "Today";
            // 
            // newCompanyToolStripMenuItem
            // 
            this.newCompanyToolStripMenuItem.Enabled = false;
            this.newCompanyToolStripMenuItem.Name = "newCompanyToolStripMenuItem";
            this.newCompanyToolStripMenuItem.Size = new System.Drawing.Size(342, 22);
            this.newCompanyToolStripMenuItem.Text = "New Company Captured";
            this.newCompanyToolStripMenuItem.Click += new System.EventHandler(this.newCompanyToolStripMenuItem_Click);
            // 
            // newDirectorSubscriberCapturedToolStripMenuItem
            // 
            this.newDirectorSubscriberCapturedToolStripMenuItem.Name = "newDirectorSubscriberCapturedToolStripMenuItem";
            this.newDirectorSubscriberCapturedToolStripMenuItem.Size = new System.Drawing.Size(342, 22);
            this.newDirectorSubscriberCapturedToolStripMenuItem.Text = "Directors/Subscribers, Secretaries, Office Addresses";
            this.newDirectorSubscriberCapturedToolStripMenuItem.Click += new System.EventHandler(this.newDirectorSubscriberCapturedToolStripMenuItem_Click);
            // 
            // yourActivitiesBasedOnSelectedDatesBracketToolStripMenuItem
            // 
            this.yourActivitiesBasedOnSelectedDatesBracketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCompanyCapturedToolStripMenuItem,
            this.directorsSubscribersSecretariesOfficeAddressesToolStripMenuItem});
            this.yourActivitiesBasedOnSelectedDatesBracketToolStripMenuItem.Image = global::cac_status_checker.Properties.Resources.activity_date;
            this.yourActivitiesBasedOnSelectedDatesBracketToolStripMenuItem.Name = "yourActivitiesBasedOnSelectedDatesBracketToolStripMenuItem";
            this.yourActivitiesBasedOnSelectedDatesBracketToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.yourActivitiesBasedOnSelectedDatesBracketToolStripMenuItem.Text = "Using Date Range";
            // 
            // newCompanyCapturedToolStripMenuItem
            // 
            this.newCompanyCapturedToolStripMenuItem.Enabled = false;
            this.newCompanyCapturedToolStripMenuItem.Name = "newCompanyCapturedToolStripMenuItem";
            this.newCompanyCapturedToolStripMenuItem.Size = new System.Drawing.Size(342, 22);
            this.newCompanyCapturedToolStripMenuItem.Text = "New Company Captured";
            this.newCompanyCapturedToolStripMenuItem.Click += new System.EventHandler(this.newCompanyCapturedToolStripMenuItem_Click);
            // 
            // directorsSubscribersSecretariesOfficeAddressesToolStripMenuItem
            // 
            this.directorsSubscribersSecretariesOfficeAddressesToolStripMenuItem.Name = "directorsSubscribersSecretariesOfficeAddressesToolStripMenuItem";
            this.directorsSubscribersSecretariesOfficeAddressesToolStripMenuItem.Size = new System.Drawing.Size(342, 22);
            this.directorsSubscribersSecretariesOfficeAddressesToolStripMenuItem.Text = "Directors/Subscribers, Secretaries, Office Addresses";
            this.directorsSubscribersSecretariesOfficeAddressesToolStripMenuItem.Click += new System.EventHandler(this.directorsSubscribersSecretariesOfficeAddressesToolStripMenuItem_Click);
            // 
            // searchTaskUsingRCNumberToolStripMenuItem
            // 
            this.searchTaskUsingRCNumberToolStripMenuItem.Image = global::cac_status_checker.Properties.Resources.search;
            this.searchTaskUsingRCNumberToolStripMenuItem.Name = "searchTaskUsingRCNumberToolStripMenuItem";
            this.searchTaskUsingRCNumberToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.searchTaskUsingRCNumberToolStripMenuItem.Text = "Search Task Using RC Number";
            this.searchTaskUsingRCNumberToolStripMenuItem.Click += new System.EventHandler(this.searchTaskUsingRCNumberToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::cac_status_checker.Properties.Resources.reset_password;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutRMDCaptureToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutRMDCaptureToolStripMenuItem
            // 
            this.aboutRMDCaptureToolStripMenuItem.Image = global::cac_status_checker.Properties.Resources.help_icon;
            this.aboutRMDCaptureToolStripMenuItem.Name = "aboutRMDCaptureToolStripMenuItem";
            this.aboutRMDCaptureToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.aboutRMDCaptureToolStripMenuItem.Text = "About RMD Capture";
            this.aboutRMDCaptureToolStripMenuItem.Click += new System.EventHandler(this.aboutRMDCaptureToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.currentUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 417);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(800, 33);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(362, 23);
            this.toolStripStatusLabel1.Text = "Copyright © 2019 Corporate Affairs Commission (ICT Department)";
            // 
            // currentUser
            // 
            this.currentUser.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.currentUser.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.currentUser.Margin = new System.Windows.Forms.Padding(5);
            this.currentUser.Name = "currentUser";
            this.currentUser.Padding = new System.Windows.Forms.Padding(2);
            this.currentUser.Size = new System.Drawing.Size(126, 23);
            this.currentUser.Text = "toolStripStatusLabel2";
            // 
            // tabForms
            // 
            this.tabForms.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabForms.Location = new System.Drawing.Point(0, 24);
            this.tabForms.Name = "tabForms";
            this.tabForms.SelectedIndex = 0;
            this.tabForms.Size = new System.Drawing.Size(800, 20);
            this.tabForms.TabIndex = 6;
            this.tabForms.Visible = false;
            this.tabForms.SelectedIndexChanged += new System.EventHandler(this.tabForms_SelectedIndexChanged);
            // 
            // searchEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabForms);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "searchEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RMD Capture Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.searchEntryForm_Load);
            this.MdiChildActivate += new System.EventHandler(this.searchEntryForm_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutRMDCaptureToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel currentUser;
        private System.Windows.Forms.ToolStripMenuItem addDirSub;
        private System.Windows.Forms.ToolStripMenuItem editDirSub;
        private System.Windows.Forms.ToolStripMenuItem editSecretary;
        private System.Windows.Forms.ToolStripMenuItem editOfficeAddress;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yourActivitiesTodayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yourActivitiesBasedOnSelectedDatesBracketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDirectorSubscriberCapturedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCompanyCapturedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directorsSubscribersSecretariesOfficeAddressesToolStripMenuItem;
        private System.Windows.Forms.TabControl tabForms;
        private System.Windows.Forms.ToolStripMenuItem searchTaskUsingRCNumberToolStripMenuItem;
    }
}

