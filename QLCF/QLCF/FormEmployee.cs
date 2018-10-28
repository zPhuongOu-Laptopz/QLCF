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
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private int ValidationModel(string firstname, string lastname, string password, string position, DateTime daystart)
        {
            if (firstname == null || firstname == "" || firstname == firstname.Trim())
            {
                return -1;
            }
            else if (lastname == null || lastname == "" || lastname == lastname.Trim())
            {
                return -2;
            }
            else if (password == null || password == "" || password == password.Trim() || password.Length < 6)
            {
                return -3;
            }
            else if (position == null || position =="" || position == position.Trim())
            {

            }
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_firstName.Text == null || txt_firstName.Text != "abcd")
            {
                MessageBox.Show("Vui lòng nhập tên của bạn!");
            }
            else if (txt_password.Text == null)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu của bạn!");
            }
            else if (txt_lastName.Text == null)
            {
                MessageBox.Show("Vui lòng nhập họ của bạn!");
            }
            else if (cbb_position.Text == null)
            {
                MessageBox.Show("Vui lòng chọn chức vụ của bạn!");
            }
            else if (dtp_daystart.Value == null)
            {
                MessageBox.Show("Vui lòng chọn ngày bắt đầu công việc của bạn!");
            }
            else
            {

            }
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            List<Employee> list = new List<Employee>();
            list = Employee.SelectallObject();

            data_Emp.DataSource = list;
        }

        private void data_Emp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data_Emp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = data_Emp.CurrentCell.RowIndex;
            int id = Convert.ToInt32(data_Emp.Rows[index].Cells["id"].Value);
            Employee emp = new Employee();
            emp.SelectObjectwithID(id);
            txt_firstName.Text = emp.firstname.ToString();
            txt_lastName.Text = emp.lastname.ToString();
            txt_email.Text = emp.email.ToString();
            dtp_dob.Value = emp.dayofbirth;
            cbb_homeTown.Text = emp.hometown.ToString();
            cbb_position.Text = emp.position.ToString();
            txt_idCardNumber.Text = emp.idcardnumber.ToString();
            txt_password.Text = emp.password.ToString();
            dtp_dayend.Value = emp.enddate;
            dtp_daystart.Value = emp.startdate;
            txt_basicSalary.Text = emp.salary.ToString();
            txt_bonus.Text = emp.bonus.ToString();
            txt_phoneNumber.Text = emp.phonenumber.ToString();
            cb_state.Checked = emp.active;
            txt_address.Text = emp.address.ToString();
            cbb_branch.Text = emp.branchWork.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }
    }
}
