using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCF
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lbl_realTime.Text = DateTime.Now.ToString();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();            
        }

        private void btn_EmployeeManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEmployee form = new FormEmployee();
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEmployee form = new FormEmployee();
            form .Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBranch form = new FormBranch();
            form.Show();
        }

        private void btn_Branch_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBranch form = new FormBranch();
            form.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFood form = new FormFood();
            form.Show();
        }

        private void btn_Food_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFood form = new FormFood();
            form.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDrink form = new FormDrink();
            form.Show();
        }

        private void btn_Drink_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDrink form = new FormDrink();
            form.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRevenue form = new FormRevenue();
            form.Show();
        }

        private void btn_Revenue_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRevenue form = new FormRevenue();
            form.Show();
        }
    }
}
