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
    public partial class PaymentScroll : Form
    {
        public PaymentScroll()
        {
            InitializeComponent();
        }

        private void PaymentScroll_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ktptsPaymentsDataSet.vwPaymentScroll' table. You can move, or remove it, as needed.
            this.vwPaymentScrollTableAdapter.Fill(this.ktptsPaymentsDataSet.vwPaymentScroll);

            this.reportViewer1.RefreshReport();
        }
    }
}
