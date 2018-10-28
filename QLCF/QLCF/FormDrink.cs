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
    public partial class FormDrink : Form
    {
        public FormDrink()
        {
            InitializeComponent();
        }

        private void FormDrink_Load(object sender, EventArgs e)
        {
            List<Drink> list = new List<Drink>();
            list = Drink.SelectallObject();

            data_Drink.DataSource = list;
        }

        private void data_Drink_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = data_Drink.CurrentCell.RowIndex;
            int id = Convert.ToInt32(data_Drink.Rows[index].Cells["id"].Value);
            Drink drink = new Drink();
            drink.SelectObjectwithID(id);
            txt_drinkName.Text = drink.drinkName.ToString();
            num_price.Value = Convert.ToDecimal(drink.price);
            cbb_drinkState.Text = drink.state.ToString();

        }

        private int Validation(string dName, decimal price)
        {
            if (dName == null || dName == "" || dName == dName.Trim())
            {
                return -1;
            }
            else if (price == 0)
            {
                return -2;
            }
            return 0;
        }

        private void btn_addDrink_Click(object sender, EventArgs e)
        {
            int check = Validation(txt_drinkName.Text, num_price.Value);
            if (check == -1)
            {
                MessageBox.Show("Vui lòng nhập tên nước uống!");
            }
            else if (check == -2)
            {
                MessageBox.Show("Vui lòng nhập giá tiền!");
            }
            else
            {

            }
        }

        private void btn_editDrink_Click(object sender, EventArgs e)
        {
            int check = Validation(txt_drinkName.Text, num_price.Value);
            if (check == -1)
            {
                MessageBox.Show("Vui lòng nhập tên nước uống!");
            }
            else if (check == -2)
            {
                MessageBox.Show("Vui lòng nhập giá tiền!");
            }
            else
            {

            }
        }
    }
}
