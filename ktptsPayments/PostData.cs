using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace ktptsPayments
{
    public partial class PostData : Form
    {
        public static string UniCon = System.Configuration.ConfigurationManager.ConnectionStrings["ktptsPayments.Properties.Settings.UniConString"].ToString();

        public PostData()
        {
            InitializeComponent();
        }

        private void PostData_Load(object sender, EventArgs e)
        {
            var conString = "Data Source=PATTERN-RECOG\\sqlexpress2015;Initial Catalog=AMD-2016; Integrated Security=True;User ID=ktc;Password=mardan!1 providerName=System.Data.SqlClient providerName=System.Data.SqlClient";
            var conString00 = "Data Source=PATTERN-RECOG\\SQLEXPRESS2019;Initial Catalog=master; Integrated Security=True;User ID=sa;Password=mardan!1 providerName=System.Data.SqlClient providerName=System.Data.SqlClient";
        

            try
            {
                var Qry = "SELECT name FROM master.dbo.sysdatabases order by name";
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var conString00 = "Data Source=PATTERN-RECOG\\SQLEXPRESS2019;Initial Catalog=ktptsPayments; Integrated Security=True;User ID=sa;Password=mardan!1 providerName=System.Data.SqlClient providerName=System.Data.SqlClient";

            string truncate_ = "TRUNCATE TABLE BALE";
            string idInsertOn = "SET IDENTITY_INSERT BALE ON";
            string idInsertOff = "SET IDENTITY_INSERT BALE OFF";

            string query = "INSERT INTO BALE (BaleID, Weight, Grade, Subgrade,Rate, GrowerID,Date, LotCode, BaleIDPK, BaleRegistrationFormID,Status,ReclassifiedSubgrade,ReclassifiedRate, ReclassifiedGrade, IsOrphanBale, IsReClassifiedExported)"
                            + "SELECT BaleID, Weight, Grade, Subgrade,Rate, GrowerID, Date, LotCode,BaleIDPK, BaleRegistrationFormID,Status,ReclassifiedSubgrade,ReclassifiedRate, ReclassifiedGrade, IsOrphanBale,IsReClassifiedExported "
                            + "FROM [" + this.cmbDatabase.SelectedItem.ToString() + "].dbo.Bale";

            try
            {
                int count = 0;
                // string Qry="exec spPostBale "+"'"+this.cmbDatabase.SelectedItem.ToString()+"'";
                var sqlCon = new SqlConnection(conString00);
                if (sqlCon.State != ConnectionState.Open)
                {
                    sqlCon.Open();
                    //var sqlComTruncate = new SqlCommand(truncate_, sqlCon);
                    //sqlComTruncate.ExecuteNonQuery();
                    var sqlcomidInsertOn = new SqlCommand(idInsertOn, sqlCon);
                    var sqlcomidInsertOff = new SqlCommand(idInsertOff, sqlCon);
                    var sqlcomquery = new SqlCommand(query, sqlCon);
                    sqlcomidInsertOn.ExecuteNonQuery().ToString();
                    string result = sqlcomquery.ExecuteNonQuery().ToString();
                    sqlcomidInsertOff.ExecuteNonQuery().ToString();
                    sqlCon.Close();
                    MessageBox.Show(lblBale.Text + " Records Inserted...");
                    //reader.Dispose();
                    sqlCon.Close();
                    DataTable dt_ = new DataTable();
                    SqlDataAdapter da_ = new SqlDataAdapter("SELECT * FROM BALE order by baleidPk desc", sqlCon);
                    da_.Fill(dt_);
                    this.vwGridView.DataSource = dt_;
                    vwGridView.Show();
                    vwGridView.ScrollBars = ScrollBars.Both;
                    da_.Dispose();
                    for (int i = 0; i < vwGridView.Rows.Count; i++)
                    {
                        DataGridViewRowHeaderCell cell = vwGridView.Rows[i].HeaderCell;
                        cell.Value = (i + 1).ToString();
                        vwGridView.Rows[i].HeaderCell = cell;
                    }
                    this.btnBalePost.BackColor = Color.Green;
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

        private void button3_Click(object sender, EventArgs e)
        {
            var conString00 = "Data Source=PATTERN-RECOG\\SQLEXPRESS2019;Initial Catalog=ktptsPayments; Integrated Security=True;User ID=sa;Password=mardan!1 providerName=System.Data.SqlClient providerName=System.Data.SqlClient";

            string trncateBaleReg = "Truncate Table BaleRegForm";
            string idInsertOn = "SET IDENTITY_INSERT BaleRegForm ON";
            string idInsertOff = "SET IDENTITY_INSERT BaleRegForm OFF";

            string query = "INSERT INTO BaleRegForm (BaleRegFormID, BaleRegFormCode, CreatedDate, BaleRegFormStatus, LocationID, GrowerID)"
                            + "SELECT BaleRegFormID, BaleRegFormCode, CreatedDate, BaleRegFormStatus, LocationID, GrowerID"
                            + " FROM    [" + this.cmbDatabase.SelectedItem.ToString() + "].dbo.BaleRegForm ";


            try
            {
                int count = 0;
                // string Qry="exec spPostBale "+"'"+this.cmbDatabase.SelectedItem.ToString()+"'";
                var sqlCon = new SqlConnection(conString00);
                if (sqlCon.State != ConnectionState.Open)
                {
                    sqlCon.Open();
                   // var sqlcmdTrncate = new SqlCommand(trncateBaleReg, sqlCon);
                    //sqlcmdTrncate.ExecuteNonQuery();
                    var sqlcomidInsertOn = new SqlCommand(idInsertOn, sqlCon);
                    var sqlcomidInsertOff = new SqlCommand(idInsertOff, sqlCon);
                    var sqlcomquery = new SqlCommand(query, sqlCon);
                    sqlcomidInsertOn.ExecuteNonQuery().ToString();
                    string result = sqlcomquery.ExecuteNonQuery().ToString();
                    sqlcomidInsertOff.ExecuteNonQuery().ToString();
                    sqlCon.Close();
                    MessageBox.Show(lblBaleRegform.Text + " Records Inserted...");
                    //reader.Dispose();
                    sqlCon.Close();
                    DataTable dt_ = new DataTable();
                    SqlDataAdapter da_ = new SqlDataAdapter("SELECT * FROM BaleRegForm order by BaleregformID desc", sqlCon);
                    da_.Fill(dt_);
                    this.vwGridView.DataSource = dt_;
                    vwGridView.Show();
                    vwGridView.ScrollBars = ScrollBars.Both;
                    da_.Dispose();
                    for (int i = 0; i < vwGridView.Rows.Count; i++)
                    {
                        DataGridViewRowHeaderCell cell = vwGridView.Rows[i].HeaderCell;
                        cell.Value = (i + 1).ToString();
                        vwGridView.Rows[i].HeaderCell = cell;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message.ToString());
            }
            finally
            {

            }
            btnBaleRegFormPost.BackColor = Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var conString00 = "Data Source=PATTERN-RECOG\\SQLEXPRESS2019;Initial Catalog=ktptsPayments; Integrated Security=True;User ID=sa;Password=mardan!1 providerName=System.Data.SqlClient providerName=System.Data.SqlClient";

            string sqlcmdTruncate = "Truncate Table Grower";
            string idInsertOn = "SET IDENTITY_INSERT Grower ON";
            string idInsertOff = "SET IDENTITY_INSERT Grower OFF";

            string query = "INSERT INTO Grower (GrowerID, GrowerName, FatherName, Location, Address, ContactNumber, CNIC, GrowerCode, CaretakerID, Active_Ind, GrowerMaxWeightLimit)"
                            + "SELECT GrowerID, GrowerName, FatherName, Location, Address, ContactNumber, CNIC, GrowerCode, CaretakerID, Active_Ind, GrowerMaxWeightLimit "
                            + "FROM [" + this.cmbDatabase.SelectedItem.ToString() + "].dbo.Grower";


            try
            {
                int count = 0;
                // string Qry="exec spPostBale "+"'"+this.cmbDatabase.SelectedItem.ToString()+"'";
                var sqlCon = new SqlConnection(conString00);
                if (sqlCon.State != ConnectionState.Open)
                {
                    sqlCon.Open();
                   // var sqlcmdTruncateGrower = new SqlCommand(sqlcmdTruncate, sqlCon);
                   // sqlcmdTruncateGrower.ExecuteNonQuery();
                    var sqlcomidInsertOn = new SqlCommand(idInsertOn, sqlCon);
                    var sqlcomidInsertOff = new SqlCommand(idInsertOff, sqlCon);
                    var sqlcomquery = new SqlCommand(query, sqlCon);
                    sqlcomidInsertOn.ExecuteNonQuery().ToString();
                    string result = sqlcomquery.ExecuteNonQuery().ToString();
                    sqlcomidInsertOff.ExecuteNonQuery().ToString();
                    sqlCon.Close();
                    MessageBox.Show(lblGrower.Text + "Records Inserted....");
                    //reader.Dispose();
                    sqlCon.Close();
                    DataTable dt_ = new DataTable();
                    SqlDataAdapter da_ = new SqlDataAdapter("SELECT * FROM Grower order by growerid desc", sqlCon);
                    da_.Fill(dt_);
                    this.vwGridView.DataSource = dt_;
                    vwGridView.Show();
                    vwGridView.ScrollBars = ScrollBars.Both;
                    da_.Dispose();
                    for (int i = 0; i < vwGridView.Rows.Count; i++)
                    {
                        DataGridViewRowHeaderCell cell = vwGridView.Rows[i].HeaderCell;
                        cell.Value = (i + 1).ToString();
                        vwGridView.Rows[i].HeaderCell = cell;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message.ToString());
            }
            finally
            {

            }
            btnPostGrower.BackColor = Color.Green;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var conString00 = "Data Source=PATTERN-RECOG\\SQLEXPRESS2019;Initial Catalog=ktptsPayments; Integrated Security=True;User ID=sa;Password=mardan!1 providerName=System.Data.SqlClient providerName=System.Data.SqlClient";
            string sqlcmdTruncateVDetail = "Truncate Table VoucherDetail";
            string idInsertOn = "SET IDENTITY_INSERT VoucherDetail ON";
            string idInsertOff = "SET IDENTITY_INSERT VoucherDetail OFF";

            string query = "INSERT INTO VoucherDetail (VoucherDetailId, VoucherId, BaleId, GradeId, Rate, Weight, Amount)"
                            + "SELECT VoucherDetailId, VoucherId, BaleId, GradeId, Rate, Weight, Amount "
                            + "FROM [" + this.cmbDatabase.SelectedItem.ToString() + "].dbo.VoucherDetail ";
            try
            {
                int count = 0;
                // string Qry="exec spPostBale "+"'"+this.cmbDatabase.SelectedItem.ToString()+"'";
                var sqlCon = new SqlConnection(conString00);
                if (sqlCon.State != ConnectionState.Open)
                {
                    sqlCon.Open();
                   // var sqlcmTruncatVD = new SqlCommand(sqlcmdTruncateVDetail, sqlCon);
                    //sqlcmTruncatVD.ExecuteNonQuery();
                    var sqlcomidInsertOn = new SqlCommand(idInsertOn, sqlCon);
                    var sqlcomidInsertOff = new SqlCommand(idInsertOff, sqlCon);
                    var sqlcomquery = new SqlCommand(query, sqlCon);
                    sqlcomidInsertOn.ExecuteNonQuery().ToString();
                    string result = sqlcomquery.ExecuteNonQuery().ToString();
                    sqlcomidInsertOff.ExecuteNonQuery().ToString();
                    sqlCon.Close();
                    MessageBox.Show(lblVoucherDetails.Text + "Records Inserted...");
                    //reader.Dispose();
                    sqlCon.Close();
                    DataTable dt_ = new DataTable();
                    SqlDataAdapter da_ = new SqlDataAdapter("SELECT * FROM VoucherDetail order by voucherdetailid desc", sqlCon);
                    da_.Fill(dt_);
                    this.vwGridView.DataSource = dt_;
                    vwGridView.Show();
                    vwGridView.ScrollBars = ScrollBars.Both;
                    da_.Dispose();
                    for (int i = 0; i < vwGridView.Rows.Count; i++)
                    {
                        DataGridViewRowHeaderCell cell = vwGridView.Rows[i].HeaderCell;
                        cell.Value = (i + 1).ToString();
                        vwGridView.Rows[i].HeaderCell = cell;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message.ToString());
            }
            finally
            {

            }
            btnPostVDetails.BackColor = Color.Green;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var conString00 = "Data Source=PATTERN-RECOG\\SQLEXPRESS2019;Initial Catalog=ktptsPayments; Integrated Security=True;User ID=sa;Password=mardan!1 providerName=System.Data.SqlClient providerName=System.Data.SqlClient";

            string sqlTruncateVoucher = "Truncate Table Voucher";
            string idInsertOn = "SET IDENTITY_INSERT Voucher ON";
            string idInsertOff = "SET IDENTITY_INSERT Voucher OFF";

            string query = "INSERT INTO Voucher (VoucherID, Amount, OriginalPrintStatus, DuplicatePrintStatus, VoucherCode, LotID, BaleRegistrationFormID, GrowerID, PaymentDate, IsPrintedPayment, IsPrintedBank, status, IsPrintedMandi, PaymentMode, CancelationReason)"
                                       + "SELECT VoucherID, Amount, OriginalPrintStatus, DuplicatePrintStatus, VoucherCode, LotID, BaleRegistrationFormID, GrowerID, PaymentDate, IsPrintedPayment, IsPrintedBank, status, IsPrintedMandi, PaymentMode, CancelationReason   FROM   [" + this.cmbDatabase.SelectedItem.ToString() + "].dbo.Voucher";
            try
            {
                int count = 0;
                // string Qry="exec spPostBale "+"'"+this.cmbDatabase.SelectedItem.ToString()+"'";
                var sqlCon = new SqlConnection(conString00);
                if (sqlCon.State != ConnectionState.Open)
                {
                    sqlCon.Open();
                   // var sqlcmdVoucher = new SqlCommand(sqlTruncateVoucher, sqlCon);
                  //  sqlcmdVoucher.ExecuteNonQuery();
                    var sqlcomidInsertOn = new SqlCommand(idInsertOn, sqlCon);
                    var sqlcomidInsertOff = new SqlCommand(idInsertOff, sqlCon);
                    var sqlcomquery = new SqlCommand(query, sqlCon);
                    sqlcomidInsertOn.ExecuteNonQuery().ToString();
                    string result = sqlcomquery.ExecuteNonQuery().ToString();
                    sqlcomidInsertOff.ExecuteNonQuery().ToString();
                    sqlCon.Close();
                    MessageBox.Show(lblVoucher.Text + ". Records Inserted....");
                    //reader.Dispose();
                    sqlCon.Close();
                    DataTable dt_ = new DataTable();
                    SqlDataAdapter da_ = new SqlDataAdapter("SELECT * FROM voucher", sqlCon);
                    da_.Fill(dt_);
                    this.vwGridView.DataSource = dt_;
                    vwGridView.Show();
                    vwGridView.ScrollBars = ScrollBars.Both;
                    da_.Dispose();
                    for (int i = 0; i < vwGridView.Rows.Count; i++)
                    {
                        DataGridViewRowHeaderCell cell = vwGridView.Rows[i].HeaderCell;
                        cell.Value = (i + 1).ToString();
                        vwGridView.Rows[i].HeaderCell = cell;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message.ToString());
            }
            finally
            {

            }
            btnPostVoucher.BackColor = Color.Green;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var conString00 = "Data Source=PATTERN-RECOG\\SQLEXPRESS2019;Initial Catalog=ktptsPayments; Integrated Security=True;User ID=sa;Password=mardan!1 providerName=System.Data.SqlClient providerName=System.Data.SqlClient";
            var UniCon = System.Configuration.ConfigurationManager.ConnectionStrings["ktptsPayments.Properties.Settings.UniConString"].ToString();
            try
            {
                if (cmbDatabase.SelectedItem != null)
                {
                    int count = 0;
                    string Qry = "SELECT COUNT(*) AS COUNT_ FROM [" + this.cmbDatabase.SelectedItem.ToString() + "].dbo.Bale";
                    var sqlCon = new SqlConnection(UniCon);
                    if (sqlCon.State != ConnectionState.Open)
                    {
                        sqlCon.Open();
                        var sqlcomidInsertOn = new SqlCommand(Qry, sqlCon);
                        SqlDataReader reader_ = sqlcomidInsertOn.ExecuteReader();
                        while (reader_.Read())
                        {
                            lblBale.Text = reader_["count_"].ToString() + ". Records...";
                        }
                        sqlCon.Close();
                        reader_.Dispose();
                        sqlCon.Close();
                    }
                }
                else
                    lblBale.Text = " . Records ...";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var conString00 = "Data Source=PATTERN-RECOG\\SQLEXPRESS2019;Initial Catalog=ktptsPayments; Integrated Security=True;User ID=sa;Password=mardan!1 providerName=System.Data.SqlClient providerName=System.Data.SqlClient";
            try
            {
                if (cmbDatabase.SelectedItem != null)
                {
                    int count = 0;
                    string Qry = "SELECT COUNT(*) AS COUNT_ FROM [" + this.cmbDatabase.SelectedItem.ToString() + "].dbo.BaleRegForm";
                    var sqlCon = new SqlConnection(UniCon);
                    if (sqlCon.State != ConnectionState.Open)
                    {
                        sqlCon.Open();
                        var sqlcomidInsertOn = new SqlCommand(Qry, sqlCon);
                        SqlDataReader reader_ = sqlcomidInsertOn.ExecuteReader();
                        while (reader_.Read())
                        {
                            lblBaleRegform.Text = reader_["count_"].ToString() + ". Records....";
                        }
                        sqlCon.Close();
                        reader_.Dispose();
                        sqlCon.Close();
                    }
                }
                else
                    lblBale.Text = " . Records...";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message.ToString());
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var conString00 = "Data Source=PATTERN-RECOG\\SQLEXPRESS2019;Initial Catalog=ktptsPayments; Integrated Security=True;User ID=sa;Password=mardan!1 providerName=System.Data.SqlClient providerName=System.Data.SqlClient";
            try
            {
                if (cmbDatabase.SelectedItem != null)
                {
                    int count = 0;
                    string Qry = "SELECT COUNT(*) AS COUNT_ FROM [" + this.cmbDatabase.SelectedItem.ToString() + "].dbo.Grower";
                    var sqlCon = new SqlConnection(UniCon);
                    if (sqlCon.State != ConnectionState.Open)
                    {
                        sqlCon.Open();
                        var sqlcomidInsertOn = new SqlCommand(Qry, sqlCon);
                        SqlDataReader reader_ = sqlcomidInsertOn.ExecuteReader();
                        while (reader_.Read())
                        {
                            this.lblGrower.Text = reader_["count_"].ToString() + ". Records....";
                        }
                        sqlCon.Close();
                        reader_.Dispose();
                        sqlCon.Close();
                    }
                }
                else
                    lblBale.Text = " . Records ...";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message.ToString());
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var conString00 = "Data Source=PATTERN-RECOG\\SQLEXPRESS2019;Initial Catalog=ktptsPayments; Integrated Security=True;User ID=sa;Password=mardan!1 providerName=System.Data.SqlClient providerName=System.Data.SqlClient";
            try
            {
                if (cmbDatabase.SelectedItem != null)
                {
                    int count = 0;
                    string Qry = "SELECT COUNT(*) AS COUNT_ FROM [" + this.cmbDatabase.SelectedItem.ToString() + "].dbo.VoucherDetail";
                    var sqlCon = new SqlConnection(UniCon);
                    if (sqlCon.State != ConnectionState.Open)
                    {
                        sqlCon.Open();
                        var sqlcomidInsertOn = new SqlCommand(Qry, sqlCon);
                        SqlDataReader reader_ = sqlcomidInsertOn.ExecuteReader();
                        while (reader_.Read())
                        {
                            lblVoucherDetails.Text = reader_["count_"].ToString() + ". Records....";
                        }
                        sqlCon.Close();
                        reader_.Dispose();
                        sqlCon.Close();
                    }
                }
                else
                    lblBale.Text = " .  Records...";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message.ToString());
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var conString00 = "Data Source=PATTERN-RECOG\\SQLEXPRESS2019;Initial Catalog=ktptsPayments; Integrated Security=True;User ID=sa;Password=mardan!1 providerName=System.Data.SqlClient providerName=System.Data.SqlClient";
            try
            {
                if (cmbDatabase.SelectedItem != null)
                {
                    int count = 0;
                    string Qry = "SELECT COUNT(*) AS COUNT_ FROM [" + this.cmbDatabase.SelectedItem.ToString() + "].dbo.Voucher";
                    var sqlCon = new SqlConnection(UniCon);
                    if (sqlCon.State != ConnectionState.Open)
                    {
                        sqlCon.Open();
                        var sqlcomidInsertOn = new SqlCommand(Qry, sqlCon);
                        SqlDataReader reader_ = sqlcomidInsertOn.ExecuteReader();
                        while (reader_.Read())
                        {
                            lblVoucher.Text = reader_["count_"].ToString() + ". Records....";
                        }
                        sqlCon.Close();
                        reader_.Dispose();
                        sqlCon.Close();
                    }
                }
                else
                    lblBale.Text = " . Records...";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message.ToString());
            }
        }

        private void btnshowcompany_Click(object sender, EventArgs e)
        {
            var conString00 = "Data Source=PATTERN-RECOG\\SQLEXPRESS2019;Initial Catalog=ktptsPayments; Integrated Security=True;User ID=sa;Password=mardan!1 providerName=System.Data.SqlClient providerName=System.Data.SqlClient";
            try
            {
                if (cmbDatabase.SelectedItem != null)
                {
                    int count = 0;
                    string Qry = "SELECT COUNT(*) AS COUNT_ FROM [" + this.cmbDatabase.SelectedItem.ToString() + "].dbo.Company";
                    var sqlCon = new SqlConnection(UniCon);
                    if (sqlCon.State != ConnectionState.Open)
                    {
                        sqlCon.Open();
                        var sqlcomidInsertOn = new SqlCommand(Qry, sqlCon);
                        SqlDataReader reader_ = sqlcomidInsertOn.ExecuteReader();
                        while (reader_.Read())
                        {
                            lblcompany.Text = reader_["count_"].ToString() + ". Records...";
                        }
                        sqlCon.Close();
                        reader_.Dispose();
                        sqlCon.Close();
                    }
                }
                else
                    lblBale.Text = " . Records ...";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message.ToString());
            }
        }

        private void btnpostcompany_Click(object sender, EventArgs e)
        {
            var conString00 = "Data Source=PATTERN-RECOG\\SQLEXPRESS2019;Initial Catalog=ktptsPayments; Integrated Security=True;User ID=sa;Password=mardan!1 providerName=System.Data.SqlClient providerName=System.Data.SqlClient";

            string sqlTruncateVoucher = "Truncate Table Voucher";
            string idInsertOn = "SET IDENTITY_INSERT [Company] ON";
            string idInsertOff = "SET IDENTITY_INSERT [Company] OFF";

            string query = "INSERT INTO [Company] ([CompanyID],[CompanyName],[CompanyCode],[CompanyAddress],[CompanyPhone],[Active_Ind])"
                                       + "SELECT [CompanyID],[CompanyName],[CompanyCode],[CompanyAddress],[CompanyPhone],[Active_Ind] FROM   [" + this.cmbDatabase.SelectedItem.ToString() + "].dbo.[Company]";
            try
            {
                int count = 0;
                // string Qry="exec spPostBale "+"'"+this.cmbDatabase.SelectedItem.ToString()+"'";
                var sqlCon = new SqlConnection(conString00);
                if (sqlCon.State != ConnectionState.Open)
                {
                    sqlCon.Open();
                   // var sqlcmdVoucher = new SqlCommand(sqlTruncateVoucher, sqlCon);
                  //  sqlcmdVoucher.ExecuteNonQuery();
                    var sqlcomidInsertOn = new SqlCommand(idInsertOn, sqlCon);
                    var sqlcomidInsertOff = new SqlCommand(idInsertOff, sqlCon);
                    var sqlcomquery = new SqlCommand(query, sqlCon);
                    sqlcomidInsertOn.ExecuteNonQuery().ToString();
                    string result = sqlcomquery.ExecuteNonQuery().ToString();
                    sqlcomidInsertOff.ExecuteNonQuery().ToString();
                    sqlCon.Close();
                    MessageBox.Show(lblcompany.Text + ". Records Inserted....");
                    //reader.Dispose();
                    sqlCon.Close();
                    DataTable dt_ = new DataTable();
                    SqlDataAdapter da_ = new SqlDataAdapter("SELECT * FROM [Company]", sqlCon);
                    da_.Fill(dt_);
                    this.vwGridView.DataSource = dt_;
                    vwGridView.Show();
                    vwGridView.ScrollBars = ScrollBars.Both;
                    da_.Dispose();
                    for (int i = 0; i < vwGridView.Rows.Count; i++)
                    {
                        DataGridViewRowHeaderCell cell = vwGridView.Rows[i].HeaderCell;
                        cell.Value = (i + 1).ToString();
                        vwGridView.Rows[i].HeaderCell = cell;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message.ToString());
            }
            finally
            {

            }
            btnpostcompany.BackColor = Color.Green;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            var  UniCon = System.Configuration.ConfigurationManager.ConnectionStrings["ktptsPayments.Properties.Settings.UniConString"].ToString();
            string trV = "Truncate Table Voucher";
            string trvd = "Truncate Table Voucherdetail";
            string trb = "Truncate Table Bale";
            string trbrf = "Truncate Table BaleRegform";
            string trg = "Truncate Table Grower";
            string trc = "Truncate Table Cashier";
            string trcmp = "Truncate Table Company";
            string trloc = "Truncate Table Location";
            string Qry = "Truncate Table Voucher Truncate Table Voucherdetail  Truncate Table Bale  Truncate Table BaleRegform  Truncate Table Grower  Truncate Table Cashier  Truncate Table Company  Truncate Table Location";
            try
            {
                int count = 0;
                // string Qry="exec spPostBale "+"'"+this.cmbDatabase.SelectedItem.ToString()+"'";
                var sqlCon = new SqlConnection(UniCon);
                if (sqlCon.State != ConnectionState.Open)
                {
                    sqlCon.Open();
                    /*****************************************************************/
                    var sqlcomTRV = new SqlCommand(Qry, sqlCon);
                    sqlcomTRV.ExecuteNonQuery().ToString();
                    sqlCon.Close();
                    MessageBox.Show("Truncate Successfull...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message.ToString());
            }            

        }

        private void btnshowlocation_Click(object sender, EventArgs e)
        {
            var conString00 = "Data Source=PATTERN-RECOG\\SQLEXPRESS2019;Initial Catalog=ktptsPayments; Integrated Security=True;User ID=sa;Password=mardan!1 providerName=System.Data.SqlClient providerName=System.Data.SqlClient";
            try
            {
                if (cmbDatabase.SelectedItem != null)
                {
                    int count = 0;
                    string Qry = "SELECT COUNT(*) AS COUNT_ FROM [" + this.cmbDatabase.SelectedItem.ToString() + "].dbo.location";
                    var sqlCon = new SqlConnection(UniCon);
                    if (sqlCon.State != ConnectionState.Open)
                    {
                        sqlCon.Open();
                        var sqlcomidInsertOn = new SqlCommand(Qry, sqlCon);
                        SqlDataReader reader_ = sqlcomidInsertOn.ExecuteReader();
                        while (reader_.Read())
                        {
                            lblLocation.Text = reader_["count_"].ToString() + ". Records...";
                        }
                        sqlCon.Close();
                        reader_.Dispose();
                        sqlCon.Close();
                    }
                }
                else
                    lblBale.Text = " . Records ...";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message.ToString());
            }
        }

        private void btnpostlocation_Click(object sender, EventArgs e)
        {
            var conString00 = "Data Source=PATTERN-RECOG\\SQLEXPRESS2019;Initial Catalog=ktptsPayments; Integrated Security=True;User ID=sa;Password=mardan!1 providerName=System.Data.SqlClient providerName=System.Data.SqlClient";

            //string sqlTruncateVoucher = "Truncate Table Voucher";
            string idInsertOn = "SET IDENTITY_INSERT [Location] ON";
            string idInsertOff = "SET IDENTITY_INSERT [Location] OFF";

            string query = "INSERT INTO [Location] ([LocationID],[LocationCode],[LocationName],[LocationAddress],[ContactNum],[Fax],[ContactPerson],[ActivationDate],[TypeID],[BankName],[AccountNo],[Active_Ind],[CompanyID],[AccountID],[Village])"
                                          + "SELECT [LocationID],[LocationCode],[LocationName],[LocationAddress],[ContactNum],[Fax],[ContactPerson],[ActivationDate],[TypeID],[BankName],[AccountNo],[Active_Ind],[CompanyID],[AccountID],[Village] FROM   [" + this.cmbDatabase.SelectedItem.ToString() + "].dbo.[Location]";
            try
            {
                int count = 0;
                var sqlCon = new SqlConnection(UniCon);
                if (sqlCon.State != ConnectionState.Open)
                {
                    sqlCon.Open();
                    // var sqlcmdVoucher = new SqlCommand(sqlTruncateVoucher, sqlCon);
                    //  sqlcmdVoucher.ExecuteNonQuery();
                    var sqlcomidInsertOn = new SqlCommand(idInsertOn, sqlCon);
                    var sqlcomidInsertOff = new SqlCommand(idInsertOff, sqlCon);
                    var sqlcomquery = new SqlCommand(query, sqlCon);
                    sqlcomidInsertOn.ExecuteNonQuery().ToString();
                    string result = sqlcomquery.ExecuteNonQuery().ToString();
                    sqlcomidInsertOff.ExecuteNonQuery().ToString();
                    sqlCon.Close();
                    MessageBox.Show(lblcompany.Text + ". Records Inserted....");
                    //reader.Dispose();
                    sqlCon.Close();
                    DataTable dt_ = new DataTable();
                    SqlDataAdapter da_ = new SqlDataAdapter("SELECT * FROM [Location]", sqlCon);
                    da_.Fill(dt_);
                    this.vwGridView.DataSource = dt_;
                    vwGridView.Show();
                    vwGridView.ScrollBars = ScrollBars.Both;
                    da_.Dispose();
                    for (int i = 0; i < vwGridView.Rows.Count; i++)
                    {
                        DataGridViewRowHeaderCell cell = vwGridView.Rows[i].HeaderCell;
                        cell.Value = (i + 1).ToString();
                        vwGridView.Rows[i].HeaderCell = cell;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message.ToString());
            }
            finally
            {

            }
            btnpostlocation.BackColor = Color.Green;
        }

    }
}
