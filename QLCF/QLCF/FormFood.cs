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
        int Oid;
        public FormFood()
        {
            InitializeComponent();
        }

        private void FormFood_Load(object sender, EventArgs e)
        {
            reLoad();
        }

        private void reLoad()
        {
            List<Food> list = new List<Food>();
            list = Food.SelectallObject();

            data_Food.DataSource = list;
        }

        private void data_Food_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = data_Food.CurrentCell.RowIndex;
            Oid = Convert.ToInt32(data_Food.Rows[index].Cells["id"].Value);
            Food food = new Food();
            food.SelectObjectwithID(Oid);
            txt_foodName.Text = food.foodName;
            num_price.Value = Convert.ToDecimal(food.price);
            cbb_foodState.Text = food.state;
        }

        private int Validation(string fName, double price)
        {
            if (fName == null || fName == "")
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
            int check = Validation(txt_foodName.Text, Convert.ToDouble(num_price.Value));
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
                Food food = new Food(txt_foodName.Text, Convert.ToDouble(num_price.Value), cbb_foodState.Text);
                try
                {
                    food.Insert();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tên món ăn không được trùng!");
                }
                finally
                {
                    reLoad();
                }
            }
        }

        private void btn_editFood_Click(object sender, EventArgs e)
        {
            int check = Validation(txt_foodName.Text, Convert.ToDouble(num_price.Value));

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
                Food food = new Food();
                food.SelectObjectwithID(Oid);
                food.foodName = txt_foodName.Text;
                food.price = Convert.ToDouble(num_price.Value);
                food.state = cbb_foodState.Text;
                food.Update();
                reLoad();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain form = new FormMain();
            form.Show();
        }
    }
}
