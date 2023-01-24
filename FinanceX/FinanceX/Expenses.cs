using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceX
{
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
            ShowExpenses();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andreea\Documents\FinanceXDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void ShowExpenses()
        {
            Con.Open();
            string qry = "select ExpName as Name,ExpCat as Category,ExpDate as Date,ExpAmt as Cost from ExpenseTbl where ExpUser='"+LoginFinanceX.User+"'";
            SqlDataAdapter sda = new SqlDataAdapter(qry, Con);
           SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ExpGrid.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void AddExp_Click(object sender, EventArgs e)
        {
            Form f1 = new AddExp();
            this.Hide();
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string qry = "select ExpName as Name," +
                "ExpCat as Category,ExpDate as Date," +
                "ExpAmt as Cost from ExpenseTbl " +
                "where  Month(ExpDate)=Month(GETDATE()) and Year(ExpDate)=Year(GETDATE()) and  ExpUser='"+LoginFinanceX.User+"'";
            SqlDataAdapter sda = new SqlDataAdapter(qry, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ExpGrid.DataSource = ds.Tables[0]; 
            Con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string qry = "select ExpName as Name," +
                "ExpCat as Category,ExpDate as Date," +
                "ExpAmt as Cost from ExpenseTbl " +
                "where   DAY(ExpDate)=DAY(GETDATE()) and Month(ExpDate)=Month(GETDATE()) and YEAR(ExpDate)=YEAR(GETDATE()) and  ExpUser='"+LoginFinanceX.User+"'";
            SqlDataAdapter sda = new SqlDataAdapter(qry, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ExpGrid.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form f = new FinanceXMain();
            this.Hide();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowExpenses();
        }
    }
}
