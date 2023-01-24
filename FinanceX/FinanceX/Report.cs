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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            GetAvgExp();
            GetTotalExp();
            GetMostExp();
            GetLowExp();
            monthgt();

        }
        
             private void monthgt()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT DATENAME(month, GETDATE())", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            month.Text = dt.Rows[0][0].ToString() ;
            Con.Close();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andreea\Documents\FinanceXDB.mdf;Integrated Security=True;Connect Timeout=30");
         private void GetAvgExp()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select AVG(ExpAmt) from ExpenseTbl where Month(ExpDate)=Month(GETDATE()) AND ExpUser='" + LoginFinanceX.User + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            avg.Text = dt.Rows[0][0].ToString()+" Lei";
            Con.Close();
        }

        private void GetTotalExp()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select SUM(ExpAmt) from ExpenseTbl where Month(ExpDate)=Month(GETDATE()) AND ExpUser='" + LoginFinanceX.User + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            total.Text = dt.Rows[0][0].ToString() + " Lei";
            Con.Close();
        }

        private void GetMostExp()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT TOP 1 ExpCat FROM ExpenseTbl where Month(ExpDate)=Month(GETDATE()) AND ExpUser='" + LoginFinanceX.User + "'"+"group by ExpCat Order by Sum(ExpAmt) DESC", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            high.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }


        private void GetLowExp()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT TOP 1 ExpCat FROM ExpenseTbl where Month(ExpDate)=Month(GETDATE()) AND ExpUser='" + LoginFinanceX.User + "'"+" group by ExpCat Order by Sum(ExpAmt) ASC", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            low.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
      
        private void label7_Click(object sender, EventArgs e)
        {
            Form f1 = new FinanceXMain();
            this.Hide();
            f1.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form f1 = new Statistics();
            this.Hide();
            f1.ShowDialog();
        }

        private void total_Click(object sender, EventArgs e)
        {

        }
    }
}
