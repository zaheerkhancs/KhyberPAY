using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ktptsPayments
{
    public partial class PaymentPendency : Form
    {
        public static string UniCon = System.Configuration.ConfigurationManager.ConnectionStrings["ktptsPayments.Properties.Settings.UniConString"].ToString();
        public PaymentPendency()
        {
            InitializeComponent();
        }
        private DataTable Getdt()
        {
            DataTable dt_ = new DataTable();
            try
            {
                var da = new SqlDataAdapter("SELECT      l.LocationName AS Depot,"
                                                        + "bg.CreatedDate AS PurchaseDate, "
                                                        + "cast(v.PaymentDate as date) as PaymentDate ,"
                                                        + "COUNT(distinct v.VoucherID) AS VCount, "
                                                        + "SUM(CAST(vd.Amount AS int)) AS Amount,"
                                                        + "COUNT(vd.BaleId) AS BaleCount, "
                                                        + "SUM(vd.Weight) AS Weight "

                                                    + " FROM            dbo.Location l INNER JOIN "
                                                    + "                        ["+cmbDatabase.SelectedItem+"].dbo.BaleRegForm bg ON l.LocationID = bg.LocationID INNER JOIN "
                                                    + "                       ["+cmbDatabase.SelectedItem+"].dbo.Voucher v ON bg.BaleRegFormID = v.BaleRegistrationFormID INNER JOIN "
                                                    + "                      [" + cmbDatabase.SelectedItem + "].dbo.VoucherDetail vd ON vd.VoucherId = v.VoucherID "
                                                    + " GROUP BY bg.CreatedDate, v.PaymentDate, l.LocationName "
                                                    + " having bg.CreatedDate between '"+dtr1.Value.Date.ToShortDateString()+"' and '"+dtr2.Value.Date.ToShortDateString()+"'", new SqlConnection(UniCon));
                da.Fill(dt_);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt_;

        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {

            if (dtr2.Value.Date > dtr1.Value.Date)
            {
                vwGrid.DataSource = Getdt();
                try
                {
                    for (int i = 0; i < vwGridUnpaid.Rows.Count; i++)
                    {
                        DataGridViewRowHeaderCell cell = vwGrid.Rows[i].HeaderCell;
                        cell.Value = (i + 1).ToString();
                        vwGrid.Rows[i].HeaderCell = cell;
                    }
                    vwGrid.AutoResizeColumns();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Revise Date Selection...");
            }
        }
        
        public void GetDbs()
        {
            try
            {
                var Qry = "SELECT name FROM master.dbo.sysdatabases";
                var sqlCon = new SqlConnection(UniCon);
                if (sqlCon.State != ConnectionState.Open)
                {
                    sqlCon.Open();
                    var sqlcom = new SqlCommand(Qry, sqlCon);
                    sqlcom.CommandText = Qry;
                    SqlDataReader reader = sqlcom.ExecuteReader();
                    while (reader.Read())
                    {
                        this.cmbDatabase.Items.Add(reader["Name"].ToString());
                        this.cmbDatabase.ValueMember = reader["name"].ToString();
                        this.cmbDatabase.DisplayMember = reader["name"].ToString();
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
        }
        private void PaymentPendency_Load(object sender, EventArgs e)
        {
            GetDbs();
        }

        private void ShowPaid(string depot_, string prdate_, string pydate_)
        {
           DataTable dt_=new DataTable();
           try
           {

               var da_ = new SqlDataAdapter("SELECT "
                                               + "Depot, PurchaseDate, "
                                               + "PaymentDate, VCount, "
                                               + "Amount, Amount_Paid, "
                                               + "DatePaid, Status, Remarks "
                                               + " FROM vwPaid001 "
                                               + " WHERE   (cast(PurchaseDate as datetime) = '" + Convert.ToDateTime(prdate_) + "' OR (cast(PaymentDate as datetime) = '" + Convert.ToDateTime(pydate_) +"' )) AND Depot = '"+depot_+"'", new SqlConnection(UniCon));
               da_.Fill(dt_);
               vwGridPaid.DataSource = dt_;
               for (int i = 0; i < vwGridPaid.Rows.Count; i++)
               {
                   DataGridViewRowHeaderCell cell = vwGridPaid.Rows[i].HeaderCell;
                   cell.Value = (i + 1).ToString();
                   vwGridPaid.Rows[i].HeaderCell = cell;
               }
               int sumPaid = 0;
               int sumPaidBy = 0;
               int sumVcount = 0;
               foreach (DataRow row_ in dt_.Rows)
               {
                   sumPaid+=Convert.ToInt32(row_["Amount"]);
                   sumPaidBy += Convert.ToInt32(row_["Amount_Paid"]);
                   sumVcount += Convert.ToInt32(row_["VCount"]);
               }
               txtAmountP.Text = sumPaid.ToString();
               txtAmountPaidP.Text = sumPaidBy.ToString();
               txtNoVp.Text = sumVcount.ToString();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           } 
        }
        private void ShowUnpaid(string _depot, string _prdate, string _pydate)
        {
            DataTable dt_ = new DataTable();
            try
            {
                var da2 = new SqlDataAdapter("SELECT			v.VoucherCode, "
				                                           +" bg.CreatedDate AS PurchaseDate,  "
				                                            +" v.PaymentDate,  "
				                                            +" SUM(vd.Weight) AS Weight,  "
				                                            +" SUM(vd.Amount) AS Amount,  "
				                                            +" g.GrowerName AS Name,  "
				                                            +" g.ContactNumber AS Mobile, " 
				                                            +" g.CNIC,  "
				                                            +" l.LocationName AS Depot   "
                                            +" FROM  "
                                            +" ["+cmbDatabase.SelectedItem+"].dbo.Voucher v INNER JOIN "
                                            +" ["+cmbDatabase.SelectedItem+"].dbo.BaleRegForm bg ON v.BaleRegistrationFormID = bg.BaleRegFormID INNER JOIN "
                                            +" ["+cmbDatabase.SelectedItem+"].dbo.VoucherDetail vd ON v.VoucherID = vd.VoucherId INNER JOIN  "
                                            +" ["+cmbDatabase.SelectedItem+"].dbo.Grower g ON v.GrowerID = g.GrowerID INNER JOIN  "
                                            +" ["+cmbDatabase.SelectedItem+"].dbo.Location l ON bg.LocationID = l.LocationID   "
                                            +" GROUP BY  "
                                            +" v.VoucherCode,  "
                                            +" bg.CreatedDate,  "
                                            +" v.PaymentDate,  "
                                            +" g.GrowerName,  "
                                            +" g.FatherName,  "
                                            +" g.ContactNumber, " 
                                            +" g.CNIC,  "
                                            +" l.LocationName,  "
                                            +" v.VoucherID   "
                                            +" HAVING   "      
                                            +" (l.LocationName = '" + _depot + "') AND  "
                                            +" ((bg.CreatedDate ='" + Convert.ToDateTime(_prdate) + "') AND  "
                                            +" (v.PaymentDate ='" + Convert.ToDateTime(_pydate) + "')) AND  "
                                            +" (v.VoucherID not in ( "
                                            +" SELECT mrc.VoucherID  "
                                            +" FROM [ktptsPayments].dbo.MasterPaymentRec mrc  "
                                            +" WHERE PurchaseDate='" + Convert.ToDateTime(_prdate) + "' AND  "
                                            +" PaymentDate='" + Convert.ToDateTime(_pydate) + "' AND Depot='" + _depot + "'))  "
                                            +" ORDER BY v.VoucherID ",new SqlConnection(UniCon));
                da2.Fill(dt_);
                vwGridUnpaid.DataSource = dt_;
                for (int i = 0; i < vwGridUnpaid.Rows.Count; i++)
                {
                    DataGridViewRowHeaderCell cell = vwGridUnpaid.Rows[i].HeaderCell;
                    cell.Value = (i + 1).ToString();
                    vwGridUnpaid.Rows[i].HeaderCell = cell;
                }
               // populating text boxes
               int sumPaid = 0;
               foreach (DataRow row_ in dt_.Rows)
               {
                   sumPaid+=Convert.ToInt32(row_["Amount"]);
               }
               txtNoVoucherUnpid.Text = dt_.Rows.Count.ToString();
               txtAmountUnp.Text = sumPaid.ToString();
               txtAmountPaidUnp.Text = sumPaid.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void vwGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (vwGrid.SelectedRows.Count > 0) // make sure user select at least 1 row 
                {

                    string depot = vwGrid.SelectedRows[0].Cells[0].Value + string.Empty;
                    string prdate = vwGrid.SelectedRows[0].Cells[1].Value + string.Empty;
                    string pydate = vwGrid.SelectedRows[0].Cells[2].Value + string.Empty;
                    string vcount = vwGrid.SelectedRows[0].Cells[3].Value + string.Empty;
                    string amount = vwGrid.SelectedRows[0].Cells[4].Value + string.Empty;
                    //
                    txtPurdateP.Text = prdate;
                    txtPaydateP.Text = pydate;
                    txtPurdateUnp.Text = prdate;
                    txtPaydateUnp.Text = pydate;
                    txtDepotP.Text = depot;
                    txtDepotUnp.Text = depot;
                    //

                    ShowPaid(depot, prdate, pydate);
                    ShowUnpaid(depot, prdate, pydate);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
