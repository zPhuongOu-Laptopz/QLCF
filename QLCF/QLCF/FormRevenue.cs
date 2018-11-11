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
    public partial class FormRevenue : Form
    {
        public FormRevenue()
        {
            InitializeComponent();
        }

        private void reLoad()
        {
            List<Model.Revenue> list = new List<Revenue>();
            list = Revenue.SelectallObject();

            data_Revenue.DataSource = list;
        }

        private List<Revenue> return_full_list(List<Revenue> list)
        {
            list = Revenue.SelectallObject_WithYear(cbb_chooseYears.Text);

            //if (list.Count != 12)
            //{

            //}
            return list;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void FormRevenue_Load(object sender, EventArgs e)
        {
            reLoad();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            List<Revenue> list = new List<Revenue>();
            list = Revenue.SelectallObject_WithMonthYear(cbb_months.Text, cbb_years.Text);
            if (list.Count == 0)
            {
                Revenue re = new Revenue(txt_name.Text, cbb_months.Text, cbb_years.Text, Double.Parse(txt_money.Text));
                re.Insert();
                reLoad();
            }
            else
            {
                Revenue re = new Revenue(txt_name.Text, cbb_months.Text, cbb_years.Text, Double.Parse(txt_money.Text));

                re.Update();
                reLoad();
            }
        }


        private void btn_submit_Click(object sender, EventArgs e)
        {
            chart.Series["Doanh thu"].Points.Clear();
           string year = cbb_chooseYears.Text;
           List<Revenue> list = Revenue.SelectallObject_WithYear(cbb_chooseYears.Text);
           
            for (int i = 1; i < 13; i++)
            {
                double _value = Return_Exist(i.ToString(), year, list);
                if (_value != 0)
                {
                    chart.Series["Doanh thu"].Points.AddXY(i + "/" + year, _value);
                }
                else
                {
                    chart.Series["Doanh thu"].Points.AddXY(i + "/" + year, _value);
                }
            }
        }

        private double Return_Exist(string _month, string _year, List<Revenue> list)
        {
            foreach (var item in list)
            {
                if (item.month == _month && item.year == _year)
                {
                    return item.money;
                }
            }
            return 0;
        }
    }
}
