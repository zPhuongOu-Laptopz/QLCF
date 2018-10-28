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
        int Oid;
        public FormDrink()
        {
            InitializeComponent();
        }

        private void FormDrink_Load(object sender, EventArgs e)
        {
            reLoad();
        }

        private void reLoad()
        {
            List<Drink> list = new List<Drink>();
            list = Drink.SelectallObject();

            data_Drink.DataSource = list;
        }

        private void data_Drink_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = data_Drink.CurrentCell.RowIndex;
            Oid = Convert.ToInt32(data_Drink.Rows[index].Cells["id"].Value);
            Drink drink = new Drink();
            drink.SelectObjectwithID(Oid);
            txt_drinkName.Text = drink.drinkName;
            num_price.Value = Convert.ToDecimal(drink.price);
            cbb_drinkState.Text = drink.state;

        }

        private int Validation(string dName, double price)
        {
            if (dName == null || dName == "")
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
            int check = Validation(txt_drinkName.Text, Convert.ToDouble(num_price.Value));
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
                Drink drink = new Drink(txt_drinkName.Text, Convert.ToDouble(num_price.Value), cbb_drinkState.Text);
                try
                {
                    drink.Insert();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tên nước uống không được trùng!");
                }
                finally
                {
                    reLoad();
                }
            }
        }

        private void btn_editDrink_Click(object sender, EventArgs e)
        {
            int check = Validation(txt_drinkName.Text, Convert.ToDouble(num_price.Value));
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
                Drink drink = new Drink();
                drink.SelectObjectwithID(Oid);
                drink.drinkName = txt_drinkName.Text;
                drink.price = Convert.ToDouble(num_price.Value);
                drink.state = cbb_drinkState.Text;
                drink.Update();
                reLoad();
            }
        }

        private void btn_deleteDrink_Click(object sender, EventArgs e)
        {
            Drink drink = new Drink();
            drink.SelectObjectwithID(Oid);
            drink.Delete();
            reLoad();
        }
    }
}
