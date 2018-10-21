using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.Model
{
    public class Drink
    {
        public int id { get; set; }
        public string drinkName { get; set; }
        public double price { get; set; }
        public string state { get; set; }

        public Drink()
        {
        }

        public Drink(string drinkName, double price, string state)
        {
            this.drinkName = drinkName;
            this.price = price;
            this.state = state;
        }

        public static List<Drink> SelectallObject()
        {
            List<Drink> list = new List<Drink>();
            string connectionString = ConfigurationManager.ConnectionStrings["cStr"].ConnectionString;
            using (SqlConnection cn = new SqlConnection())
            {
                cn.Open();
                string query = "SELECT * FROM Drink";

                SqlCommand cmd = new SqlCommand(query, cn);
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Drink dr = new Drink();
                        dr.id = Convert.ToInt32(dataReader["id"]);
                        dr.drinkName = dataReader["drink"].ToString();                        
                        dr.state = dataReader["state"].ToString();
                        dr.price = Convert.ToInt32(dataReader["price"]);
                        list.Add(dr);
                    }
                }
                cn.Close();
            }

            return list;
        }

        public void SelectObjectwithID(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cStr"].ConnectionString;
            using (SqlConnection cn = new SqlConnection())
            {
                cn.Open();
                string query = "SELECT * FROM Branch WHERE id = " + id;

                SqlCommand cmd = new SqlCommand(query, cn);
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        this.id = Convert.ToInt32(dataReader["id"]);
                        this.drinkName = dataReader["drink"].ToString();
                        this.state = dataReader["state"].ToString();
                        this.price = Convert.ToInt32(dataReader["price"]);
                    }
                }
                cn.Close();
            }
        }
    }
}
