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
    public partial class searchEntryForm : Form
    {
        Point _imageLocation = new Point(20, 4);
        Point _imgHitArea = new Point(20, 4);
        Image closeImage;

        public searchEntryForm()
        {
            InitializeComponent();
        }

        private void searchEntryForm_Load(object sender, EventArgs e)
        {
            /*tabForms.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabForms.DrawItem += tabForms_DrawItem;
            closeImage = cac_status_checker.Properties.Resources.close;
            tabForms.Padding = new Point(20, 5);*/

            currentUser.Text = "Current User: " + Program.user_full_name;
            if (Program.access_level == "Super")
                viewToolStripMenuItem.Visible = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newEntryForm newEnt = new newEntryForm();
            newEnt.MdiParent = this;
            newEnt.Dock = DockStyle.Fill;
            //newEnt.WindowState = FormWindowState.Maximized;
            newEnt.Show();
        }

        private void editOfficeAddress_Click(object sender, EventArgs e)
        {
            editAddressForm editAddFrm = new editAddressForm();
            editAddFrm.MdiParent = this;
            editAddFrm.Dock = DockStyle.Fill;
            //editFrm.WindowState = FormWindowState.Maximized;
            editAddFrm.ShowIcon = false;
            editAddFrm.Show();
        }

        private void editSecretary_Click(object sender, EventArgs e)
        {
            editSecretaryForm editSecFrm = new editSecretaryForm();
            editSecFrm.MdiParent = this;
            editSecFrm.Dock = DockStyle.Fill;
            //editFrm.WindowState = FormWindowState.Maximized;
            editSecFrm.ShowIcon = false;
            editSecFrm.Show();
        }

        private void editDirSub_Click(object sender, EventArgs e)
        {
            editDirectorSubscriber editDirSubFrm = new editDirectorSubscriber();
            editDirSubFrm.MdiParent = this;
            editDirSubFrm.Dock = DockStyle.Fill;
            //editFrm.WindowState = FormWindowState.Maximized;
            editDirSubFrm.ShowIcon = false;
            editDirSubFrm.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changePassword changePwd = new changePassword();
            changePwd.MdiParent = this;
            changePwd.Dock = DockStyle.Fill;
            //editFrm.WindowState = FormWindowState.Maximized;
            changePwd.ShowIcon = false;
            changePwd.Show();
        }

        private void addDirSub_Click(object sender, EventArgs e)
        {
            addNewDirSub newDirSub = new addNewDirSub();
            newDirSub.MdiParent = this;
            newDirSub.Dock = DockStyle.Fill;
            //editFrm.WindowState = FormWindowState.Maximized;
            newDirSub.ShowIcon = false;
            newDirSub.Show();
        }

        private void aboutRMDCaptureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutForm = new AboutBox();
            aboutForm.Dock = DockStyle.Fill;
            //editFrm.WindowState = FormWindowState.Maximized;
            aboutForm.ShowIcon = false;
            aboutForm.ShowDialog();
        }

        private void newCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            todaysActivites tActv = new todaysActivites();
            tActv.MdiParent = this;
            tActv.Dock = DockStyle.Fill;
            //editFrm.WindowState = FormWindowState.Maximized;
            tActv.ShowIcon = false;
            tActv.Show();
        }

        private void newCompanyCapturedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activityDateBased actDateBased = new activityDateBased();
            actDateBased.MdiParent = this;
            actDateBased.Dock = DockStyle.Fill;
            //editFrm.WindowState = FormWindowState.Maximized;
            actDateBased.ShowIcon = false;
            actDateBased.Show();
        }

        private void newDirectorSubscriberCapturedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dsoToday dso = new dsoToday();
            dso.MdiParent = this;
            dso.Dock = DockStyle.Fill;
            //editFrm.WindowState = FormWindowState.Maximized;
            dso.ShowIcon = false;
            dso.Show();
        }

        private void directorsSubscribersSecretariesOfficeAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dsoDate dsoD = new dsoDate();
            dsoD.MdiParent = this;
            dsoD.Dock = DockStyle.Fill;
            //editFrm.WindowState = FormWindowState.Maximized;
            dsoD.ShowIcon = false;
            dsoD.Show();
        }

        private void searchEntryForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
                tabForms.Visible = false;
            // If no any child form, hide tabControl 
            else
            {
                this.ActiveMdiChild.WindowState =
                FormWindowState.Maximized;
                // Child form always maximized 

                // If child form is new and no has tabPage, 
                // create new tabPage 
                if (this.ActiveMdiChild.Tag == null)
                {
                    // Add a tabPage to tabControl with child 
                    // form caption 
                    TabPage tp = new TabPage(this.ActiveMdiChild
                                             .Text);
                    tp.Tag = this.ActiveMdiChild;
                    tp.Parent = tabForms;
                    tabForms.SelectedTab = tp;


                    this.ActiveMdiChild.Tag = tp;
                    this.ActiveMdiChild.FormClosed +=
                        new FormClosedEventHandler(
                                        ActiveMdiChild_FormClosed);
                }

                if (!tabForms.Visible) tabForms.Visible = true;

            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void tabForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((tabForms.SelectedTab != null) && (tabForms.SelectedTab.Tag != null))
                (tabForms.SelectedTab.Tag as Form).Select();
        }

        private void searchTaskUsingRCNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchUsingRC suID = new searchUsingRC();
            suID.MdiParent = this;
            suID.Dock = DockStyle.Fill;
            //editFrm.WindowState = FormWindowState.Maximized;
            suID.ShowIcon = false;
            suID.Show();
        }

        /*private void tabForms_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                Image img = new Bitmap(closeImage);
                Rectangle r = e.Bounds;
                r = this.tabForms.GetTabRect(e.Index);
                r.Offset(2, 2);
                Brush TitleBrush = new SolidBrush(Color.Black);
                Font f = this.Font;
                string title = this.tabForms.TabPages[e.Index].Text;
                e.Graphics.DrawString(title, f, TitleBrush, new PointF(r.X, r.Y));
                if (tabForms.SelectedIndex >= 0)
                    e.Graphics.DrawImage(img, new Point(r.X + (this.tabForms.GetTabRect(e.Index).Width - _imageLocation.X), _imageLocation.Y));
            }
            catch
            {

            }
        }*/

        /*private void tabForms_MouseClick(object sender, MouseEventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            Point p = e.Location;
            int _tabWidth = 0;
            _tabWidth = this.tabForms.GetTabRect(tabControl.SelectedIndex).Width - (_imgHitArea.X);
            Rectangle r = this.tabForms.GetTabRect(tabControl.SelectedIndex);
            r.Offset(_tabWidth, _imgHitArea.Y);
            r.Width = 16;
            r.Height = 16;
            if (tabForms.SelectedIndex >= 0)
            {
                if (r.Contains(p))
                {
                    TabPage tabPage = (TabPage)tabControl.TabPages[tabControl.SelectedIndex];
                    tabControl.TabPages.Remove(tabPage);
                }
            }
        }*/
    }
}

