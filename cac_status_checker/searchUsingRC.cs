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
    public partial class searchUsingRC : Form
    {
        public searchUsingRC()
        {
            InitializeComponent();
        }

        private void searchRC_Click(object sender, EventArgs e)
        {
            searchGridView.Rows.Clear();
            searchGridView.Refresh();
            if (!(string.IsNullOrWhiteSpace(rcSearchBox.Text)))
            {
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
                try
                {
                    conn.Open();
                    string date = null;
                    string num = null;
                    string Query = @"SELECT C.comp_name, C.rc, R.purpose, R.activity_date, U.Fullname, U.username ";
                    Query += " FROM COMPANIES_ as C INNER JOIN tblReceipts_ as R ON (C.rc = R.rc AND C.rc = '"+ rcSearchBox.Text+"')  ";
                    Query += "INNER JOIN tblUsers_ as U ON (R.user_id = U.username) ";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    //cmd.Parameters.AddWithValue("@rc", rcSearchBox.Text);
                    //cmd.CommandType = CommandType.Text;
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)//Meaning at least a row of data was found from the DB
                    {
                        while (rd.Read())
                        {
                            Object date_ = rd["activity_date"];
                            if (string.IsNullOrWhiteSpace(date_.ToString()))
                                date = "-";
                            else
                                date = rd["activity_date"].ToString();

                            //Check Number for NULL Value
                            string[] row = { rd["comp_name"].ToString(), rd["rc"].ToString(), rd["purpose"].ToString(), date, rd["Fullname"].ToString() + " (" + rd["username"].ToString() + ")" };
                            searchGridView.Rows.Add(row);
                        }
                        conn.Close();
                        conn.Dispose();
                        AcceptButton = searchRC;
                    }
                    else
                    {
                        rd.Close();
                        Query = "SELECT C.comp_name, C.rc, '-' as purpose, C.activity_date, U.Fullname, U.username  ";
                        Query += "FROM COMPANIES_ as C INNER JOIN tblUsers_ as U ON (C.rc = '" + rcSearchBox.Text + "' AND C.user_id = U.username)";
                        cmd = new SqlCommand(Query, conn);
                        //cmd.Parameters.AddWithValue("@rc", rcSearchBox.Text);
                        //cmd.CommandType = CommandType.Text;
                        rd = cmd.ExecuteReader();
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                Object date_ = rd["activity_date"];
                                if (string.IsNullOrWhiteSpace(date_.ToString()))
                                    date = "-";
                                else
                                    date = rd["activity_date"].ToString();

                                //Check Number for NULL Value
                                string[] row = { rd["comp_name"].ToString(), rd["rc"].ToString(), rd["purpose"].ToString(), date, rd["Fullname"].ToString() + " (" + rd["username"].ToString() + ")" };
                                searchGridView.Rows.Add(row);
                            }
                            conn.Close();
                            conn.Dispose();
                            AcceptButton = searchRC;
                        }
                        else
                        {
                            MessageBox.Show("The record with thi RC Number does not exist on the RMD Capture database, or it was an old record entered that did not cature the details of the entry officer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            AcceptButton = searchRC;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database Availability", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void searchUsingRC_Load(object sender, EventArgs e)
        {
            AcceptButton = searchRC;
        }
    }
}
