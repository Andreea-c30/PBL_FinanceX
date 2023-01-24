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
    public partial class RegisterFinanceX : Form
    {
        public RegisterFinanceX()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andreea\Documents\FinanceXDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void Clear()
        {
            UName.Text = "";
            UPhone.Text = "";
            UPass.Text = "";
            UAddress.Text = "";

        }
      
        private void Addbtn_Click(object sender, EventArgs e)
        {
            if(UName.Text=="" || UPhone.Text=="" || UPass.Text=="" || UAddress.Text=="")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO UserTbl(UName,UDOB,UPhone, UPass,UAddress) " +
                    "VALUES(@UN,@UD,@UP,@UPA,@UA)",Con);
                cmd.Parameters.AddWithValue("@UN",UName.Text);
                cmd.Parameters.AddWithValue("@UD", UDOB.Value.Date);
                cmd.Parameters.AddWithValue("@UP", UPhone.Text); 
                cmd.Parameters.AddWithValue("@UPA", UPass.Text);
                cmd.Parameters.AddWithValue("@UA", UAddress.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sign Up Completed");
                Clear();
                Con.Close();
                Form f1 = new LoginFinanceX();
                this.Hide();
                f1.ShowDialog();
                
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //
        }

        private void backlbl_Click(object sender, EventArgs e)
        {
            Form f2 = new LoginFinanceX();
            this.Hide();
            f2.ShowDialog();

        }
    }
}

