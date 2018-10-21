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
    public partial class Login : Form
    {
        public static string UniCon = System.Configuration.ConfigurationManager.ConnectionStrings["ktptsPayments.Properties.Settings.UniConString"].ToString();

        public Login()
        {
            InitializeComponent();
        }

        public void ShowData()
        {
            var da = new SqlDataAdapter("Select username, isactive from Login Order by UserName", new SqlConnection(UniCon));
            DataTable dt_ = new DataTable();
            da.Fill(dt_);
            vwGrid.DataSource = dt_;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            string Qry = "INSERT INTO [dbo].[Login]"
                                       +"([UserName]"
                                       +",[Password]"
                                       +",[IsActive])"
                                 +"VALUES "
                                   +" ('"+txtUserName.Text.ToUpper()+"'"
                                   +",'"+txtPassword.Text+"'"
                                   +",'TRUE')";
            if (txtPassword.Text == txtRePassword.Text)
            {
                try
                {
                    var sqlcom = new SqlCommand(Qry, new SqlConnection(UniCon));
                    sqlcom.Connection.Open();
                    sqlcom.ExecuteNonQuery();
                    MessageBox.Show("Record Inserted...");
                    ShowData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Password Matched...");
            }
        }
    }
}
