using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cac_status_checker
{
    public partial class editDirectorSubscriber : Form
    {
        ToolTip MyToolTip = new ToolTip();
        int row_index_clicked = 0;
        string global_rc = "";
        public editDirectorSubscriber()
        {
            InitializeComponent();
        }

        private void closeNewForm_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void searchRC_Click(object sender, EventArgs e)
        {
            dirsubGridView.Rows.Clear();
            dirsubGridView.Refresh();
            if (!(string.IsNullOrWhiteSpace(rcSearchBox.Text)))
            {
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
                try
                {
                    conn.Open();
                    string date = null;
                    string num = null;
                    string Query = @"SELECT C.comp_name, D.sn, name, address,";
                    Query += " type, type_of_share, number, share, D.remark, date_of_appoint FROM COMPANIES_ AS c, ";
                    Query += "DIRECTORS_ as D WHERE C.rc = D.rc AND (D.rc = '" + rcSearchBox.Text  + "' and D.rc <> '')";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    //cmd.Parameters.AddWithValue("@rc", rcSearchBox.Text);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)//Meaning at least a row of data was found from the DB
                    {
                        while (rd.Read())
                        {
                            compName.Text = rd["comp_name"].ToString();
                            Object date_ = rd["date_of_appoint"];
                            if (string.IsNullOrWhiteSpace(date_.ToString()))
                                date = "-";
                            else
                                date = rd["date_of_appoint"].ToString();

                            //Check Number for NULL Value
                            num = rd["number"].ToString();
                            string[] row = {rd["sn"].ToString(), rd["name"].ToString(), rd["address"].ToString(), rd["type"].ToString(), rd["type_of_share"].ToString(), num, rd["share"].ToString(), rd["remark"].ToString(), date };
                            dirsubGridView.Rows.Add(row);
                        }
                        conn.Close();
                        conn.Dispose();
                        subGroupBox.Enabled = dirSubGroupBox.Enabled = paymentGroupBox.Enabled = Enabled;
                        updateAllDirSub.Enabled = Enabled;
                        global_rc = rcSearchBox.Text;
                        AcceptButton = updateAllDirSub;
                    }
                    else
                    {
                        rd.Close();
                        Query = "SELECT C.comp_name, purpose FROM COMPANIES_ AS C, tblReceipts_ as R ";
                        Query += "WHERE C.rc =  R.rc and R.rc = @RC and R.rc <> ''";
                        cmd = new SqlCommand(Query, conn);
                        cmd.Parameters.AddWithValue("@rc", rcSearchBox.Text);
                        cmd.CommandType = CommandType.Text;
                        rd = cmd.ExecuteReader();
                        if (rd.HasRows)
                        {
                            string what_for = "";
                            int rows_cnt = 0;
                            int i = 0;
                            while (rd.Read())
                                rows_cnt++;
                            rd.Close();
                            rd = cmd.ExecuteReader();
                            while (rd.Read())
                            {
                                compName.Text = rd["comp_name"].ToString();
                                what_for += rd["purpose"].ToString();
                                if (i < (rows_cnt - 1))
                                {
                                    what_for += ", ";
                                }

                            }
                            MessageBox.Show("This Company was previously captured for " + what_for + ". However, no Director/Subscriber captured previosuly. Proceed and add new Directors/Subscribers please.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            rd.Close();
                            cmd.Dispose();
                            conn.Close();
                            conn.Dispose();
                            paymentGroupBox.Enabled = subGroupBox.Enabled = dirSubGroupBox.Enabled = Enabled;
                            updateAllDirSub.Enabled = Enabled;
                            AcceptButton = updateAllDirSub;
                            subscriberType.SelectedItem = subShareType.SelectedItem = subShareAllot.Text = subRemark.Text = "";
                            subscriberName.Text = subscriberAddr.Text = subPhone.Text = null;
                            global_rc = rcSearchBox.Text;
                        }
                        else
                        {
                            MessageBox.Show("This RC Number does not exist on the RMD Capture database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            rcSearchBox.Text = subscriberName.Text = subscriberAddr.Text = subPhone.Text = null;
                            subscriberType.SelectedItem = subShareType.SelectedItem = subShareAllot.Text = subRemark.Text = "";
                            paymentGroupBox.Enabled = dirSubGroupBox.Enabled = subGroupBox.Enabled = false;
                            updateAllDirSub.Enabled = false;
                            compName.Text = null;
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

        static bool DateFunc(DateTime? dt)
        {
            if (dt.HasValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void dirsubGridView_SelectionChanged(object sender, EventArgs e)
        {
            int i = dirsubGridView.CurrentCell.RowIndex;
            row_index_clicked = i;
            DataGridViewRow row = dirsubGridView.Rows[i];
            subscriberName.Text = row.Cells[1].Value.ToString();
            subscriberAddr.Text = row.Cells[2].Value.ToString();
            subscriberType.SelectedItem = row.Cells[3].Value.ToString();
            if(subscriberType.SelectedItem.ToString() == "Director"|| 
                (string.IsNullOrWhiteSpace(subscriberType.SelectedItem.ToString())))
            {
                //Disable Type of share and share allotment
                subShareType.Enabled = false;
                subShareAllot.Enabled = false;
                subShareType.SelectedItem = "";
                subShareAllot.Text = "";
            }
            else
            {//Meaning this is either a director/subscriber or subscriber
                subShareType.Enabled = Enabled;
                subShareAllot.Enabled = Enabled;
                subShareType.SelectedItem = row.Cells[4].Value.ToString();
                subShareAllot.Text = row.Cells[6].Value.ToString();
            }
            subPhone.Text = row.Cells[5].Value.ToString();
            subRemark.SelectedItem = row.Cells[7].Value.ToString();
            string tmp = row.Cells[8].Value.ToString();
            if(tmp != "-")
                subResDate.Value = Convert.ToDateTime(row.Cells[8].Value.ToString());
        }

        private void updateAllDirSub_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(rrrNumber.Text) ||
                string.IsNullOrWhiteSpace(amountPaid.Text))
            {
                MessageBox.Show("Make sure Receipt Number, Amount Paid, and Acrreditation Number are entered.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Query += "as act_date FROM tblReceipts_ WHERE receipt_no = @receipt AND purpose = 'Modification of Director/Subscriber'";
                    SqlCommand comm = new SqlCommand(Query, conn);
                    comm.Parameters.Add("@receipt", SqlDbType.NVarChar).Value = rrrNumber.Text;
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
                        int i = 0;
                        int rowsAdded = dirsubGridView.Rows.Count;
                        for (; i < dirsubGridView.Rows.Count; i++)
                        {
                            Query = "UPDATE DIRECTORS_ SET rc = @rc, name = @name, address = @address, share = @share, ";
                            Query += "number = @phone, type = @subtype, remark = @remark, type_of_share = @sharetype, ";
                            Query += "date_of_appoint = @dateappointed, last_updated = @lastUpdated, last_updated_by = @updatedBy WHERE sn = @sn";
                            comm = new SqlCommand(Query, conn);
                            comm.Parameters.Add("@sn", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colSN"].Value.ToString();
                            comm.Parameters.Add("@rc", SqlDbType.NVarChar).Value = global_rc;
                            comm.Parameters.Add("@name", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colDirSub"].Value.ToString();
                            comm.Parameters.Add("@address", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colSubAddress"].Value.ToString();
                            comm.Parameters.Add("@share", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colShareAllot"].Value.ToString();
                            comm.Parameters.Add("@phone", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colPhone"].Value.ToString();
                            comm.Parameters.Add("@subtype", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colSubType"].Value.ToString();
                            comm.Parameters.Add("@remark", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colRemark"].Value.ToString();
                            comm.Parameters.Add("@sharetype", SqlDbType.NVarChar).Value = dirsubGridView.Rows[i].Cells["colShareType"].Value.ToString();
                            comm.Parameters.Add("@dateappointed", SqlDbType.DateTime).Value = DateTime.Now;
                            if ( (dirsubGridView.Rows[i].Cells["colResDate"].Value.ToString()) != "-")
                                comm.Parameters["@dateappointed"].Value = dirsubGridView.Rows[i].Cells["colResDate"].Value.ToString();
                            comm.Parameters.Add("@lastUpdated", SqlDbType.DateTime).Value = DateTime.Now;
                            comm.Parameters.Add("@updatedBy", SqlDbType.NVarChar).Value = Program.user_name;
                            comm.ExecuteNonQuery();
                        }

                        if (i == dirsubGridView.Rows.Count)//At this stage,Director/Subscriber details are successfully updated on the database.
                        {
                            //Now Make insertion into Receipts Database
                            Query = "INSERT INTO tblReceipts_ VALUES (@rc, @receipt_no, @amount, @purpose, @presenter, @user, @when) ";
                            comm = new SqlCommand(Query, conn);
                            comm.Parameters.Add("@rc", SqlDbType.NVarChar).Value = global_rc;
                            comm.Parameters.Add("@receipt_no", SqlDbType.NVarChar).Value = rrrNumber.Text;
                            comm.Parameters.Add("@amount", SqlDbType.NVarChar).Value = amountPaid.Text;
                            comm.Parameters.Add("@purpose", SqlDbType.NVarChar).Value = "Modification of Director/Subscriber";
                            comm.Parameters.Add("@presenter", SqlDbType.NVarChar).Value = accrNumber.Text;
                            comm.Parameters.Add("@user", SqlDbType.NVarChar).Value = Program.user_name;
                            comm.Parameters.Add("@when", SqlDbType.DateTime).Value = DateTime.Now;
                            rowsAdded = comm.ExecuteNonQuery();
                            if (rowsAdded > 0)
                            {
                                MessageBox.Show("Director/Subscriber successfully updated on the database.", "Update information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                conn.Close();
                                conn.Dispose();
                                comm.Dispose();
                                rcSearchBox.Text = subscriberName.Text = subscriberAddr.Text = subPhone.Text = null;
                                subscriberType.SelectedItem = subShareType.SelectedItem = subShareAllot.Text = subRemark.Text = "";
                                rrrNumber.Text = amountPaid.Text = accrNumber.Text = presenterName.Text = null;
                                dirsubGridView.Rows.Clear();
                                dirsubGridView.Refresh();
                                dirSubGroupBox.Enabled = subGroupBox.Enabled = paymentGroupBox.Enabled = false;
                                paymentGroupBox.Enabled = false;
                                updateAllDirSub.Enabled = false;
                            }
                        }
                    }
                }
            }
        }

        private void updateDirSub_Click(object sender, EventArgs e)
        {
            //First, Check for Empty Entries in the Director/Subscriber form before proceeding
            if ((string.IsNullOrWhiteSpace(subscriberName.Text) ||
                string.IsNullOrWhiteSpace(subscriberAddr.Text) ||
                string.IsNullOrWhiteSpace(subscriberType.Text) ||
                string.IsNullOrWhiteSpace(subRemark.Text) ||
                string.IsNullOrWhiteSpace(subResDate.Text) && (subShareAllot.Enabled == false && subShareType.Enabled == false))
                ||
                ((subShareAllot.Enabled == Enabled && subShareType.Enabled == Enabled)) &&
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
                dirsubGridView.CurrentRow.Cells["colDirSub"].Value = sName;
                dirsubGridView.CurrentRow.Cells["colSubAddress"].Value = sAddress;
                dirsubGridView.CurrentRow.Cells["colSubType"].Value = sType;
                dirsubGridView.CurrentRow.Cells["colShareType"].Value = sShare;
                dirsubGridView.CurrentRow.Cells["colPhone"].Value = sPhone;
                dirsubGridView.CurrentRow.Cells["colshareAllot"].Value = sAllot;
                dirsubGridView.CurrentRow.Cells["colRemark"].Value = sRemark;
                dirsubGridView.CurrentRow.Cells["colResDate"].Value = sResDate;
                MessageBox.Show("New " + sType + " successfullyUpdated on the table. However, you need to click on the Update Director/Subscriber Button below before this entry gets committed to the Database.", "Information on " + sType + " Modified.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (subShareType.Enabled == Enabled)
                    subShareType.SelectedItem = null;
                if (subShareAllot.Enabled == Enabled)
                    subShareAllot.Text = null;
                subscriberName.Text = subscriberAddr.Text = subRemark.Text = subPhone.Text = null;
            }
        }

        private void subscriberType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subscriberType.SelectedItem.ToString() == "Director")
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

        private void editDirectorSubscriber_Load(object sender, EventArgs e)
        {
            compName.Text = null;
        }

        private void closeNewForm_MouseHover(object sender, EventArgs e)
        {
            MyToolTip.Show("Close", closeNewForm);
        }

        private void closeNewForm_MouseLeave(object sender, EventArgs e)
        {
            MyToolTip.Hide(closeNewForm);
        }

        private void rrrNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
