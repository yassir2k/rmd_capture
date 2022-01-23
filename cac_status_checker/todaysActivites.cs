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
    public partial class todaysActivites : Form
    {
        ToolTip MyToolTip = new ToolTip();
        public todaysActivites()
        {
            InitializeComponent();
        }

        private void closeNewForm_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void closeNewForm_MouseLeave(object sender, EventArgs e)
        {
            MyToolTip.Hide(closeNewForm);
        }

        private void closeNewForm_MouseHover(object sender, EventArgs e)
        {
            MyToolTip.Show("Close", closeNewForm);
        }

        private void todaysActivites_Load(object sender, EventArgs e)
        {
            //This connection string gets loaded together with the application
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select username, fullname from tblUsers_ WHERE access_level = 'Basic' OR access_level = 'Super' ", conn);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        userComboBox.Items.Add(rd["username"].ToString() + " " + "(" + rd["fullname"].ToString() + ")");
                    }
                    rd.Close();
                    conn.Close();
                    conn.Dispose();
                    //after successful it will redirect  to next page .  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Availability", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void userComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            compGridView.Rows.Clear();
            int count = 0;
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            try
            {
                conn.Open();
                string Query = "SELECT comp_name, rc, receipt_no,";
                Query += " amount, agent_id, activity_date, user_id FROM COMPANIES_ ";
                Query += "WHERE cast(activity_date as date) = @today AND user_id = @user";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.Parameters.Add("@today", SqlDbType.NVarChar).Value = DateTime.Now.ToString("yyyy/MM/dd");
                cmd.Parameters.Add("@user", SqlDbType.NVarChar).Value = GetUntilOrEmpty(userComboBox.SelectedItem.ToString());
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)//Meaning at least a row of data was found from the DB
                {
                    while (rd.Read())
                    {
                        count++;
                        string[] row = { rd["comp_name"].ToString(), rd["rc"].ToString(), rd["receipt_no"].ToString(), rd["amount"].ToString(), rd["agent_id"].ToString(), rd["activity_date"].ToString(), rd["user_id"].ToString() };
                        compGridView.Rows.Add(row);
                    }
                    conn.Close();
                    conn.Dispose();
                    countLabel.Text = "Total count for new Company capture: " + count;
                }
                else
                {
                    MessageBox.Show("No activity found today for " + userComboBox.SelectedItem, "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    compGridView.Rows.Clear();
                    countLabel.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Availability", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void compRadio_CheckedChanged(object sender, EventArgs e)
        {

        }
        public static string GetUntilOrEmpty(string text, string stopAt = "(")
        {
            if (!String.IsNullOrWhiteSpace(text))
            {
                int charLocation = text.IndexOf(stopAt, StringComparison.Ordinal);

                if (charLocation > 0)
                {
                    return text.Substring(0, charLocation - 1);
                }
            }

            return String.Empty;
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void dirSubGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void compGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void countLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
