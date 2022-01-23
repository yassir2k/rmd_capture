using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cac_status_checker
{
    public partial class changePassword : Form
    {
        ToolTip MyToolTip = new ToolTip();
        public changePassword()
        {
            InitializeComponent();
        }

        private void closePwdForm_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void changePassword_Load(object sender, EventArgs e)
        {

        }

        private void closePwdForm_MouseHover(object sender, EventArgs e)
        {
            MyToolTip.Show("Close", closePwdForm);
        }

        private void closePwdForm_MouseLeave(object sender, EventArgs e)
        {
            MyToolTip.Hide(closePwdForm);
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(currentPassword.Text) ||
                string.IsNullOrWhiteSpace(newPassword.Text) ||
                string.IsNullOrWhiteSpace(reEnterNewPassword.Text))
            {
                MessageBox.Show("One or all of your entries is/are empty. Please make your entries as instructed.", "Password Change Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(currentPassword.Text != Program.user_password)
            {
                MessageBox.Show("Invalid current password. Please try again.", "Password Change Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(newPassword.Text != reEnterNewPassword.Text)
            {
                MessageBox.Show("The New Passoword fields do not match. Please try again.", "Password Change Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database Availability", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    string Query = "";
                    SqlCommand comm = new SqlCommand();
                    Query = "UPDATE tblUsers_ SET password = @password WHERE username = @username ";
                    comm = new SqlCommand(Query, conn);
                    comm.Parameters.Add("@password", SqlDbType.NVarChar).Value = newPassword.Text;
                    comm.Parameters.Add("@username", SqlDbType.NVarChar).Value = Program.user_name;
                    int i = comm.ExecuteNonQuery();
                    if (i > 0)//At this office address is successfully updated on the database.
                    {
                        if (i > 0)
                        {
                            MessageBox.Show("Password successfully changed.", "Password Change information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            conn.Close();
                            conn.Dispose();
                            comm.Dispose();
                            newPassword.Text = currentPassword.Text = reEnterNewPassword.Text = null;
                        }
                    }
                }
            }
        }
    }
}
