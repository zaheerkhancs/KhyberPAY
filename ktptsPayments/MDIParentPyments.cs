using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ktptsPayments
{
    public partial class MDIParentPyments : Form
    {
        private int childFormNumber = 0;

        public MDIParentPyments()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            var post_dt = new PostData();
            post_dt.MdiParent = this;
            post_dt.Show();

        }

      

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var post_dt = new PaymentEntry();
            post_dt.MdiParent = this;
            post_dt.Show();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var post_dt = new CenterWisePaymentScrollRpt();
            post_dt.MdiParent = this;
            post_dt.Show();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStripSeparator6_Click(object sender, EventArgs e)
        {

        }

        private void cashierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var post_dt = new DepotCashier();
            post_dt.MdiParent = this;
            post_dt.Show();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var post_dt = new PaymentScroll();
            post_dt.MdiParent = this;
            post_dt.Show();

        }

        private void pendencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var post_dt = new PaymentPendency();
            post_dt.MdiParent = this;
            post_dt.Show();
        }

        private void loginPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var post_dt = new Login();
            post_dt.MdiParent = this;
            post_dt.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
