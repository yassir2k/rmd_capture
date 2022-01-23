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
    public partial class editSecretaryForm : Form
    {
        ToolTip MyToolTip = new ToolTip();
        string global_rc = "";
        public editSecretaryForm()
        {
            InitializeComponent();
        }

        private void searchRC_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(rcSearchBox.Text)))
            {
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT receipt_no, comp_name, rc, amount, agent_id, agent_name, sec_name, sec_address, remark, sec_date_of_appoint FROM COMPANIES_ WHERE rc = @RC and rc <> ''", conn);
                    cmd.Parameters.AddWithValue("@rc", rcSearchBox.Text);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            compName_.Text = rd["comp_name"].ToString();
                            rrrNumber.Text = rd["receipt_no"].ToString();
                            amountPaid.Text = rd["amount"].ToString();
                            rcNumber.Text = rd["rc"].ToString();
                            compName.Text = rd["comp_name"].ToString();
                            accrNumber.Text = rd["agent_id"].ToString();
                            presenterName.Text = rd["agent_name"].ToString();
                            secName.Text = rd["sec_name"].ToString();
                            secAddress.Text = rd["sec_address"].ToString();
                            secRemark.SelectedItem = rd["remark"].ToString();
                            string temp = rd["sec_date_of_appoint"].ToString();
                            if (!(string.IsNullOrWhiteSpace(temp)))
                                secDateRes.Value = Convert.ToDateTime(rd["sec_date_of_appoint"]);
                        }
                        officeGbox.Enabled = Enabled;
                        AcceptButton = updateSecretary;
                        updateSecretary.Enabled = Enabled;
                        global_rc = rcSearchBox.Text;
                    }
                    else
                    {
                        MessageBox.Show("This name does not exist on the RMD Capture database", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        officeGbox.Enabled = false;
                        newRRRNumber.Text = newAccrNumber.Text = newAmountPaid.Text = newPresenterName.Text = null;
                        secName.Text = secAddress.Text = compName_.Text = null;
                        secRemark.SelectedItem = "";
                        AcceptButton = searchRC;
                    }
                    rd.Close();
                    conn.Close();
                    conn.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database Availability", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void updateSecretary_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(newRRRNumber.Text) ||
                string.IsNullOrWhiteSpace(newAmountPaid.Text) ||
                string.IsNullOrWhiteSpace(secAddress.Text) ||
                string.IsNullOrWhiteSpace(secRemark.SelectedItem.ToString()) ||
                string.IsNullOrWhiteSpace(secName.Text))
            {
                MessageBox.Show("Make sure Receipt Number, Amount Paid, Secretary Name, Secretary Address and Remarks fields are entered.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(global_rc != rcSearchBox.Text)
            {
                MessageBox.Show("Change detected in RC Number. Make sure you maintain the RC used in bringing out the current Company info displayed.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string Query = "SELECT rc, presenter, receipt_no, purpose, CONVERT (VARCHAR(10), activity_date, 103) ";
                    Query += "as act_date FROM tblReceipts_ WHERE receipt_no = @receipt AND purpose = 'Addition/Modification of Secretary'";
                    SqlCommand comm = new SqlCommand(Query, conn);
                    comm.Parameters.Add("@receipt", SqlDbType.NVarChar).Value = newRRRNumber.Text;
                    SqlDataReader rd = comm.ExecuteReader();
                    if (rd.HasRows)//It means this receipt has been used previously for this process, terminate progress
                    {
                        string what_for = "", rc_ = "", presenter_ = "";
                        string date_ = "";
                        int j = 0, totalRow = 0;
                        if (rd.Read())
                        {
                            rc_ = rd["rc"].ToString();
                            presenter_ = rd["presenter"].ToString();
                            date_ = rd["act_date"].ToString();
                            totalRow++;
                        }
                        while (rd.Read())
                            totalRow++;
                        rd.Close();
                        rd = comm.ExecuteReader();
                        while (rd.Read())
                        {
                            what_for += rd["purpose"].ToString();
                            if (j < (totalRow - 1))
                            {
                                what_for += ", ";
                            }
                            j++;
                        }
                        MessageBox.Show("This receipt " + rrrNumber.Text + " has been used by " + presenter_ + " for filing " + what_for + " on " + date_ + " for the Company with RC Number " + rc_ + ".  Use a genuine receipt in order to proceed.", "Possible Receipt Fraud Detected.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        rd.Close();
                        Query = "UPDATE COMPANIES_ SET sec_name = @secname, sec_address = @sec_addr, remark = @remark, ";
                        Query += "sec_date_of_appoint = @dateappointed, last_updated = @latest, updated_by = @user, ";
                        Query += "update_purpose = @purpose WHERE rc = @rc";
                        comm = new SqlCommand(Query, conn);
                        comm.Parameters.Add("@rc", SqlDbType.NVarChar).Value = global_rc;
                        comm.Parameters.Add("@secname", SqlDbType.NVarChar).Value = secName.Text;
                        comm.Parameters.Add("@sec_addr", SqlDbType.NVarChar).Value = secAddress.Text;
                        comm.Parameters.Add("@remark", SqlDbType.NVarChar).Value = secRemark.Text;
                        comm.Parameters.Add("@dateappointed", SqlDbType.DateTime).Value = secDateRes.Value;
                        comm.Parameters.Add("@latest", SqlDbType.DateTime).Value = DateTime.Now;
                        comm.Parameters.Add("@user", SqlDbType.NVarChar).Value = Program.user_name;
                        comm.Parameters.Add("@purpose", SqlDbType.NVarChar).Value = "Addition/Modification of Secretary";
                        int i = comm.ExecuteNonQuery();
                        if (i > 0)//At this office address is successfully updated on the database.
                        {
                            //Now Make insertion into Receipts Database
                            Query = "INSERT INTO tblReceipts_ VALUES (@rc, @receipt_no, @amount, @purpose, @presenter, @user, @when) ";
                            comm = new SqlCommand(Query, conn);
                            comm.Parameters.Add("@rc", SqlDbType.NVarChar).Value = global_rc;
                            comm.Parameters.Add("@receipt_no", SqlDbType.NVarChar).Value = newRRRNumber.Text;
                            comm.Parameters.Add("@amount", SqlDbType.NVarChar).Value = newAmountPaid.Text;
                            comm.Parameters.Add("@purpose", SqlDbType.NVarChar).Value = "Addition/Modification of Secretary";
                            comm.Parameters.Add("@presenter", SqlDbType.NVarChar).Value = newAccrNumber.Text;
                            comm.Parameters.Add("@user", SqlDbType.NVarChar).Value = Program.user_name;
                            comm.Parameters.Add("@when", SqlDbType.DateTime).Value = DateTime.Now;
                            i = comm.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Secretary successfully updated on the database.", "Update information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                conn.Close();
                                conn.Dispose();
                                comm.Dispose();
                                rcSearchBox.Text = compName.Text = rcNumber.Text = null;
                                secName.Text = secAddress.Text = null;
                                secRemark.SelectedItem = "";
                                rrrNumber.Text = amountPaid.Text = accrNumber.Text = presenterName.Text = null;
                                newRRRNumber.Text = newAccrNumber.Text = newAmountPaid.Text = newPresenterName.Text = null;
                                officeGbox.Enabled = companyGroupBox.Enabled = false;
                                updateSecretary.Enabled = false;
                                AcceptButton = searchRC;
                            }
                        }
                    }
                }
            }
        }

        private void closeNewForm_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void closeNewForm_MouseHover(object sender, EventArgs e)
        {
            MyToolTip.Show("Close", closeNewForm);
        }

        private void closeNewForm_MouseLeave(object sender, EventArgs e)
        {
            MyToolTip.Hide(closeNewForm);
        }

        private void newAccrNumber_Leave(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(newAccrNumber.Text)))
            {
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.Conn_String);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select NAME FROM ACCREDITED_USERS WHERE ACCREDITATION_NUMBER = @accr ", conn);
                    cmd.Parameters.AddWithValue("@accr", newAccrNumber.Text);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            newPresenterName.Text = rd["NAME"].ToString();
                        }
                        rd.Close();
                        conn.Close();
                        conn.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("This Accreditor's name does not exist on the database", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database Availability", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void newRRRNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void editSecretaryForm_Load(object sender, EventArgs e)
        {
            compName_.Text = null;
        }
    }
}
