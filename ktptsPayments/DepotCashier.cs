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
    public partial class DepotCashier : Form
    {
        public DepotCashier()
        {
            InitializeComponent();
        }

        private void DepotCashier_Load(object sender, EventArgs e)
        {
            ShowGrid();
            var conString = "Data Source=PATTERN-RECOG\\sqlexpress2015;Initial Catalog=AMD-2016; Integrated Security=True;User ID=ktc;Password=mardan!1 providerName=System.Data.SqlClient providerName=System.Data.SqlClient";
            var conString00 = "Data Source=PATTERN-RECOG\\SQLEXPRESS2019;Initial Catalog=master; Integrated Security=True;User ID=sa;Password=mardan!1 providerName=System.Data.SqlClient providerName=System.Data.SqlClient";

            try
            {
                var Qry = "SELECT name FROM master.dbo.sysdatabases";
                var sqlCon = new SqlConnection(conString00);
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            var conString00 = "Data Source=PATTERN-RECOG\\SQLEXPRESS2019;Initial Catalog=ktptsPayments; Integrated Security=True;User ID=sa;Password=mardan!1 providerName=System.Data.SqlClient providerName=System.Data.SqlClient";
            string Qry = "";
            try
            {
                Qry = "INSERT INTO [dbo].[Cashier]"
                                       + "([Depot]"
                                       + ",[Cashier]"
                                       + ",[Role]"
                                       + ",[Mobile]"
                                       + ",[Address]"
                                       + ",[iActive])"
                                 + "VALUES"
                                       + "('" + cmbDatabase.SelectedItem + "'"
                                       + ",'" + txtname.Text.ToUpper() + "'"
                                       + ",'" + txtdesignation.Text.ToUpper() + "'"
                                       + ",'" + txtmobile.Text + "'"
                                       + ",'" + txtaddress.Text + "'"
                                       + ",'" + Convert.ToBoolean(chkActive.CheckState) + "')";
                var sqlcon = new SqlConnection(conString00);
                var sqlcom = new SqlCommand(Qry, sqlcon);
                sqlcon.Open();
                sqlcom.ExecuteNonQuery();
                MessageBox.Show("Record Inserted...");
                ShowGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void ShowGrid()
        {
            var conString00 = "Data Source=PATTERN-RECOG\\SQLEXPRESS2019;Initial Catalog=ktptsPayments; Integrated Security=True;User ID=sa;Password=mardan!1 providerName=System.Data.SqlClient providerName=System.Data.SqlClient";
            var da_ = new SqlDataAdapter("SELECT * FROM CASHIER WHERE iACTIVE=1 ORDER BY ID DESC", conString00);
            var dt_ = new DataTable();
            da_.Fill(dt_);
            vwGrid.DataSource = dt_;
        }

        private void vwGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (vwGrid.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {

                string id = vwGrid.SelectedRows[0].Cells[0].Value + string.Empty;
                string depot = vwGrid.SelectedRows[0].Cells[1].Value + string.Empty;
                cmbDatabase.SelectedItem = depot;
                string cname = vwGrid.SelectedRows[0].Cells[2].Value + string.Empty;
                txtname.Text = cname;
                string role_ = vwGrid.SelectedRows[0].Cells[3].Value + string.Empty;
                txtdesignation.Text = role_;
                string mobile_ = vwGrid.SelectedRows[0].Cells[4].Value + string.Empty;
                txtmobile.Text = mobile_;
                string address_ = vwGrid.SelectedRows[0].Cells[5].Value + string.Empty;
                txtaddress.Text = address_;
                bool isactive_ = Convert.ToBoolean(vwGrid.SelectedRows[0].Cells[6].Value + string.Empty);
                chkActive.Checked = isactive_;
            }
        }
    }
}
