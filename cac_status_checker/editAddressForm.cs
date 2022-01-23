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

namespace cac_status_checker
{
    public partial class editAddressForm : Form
    {
        ToolTip MyToolTip = new ToolTip();
        string global_rc = "";
        public editAddressForm()
        {
            InitializeComponent();
        }

        private void closeEditForm_MouseHover(object sender, EventArgs e)
        {
            MyToolTip.Show("Close", closeEditForm);
        }

        private void closeEditForm_MouseLeave(object sender, EventArgs e)
        {
            MyToolTip.Hide(closeEditForm);
        }

        private void closeEditForm_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void searchRC_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(searchRC.Text)))
            {
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT receipt_no, comp_name, rc, amount, agent_id, agent_name, office_address, office_res_date FROM COMPANIES_ WHERE rc = @RC and rc <> ''", conn);
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
                            newOffAddress.Text = rd["office_address"].ToString();
                            string temp = rd["office_res_date"].ToString();
                            if (!(string.IsNullOrWhiteSpace(temp)))
                                addrResDate.Value = Convert.ToDateTime(rd["office_res_date"]);
                        }
                        officeGbox.Enabled = updateAddress.Enabled = Enabled;
                        global_rc = rcSearchBox.Text;
                        AcceptButton = updateAddress;
                        rd.Close();
                        conn.Close();
                        conn.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("This name does not exist on the RMD Capture database", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        officeGbox.Enabled = updateAddress.Enabled = false;
                        compName_.Text = newOffAddress.Text = newPresenterName.Text = newAccrNumber.Text = newRRRNumber.Text = null;
                        updateAddress.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database Availability", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void updateAddress_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(newRRRNumber.Text) ||
                string.IsNullOrWhiteSpace(newAmountPaid.Text) ||
                string.IsNullOrWhiteSpace(newOffAddress.Text))
            {
                MessageBox.Show("Make sure Receipt Number, Amount Paid, and Addresss fields are entered.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Query += "as act_date FROM tblReceipts_ WHERE receipt_no = @receipt AND purpose = 'Addition/Modification of Office Address'";
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
                        Query = "UPDATE COMPANIES_ SET office_address = @office_addr, office_res_date = @off_res_date, ";
                        Query += "last_updated = @latest, updated_by = @user, update_purpose = @purpose WHERE rc = @rc";
                        comm = new SqlCommand(Query, conn);
                        comm.Parameters.Add("@rc", SqlDbType.NVarChar).Value = global_rc;
                        comm.Parameters.Add("@office_addr", SqlDbType.NVarChar).Value = newOffAddress.Text;
                        comm.Parameters.Add("@off_res_date", SqlDbType.DateTime).Value = addrResDate.Value;
                        comm.Parameters.Add("@latest", SqlDbType.DateTime).Value = DateTime.Now;
                        comm.Parameters.Add("@user", SqlDbType.NVarChar).Value = Program.user_name;
                        comm.Parameters.Add("@purpose", SqlDbType.NVarChar).Value = "Addition/Modification of Office Address";
                        int i = comm.ExecuteNonQuery();
                        if (i > 0)//At this office address is successfully updated on the database.
                        {
                            //Now Make insertion into Receipts Database
                            Query = "INSERT INTO tblReceipts_ VALUES (@rc, @receipt_no, @amount, @purpose, @presenter, @user, @when) ";
                            comm = new SqlCommand(Query, conn);
                            comm.Parameters.Add("@rc", SqlDbType.NVarChar).Value = global_rc;
                            comm.Parameters.Add("@receipt_no", SqlDbType.NVarChar).Value = newRRRNumber.Text;
                            comm.Parameters.Add("@amount", SqlDbType.NVarChar).Value = newAmountPaid.Text;
                            comm.Parameters.Add("@purpose", SqlDbType.NVarChar).Value = "Addition/Modification of Office Address";
                            comm.Parameters.Add("@presenter", SqlDbType.NVarChar).Value = newAccrNumber.Text;
                            comm.Parameters.Add("@user", SqlDbType.NVarChar).Value = Program.user_name;
                            comm.Parameters.Add("@when", SqlDbType.DateTime).Value = DateTime.Now;
                            i = comm.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Address successfully updated on the database.", "Update information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                conn.Close();
                                conn.Dispose();
                                comm.Dispose();
                                rcSearchBox.Text = newOffAddress.Text = compName.Text = rcNumber.Text = null;
                                rrrNumber.Text = amountPaid.Text = accrNumber.Text = presenterName.Text = null;
                                newRRRNumber.Text = newAccrNumber.Text = newAmountPaid.Text = newPresenterName.Text = null;
                                officeGbox.Enabled = companyGroupBox.Enabled = false;
                                updateAddress.Enabled = false;
                                AcceptButton = searchRC;
                            }
                        }
                    }
                }
            }
        }

        private void rcSearchBox_TextChanged(object sender, EventArgs e)
        {

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

        private void editAddressForm_Load(object sender, EventArgs e)
        {
            compName_.Text = null;
        }

        private void newRRRNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
