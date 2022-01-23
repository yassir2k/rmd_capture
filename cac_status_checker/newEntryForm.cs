using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cac_status_checker
{
    public partial class newEntryForm : Form
    {
        ToolTip MyToolTip = new ToolTip();
        string RC = "";
        string Company = "";
        string purpose = "";
        public newEntryForm()
        {
            InitializeComponent();
        }

        private void addDirSub_Click(object sender, EventArgs e)
        {
            //First, Check for Empty Entries in the Director/Subscriber form before proceeding
            if ( (string.IsNullOrWhiteSpace(subscriberName.Text) ||
                string.IsNullOrWhiteSpace(subscriberAddr.Text) ||
                string.IsNullOrWhiteSpace(subscriberType.Text) ||
                string.IsNullOrWhiteSpace(subRemark.Text) ||
                string.IsNullOrWhiteSpace(subResDate.Text) && (subShareAllot.Enabled == false && subShareType.Enabled == false))
                ||
                ( (subShareAllot.Enabled == Enabled && subShareType.Enabled == Enabled)) &&
                (string.IsNullOrWhiteSpace(subscriberName.Text) ||
                string.IsNullOrWhiteSpace(subscriberAddr.Text) ||
                string.IsNullOrWhiteSpace(subscriberType.Text) ||
                string.IsNullOrWhiteSpace(subRemark.Text) ||
                string.IsNullOrWhiteSpace(subShareAllot.Text) ||
                string.IsNullOrWhiteSpace(subShareType.Text))
                )
            {
                MessageBox.Show("Void entry detected in the Directors/Subscriber section. Make sure entries are made in all items.", "Director/Subscriber Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                //Add to GridView
                string sName = subscriberName.Text;
                string sAddress = subscriberAddr.Text;
                string sType = subscriberType.Text;
                string sShare = subShareType.Text;
                if (subShareType.Enabled == false)
                    sShare = "";
                string sAllot = subShareAllot.Text;
                if (subShareAllot.Enabled == false)
                    sAllot = "";
                string sRemark = subRemark.Text;
                string sResDate = subResDate.Value.ToString();
                string sPhone = subPhone.Text;
                string[] row = { sName, sAddress, sType, sShare, sPhone, sAllot, sRemark, sResDate };
                dirsubGridView.Rows.Add(row);
                MessageBox.Show("New " + sType + " successfully captured. However, you need to fill the Company Information, Secrtary Information, and Office Address forms respectively and submit before this entry gets committed to the Database.", "Information on " + sType + " Added.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (subShareType.Enabled == Enabled)
                    subShareType.SelectedItem = null;
                if (subShareAllot.Enabled == Enabled)
                    subShareAllot.Text = null;
                subscriberName.Text = subscriberAddr.Text = subRemark.Text = subPhone.Text = null;
            }
        }

        private void saveEntry_Click(object sender, EventArgs e)
        {
            if(subGroupBox.Enabled && !secGroupBox.Enabled && !offGroupBox.Enabled)//Director/Subscriber Task only
            {
                if (dirsubGridView.Rows.Count <= 0)
                {
                    MessageBox.Show("No Director or Subscriber captured for this Company. Please ensure you capture at least two Director/Subscriber before saving the forms' entries.", "Error Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                        string Query = "INSERT into COMPANIES_ (receipt_no, comp_name, rc, amount, agent_id, agent_name, ";
                        Query+="user_id, activity_date) VALUES (@receipt, @compname, @rcno, @amount, @agentid, ";
                        Query += "@agent_name, @user, @when)";
                        SqlCommand comm = new SqlCommand(Query, conn);
                        comm.Parameters.Add("@receipt", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colRRR"].Value.ToString();
                        comm.Parameters.Add("@compname", SqlDbType.NVarChar).Value = compName.Text;
                        comm.Parameters.Add("@rcno", SqlDbType.NVarChar).Value = rcNumber.Text;
                        comm.Parameters.Add("@amount", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colAmount"].Value.ToString();
                        comm.Parameters.Add("@agentid", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colAgentID"].Value.ToString();
                        comm.Parameters.Add("@agent_name", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colPresenter"].Value.ToString();
                        comm.Parameters.Add("@user", SqlDbType.NVarChar).Value = Program.user_name;
                        comm.Parameters.Add("@when", SqlDbType.DateTime).Value = DateTime.Now;
                        // Let's ask the db to execute the query
                        int rowsAdded = comm.ExecuteNonQuery();
                        if (rowsAdded > 0) //We can be sure the above details have been captured successfully on the DB
                        {//Proceed to capture director details
                            int i = 0;
                            for (; i < dirsubGridView.Rows.Count; i++)
                            {
                                Query = "INSERT into DIRECTORS_ (rc, name, address, share, number, type, remark, type_of_share, date_of_appoint, activity_date, user_id) ";
                                Query += "VALUES (@rc, @name, @address, @share, @phone, @subtype, @remark, ";
                                Query += "@sharetype, @dateappointed, @when, @user)";
                                comm = new SqlCommand(Query, conn);
                                comm.Parameters.Add("@rc", SqlDbType.NVarChar).Value = rcNumber.Text;
                                comm.Parameters.Add("@name", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colDirSub"].Value.ToString();
                                comm.Parameters.Add("@address", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colSubAddress"].Value.ToString();
                                comm.Parameters.Add("@share", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colShareAllot"].Value.ToString();
                                comm.Parameters.Add("@phone", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colPhone"].Value.ToString();
                                comm.Parameters.Add("@subtype", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colSubType"].Value.ToString();
                                comm.Parameters.Add("@remark", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colRemark"].Value.ToString();
                                comm.Parameters.Add("@sharetype", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colShareType"].Value.ToString();
                                comm.Parameters.Add("@dateappointed", SqlDbType.DateTime).Value = dirsubGridView.Rows[i].Cells["colResDate"].Value.ToString();
                                comm.Parameters.Add("@when", SqlDbType.DateTime).Value = DateTime.Now;
                                comm.Parameters.Add("@user", SqlDbType.NVarChar).Value = Program.user_name;
                                rowsAdded = comm.ExecuteNonQuery();
                            }

                            if (i == dirsubGridView.Rows.Count)//At this stage, Company, Director/Subscriber, secretary details, and office address are successfully saved on the database.
                            {
                                //Now add Receipt
                                for (i = 0; i < receiptGridView.Rows.Count; i++)
                                {
                                    Query = "INSERT INTO tblReceipts_ VALUES (@rc, @receipt_no, @amount, @purpose, @presenter, @user, @dateActivity)";
                                    comm = new SqlCommand(Query, conn);
                                    comm.Parameters.Add("@rc", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colRC"].Value.ToString();
                                    comm.Parameters.Add("@receipt_no", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colRRR"].Value.ToString();
                                    comm.Parameters.Add("@amount", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colAmount"].Value.ToString();
                                    comm.Parameters.Add("@purpose", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colPurpose"].Value.ToString();
                                    comm.Parameters.Add("@presenter", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colAgentID"].Value.ToString();
                                    comm.Parameters.Add("@user", SqlDbType.NVarChar).Value = Program.user_name;
                                    comm.Parameters.Add("@dateActivity", SqlDbType.DateTime).Value = DateTime.Now;
                                    comm.ExecuteNonQuery();
                                }
                                if (i == receiptGridView.Rows.Count)
                                {
                                    MessageBox.Show("Company, Director/Subscriber, and Receipt details are successfully captured on the database.", "New entry information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    receiptGridView.Rows.Clear();
                                    dircheckBox1.Checked = seccheckBox1.Checked = offcheckBox1.Checked = false;
                                    dircheckBox1.Visible = seccheckBox1.Visible = offcheckBox1.Visible = false;
                                    receiptGridView.Visible = recGropuBox1.Visible = false;
                                    subGroupBox.Enabled = dirListGroupBox.Enabled = saveEntry.Enabled = clearForms.Enabled = false;
                                    dirsubGridView.Rows.Clear();
                                    dirsubGridView.Refresh();
                                    compName_.Text = null;
                                }
                            }
                        }
                        else
                        {
                            // Well this should never really happen
                            MessageBox.Show("Data is not saved. Please try again.", "Data capture error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        conn.Close();
                        conn.Dispose();
                        comm.Dispose();
                    }
                }
            }
            else if(subGroupBox.Enabled && secGroupBox.Enabled && !offGroupBox.Enabled)//Director/Subscriber and Secretary Task
            {
                if (dirsubGridView.Rows.Count <= 0)
                {
                    MessageBox.Show("No Director or Subscriber captured for this Company. Please ensure you capture at least two Director/Subscriber before saving the forms' entries.", "Error Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if(string.IsNullOrWhiteSpace(secName.Text) ||
                        string.IsNullOrWhiteSpace(secAddress.Text) ||
                        string.IsNullOrWhiteSpace(secRemark.SelectedItem.ToString()))
                {
                    MessageBox.Show("Missing field(s) detected in Secretary's form. Please ensure you entered all the mandatory details in the Secretary form.", "Error Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                        string Query = "INSERT into COMPANIES_ (receipt_no, comp_name, rc, amount, agent_id, agent_name, ";
                        Query += "sec_name, sec_address, remark, sec_date_of_appoint, user_id, activity_date) VALUES (@receipt, @compname, @rcno, @amount, @agentid, ";
                        Query += "@agent_name, @secname, @secaddress, @remark, @secDate, @user, @when)";
                        SqlCommand comm = new SqlCommand(Query, conn);
                        if (receiptGridView.Rows.Count == 1)//Agent uses single receipt for the transaction.
                            comm.Parameters.Add("@receipt", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colRRR"].Value.ToString();
                        else
                            comm.Parameters.Add("@receipt", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colRRR"].Value.ToString() + ", " + receiptGridView.Rows[1].Cells["colRRR"].Value.ToString();
                        comm.Parameters.Add("@compname", SqlDbType.NVarChar).Value = compName.Text;
                        comm.Parameters.Add("@rcno", SqlDbType.NVarChar).Value = rcNumber.Text;
                        if (receiptGridView.Rows.Count == 1)
                            comm.Parameters.Add("@amount", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colAmount"].Value.ToString();
                        else
                            comm.Parameters.Add("@amount", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colAmount"].Value.ToString() + ", " + receiptGridView.Rows[1].Cells["colAmount"].Value.ToString();
                        comm.Parameters.Add("@agentid", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colAgentID"].Value.ToString();
                        comm.Parameters.Add("@agent_name", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colPresenter"].Value.ToString();
                        comm.Parameters.Add("@secname", SqlDbType.NVarChar).Value = secName.Text;
                        comm.Parameters.Add("@secaddress", SqlDbType.NVarChar).Value = secAddress.Text;
                        comm.Parameters.Add("@remark", SqlDbType.NVarChar).Value = secRemark.Text;
                        comm.Parameters.Add("@secDate", SqlDbType.DateTime).Value = secDateRes.Value;
                        comm.Parameters.Add("@user", SqlDbType.NVarChar).Value = Program.user_name;
                        comm.Parameters.Add("@when", SqlDbType.DateTime).Value = DateTime.Now;
                        // Let's ask the db to execute the query
                        int rowsAdded = comm.ExecuteNonQuery();
                        if (rowsAdded > 0) //We can be sure the above details have been captured successfully on the DB
                        {//Proceed to capture director details
                            int i = 0;
                            for (; i < dirsubGridView.Rows.Count; i++)
                            {
                                Query = "INSERT into DIRECTORS_ (rc, name, address, share, number, type, remark, type_of_share, date_of_appoint, activity_date, user_id) ";
                                Query += "VALUES (@rc, @name, @address, @share, @phone, @subtype, @remark, ";
                                Query += "@sharetype, @dateappointed, @when, @user)";
                                comm = new SqlCommand(Query, conn);
                                comm.Parameters.Add("@rc", SqlDbType.NVarChar).Value = rcNumber.Text;
                                comm.Parameters.Add("@name", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colDirSub"].Value.ToString();
                                comm.Parameters.Add("@address", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colSubAddress"].Value.ToString();
                                comm.Parameters.Add("@share", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colShareAllot"].Value.ToString();
                                comm.Parameters.Add("@phone", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colPhone"].Value.ToString();
                                comm.Parameters.Add("@subtype", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colSubType"].Value.ToString();
                                comm.Parameters.Add("@remark", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colRemark"].Value.ToString();
                                comm.Parameters.Add("@sharetype", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colShareType"].Value.ToString();
                                comm.Parameters.Add("@dateappointed", SqlDbType.DateTime).Value = dirsubGridView.Rows[i].Cells["colResDate"].Value.ToString();
                                comm.Parameters.Add("@when", SqlDbType.DateTime).Value = DateTime.Now;
                                comm.Parameters.Add("@user", SqlDbType.NVarChar).Value = Program.user_name;
                                rowsAdded = comm.ExecuteNonQuery();
                            }

                            if (i == dirsubGridView.Rows.Count)//At this stage, Company, Director/Subscriber, secretary details, and office address are successfully saved on the database.
                            {
                                //Now add Receipt
                                for (i = 0; i < receiptGridView.Rows.Count; i++)
                                {
                                    Query = "INSERT INTO tblReceipts_ VALUES (@rc, @receipt_no, @amount, @purpose, @presenter, @user, @dateActivity)";
                                    comm = new SqlCommand(Query, conn);
                                    comm.Parameters.Add("@rc", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colRC"].Value.ToString();
                                    comm.Parameters.Add("@receipt_no", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colRRR"].Value.ToString();
                                    comm.Parameters.Add("@amount", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colAmount"].Value.ToString();
                                    comm.Parameters.Add("@purpose", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colPurpose"].Value.ToString();
                                    comm.Parameters.Add("@presenter", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colAgentID"].Value.ToString();
                                    comm.Parameters.Add("@user", SqlDbType.NVarChar).Value = Program.user_name;
                                    comm.Parameters.Add("@dateActivity", SqlDbType.DateTime).Value = DateTime.Now;
                                    comm.ExecuteNonQuery();
                                }
                                if (i == receiptGridView.Rows.Count)
                                {
                                    MessageBox.Show("Company, Director/Subscriber, Secretary, and Receipt details are successfully captured on the database.", "New entry information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    receiptGridView.Rows.Clear();
                                    dircheckBox1.Checked = seccheckBox1.Checked = offcheckBox1.Checked = false;
                                    dircheckBox1.Visible = seccheckBox1.Visible = offcheckBox1.Visible = false;
                                    receiptGridView.Visible = recGropuBox1.Visible = false;
                                    subGroupBox.Enabled = dirListGroupBox.Enabled = saveEntry.Enabled = clearForms.Enabled = false;
                                    secName.Text = secAddress.Text = secRemark.Text = null;
                                    secDateRes.ResetText();
                                    secGroupBox.Enabled = false;
                                    dirsubGridView.Rows.Clear();
                                    dirsubGridView.Refresh();
                                    compName_.Text = null;
                                }
                                conn.Close();
                                conn.Dispose();
                                comm.Dispose();
                            }
                        }
                        else
                        {
                            // Well this should never really happen
                            MessageBox.Show("Data is not saved. Please try again.", "Data capture error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            else if(secGroupBox.Enabled && !offGroupBox.Enabled && !subGroupBox.Enabled)//Secretary Task Only
            {
                if (string.IsNullOrWhiteSpace(secName.Text) ||
                        string.IsNullOrWhiteSpace(secAddress.Text) ||
                        string.IsNullOrWhiteSpace(secRemark.SelectedItem.ToString()))
                {
                    MessageBox.Show("Missing field(s) detected in Secretary's form. Please ensure you entered all the mandatory details in the Secretary form.", "Error Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                        string Query = "INSERT into COMPANIES_ (receipt_no, comp_name, rc, amount, agent_id, agent_name, ";
                        Query += "sec_name, sec_address, remark, sec_date_of_appoint, user_id, activity_date) VALUES (@receipt, @compname, @rcno, @amount, @agentid, ";
                        Query += "@agent_name, @secname, @secaddress, @remark, @secDate, @user, @when)";
                        SqlCommand comm = new SqlCommand(Query, conn);
                        comm.Parameters.Add("@receipt", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colRRR"].Value.ToString();
                        comm.Parameters.Add("@compname", SqlDbType.NVarChar).Value = compName.Text;
                        comm.Parameters.Add("@rcno", SqlDbType.NVarChar).Value = rcNumber.Text;
                        comm.Parameters.Add("@amount", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colAmount"].Value.ToString();
                        comm.Parameters.Add("@agentid", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colAgentID"].Value.ToString();
                        comm.Parameters.Add("@agent_name", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colPresenter"].Value.ToString();
                        comm.Parameters.Add("@secname", SqlDbType.NVarChar).Value = secName.Text;
                        comm.Parameters.Add("@secaddress", SqlDbType.NVarChar).Value = secAddress.Text;
                        comm.Parameters.Add("@remark", SqlDbType.NVarChar).Value = secRemark.Text;
                        comm.Parameters.Add("@secDate", SqlDbType.DateTime).Value = secDateRes.Value;
                        comm.Parameters.Add("@user", SqlDbType.NVarChar).Value = Program.user_name;
                        comm.Parameters.Add("@when", SqlDbType.DateTime).Value = DateTime.Now;
                        // Let's ask the db to execute the query
                        int rowsAdded = comm.ExecuteNonQuery();
                        if (rowsAdded > 0) //We can be sure the above details have been captured successfully on the DB
                        {
                            //Now add Receipt
                            int i = 0;
                            for (; i < receiptGridView.Rows.Count; i++)
                            {
                                Query = "INSERT INTO tblReceipts_ VALUES (@rc, @receipt_no, @amount, @purpose, @presenter, @user, @dateActivity)";
                                comm = new SqlCommand(Query, conn);
                                comm.Parameters.Add("@rc", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colRC"].Value.ToString();
                                comm.Parameters.Add("@receipt_no", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colRRR"].Value.ToString();
                                comm.Parameters.Add("@amount", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colAmount"].Value.ToString();
                                comm.Parameters.Add("@purpose", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colPurpose"].Value.ToString();
                                comm.Parameters.Add("@presenter", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colAgentID"].Value.ToString();
                                comm.Parameters.Add("@user", SqlDbType.NVarChar).Value = Program.user_name;
                                comm.Parameters.Add("@dateActivity", SqlDbType.DateTime).Value = DateTime.Now;
                                comm.ExecuteNonQuery();
                            }
                            if (i == receiptGridView.Rows.Count)
                            {
                                MessageBox.Show("Company, Secretary, and Receipt details are successfully captured on the database.", "New entry information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                receiptGridView.Rows.Clear();
                                dircheckBox1.Checked = seccheckBox1.Checked = offcheckBox1.Checked = false;
                                dircheckBox1.Visible = seccheckBox1.Visible = offcheckBox1.Visible = false;
                                receiptGridView.Visible = recGropuBox1.Visible = false;
                                saveEntry.Enabled = clearForms.Enabled = false;
                                secName.Text = secAddress.Text = secRemark.Text = null;
                                secDateRes.ResetText();
                                secGroupBox.Enabled = false;
                                compName_.Text = null;
                            }
                            conn.Close();
                            conn.Dispose();
                            comm.Dispose();
                        }
                        else
                        {
                            // Well this should never really happen
                            MessageBox.Show("Data is not saved. Please try again.", "Data capture error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            else if(subGroupBox.Enabled && offGroupBox.Enabled && !secGroupBox.Enabled)//Director/Subscriber and Office Address Task
            {
                if (dirsubGridView.Rows.Count <= 0)
                {
                    MessageBox.Show("No Director or Subscriber captured for this Company. Please ensure you capture at least two Director/Subscriber before saving the forms' entries.", "Error Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (string.IsNullOrWhiteSpace(newOffAddress.Text))
                {
                    MessageBox.Show("Office Address is missing. Please ensure you enter the new office address.", "Error Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                        string Query = "INSERT into COMPANIES_ (receipt_no, comp_name, rc, amount, agent_id, agent_name, ";
                        Query += "office_address, office_res_date, user_id, activity_date) VALUES (@receipt, @compname, @rcno, @amount, @agentid, ";
                        Query += "@agent_name, @off_addr, @off_res_date, @user, @when)";
                        SqlCommand comm = new SqlCommand(Query, conn);
                        if (receiptGridView.Rows.Count == 1)//Agent uses single receipt for the transaction.
                            comm.Parameters.Add("@receipt", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colRRR"].Value.ToString();
                        else
                            comm.Parameters.Add("@receipt", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colRRR"].Value.ToString() + ", " + receiptGridView.Rows[1].Cells["colRRR"].Value.ToString();
                        comm.Parameters.Add("@compname", SqlDbType.NVarChar).Value = compName.Text;
                        comm.Parameters.Add("@rcno", SqlDbType.NVarChar).Value = rcNumber.Text;
                        if (receiptGridView.Rows.Count == 1)
                            comm.Parameters.Add("@amount", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colAmount"].Value.ToString();
                        else
                            comm.Parameters.Add("@amount", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colAmount"].Value.ToString() + ", " + receiptGridView.Rows[1].Cells["colAmount"].Value.ToString();
                        comm.Parameters.Add("@agentid", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colAgentID"].Value.ToString();
                        comm.Parameters.Add("@agent_name", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colPresenter"].Value.ToString();
                        comm.Parameters.Add("@off_addr", SqlDbType.NVarChar).Value = newOffAddress.Text;
                        comm.Parameters.Add("@off_res_date", SqlDbType.DateTime).Value = addrResDate.Value;
                        comm.Parameters.Add("@user", SqlDbType.NVarChar).Value = Program.user_name;
                        comm.Parameters.Add("@when", SqlDbType.DateTime).Value = DateTime.Now;
                        // Let's ask the db to execute the query
                        int rowsAdded = comm.ExecuteNonQuery();
                        if (rowsAdded > 0) //We can be sure the above details have been captured successfully on the DB
                        {//Proceed to capture director details
                            int i = 0;
                            for (; i < dirsubGridView.Rows.Count; i++)
                            {
                                Query = "INSERT into DIRECTORS_ (rc, name, address, share, number, type, remark, type_of_share, date_of_appoint, activity_date, user_id) ";
                                Query += "VALUES (@rc, @name, @address, @share, @phone, @subtype, @remark, ";
                                Query += "@sharetype, @dateappointed, @when, @user)";
                                comm = new SqlCommand(Query, conn);
                                comm.Parameters.Add("@rc", SqlDbType.NVarChar).Value = rcNumber.Text;
                                comm.Parameters.Add("@name", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colDirSub"].Value.ToString();
                                comm.Parameters.Add("@address", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colSubAddress"].Value.ToString();
                                comm.Parameters.Add("@share", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colShareAllot"].Value.ToString();
                                comm.Parameters.Add("@phone", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colPhone"].Value.ToString();
                                comm.Parameters.Add("@subtype", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colSubType"].Value.ToString();
                                comm.Parameters.Add("@remark", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colRemark"].Value.ToString();
                                comm.Parameters.Add("@sharetype", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colShareType"].Value.ToString();
                                comm.Parameters.Add("@dateappointed", SqlDbType.DateTime).Value = dirsubGridView.Rows[i].Cells["colResDate"].Value.ToString();
                                comm.Parameters.Add("@when", SqlDbType.DateTime).Value = DateTime.Now;
                                comm.Parameters.Add("@user", SqlDbType.NVarChar).Value = Program.user_name;
                                rowsAdded = comm.ExecuteNonQuery();
                            }

                            if (i == dirsubGridView.Rows.Count)//At this stage, Company, Director/Subscriber, and office address are successfully saved on the database.
                            {
                                //Now add Receipt
                                for (i = 0; i < receiptGridView.Rows.Count; i++)
                                {
                                    Query = "INSERT INTO tblReceipts_ VALUES (@rc, @receipt_no, @amount, @purpose, @presenter, @user, @dateActivity)";
                                    comm = new SqlCommand(Query, conn);
                                    comm.Parameters.Add("@rc", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colRC"].Value.ToString();
                                    comm.Parameters.Add("@receipt_no", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colRRR"].Value.ToString();
                                    comm.Parameters.Add("@amount", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colAmount"].Value.ToString();
                                    comm.Parameters.Add("@purpose", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colPurpose"].Value.ToString();
                                    comm.Parameters.Add("@presenter", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colAgentID"].Value.ToString();
                                    comm.Parameters.Add("@user", SqlDbType.NVarChar).Value = Program.user_name;
                                    comm.Parameters.Add("@dateActivity", SqlDbType.DateTime).Value = DateTime.Now;
                                    comm.ExecuteNonQuery();
                                }
                                if (i == receiptGridView.Rows.Count)
                                {
                                    MessageBox.Show("Company, Director/Subscriber, Office address, and Receipt details are successfully captured on the database.", "New entry information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    receiptGridView.Rows.Clear();
                                    dircheckBox1.Checked = seccheckBox1.Checked = offcheckBox1.Checked = false;
                                    dircheckBox1.Visible = seccheckBox1.Visible = offcheckBox1.Visible = false;
                                    receiptGridView.Visible = recGropuBox1.Visible = false;
                                    subGroupBox.Enabled = dirListGroupBox.Enabled = saveEntry.Enabled = clearForms.Enabled = false;
                                    secName.Text = secAddress.Text = secRemark.Text = null;
                                    secDateRes.ResetText();
                                    secGroupBox.Enabled = false;
                                    dirsubGridView.Rows.Clear();
                                    dirsubGridView.Refresh();
                                    compName_.Text = null;
                                }
                                conn.Close();
                                conn.Dispose();
                                comm.Dispose();
                            }
                        }
                        else
                        {
                            // Well this should never really happen
                            MessageBox.Show("Data is not saved. Please try again.", "Data capture error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            else if(offGroupBox.Enabled && !subGroupBox.Enabled && !secGroupBox.Enabled)//Office Address Task Only
            {
                if (string.IsNullOrWhiteSpace(newOffAddress.Text) )
                {
                    MessageBox.Show("Office Address is missing. Please ensure you enter the new office address.", "Error Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                        string Query = "INSERT into COMPANIES_ (receipt_no, comp_name, rc, amount, agent_id, agent_name, ";
                        Query += "office_address, office_res_date, user_id, activity_date) VALUES (@receipt, @compname, @rcno, @amount, @agentid, ";
                        Query += "@agent_name, @off_addr, @off_res_date, @user, @when)";
                        SqlCommand comm = new SqlCommand(Query, conn);
                        comm.Parameters.Add("@receipt", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colRRR"].Value.ToString();
                        comm.Parameters.Add("@compname", SqlDbType.NVarChar).Value = compName.Text;
                        comm.Parameters.Add("@rcno", SqlDbType.NVarChar).Value = rcNumber.Text;
                        comm.Parameters.Add("@amount", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colAmount"].Value.ToString();
                        comm.Parameters.Add("@agentid", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colAgentID"].Value.ToString();
                        comm.Parameters.Add("@agent_name", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colPresenter"].Value.ToString();
                        comm.Parameters.Add("@off_addr", SqlDbType.NVarChar).Value = newOffAddress.Text;
                        comm.Parameters.Add("@off_res_date", SqlDbType.DateTime).Value = addrResDate.Value;
                        comm.Parameters.Add("@user", SqlDbType.NVarChar).Value = Program.user_name;
                        comm.Parameters.Add("@when", SqlDbType.DateTime).Value = DateTime.Now;
                        // Let's ask the db to execute the query
                        int rowsAdded = comm.ExecuteNonQuery();
                        if (rowsAdded > 0) //We can be sure the above details have been captured successfully on the DB
                        {
                            //Now add Receipt
                            int i = 0;
                            for (; i < receiptGridView.Rows.Count; i++)
                            {
                                Query = "INSERT INTO tblReceipts_ VALUES (@rc, @receipt_no, @amount, @purpose, @presenter, @user, @dateActivity)";
                                comm = new SqlCommand(Query, conn);
                                comm.Parameters.Add("@rc", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colRC"].Value.ToString();
                                comm.Parameters.Add("@receipt_no", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colRRR"].Value.ToString();
                                comm.Parameters.Add("@amount", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colAmount"].Value.ToString();
                                comm.Parameters.Add("@purpose", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colPurpose"].Value.ToString();
                                comm.Parameters.Add("@presenter", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colAgentID"].Value.ToString();
                                comm.Parameters.Add("@user", SqlDbType.NVarChar).Value = Program.user_name;
                                comm.Parameters.Add("@dateActivity", SqlDbType.DateTime).Value = DateTime.Now;
                                comm.ExecuteNonQuery();
                            }
                            if (i == receiptGridView.Rows.Count)
                            {
                                MessageBox.Show("Company, new office address, and Receipt details are successfully captured on the database.", "New entry information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                receiptGridView.Rows.Clear();
                                dircheckBox1.Checked = seccheckBox1.Checked = offcheckBox1.Checked = false;
                                dircheckBox1.Visible = seccheckBox1.Visible = offcheckBox1.Visible = false;
                                receiptGridView.Visible = recGropuBox1.Visible = false;
                                saveEntry.Enabled = clearForms.Enabled = false;
                                newOffAddress.Text = null;
                                addrResDate.ResetText();
                                offGroupBox.Enabled = false;
                                compName_.Text = null;
                            }
                            conn.Close();
                            conn.Dispose();
                            comm.Dispose();
                        }
                        else
                        {
                            // Well this should never really happen
                            MessageBox.Show("Data is not saved. Please try again.", "Data capture error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            else if(secGroupBox.Enabled && offGroupBox.Enabled && !subGroupBox.Enabled)//Secretary and Office Address Task
            {
                if (string.IsNullOrWhiteSpace(secName.Text) ||
                        string.IsNullOrWhiteSpace(secAddress.Text) ||
                        string.IsNullOrWhiteSpace(secRemark.SelectedItem.ToString()))
                {
                    MessageBox.Show("Missing field(s) detected in Secretary's form. Please ensure you entered all the mandatory details in the Secretary form.", "Error Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (string.IsNullOrWhiteSpace(newOffAddress.Text))
                {
                    MessageBox.Show("Office Address is missing. Please ensure you enter the new office address.", "Error Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                        string Query = "INSERT into COMPANIES_ (receipt_no, comp_name, rc, amount, agent_id, agent_name, ";
                        Query += "sec_name, sec_address, remark, sec_date_of_appoint, office_address, office_res_date, ";
                        Query += "user_id, activity_date) VALUES (@receipt, @compname, @rcno, @amount, @agentid, ";
                        Query += "@agent_name, @secname, @secaddress, @remark, @secDate, @off_addr, @off_res_date, @user, @when)";
                        SqlCommand comm = new SqlCommand(Query, conn);
                        if (receiptGridView.Rows.Count == 1)//Agent uses single receipt for the transaction.
                            comm.Parameters.Add("@receipt", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colRRR"].Value.ToString();
                        else
                            comm.Parameters.Add("@receipt", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colRRR"].Value.ToString() + ", " + receiptGridView.Rows[1].Cells["colRRR"].Value.ToString();
                        comm.Parameters.Add("@compname", SqlDbType.NVarChar).Value = compName.Text;
                        comm.Parameters.Add("@rcno", SqlDbType.NVarChar).Value = rcNumber.Text;
                        if (receiptGridView.Rows.Count == 1)
                            comm.Parameters.Add("@amount", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colAmount"].Value.ToString();
                        else
                            comm.Parameters.Add("@amount", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colAmount"].Value.ToString() + ", " + receiptGridView.Rows[1].Cells["colAmount"].Value.ToString();
                        comm.Parameters.Add("@agentid", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colAgentID"].Value.ToString();
                        comm.Parameters.Add("@agent_name", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colPresenter"].Value.ToString();
                        comm.Parameters.Add("@secname", SqlDbType.NVarChar).Value = secName.Text;
                        comm.Parameters.Add("@secaddress", SqlDbType.NVarChar).Value = secAddress.Text;
                        comm.Parameters.Add("@remark", SqlDbType.NVarChar).Value = secRemark.Text;
                        comm.Parameters.Add("@secDate", SqlDbType.DateTime).Value = secDateRes.Value;
                        comm.Parameters.Add("@off_addr", SqlDbType.NVarChar).Value = newOffAddress.Text;
                        comm.Parameters.Add("@off_res_date", SqlDbType.DateTime).Value = addrResDate.Value;
                        comm.Parameters.Add("@user", SqlDbType.NVarChar).Value = Program.user_name;
                        comm.Parameters.Add("@when", SqlDbType.DateTime).Value = DateTime.Now;
                        // Let's ask the db to execute the query
                        int rowsAdded = comm.ExecuteNonQuery();
                        if (rowsAdded > 0) //We can be sure the above details have been captured successfully on the DB
                        {
                            //Now add Receipt
                            int i = 0;
                            for (; i < receiptGridView.Rows.Count; i++)
                            {
                                Query = "INSERT INTO tblReceipts_ VALUES (@rc, @receipt_no, @amount, @purpose, @presenter, @user, @dateActivity)";
                                comm = new SqlCommand(Query, conn);
                                comm.Parameters.Add("@rc", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colRC"].Value.ToString();
                                comm.Parameters.Add("@receipt_no", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colRRR"].Value.ToString();
                                comm.Parameters.Add("@amount", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colAmount"].Value.ToString();
                                comm.Parameters.Add("@purpose", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colPurpose"].Value.ToString();
                                comm.Parameters.Add("@presenter", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colAgentID"].Value.ToString();
                                comm.Parameters.Add("@user", SqlDbType.NVarChar).Value = Program.user_name;
                                comm.Parameters.Add("@dateActivity", SqlDbType.DateTime).Value = DateTime.Now;
                                comm.ExecuteNonQuery();
                            }
                            if (i == receiptGridView.Rows.Count)
                            {
                                MessageBox.Show("Company, Secretary, new office address, and Receipt details are successfully captured on the database.", "New entry information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                receiptGridView.Rows.Clear();
                                dircheckBox1.Checked = seccheckBox1.Checked = offcheckBox1.Checked = false;
                                dircheckBox1.Visible = seccheckBox1.Visible = offcheckBox1.Visible = false;
                                receiptGridView.Visible = recGropuBox1.Visible = false;
                                saveEntry.Enabled = clearForms.Enabled = false;
                                secName.Text = secAddress.Text = secRemark.Text = null;
                                secDateRes.ResetText();
                                secGroupBox.Enabled = false;
                                newOffAddress.Text = null;
                                addrResDate.ResetText();
                                offGroupBox.Enabled = false;
                                compName_.Text = null;
                            }  
                        }
                        else
                        {
                            // Well this should never really happen
                            MessageBox.Show("Data is not saved. Please try again.", "Data capture error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        conn.Close();
                        conn.Dispose();
                        comm.Dispose();
                    }
                }
            }
            else //Director/Subscriber, Secretrary, and Office Address Task
            {
                if (dirsubGridView.Rows.Count <= 0)
                {
                    MessageBox.Show("No Director or Subscriber captured for this Company. Please ensure you capture at least two Director/Subscriber before saving the forms' entries.", "Error Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else//We Check Secretary, and Office Address Forms for Empty Entries
                {
                    if (string.IsNullOrWhiteSpace(secName.Text) ||
                            string.IsNullOrWhiteSpace(secAddress.Text) ||
                            string.IsNullOrWhiteSpace(secRemark.Text))
                    {
                        MessageBox.Show("Empty entry/entries detected in Secretary Information form. Check and correct accordingly.", "Secretary Information Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else if (string.IsNullOrWhiteSpace(newOffAddress.Text))
                    {
                        MessageBox.Show("Empty Office address detected. Check and correct accordingly.", "Office Address Information Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else//This is where every entry gets processed for onward capture onto the database
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
                            string Query = "INSERT into COMPANIES_ (receipt_no, comp_name, rc, amount, agent_id, agent_name, sec_name, sec_address, remark, sec_date_of_appoint, office_address, office_res_date, user_id, activity_date) VALUES (@receipt, @compname, @rcno, @amount, @agentid, ";
                            Query += "@agent_name, @sec_name, @secaddress, @remark, @secDate, @off_addr, @off_res_date, @user, @when)";
                            SqlCommand comm = new SqlCommand(Query, conn);
                            if (receiptGridView.Rows.Count == 1)//Agent uses single receipt for the transaction.
                                comm.Parameters.Add("@receipt", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colRRR"].Value.ToString();
                            else if (receiptGridView.Rows.Count == 2)
                                comm.Parameters.Add("@receipt", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colRRR"].Value.ToString() + ", " + receiptGridView.Rows[1].Cells["colRRR"].Value.ToString();
                            else 
                                comm.Parameters.Add("@receipt", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colRRR"].Value.ToString() + ", " + receiptGridView.Rows[1].Cells["colRRR"].Value.ToString() + ", " + receiptGridView.Rows[2].Cells["colRRR"].Value.ToString();
                            comm.Parameters.Add("@compname", SqlDbType.NVarChar).Value = compName.Text;
                            comm.Parameters.Add("@rcno", SqlDbType.NVarChar).Value = rcNumber.Text;
                            if (receiptGridView.Rows.Count == 1)
                                comm.Parameters.Add("@amount", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colAmount"].Value.ToString();
                            else if (receiptGridView.Rows.Count == 2)
                                comm.Parameters.Add("@amount", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colAmount"].Value.ToString() + ", " + receiptGridView.Rows[1].Cells["colAmount"].Value.ToString();
                            else 
                                comm.Parameters.Add("@amount", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colAmount"].Value.ToString() + ", " + receiptGridView.Rows[1].Cells["colAmount"].Value.ToString() + ", " + receiptGridView.Rows[2].Cells["colAmount"].Value.ToString();
                            comm.Parameters.Add("@agentid", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colAgentID"].Value.ToString();
                            comm.Parameters.Add("@agent_name", SqlDbType.NVarChar).Value = receiptGridView.Rows[0].Cells["colPresenter"].Value.ToString();
                            comm.Parameters.Add("@sec_name", SqlDbType.NVarChar).Value = secName.Text;
                            comm.Parameters.Add("@secaddress", SqlDbType.NVarChar).Value = secAddress.Text;
                            comm.Parameters.Add("@remark", SqlDbType.NVarChar).Value = secRemark.Text;
                            comm.Parameters.Add("@secDate", SqlDbType.DateTime).Value = secDateRes.Value;
                            comm.Parameters.Add("@off_addr", SqlDbType.NVarChar).Value = newOffAddress.Text;
                            comm.Parameters.Add("@off_res_date", SqlDbType.DateTime).Value = addrResDate.Value;
                            comm.Parameters.Add("@user", SqlDbType.NVarChar).Value = Program.user_name;
                            comm.Parameters.Add("@when", SqlDbType.DateTime).Value = DateTime.Now;
                            // Let's ask the db to execute the query
                            int rowsAdded = comm.ExecuteNonQuery();
                            if (rowsAdded > 0) //We can be sure the above details have been captured successfully on the DB
                            {//Proceed to capture director details
                                int i = 0;
                                for (; i < dirsubGridView.Rows.Count; i++)
                                {
                                    Query = "INSERT into DIRECTORS_ (rc, name, address, share, number, type, remark, type_of_share, date_of_appoint, activity_date, user_id) ";
                                    Query += "VALUES (@rc, @name, @address, @share, @phone, @subtype, @remark, ";
                                    Query += "@sharetype, @dateappointed, @when, @user)";
                                    comm = new SqlCommand(Query, conn);
                                    comm.Parameters.Add("@rc", SqlDbType.NVarChar).Value = rcNumber.Text;
                                    comm.Parameters.Add("@name", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colDirSub"].Value.ToString();
                                    comm.Parameters.Add("@address", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colSubAddress"].Value.ToString();
                                    comm.Parameters.Add("@share", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colShareAllot"].Value.ToString();
                                    comm.Parameters.Add("@phone", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colPhone"].Value.ToString();
                                    comm.Parameters.Add("@subtype", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colSubType"].Value.ToString();
                                    comm.Parameters.Add("@remark", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colRemark"].Value.ToString();
                                    comm.Parameters.Add("@sharetype", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colShareType"].Value.ToString();
                                    comm.Parameters.Add("@dateappointed", SqlDbType.DateTime).Value = dirsubGridView.Rows[i].Cells["colResDate"].Value.ToString();
                                    comm.Parameters.Add("@when", SqlDbType.DateTime).Value = DateTime.Now;
                                    comm.Parameters.Add("@user", SqlDbType.NVarChar).Value = Program.user_name;
                                    rowsAdded = comm.ExecuteNonQuery();
                                }

                                if (i == dirsubGridView.Rows.Count)//At this stage, Company, Director/Subscriber, secretary details, and office address are successfully saved on the database.
                                {
                                    //Now add Receipt
                                    for (i = 0; i < receiptGridView.Rows.Count; i++)
                                    {
                                        Query = "INSERT INTO tblReceipts_ VALUES (@rc, @receipt_no, @amount, @purpose, @presenter, @user, @dateActivity)";
                                        comm = new SqlCommand(Query, conn);
                                        comm.Parameters.Add("@rc", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colRC"].Value.ToString();
                                        comm.Parameters.Add("@receipt_no", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colRRR"].Value.ToString();
                                        comm.Parameters.Add("@amount", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colAmount"].Value.ToString();
                                        comm.Parameters.Add("@purpose", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colPurpose"].Value.ToString();
                                        comm.Parameters.Add("@presenter", SqlDbType.NVarChar).Value = receiptGridView.Rows[i].Cells["colAgentID"].Value.ToString();
                                        comm.Parameters.Add("@user", SqlDbType.NVarChar).Value = Program.user_name;
                                        comm.Parameters.Add("@dateActivity", SqlDbType.DateTime).Value = DateTime.Now;
                                        comm.ExecuteNonQuery();
                                    }
                                    if (i == receiptGridView.Rows.Count)
                                    {
                                        MessageBox.Show("Company, Director/Subscriber, Secretary details, new office address, and receipts are successfully captured on the database.", "New entry information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                        receiptGridView.Rows.Clear();
                                        dircheckBox1.Checked = seccheckBox1.Checked = offcheckBox1.Checked = false;
                                        dircheckBox1.Visible = seccheckBox1.Visible = offcheckBox1.Visible = false;
                                        receiptGridView.Visible = recGropuBox1.Visible = false;
                                        subGroupBox.Enabled = dirListGroupBox.Enabled = saveEntry.Enabled = clearForms.Enabled = false;
                                        secName.Text = secAddress.Text = secRemark.Text = null;
                                        secDateRes.ResetText();
                                        secGroupBox.Enabled = false;
                                        newOffAddress.Text = null;
                                        addrResDate.ResetText();
                                        subResDate.ResetText();
                                        offGroupBox.Enabled = false;
                                        dirsubGridView.Rows.Clear();
                                        dirsubGridView.Refresh();
                                        compName_.Text = null;
                                    }
                                    conn.Close();
                                    conn.Dispose();
                                    comm.Dispose();
                                }
                            }
                            else
                            {
                                // Well this should never really happen
                                MessageBox.Show("Data is not saved. Please try again.", "Data capture error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            conn.Close();
                            conn.Dispose();
                            comm.Dispose();
                        }
                    }
                }
            }
            /////////////////////////////////////////////////////////////////////////////////////////////
        }

        private void rcNumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(rcNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rcNumber.Text = rcNumber.Text.Remove(rcNumber.Text.Length - 1);
            }
        }
        private void rcNumber_Leave(object sender, EventArgs e)
        {
            if(!(string.IsNullOrWhiteSpace(rcNumber.Text)))
            {
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.Conn_String);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select APPROVED_NAME FROM COMPANY WHERE RC_NUMBER = @RC AND CLASSIFICATION_FK = '2' AND RC_NUMBER <> '' ", conn);
                    cmd.Parameters.AddWithValue("@RC", rcNumber.Text);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            compName.Text = rd["APPROVED_NAME"].ToString();
                            compName.BackColor = Color.Pink;
                        }
                        rd.Close();
                        conn.Close();
                        conn.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("This name does not exist on the database", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database Availability", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void accrNumber_Leave(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(accrNumber.Text)))
            {
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.Conn_String);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select NAME FROM ACCREDITED_USERS WHERE ACCREDITATION_NUMBER = @accr ", conn);
                    cmd.Parameters.AddWithValue("@accr", accrNumber.Text);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            presenterName.Text = rd["NAME"].ToString();
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

        private void rrrNumber_TextChanged(object sender, EventArgs e)
        {
            /*if (System.Text.RegularExpressions.Regex.IsMatch(rrrNumber.Text, "word(\\d+|{\\d+(,\\d+)*})(,(\\d+|{\\d+(,\\d+)*}))*"))
            {
                MessageBox.Show("Please enter only numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rcNumber.Text = rcNumber.Text.Remove(rcNumber.Text.Length - 1);
            }*/
        }

        private void subPhone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(subPhone.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                subPhone.Text = subPhone.Text.Remove(subPhone.Text.Length - 1);
            }
        }

        private void presenterName_TextChanged(object sender, EventArgs e)
        {

        }

        private void subscriberType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(subscriberType.SelectedItem.ToString() == "Director")
            {
                subShareType.Enabled = false;
                subShareAllot.Enabled = false;
            }
            else
            {
                subShareType.Enabled = Enabled;
                subShareAllot.Enabled = Enabled;
            }
        }

        private void newEntryForm_Load(object sender, EventArgs e)
        {
            compName_.Text = null;
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

        private void addReceiptBtn_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(amountPaid.Text) ||
                string.IsNullOrWhiteSpace(rrrNumber.Text)) ||
                ((!dircheckBox1.Checked && dircheckBox1.Visible == Visible) &&
                (!seccheckBox1.Checked && seccheckBox1.Visible == Visible) &&
                (!offcheckBox1.Checked && offcheckBox1.Visible == Visible)))
            {
                MessageBox.Show("Empty entry/entries detected. Make sure Receipt No, Amount, and at least, one purpose for the receipt is ticked.", "Receipt Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else if ((dircheckBox1.Visible && !dircheckBox1.Checked) &&
                    (seccheckBox1.Visible && !seccheckBox1.Checked) &&
                    offcheckBox1.Visible == false)
            {
                MessageBox.Show("Receipt purpose field(s) not ticked. Please tick at least the receipt box for Director/Subscriber or Secretary or both.", "Receipt Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if ((dircheckBox1.Visible && !dircheckBox1.Checked) &&
                    (offcheckBox1.Visible && !offcheckBox1.Checked) &&
                    seccheckBox1.Visible == false)
            {
                MessageBox.Show("Receipt purpose field(s) not ticked. Please tick at least the receipt box for Director/Subscriber or Office address or both.", "Receipt Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if ((seccheckBox1.Visible && !seccheckBox1.Checked) &&
                    (offcheckBox1.Visible && !offcheckBox1.Checked) &&
                    dircheckBox1.Visible == false)
            {
                MessageBox.Show("Receipt purpose field(s) not ticked. Please tick at least the receipt box for Secretary or Office address or both.", "Receipt Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (dircheckBox1.Visible == false && seccheckBox1.Visible == false &&
                    (offcheckBox1.Visible && !offcheckBox1.Checked))
            {
                MessageBox.Show("Receipt purpose field not ticked. Please tick the box for Office address to to succesfully capture this receipt.", "Receipt Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (dircheckBox1.Visible == false && offcheckBox1.Visible == false &&
                    (seccheckBox1.Visible && !seccheckBox1.Checked))
            {
                MessageBox.Show("Receipt purpose field not ticked. Please tick the box for Secretary to to succesfully capture this receipt.", "Receipt Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (seccheckBox1.Visible == false && offcheckBox1.Visible == false &&
                    (dircheckBox1.Visible && !dircheckBox1.Checked))
            {
                MessageBox.Show("Receipt purpose field not ticked. Please tick the box for Secretary to to succesfully capture this receipt.", "Receipt Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                //Check if user is trying to capture same receipt more than once here
                int flag = 0; //Flag is to control whether the application would proceed to add receipt or not based on whether a duplicate receipt is detected.
                if (receiptGridView.Rows.Count > 0)
                {
                    foreach (DataGridViewRow Row in receiptGridView.Rows)
                    {
                        string cellText = Row.Cells[0].Value.ToString();
                        if (cellText == rrrNumber.Text)
                        {
                            MessageBox.Show("Duplicate receipt detected. Please enter a different receipt.", "Receipt Information", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button3);
                            flag = 1;
                            return;
                        }
                    }
                }
                if(flag == 0)
                {
                    SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
                    try
                    {
                        conn.Open();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        string Query = "SELECT rc, presenter, receipt_no, purpose, CONVERT (VARCHAR(10), activity_date, 103) ";
                        Query += "as act_date FROM tblReceipts_ WHERE receipt_no = @receipt";
                        SqlCommand comm = new SqlCommand(Query, conn);
                        comm.Parameters.Add("@receipt", SqlDbType.NVarChar).Value = rrrNumber.Text;
                        SqlDataReader rd = comm.ExecuteReader();
                        if (rd.HasRows)//It means this receipt has been used previously, terminate progress
                        {
                            string what_for = "" , rc_ = "", presenter_ = "";
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
                                if (j < (totalRow - 1) )
                                {
                                    what_for += ", ";
                                }
                                j++;
                            }
                            MessageBox.Show("This receipt " + rrrNumber.Text + " has been used by " + presenter_ + " for filing " + what_for + " on " + date_ + " for the Company with RC Number " + rc_ + ".  Use a genuine receipt in order to proceed." , "Possible Receipt Fraud Detected.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            if ((dircheckBox1.Checked && dircheckBox1.Visible) &&
                              !seccheckBox1.Checked && !offcheckBox1.Checked)
                            {
                                purpose += "New Director/Subscriber";
                                dircheckBox1.Visible = false;
                                subGroupBox.Enabled = Enabled;
                                dirListGroupBox.Enabled = Enabled;
                                saveEntry.Enabled = Enabled;
                                clearForms.Enabled = Enabled;
                            }
                            else if ((dircheckBox1.Checked && dircheckBox1.Visible) &&
                                  seccheckBox1.Checked && !offcheckBox1.Checked)
                            {
                                purpose += "New Director/Subscriber, New Secretary";
                                dircheckBox1.Visible = false;
                                seccheckBox1.Visible = false;
                                subGroupBox.Enabled = Enabled;
                                dirListGroupBox.Enabled = Enabled;
                                secGroupBox.Enabled = Enabled;
                                saveEntry.Enabled = Enabled;
                                clearForms.Enabled = Enabled;
                            }
                            else if ((dircheckBox1.Checked && dircheckBox1.Visible) &&
                                  seccheckBox1.Checked && offcheckBox1.Checked)
                            {
                                purpose += "New Director/Subscriber, New Secretary, New Office Address";
                                dircheckBox1.Visible = false;
                                seccheckBox1.Visible = false;
                                offcheckBox1.Visible = false;
                                subGroupBox.Enabled = Enabled;
                                dirListGroupBox.Enabled = Enabled;
                                secGroupBox.Enabled = Enabled;
                                offGroupBox.Enabled = Enabled;
                                saveEntry.Enabled = Enabled;
                                clearForms.Enabled = Enabled;
                            }
                            else if ((seccheckBox1.Checked && seccheckBox1.Visible) &&
                                  !dircheckBox1.Checked && !offcheckBox1.Checked)
                            {
                                purpose += "New Secretary";
                                seccheckBox1.Visible = false;
                                secGroupBox.Enabled = Enabled;
                                saveEntry.Enabled = Enabled;
                                clearForms.Enabled = Enabled;
                            }
                            else if ((seccheckBox1.Checked && seccheckBox1.Visible) &&
                                    offcheckBox1.Checked)
                            {
                                purpose += "New Secretary, New Office Address";
                                seccheckBox1.Visible = false;
                                offcheckBox1.Visible = false;
                                secGroupBox.Enabled = Enabled;
                                offGroupBox.Enabled = Enabled;
                                saveEntry.Enabled = Enabled;
                                clearForms.Enabled = Enabled;
                            }
                            else if ((offcheckBox1.Checked && offcheckBox1.Visible) &&
                                    !dircheckBox1.Checked && !seccheckBox1.Checked)
                            {
                                purpose += "New Office Address";
                                offcheckBox1.Visible = false;
                                offGroupBox.Enabled = Enabled;
                                saveEntry.Enabled = Enabled;
                                clearForms.Enabled = Enabled;
                            }//
                            else
                            {
                                purpose += "New Director/Subscriber, New Office Address";
                                dircheckBox1.Visible = false;
                                subGroupBox.Enabled = Enabled;
                                dirListGroupBox.Enabled = Enabled;
                                offcheckBox1.Visible = false;
                                offGroupBox.Enabled = Enabled;
                                saveEntry.Enabled = Enabled;
                                clearForms.Enabled = Enabled;
                            }

                            string receipt = rrrNumber.Text;
                            string amount = amountPaid.Text;
                            string rcnumber = rcNumber.Text;
                            string accred_no = accrNumber.Text;
                            string presenter = presenterName.Text;
                            string[] row = { receipt, amount, purpose, rcnumber, presenter, accred_no };
                            receiptGridView.Rows.Add(row);
                            if (!dircheckBox1.Visible && !seccheckBox1.Visible && !offcheckBox1.Visible)
                                recGropuBox1.Enabled = false;
                            MessageBox.Show("Receipt with receipt number " + receipt + " successfully added.", "Receipt Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            rrrNumber.Text = amountPaid.Text = accrNumber.Text = presenterName.Text = null;
                            purpose = "";
                            dircheckBox1.Checked = seccheckBox1.Checked = offcheckBox1.Checked = false;
                        }
                    }
                }
            }
        }


        private void searchRC_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(searchRC.Text)))
            {
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.Conn_String);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select RC_NUMBER, APPROVED_NAME FROM COMPANY WHERE RC_NUMBER = @RC AND CLASSIFICATION_FK = '2' AND RC_NUMBER <> '' ", conn);
                    cmd.Parameters.AddWithValue("@RC", rcSearchBox.Text);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            RC = rd["RC_NUMBER"].ToString();
                            Company = rd["APPROVED_NAME"].ToString();
                        }
                        //Now that we've confirmed this is a valid RC, let's check the RMD Capture DB
                        conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
                        try
                        {
                            conn.Open();
                            cmd = new SqlCommand("SELECT rc FROM COMPANIES_ WHERE rc = @RC and rc <> ''", conn);
                            cmd.Parameters.AddWithValue("@rc", RC);
                            rd = cmd.ExecuteReader();
                            if (rd.HasRows)
                            {
                                MessageBox.Show("This Company RC number has previously been captured on the RMD Capture database. Please go to the menu options and select the task you would want to carry out.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                rcSearchBox.Text = null;
                                rd.Close();
                                conn.Close();
                                conn.Dispose();
                            }
                            else
                            {
                                DialogResult result = MessageBox.Show("This Company RC number does not exist on the RMD Capture database. Do you want to start a new capture for this Company?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                if (result == DialogResult.Yes)
                                {
                                    rcNumber.Text = RC;
                                    compName.Text = compName_.Text = Company;
                                    receiptPanel.Enabled = Enabled;
                                    recGropuBox1.Visible = Visible;
                                    receiptGridView.Visible = Visible;
                                }
                                else 
                                {
                                    receiptPanel.Enabled = false;
                                    recGropuBox1.Visible = false;
                                    receiptGridView.Visible = false;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Database Availability", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This name does not exist on CAC's main Company database", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        compName_.Text = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database Availability", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void receiptGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow Row = e.Row;
            string receiptRow = Row.Cells[2].Value.ToString();
            if (receiptRow == "New Director/Subscriber")
            {
                dircheckBox1.Visible = Visible;
                dircheckBox1.Checked = false;
                subGroupBox.Enabled = dirListGroupBox.Enabled = false;
            }
            else if(receiptRow == "New Office Address")
            {
                offcheckBox1.Visible = Visible;
                offcheckBox1.Checked = false;
                offGroupBox.Enabled = false;
            }
            else if(receiptRow == "New Secretary")
            {
                seccheckBox1.Visible = Visible;
                seccheckBox1.Checked = false;
                secGroupBox.Enabled = false;
            }
            else if (receiptRow == "New Director/Subscriber, New Secretary")
            {
                dircheckBox1.Visible = Visible;
                dircheckBox1.Checked = false;
                seccheckBox1.Visible = Visible;
                seccheckBox1.Checked = false;
                subGroupBox.Enabled = dirListGroupBox.Enabled = secGroupBox.Enabled = false;
            }
            else if (receiptRow == "New Director/Subscriber, New Office Address")
            {
                dircheckBox1.Visible = Visible;
                dircheckBox1.Checked = false;
                offcheckBox1.Visible = Visible;
                offcheckBox1.Checked = false;
                subGroupBox.Enabled = dirListGroupBox.Enabled = offGroupBox.Enabled = false;
            }
            else if (receiptRow == "New Secretary, New Office Address")
            {
                seccheckBox1.Visible = Visible;
                seccheckBox1.Checked = false;
                offcheckBox1.Visible = Visible;
                offcheckBox1.Checked = false;
                secGroupBox.Enabled = offGroupBox.Enabled = false;
            }
            else
            {
                dircheckBox1.Visible = Visible;
                dircheckBox1.Checked = false;
                seccheckBox1.Visible = Visible;
                seccheckBox1.Checked = false;
                offcheckBox1.Visible = Visible;
                offcheckBox1.Checked = false;
                subGroupBox.Enabled = dirListGroupBox.Enabled = offGroupBox.Enabled = secGroupBox.Enabled = false;
            }
            if(dircheckBox1.Visible == Visible && seccheckBox1.Visible == Visible && offcheckBox1.Visible == Visible)
            {
                saveEntry.Enabled = false;
                clearForms.Enabled = false;
            }
            if(recGropuBox1.Enabled == false)
                recGropuBox1.Enabled = Enabled;
        }
    }
}
