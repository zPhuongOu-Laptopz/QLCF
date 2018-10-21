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
            
            Login login = new Login();
            login.ShowDialog();
            
        }
    }
}
