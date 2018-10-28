using QLCF.Model;
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
    public partial class FormBranch : Form
    {
        public FormBranch()
        {
            InitializeComponent();
        }

        private void FormBranch_Load(object sender, EventArgs e)
        {
            List<Branch> list = new List<Branch>();
            list = Branch.SelectallObject();

            data_branch.DataSource = list;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void data_branch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = data_branch.CurrentCell.RowIndex;
            int id = Convert.ToInt32(data_branch.Rows[index].Cells["id"].Value);
            Branch branch = new Branch();
            branch.SelectObjectwithID(id);
            txt_branchName.Text = branch.branchName.ToString();
            txt_addressBranch.Text = branch.address.ToString();
            num_emp.Value = branch.eNumber;
            num_empExpect.Value = branch.eNumberExpect;

        }

        private int Validation(string bName, string bAddress, decimal bEmp, decimal bEmpExpect)
        {
            if (bName == null || bName == "" || bName == bName.Trim())
            {
                return -1;
            }
            else if (bAddress == null || bAddress == "" || bAddress == bAddress.Trim())
            {
                return -2;
            }
            else if (bEmp == 0)
            {
                return -3;
            }
            else if (bEmpExpect == 0)
            {
                return -4;
            }
            return 0;
        }

        private void btn_addBranch_Click(object sender, EventArgs e)
        {
            int check = Validation(txt_branchName.Text, txt_addressBranch.Text, num_emp.Value, num_empExpect.Value);
            if (check == -1)
            {
                MessageBox.Show("Vui lòng nhập tên chi nhánh!");
            }
            else if (check == -2)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ chi nhánh!");
            }
            else if (check == -3)
            {
                MessageBox.Show("Vui lòng nhập số nhân viên hiện tại!");
            }
            else if (check == -4)
            {
                MessageBox.Show("Vui lòng nhập số nhân viên dự kiến!");
            }
            else
            {

            }
        }
    }
}
