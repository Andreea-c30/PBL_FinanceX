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
    public partial class AddExp : Form
    {
        public AddExp()
        {
            InitializeComponent();
        }

        private void backlbl_Click(object sender, EventArgs e)
        {
            Form f = new FinanceXMain();
            this.Hide();
            f.ShowDialog();

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andreea\Documents\FinanceXDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void Clear()
        {
            EName.Text = "";
            ECategory.SelectedIndex = 0;
            EAmt.Text = "";
            EDesc.Text = "";

        }

        private void AddExpBtn_Click(object sender, EventArgs e)
        {
            if (EName.Text == "" || ECategory.Text == "" || ECategory.SelectedIndex == -1 || EAmt.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO ExpenseTbl(ExpName,ExpAmt,ExpCat, ExpDate,ExpComment,ExpUser) " +
                    "VALUES(@EN,@EA,@EC,@ED,@ECo,@EU)", Con);
                cmd.Parameters.AddWithValue("@EN", EName.Text);
                cmd.Parameters.AddWithValue("@EA", EAmt.Text);
                cmd.Parameters.AddWithValue("@EC", ECategory.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@ED", EDate.Value.Date);
                cmd.Parameters.AddWithValue("@ECo", EDesc.Text);
                cmd.Parameters.AddWithValue("@EU", LoginFinanceX.User);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Expense added");
                Clear();
                Con.Close();
                Form f1 = new FinanceXMain();
                this.Hide();
                f1.ShowDialog();

            }

        }
    }
}
