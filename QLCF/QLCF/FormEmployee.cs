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
        int Oid;
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
            else if (position == null || position == "" || position == position.Trim())
            {

            }
            return 0;
        }

        private void reLoad()
        {
            List<Employee> list = new List<Employee>();
            list = Employee.SelectallObject();

            data_Emp.DataSource = list;
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {

            List<Branch> list = new List<Branch>();
            list = Branch.SelectallObject();
            foreach (var item in list)
            {
                cbb_branch.Items.Add(item.branchName);
            }
            reLoad();
        }

        private void data_Emp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data_Emp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = data_Emp.CurrentCell.RowIndex;
            Oid = Convert.ToInt32(data_Emp.Rows[index].Cells["id"].Value);
            Employee emp = new Employee();
            emp.SelectObjectwithID(Oid);
            txt_firstName.Text = emp.firstname.ToString();
            txt_lastName.Text = emp.lastname.ToString();
            txt_email.Text = emp.email.ToString();
            dtp_dob.Value = emp.dayofbirth;
            cbb_homeTown.Text = emp.hometown.ToString();
            cbb_position.Text = emp.position.ToString();
            txt_idCard.Text = emp.idcardnumber.ToString();
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


        private void btn_search_Click(object sender, EventArgs e)
        {
            string key = "firstName";
            Employee emp = new Employee();
            List<Employee> list = new List<Employee>();
            list = emp.Search_Employee(key, txt_search.Text);

            data_Emp.DataSource = list;
          
           

        }

        private int checkValidation(string firstname, string lastname, DateTime dayofbirth, string address, string hometown, string position, string phonenumber, string idcardnumber, string email, string password, DateTime startdate, DateTime enddate, bool active, double salary, double bonus)
        {
            if (firstname == null || firstname == "")
            {
                return -1;
            }
            else if (lastname == null || lastname == "")
            {
                return -2;
            }
            else if (dayofbirth == null)
            {
                return -3;
            }
            else if (address == null || address == "")
            {
                return -4;
            }
            else if (hometown == null)
            {
                return -5;
            }
            else if (position == null)
            {
                return -6;
            }
            else if (phonenumber == null || phonenumber == "")
            {
                return -7;
            }
            else if (idcardnumber == null || idcardnumber == "")
            {
                return -8;
            }
            else if (email == null || email == "")
            {
                return -9;
            }
            else if (password == null || password == "")
            {
                return -10;
            }
            else if (startdate == null)
            {
                return -11;
            }
            else if (enddate == null)
            {
                return -12;
            }
            else if (salary == 0)
            {
                return -14;
            }
            else if (bonus == 0)
            {
                return -15;
            }
            return 0;
        }
        /// <summary>
        /// 
        /// </summary>
        private void btn_add_Click(object sender, EventArgs e)
        {
            int check = checkValidation(txt_firstName.Text, txt_lastName.Text, dtp_dob.Value, txt_address.Text, cbb_homeTown.Text, cbb_position.Text, txt_phoneNumber.Text, txt_idCard.Text, txt_email.Text, txt_password.Text, dtp_daystart.Value, dtp_dayend.Value, cb_state.Checked, Convert.ToDouble(txt_basicSalary.Text), Convert.ToDouble(txt_bonus.Text));
            if (check == -1)
            {
                MessageBox.Show("Vui lòng nhập tên!");
            }
            else if (check == -2)
            {
                MessageBox.Show("Vui lòng nhập họ!");
            }
            else if (check == -3)
            {
                MessageBox.Show("Vui lòng nhập ngày sinh!");
            }
            else if (check == -4)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!");
            }
            else if (check == -5)
            {
                MessageBox.Show("Vui lòng chọn quê quán");
            }
            else if (check == -6)
            {
                MessageBox.Show("Vui lòng chọn chức vụ!");
            }
            else if (check == -7)
            {
                MessageBox.Show("Vui lòng nhập sđt!");
            }
            else if (check == -8)
            {
                MessageBox.Show("Vui lòng nhập CMND!");
            }
            else if (check == -9)
            {

                MessageBox.Show("Vui lòng nhập email!");
            }
            else if (check == -10)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");

            }
            else if (check == -11)
            {
                MessageBox.Show("Vui lòng nhập ngày vào làm!");

            }
            else if (check == -12)
            {
                MessageBox.Show("Vui lòng nhập ngày kết thúc hợp đồng!");
            }
            else if (check == -14)
            {
                MessageBox.Show("Vui lòng nhập lương cơ bản!");
            }
            else if (check == -15)
            {
                MessageBox.Show("Vui lòng nhập thưởng!");
            }
            else
            {
                Employee emp = new Employee(txt_firstName.Text, txt_lastName.Text, dtp_dob.Value, txt_address.Text, cbb_homeTown.Text, cbb_position.Text, txt_phoneNumber.Text, txt_idCard.Text, txt_email.Text, txt_password.Text, dtp_daystart.Value, dtp_dayend.Value, cb_state.Checked, Convert.ToDouble(txt_basicSalary.Text), Convert.ToDouble(txt_bonus.Text), cbb_branch.Text);
                emp.InsertEmployee();
                reLoad();
            }
        }
        private int Return_Int_With_Boolean(bool check)
        {
            if (check) return 1;
            return 0;
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            int check = checkValidation(txt_firstName.Text, txt_lastName.Text, dtp_dob.Value, txt_address.Text, cbb_homeTown.Text, cbb_position.Text, txt_phoneNumber.Text, txt_idCard.Text, txt_email.Text, txt_password.Text, dtp_daystart.Value, dtp_dayend.Value, cb_state.Checked, Convert.ToDouble(txt_basicSalary.Text), Convert.ToDouble(txt_bonus.Text));
            if (check == -1)
            {
                MessageBox.Show("Vui lòng nhập tên!");
            }
            else if (check == -2)
            {
                MessageBox.Show("Vui lòng nhập họ!");
            }
            else if (check == -3)
            {
                MessageBox.Show("Vui lòng nhập ngày sinh!");
            }
            else if (check == -4)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!");
            }
            else if (check == -5)
            {
                MessageBox.Show("Vui lòng chọn quê quán");
            }
            else if (check == -6)
            {
                MessageBox.Show("Vui lòng chọn chức vụ!");
            }
            else if (check == -7)
            {
                MessageBox.Show("Vui lòng nhập sđt!");
            }
            else if (check == -8)
            {
                MessageBox.Show("Vui lòng nhập CMND!");
            }
            else if (check == -9)
            {

                MessageBox.Show("Vui lòng nhập email!");
            }
            else if (check == -10)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");

            }
            else if (check == -11)
            {
                MessageBox.Show("Vui lòng nhập ngày vào làm!");

            }
            else if (check == -12)
            {
                MessageBox.Show("Vui lòng nhập ngày kết thúc hợp đồng!");
            }
       
            else if (check == -14)
            {
                MessageBox.Show("Vui lòng nhập lương cơ bản!");
            }
            else if (check == -15)
            {
                MessageBox.Show("Vui lòng nhập thưởng!");
            }
            else
            {
                Employee emp = new Employee();
                emp.SelectObjectwithID(Oid);
                emp.firstname = txt_firstName.Text;
                emp.lastname = txt_lastName.Text;
                emp.email = txt_email.Text;
                emp.dayofbirth = dtp_dob.Value;
                emp.hometown = cbb_homeTown.Text;
                emp.position = cbb_position.Text;
                emp.idcardnumber = txt_idCard.Text;
                emp.password = txt_password.Text;
                emp.enddate = dtp_dayend.Value;
                emp.startdate = dtp_daystart.Value;
                emp.salary = Convert.ToDouble(txt_basicSalary.Text);
                emp.bonus = Convert.ToDouble(txt_bonus.Text);
                emp.phonenumber = txt_phoneNumber.Text;
                emp.active = cb_state.Checked;
                emp.address = txt_address.Text;
                emp.branchWork = cbb_branch.Text;
                emp.Update();
                reLoad();
            }
        }
    }
}
