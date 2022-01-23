namespace cac_status_checker
{
    partial class changePassword
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
            this.closePwdForm = new System.Windows.Forms.Button();
            this.passwordGroupBox = new System.Windows.Forms.GroupBox();
            this.changePasswordBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reEnterNewPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.currentPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // closePwdForm
            // 
            this.closePwdForm.BackColor = System.Drawing.Color.Firebrick;
            this.closePwdForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closePwdForm.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closePwdForm.ForeColor = System.Drawing.Color.White;
            this.closePwdForm.Location = new System.Drawing.Point(1328, 15);
            this.closePwdForm.Name = "closePwdForm";
            this.closePwdForm.Size = new System.Drawing.Size(24, 24);
            this.closePwdForm.TabIndex = 33;
            this.closePwdForm.Text = "X";
            this.closePwdForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closePwdForm.UseCompatibleTextRendering = true;
            this.closePwdForm.UseVisualStyleBackColor = false;
            this.closePwdForm.Visible = false;
            this.closePwdForm.Click += new System.EventHandler(this.closePwdForm_Click);
            this.closePwdForm.MouseLeave += new System.EventHandler(this.closePwdForm_MouseLeave);
            this.closePwdForm.MouseHover += new System.EventHandler(this.closePwdForm_MouseHover);
            // 
            // passwordGroupBox
            // 
            this.passwordGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.passwordGroupBox.Controls.Add(this.changePasswordBtn);
            this.passwordGroupBox.Controls.Add(this.label3);
            this.passwordGroupBox.Controls.Add(this.label2);
            this.passwordGroupBox.Controls.Add(this.reEnterNewPassword);
            this.passwordGroupBox.Controls.Add(this.label1);
            this.passwordGroupBox.Controls.Add(this.newPassword);
            this.passwordGroupBox.Controls.Add(this.currentPassword);
            this.passwordGroupBox.Location = new System.Drawing.Point(558, 157);
            this.passwordGroupBox.Name = "passwordGroupBox";
            this.passwordGroupBox.Size = new System.Drawing.Size(244, 219);
            this.passwordGroupBox.TabIndex = 34;
            this.passwordGroupBox.TabStop = false;
            this.passwordGroupBox.Text = "Change Password";
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.Image = global::cac_status_checker.Properties.Resources.change_passwd;
            this.changePasswordBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.changePasswordBtn.Location = new System.Drawing.Point(83, 169);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(140, 44);
            this.changePasswordBtn.TabIndex = 2;
            this.changePasswordBtn.Text = "Change Password";
            this.changePasswordBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changePasswordBtn.UseVisualStyleBackColor = true;
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Re-Enter New Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter New Password:";
            // 
            // reEnterNewPassword
            // 
            this.reEnterNewPassword.Location = new System.Drawing.Point(17, 133);
            this.reEnterNewPassword.MaxLength = 100;
            this.reEnterNewPassword.Name = "reEnterNewPassword";
            this.reEnterNewPassword.PasswordChar = '●';
            this.reEnterNewPassword.Size = new System.Drawing.Size(206, 20);
            this.reEnterNewPassword.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Current Password:";
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(17, 90);
            this.newPassword.MaxLength = 100;
            this.newPassword.Name = "newPassword";
            this.newPassword.PasswordChar = '●';
            this.newPassword.Size = new System.Drawing.Size(206, 20);
            this.newPassword.TabIndex = 0;
            // 
            // currentPassword
            // 
            this.currentPassword.Location = new System.Drawing.Point(17, 47);
            this.currentPassword.MaxLength = 100;
            this.currentPassword.Name = "currentPassword";
            this.currentPassword.PasswordChar = '*';
            this.currentPassword.Size = new System.Drawing.Size(206, 20);
            this.currentPassword.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(7, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "EDIT DIRECTOR/SUBCRIBER";
            // 
            // changePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1356, 605);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordGroupBox);
            this.Controls.Add(this.closePwdForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "changePassword";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Login Password";
            this.Load += new System.EventHandler(this.changePassword_Load);
            this.passwordGroupBox.ResumeLayout(false);
            this.passwordGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closePwdForm;
        private System.Windows.Forms.GroupBox passwordGroupBox;
        private System.Windows.Forms.Button changePasswordBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reEnterNewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.TextBox currentPassword;
        private System.Windows.Forms.Label label4;
    }
}