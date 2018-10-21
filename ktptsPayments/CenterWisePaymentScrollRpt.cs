using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
namespace ktptsPayments
{
    public partial class CenterWisePaymentScrollRpt : Form
    {
        public static string UniCon = System.Configuration.ConfigurationManager.ConnectionStrings["ktptsPayments.Properties.Settings.UniConString"].ToString();

        public CenterWisePaymentScrollRpt()
        {
            InitializeComponent();
        }

        private void PaymentScrollRpt_Load(object sender, EventArgs e)
        {
            try
            {
                var Qry = "SELECT  distinct depot from MasterPaymentRec";
                var sqlCon = new SqlConnection(UniCon);
                if (sqlCon.State != ConnectionState.Open)
                {
                    sqlCon.Open();
                    var sqlcom = new SqlCommand(Qry, sqlCon);
                    sqlcom.CommandText = Qry;
                    SqlDataReader reader = sqlcom.ExecuteReader();
                    while (reader.Read())
                    {
                        this.cmbDatabase.Items.Add(reader["depot"].ToString());
                        this.cmbDatabase.ValueMember = reader["depot"].ToString();
                        this.cmbDatabase.DisplayMember = reader["depot"].ToString();
                    }
                    sqlCon.Close();
                    reader.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message.ToString());
            }
            finally
            {

            }
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.getPaymentReportBindingSource.DataSource = getPaymentReportBindingSource(dtPurchase.Value.Date.ToString, dtPurchase.Value.Date.ToShortDateString, this.cmbDatabase.SelectedItem);
            ShowReport();
        }
        private void ShowReport()
        {
            this.reportViewer1.Reset();
            DataTable dt = GetData();
            ReportDataSource rds = new ReportDataSource("dsCWPayment", dt);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.ReportPath = "rptcwPayment.rdlc";
            
            ReportParameter[] rptparam = new ReportParameter[]
            {
                new ReportParameter("purdate",dtPurchase.Value.Date.ToShortDateString()),
                new ReportParameter("pydate",dtPayment.Value.Date.ToShortDateString()),
                new ReportParameter ("depot",cmbDatabase.SelectedItem.ToString())
            };
            reportViewer1.LocalReport.SetParameters(rptparam);
            
            this.reportViewer1.Refresh();
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }
        public DataTable GetDataVIASELECT()
        {
            DataTable dt_ = new DataTable();
            SqlConnection sqlcon = new SqlConnection(UniCon);            {
                var da_ = new SqlDataAdapter("SELECT "        
                                                +"Depot, "
                                                +"PurchaseDate," 
                                                +"PaymentDate, "
                                                +"VoucherCode, "
                                                +"GrowerName, "
                                                +"CNIC, "
                                                +"Mobile," 
                                                +"Amount, "
                                                +"AmountPaid," 
                                                +"DatePaid, "
                                                +"PaidBy, "
                                                +"Status, "
                                                +"Remarks, "
                                                +"Attachment "
                                                  +"   FROM   "         
                                                    +" MasterPaymentRec " 
                                                    +" GROUP BY Depot, PurchaseDate, PaymentDate, VoucherCode, GrowerName, CNIC, Mobile, Amount, "
                                                    +" AmountPaid, DatePaid, PaidBy, Status, Remarks, Attachment "
                                                    + " having ((PurchaseDate = '"+dtPurchase.Value.Date.ToShortDateString()+"') OR (PaymentDate = '"+dtPayment.Value.Date.ToShortDateString()+"')) AND (Depot ='"+cmbDatabase.SelectedItem+"')"
                                                    +" ORDER BY PaymentDate",sqlcon);
                da_.Fill(dt_);
                da_.Dispose();
            }
            return dt_;
        }

        public DataTable GetData()
        {
            DataTable dt_ = new DataTable();
            using (SqlConnection sqlcon = new SqlConnection(UniCon))
            {
                SqlCommand sqlcom = new SqlCommand("GetPaymentReport", sqlcon);
                sqlcom.CommandType = CommandType.StoredProcedure;
                sqlcom.Parameters.AddWithValue("@purdate",Convert.ToDateTime(dtPurchase.Value.Date.ToShortDateString()));
                sqlcom.Parameters.AddWithValue("@pydate",Convert.ToDateTime(dtPayment.Value.Date.ToShortDateString()));
                sqlcom.Parameters.AddWithValue("@depot",cmbDatabase.SelectedItem.ToString());
                var da_ = new SqlDataAdapter(sqlcom);
                da_.Fill(dt_);
                return dt_;
            }            
        }
    }
}
