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
    public partial class LoginFlash : Form
    {
        public static string UniCon = System.Configuration.ConfigurationManager.ConnectionStrings["ktptsPayments.Properties.Settings.UniConString"].ToString();

        public LoginFlash()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string GetRetPass="";
            try
            {
                var sqlcom=new SqlCommand("SELECT PASSWORD FROM LOGIN WHERE USERNAME='"+txtUserName.Text+"'",new SqlConnection(UniCon));
                sqlcom.Connection.Open();
                SqlDataReader reader_=  reader_=sqlcom.ExecuteReader();
                while(reader_.Read())
                {
                    GetRetPass=reader_["password"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string GetPass = txtPassword.Text;
            if (GetPass == GetRetPass)
            {
                this.Hide();
                var mdi_ = new MDIParentPyments();
                mdi_.Show();
            }
            else {
                MessageBox.Show("Incorrect Login...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
