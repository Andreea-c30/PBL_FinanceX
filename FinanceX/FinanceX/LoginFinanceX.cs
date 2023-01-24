using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinanceX
{
    public partial class LoginFinanceX : Form
    {
        public LoginFinanceX()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andreea\Documents\FinanceXDB.mdf;Integrated Security=True;Connect Timeout=30");

        public static string User;
        private void Loginbnt_Click(object sender, EventArgs e)
        {
            //login
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM UserTbl " +
                "WHERE UName='" + UName.Text + "' AND UPass='" + UPass.Text + "'",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString()=="1")
            {
                  User = UName.Text;
                Form f1 = new FinanceXMain();
                this.Hide();
                f1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid data! Try again!");
            }
            Con.Close();

         
        }

        private void Registrationlbl_Click(object sender, EventArgs e)
        {
            //sign up
            Form f2 = new RegisterFinanceX();
            this.Hide();
            f2.ShowDialog();
        }
    }
}
