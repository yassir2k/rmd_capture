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
    public partial class dsoDate : Form
    {
        ToolTip MyToolTip = new ToolTip();
        public dsoDate()
        {
            InitializeComponent();
        }

        private void closeNewForm_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void dsoDate_Load(object sender, EventArgs e)
        {
            //This connection string gets loaded together with the application
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select username, fullname from tblUsers_ WHERE access_level = 'Basic' OR access_level = 'Super'", conn);
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
                string Query = "SELECT purpose, rc, receipt_no, amount, presenter, activity_date, user_id ";
                Query += "FROM tblReceipts_ WHERE cast(activity_date as date) between @from and @to AND user_id = @user";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.Parameters.Add("@from", SqlDbType.NVarChar).Value = dateFrom.Value.ToString("yyyy/MM/dd");
                cmd.Parameters.Add("@to", SqlDbType.NVarChar).Value = dateTo.Value.ToString("yyyy/MM/dd");
                cmd.Parameters.Add("@user", SqlDbType.NVarChar).Value = GetUntilOrEmpty(userComboBox.SelectedItem.ToString());
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)//Meaning at least a row of data was found from the DB
                {
                    while (rd.Read())
                    {
                        count++;
                        string[] row = { rd["purpose"].ToString(), rd["rc"].ToString(), rd["receipt_no"].ToString(), rd["amount"].ToString(), rd["presenter"].ToString(), rd["activity_date"].ToString(), rd["user_id"].ToString() };
                        compGridView.Rows.Add(row);
                    }
                    conn.Close();
                    conn.Dispose();
                    countLabel.Text = "Total count for activities between " + dateFrom.Value.ToString("yyyy/MM/dd") + " and " + dateTo.Value.ToString("yyyy/MM/dd") + ": " + count;
                }
                else
                {
                    MessageBox.Show("No activity found between " + dateFrom.Value.ToString("dd/MM/yyyy") + " and " + dateTo.Value.ToString("dd/MM/yyyy") + " for " + userComboBox.SelectedItem, "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    compGridView.Rows.Clear();
                    countLabel.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Availability", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private void closeNewForm_MouseLeave(object sender, EventArgs e)
        {
            MyToolTip.Hide(closeNewForm);
        }

        private void closeNewForm_MouseHover(object sender, EventArgs e)
        {
            MyToolTip.Show("Close", closeNewForm);
        }
    }
}
