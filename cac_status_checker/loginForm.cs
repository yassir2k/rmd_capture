using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace cac_status_checker
{

    public partial class loginForm : Form
    {
        ~loginForm()
        {
            //breakpoint here
        }
        public loginForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //This connection string gets loaded together with the application
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from tblUsers_ where username=@UserName and password=@Password", conn);
                cmd.Parameters.AddWithValue("@UserName", username.Text);
                cmd.Parameters.AddWithValue("@Password", password.Text);
                SqlDataReader rd = cmd.ExecuteReader();
                loginProgress.Minimum = 0;
                loginProgress.Maximum = 1;//Dt is your DataTable
                for (int i = 0; i < 1; i++)
                {
                    //Do Work
                    loginProgress.Value = i + 1;
                }
                if (rd.HasRows)
                {
                    Program.Status = true;
                    Program.user_name = username.Text;
                    Program.user_password = password.Text;
                    while(rd.Read())
                    {
                        Program.user_full_name = rd["fullname"].ToString();
                        Program.access_level = rd["access_level"].ToString();
                    }
                    rd.Close();
                    conn.Close();
                    conn.Dispose();
                    Close();
                    //after successful it will redirect  to next page .  
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    username.Text = password.Text = null;
                    loginProgress.Value = 0;
                    ActiveControl = username;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Availability", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            //Check if it is running for the first time
            const string REGISTRY_KEY = @"HKEY_CURRENT_USER\MyApplication";
            const string REGISTY_VALUE = "First_Run_RMD";
            if (Convert.ToInt32(Microsoft.Win32.Registry.GetValue(REGISTRY_KEY, REGISTY_VALUE, 0)) == 0)
            {
                MessageBox.Show("This version comes with the following updates:\n\n1. Updated query for checking existing record.", "What is new?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Change the value since the program has run once now
                Microsoft.Win32.Registry.SetValue(REGISTRY_KEY, REGISTY_VALUE, 1, Microsoft.Win32.RegistryValueKind.DWord);
            }
        }
    }
}
