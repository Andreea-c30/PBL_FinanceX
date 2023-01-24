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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
            piechart();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andreea\Documents\FinanceXDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void label1_Click(object sender, EventArgs e)
        {
            Form f1 = new Report();
            this.Hide();
            f1.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form f1 = new FinanceXMain();
            this.Hide();
            f1.ShowDialog();
        }
    
        private void piechart()
        {
            //geting values
            chart1.Titles.Add("Monthy Spendings");
            chart1.Series["s1"].IsValueShownAsLabel = true;
            int a, b, c, d, e, f, g;
            string aa,bb,cc,dd,ee,ff,gg;
                Con.Open();
            //Data abt food
                SqlDataAdapter sda1 = new SqlDataAdapter("select SUM(ExpAmt) from ExpenseTbl where ExpCat = 'Food' and Month(ExpDate)=Month(GETDATE()) and  ExpUser='" + LoginFinanceX.User + "'", Con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
               aa = dt1.Rows[0][0].ToString();
            if (aa != "")
            {
                a = int.Parse(aa);
                chart1.Series["s1"].Points.AddXY("Food", a);
            }
            //data about Shopping
            SqlDataAdapter sda2 = new SqlDataAdapter("select SUM(ExpAmt) from ExpenseTbl where ExpCat = 'Shopping' and Month(ExpDate)=Month(GETDATE()) and  ExpUser='" + LoginFinanceX.User + "'", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            bb = dt2.Rows[0][0].ToString();
            if (bb != "")
            {
                b = int.Parse(bb);
                chart1.Series["s1"].Points.AddXY("Shopping", b);
            }

            //Medical
            SqlDataAdapter sda3 = new SqlDataAdapter("select SUM(ExpAmt) from ExpenseTbl where ExpCat = 'Medical' and Month(ExpDate)=Month(GETDATE()) and  ExpUser='" + LoginFinanceX.User + "'", Con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            cc = dt3.Rows[0][0].ToString();
            if (cc != "")
            {
                c = int.Parse(cc);
                chart1.Series["s1"].Points.AddXY("Medical", c);
            }
            //Housing
            SqlDataAdapter sda4 = new SqlDataAdapter("select SUM(ExpAmt) from ExpenseTbl where ExpCat = 'Housing' and Month(ExpDate)=Month(GETDATE()) and  ExpUser='" + LoginFinanceX.User + "'", Con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            dd = dt4.Rows[0][0].ToString();
            if (dd != "")
            {
                d = int.Parse(dd);
                chart1.Series["s1"].Points.AddXY("Housing", d);
            }
            //Travel
            SqlDataAdapter sda5 = new SqlDataAdapter("select SUM(ExpAmt) from ExpenseTbl where ExpCat = 'Travel' and Month(ExpDate)=Month(GETDATE()) and  ExpUser='" + LoginFinanceX.User + "'", Con);
            DataTable dt5 = new DataTable();
            sda5.Fill(dt5);
            ee = dt5.Rows[0][0].ToString();
            if (ee != "")
            {
                e = int.Parse(ee);
                chart1.Series["s1"].Points.AddXY("Travel", e);
            }
            //Transportation
            SqlDataAdapter sda6 = new SqlDataAdapter("select SUM(ExpAmt) from ExpenseTbl where ExpCat = 'Transportation' and Month(ExpDate)=Month(GETDATE()) and  ExpUser='" + LoginFinanceX.User + "'", Con);
            DataTable dt6 = new DataTable();
            sda6.Fill(dt6);
            ff = dt6.Rows[0][0].ToString();
            if (ff != "")
            {
                f = int.Parse(ff);
                chart1.Series["s1"].Points.AddXY("Transportation", f);
            }
                //Others
            SqlDataAdapter sda7 = new SqlDataAdapter("select SUM(ExpAmt) from ExpenseTbl where ExpCat = 'Others' and Month(ExpDate)=Month(GETDATE()) and  ExpUser='" + LoginFinanceX.User + "'", Con);
            DataTable dt7 = new DataTable();
            sda7.Fill(dt7);
            gg = dt7.Rows[0][0].ToString();
            if (gg != "")
            {
                g = int.Parse(gg);
                chart1.Series["s1"].Points.AddXY("Others", g);
            }
          

            Con.Close();
            
            //////////////
            ///start chart
            
            
           
          
           
            
        }

        private void Statistics_Load(object sender, EventArgs e)
        {

        }
    }
}
