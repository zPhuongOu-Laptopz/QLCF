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
    public partial class FormFood : Form
    {
        public FormFood()
        {
            InitializeComponent();
        }

        private void FormFood_Load(object sender, EventArgs e)
        {
            List<Food> list = new List<Food>();
            list = Food.SelectallObject();

            data_Food.DataSource = list;
        }

        private void data_Food_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = data_Food.CurrentCell.RowIndex;
            int id = Convert.ToInt32(data_Food.Rows[index].Cells["id"].Value);
            Food food = new Food();
            txt_foodName.Text = food.foodName.ToString();
            num_price.Value = Convert.ToDecimal(food.price);
            cbb_foodState.Text = food.state.ToString();
        }

        private int Validation(string fName, decimal price)
        {
            if (fName == null || fName == "" || fName == fName.Trim())
            {
                return -1;
            }
            else if (price == 0)
            {
                return -2;
            }
            return 0;
        }

        private void btn_addFood_Click(object sender, EventArgs e)
        {
            int check = Validation(txt_foodName.Text, num_price.Value);
            if (check == -1)
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!");
            }
            else if (check == -2)
            {
                MessageBox.Show("Vui lòng nhập giá tiền!");
            }
            else
            {

            }
        }

        private void btn_editFood_Click(object sender, EventArgs e)
        {
            if (Validation(txt_foodName.Text, num_price.Value) == -1)
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!");
            }
            else if (Validation(txt_foodName.Text, num_price.Value) == -2)
            {
                MessageBox.Show("Vui lòng nhập giá tiền!");
            }
            else
            {

            }
        }
    }
}
