using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceX
{
    public partial class FinanceXMain : Form
    {
        public FinanceXMain()
        {
            InitializeComponent();
            UNamelbl.Text = LoginFinanceX.User;
        }

        private void AddExp_Click(object sender, EventArgs e)
        {
            Form f1 = new AddExp();
            this.Hide();
            f1.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form f1 = new LoginFinanceX();
            this.Hide();
            f1.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form f1 = new LoginFinanceX();
            this.Hide();
            f1.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f1 = new Expenses();
            this.Hide();
            f1.ShowDialog();
        }

        private void Report_Click(object sender, EventArgs e)
        {
            Form f1 = new Report();
            this.Hide();
            f1.ShowDialog();
        }
    }
}
