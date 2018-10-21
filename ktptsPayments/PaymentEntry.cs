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
    public partial class PaymentEntry : Form
    {
        public static string UniCon = System.Configuration.ConfigurationManager.ConnectionStrings["ktptsPayments.Properties.Settings.UniConString"].ToString();

        public PaymentEntry()
        {
            InitializeComponent();
        }

        private void PaymentEntry_Load(object sender, EventArgs e)
        {           
            LoadPaidBy();
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
            txtReAmount.Focus();
            cmbAttachment.SelectedIndex = 0;
            txtRemarks.Text = "Paid with Remarks...";
            cmbPaidBy.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
        }
        public void LoadPaidBy()
        {
            try
            {
                var Qry = "SELECT TOP 10000 [ID],[Cashier]  FROM [ktptsPayments].[dbo].[Cashier]";
                var sqlCon = new SqlConnection(UniCon);
                if (sqlCon.State != ConnectionState.Open)
                {
                    sqlCon.Open();
                    var sqlcom = new SqlCommand(Qry, sqlCon);
                    sqlcom.CommandText = Qry;
                    SqlDataReader reader = sqlcom.ExecuteReader();
                    while (reader.Read())
                    {
                        this.cmbPaidBy.Items.Add(reader["Cashier"].ToString());
                        this.cmbPaidBy.ValueMember = reader["Cashier"].ToString();
                        this.cmbPaidBy.DisplayMember = reader["Cashier"].ToString();

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

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            vwGrid.DataSource=null;
            try
            {
                //string having = "cast(bg.CreatedDate as Date)='" + dtPurchase.Value.Date.ToShortDateString() + "' OR v.VoucherCode='" + txtvcode.Text.Trim() + "' OR vd.Amount='" + Convert.ToInt32(txtamount.Text.Trim()) + "' OR cast(v.PaymentDate as Date)='" + dtPayment.Value.Date.ToShortDateString() + "'";
                string db = cmbDatabase.SelectedItem.ToString();
                string prdate = dtPurchase.Value.Date.ToShortDateString();
                string pydate = dtPayment.Value.Date.ToShortDateString();
                string vcode = txtvcode.Text;
                if (cmbDatabase.SelectedItem != null)
                {

                    vwGrid.DataSource = "";
                    var da_ = new SqlDataAdapter("SELECT        "
                                                   + "SUM(vd.Amount) AS Amount,"
                                                   + "v.VoucherCode,"
                                                   + "g.GrowerName,"
                                                   + "bg.CreatedDate AS PurchaseDate, "
                                                   + "v.PaymentDate, "
                                                   + "v.VoucherID, "
                                                   + "v.GrowerID, "
                                                   + "g.FatherName, "
                                                   + "g.CNIC, "
                                                   + "g.ContactNumber,"
                                                   + "l.LocationName "
                                                   + " FROM            [" + cmbDatabase.SelectedItem + "].dbo.Voucher v INNER JOIN   "
                                                   + "                         [" + cmbDatabase.SelectedItem + "].dbo.VoucherDetail vd ON v.VoucherID = vd.VoucherId INNER JOIN  "
                                                   + "                         [" + cmbDatabase.SelectedItem + "].dbo.Grower g ON v.GrowerID = g.GrowerID INNER JOIN  "
                                                   + "                         [" + cmbDatabase.SelectedItem + "].dbo.Bale b ON b.BaleID = vd.BaleId INNER JOIN  "
                                                   + "                         [" + cmbDatabase.SelectedItem + "].dbo.BaleRegForm bg ON g.GrowerID = bg.GrowerID AND v.LotID = bg.BaleRegFormCode AND  "
                                                   + "                         v.BaleRegistrationFormID = bg.BaleRegFormID INNER JOIN  "
                                                   + "                         [" + cmbDatabase.SelectedItem + "].dbo.Location l ON bg.LocationID = l.LocationID "
                                                   + " GROUP BY v.PaymentDate, g.ContactNumber, v.GrowerID, g.CNIC, v.VoucherID, v.VoucherCode, g.GrowerName, g.FatherName,  bg.CreatedDate, l.LocationName  "
                                                   + " HAVING (CAST(bg.CreatedDate as Date)='"+ dtPurchase.Value.Date.ToShortDateString()+" ' OR v.VoucherCode='" + txtvcode.Text.Trim() + "'  OR CAST(v.PaymentDate as Date)='" + dtPayment.Value.Date.ToShortDateString()+ "') ORDER BY v.VoucherID", UniCon);
                    var dt_ = new DataTable();
                    da_.Fill(dt_);
                    this.vwGrid.DataSource = dt_;
                    vwGrid.Show();
                    vwGrid.ScrollBars = ScrollBars.Both;
                    da_.Dispose();
                    for (int i = 0; i < vwGrid.Rows.Count; i++)
                    {
                        DataGridViewRowHeaderCell cell = vwGrid.Rows[i].HeaderCell;
                        cell.Value = (i + 1).ToString();
                        vwGrid.Rows[i].HeaderCell = cell;
                    }
                    da_.Dispose();
                }
            }
            catch (Exception ex)
            {           
            }
        }

        private void vwGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (vwGrid.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
 
                string  AMOUNT=         vwGrid.SelectedRows[0].Cells[0].Value + string.Empty;
                //double amount_ = Convert.ToInt64(AMOUNT.Trim());
                txtAmount.Text = AMOUNT;
                string  VCODE=          vwGrid.SelectedRows[0].Cells[1].Value + string.Empty;
                txtVoucherCode.Text = VCODE;
                ShowPaid(VCODE);
                string  GNAME=          vwGrid.SelectedRows[0].Cells[2].Value + string.Empty;
                txtGrowerName.Text = GNAME;
                string  PURDATE=        vwGrid.SelectedRows[0].Cells[3].Value + string.Empty;
                dtPurchaseDate.Value = Convert.ToDateTime(PURDATE);
                string  PYDATE=         vwGrid.SelectedRows[0].Cells[4].Value + string.Empty;
                dtPaymentDate.Value = Convert.ToDateTime(PYDATE);
                string  VID=            vwGrid.SelectedRows[0].Cells[5].Value + string.Empty;
                txtVoucherID.Text = VID;
                string  GID=            vwGrid.SelectedRows[0].Cells[6].Value + string.Empty;
                txtGrowerID.Text = GID;
                string  FNAME=          vwGrid.SelectedRows[0].Cells[7].Value + string.Empty;
                txtFatherName.Text = FNAME;
                string  CNIC=           vwGrid.SelectedRows[0].Cells[8].Value + string.Empty;
                txtCNIC.Text = CNIC;
                string  MOBILE=         vwGrid.SelectedRows[0].Cells[9].Value + string.Empty;
                txtMobile.Text = MOBILE;
                string  LOCATION=       vwGrid.SelectedRows[0].Cells[10].Value + string.Empty;
                txtDepot.Text = LOCATION;
                txtReAmount.BackColor = Color.Red;
                txtReAmount.Focus();
            }
        }
            public  void ShowPaid(string VCode)
            {
                string Qry="SELECT * FROM [ktptsPayments].dbo.MasterPaymentRec WHERE VoucherCode='"+VCode+"'";
                var sqcon=new SqlConnection(UniCon);
                var da_=new SqlDataAdapter(Qry,sqcon);
                var dt_=new DataTable();
                da_.Fill(dt_);
                vwGridMaster.DataSource=dt_;
                da_.Dispose();                    
            }
            public void ShowPaidOverdtPayment(string dt )
            {
                string Qry = "SELECT * FROM [ktptsPayments].dbo.MasterPaymentRec WHERE cast(PaymentDate as date)='" + Convert.ToDateTime(dtPaymentDate.Value.Date.ToShortDateString()) + "'";
                var sqcon = new SqlConnection(UniCon);
                var da_ = new SqlDataAdapter(Qry, sqcon);
                var dt_ = new DataTable();
                da_.Fill(dt_);
                vwGridMaster.DataSource = dt_;
                da_.Dispose();
            }


            private void btnSave_Click(object sender, EventArgs e)
            {
                string reamount_="'"+txtReAmount.Text.Trim()+".00'";
                string Qry = "";
                try
                {                
                Qry="INSERT INTO [dbo].[MasterPaymentRec]"
                                                           +"([Depot]"
                                                           +",[PurchaseDate]"
                                                           +",[PaymentDate]"
                                                           +",[VoucherID]"
                                                           +",[VoucherCode]"
                                                           +",[GrowerID]"
                                                           +",[GrowerName]"
                                                           +",[FatherName]"
                                                           +",[CNIC]"
                                                           +",[Mobile]"
                                                           +",[Amount]"
                                                           +",[AmountPaid]"
                                                           +",[DatePaid]"
                                                           +",[PaidBy]"
                                                           +",[Status]"
                                                           +",[Remarks]"
                                                           +",[Attachment]"
                                                           +",[isDeleted])"      
                                                     +"VALUES"
                                                           +"('"+txtDepot.Text+"'"
                                                           +",'"+dtPurchase.Value.Date.ToShortDateString().ToString()+"'"
                                                           +",'"+dtPaymentDate.Value.Date.ToShortDateString().ToString()+"'"
                                                           +",'"+txtVoucherID.Text.ToString()+"'"
                                                           +",'"+txtVoucherCode.Text.Trim()+"'"
                                                           +",'"+txtGrowerID.Text.Trim().ToString()+"'"
                                                           +",'"+txtGrowerName.Text.ToUpper()+"'"
                                                           +",'"+txtFatherName.Text+"'"
                                                           +",'"+txtCNIC.Text+"'"
                                                           +",'"+txtMobile.Text+"'"
                                                           +",'"+txtAmount.Text.Trim()+"'"
                                                           +","+reamount_.Trim()
                                                           +",'"+dtDatePaid.Value.Date.ToShortDateString().ToString()+"'"
                                                           +",'"+cmbPaidBy.SelectedItem+"'"
                                                           +",'"+cmbStatus.SelectedItem+"'"
                                                           +",'"+txtRemarks.Text+"'"
                                                           + ",'"+cmbAttachment.SelectedItem+"'"
                                                           +",  'FALSE')";
                var conString00 = "Data Source=PATTERN-RECOG\\SQLEXPRESS2019;Initial Catalog=ktptsPayments; Integrated Security=True;User ID=sa;Password=mardan!1 providerName=System.Data.SqlClient providerName=System.Data.SqlClient";
                var sqlcon = new SqlConnection(UniCon);
                var sqlcom = new SqlCommand(Qry, sqlcon);
                sqlcon.Open();
                sqlcom.ExecuteNonQuery();
                MessageBox.Show("Record Inserted...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    MessageBox.Show(Qry);
                }
                ShowPaidOverdtPayment(dtPaymentDate.Value.Date.ToString());
                txtReAmount.Focus();
                txtReAmount.Text = "";
            }

            private void txtReAmount_KeyDown(object sender, KeyEventArgs e)
            {
                if (txtReAmount.Text != "")
                    if (e.KeyCode == Keys.Enter)
                    {
                        btnSave.Focus();
                         btnSave.PerformClick();
                    }
            }

            private void txtReAmount_TextChanged(object sender, EventArgs e)
            {
                string append_ = ".00";
                if (txtAmount.Text != txtReAmount.Text.Trim() + append_)
                {
                    try
                    {
                        txtReAmount.BackColor = Color.Red;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    txtReAmount.BackColor = Color.Green;
                }
            }
    }
}



