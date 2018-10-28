using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.Model
{
    public class Food
    {
        public int id { get; set; }
        public string foodName { get; set; }
        public double price { get; set; }
        public string state { get; set; }

        public Food()
        {
        }

        public Food(string foodName, double price, string state)
        {
            this.foodName = foodName;
            this.price = price;
            this.state = state;
        }

        public static List<Food> SelectallObject()
        {
            List<Food> list = new List<Food>();
            string connectionString = ConfigurationManager.ConnectionStrings["cStr"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                string query = "SELECT * FROM Food";

                SqlCommand cmd = new SqlCommand(query, cn);
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Food fo = new Food();
                        fo.id = Convert.ToInt32(dataReader["id"]);
                        fo.foodName = dataReader["food"].ToString();
                        fo.state = dataReader["state"].ToString();
                        fo.price = Convert.ToInt32(dataReader["price"]);
                        list.Add(fo);
                    }
                }
                cn.Close();
            }

            return list;
        }

        public void SelectObjectwithID(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cStr"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                string query = "SELECT * FROM Food WHERE id = " + id;

                SqlCommand cmd = new SqlCommand(query, cn);
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        this.id = Convert.ToInt32(dataReader["id"]);
                        this.foodName = dataReader["food"].ToString();
                        this.state = dataReader["state"].ToString();
                        this.price = Convert.ToInt32(dataReader["price"]);
                    }
                }
                cn.Close();
            }
        }

        public void Insert()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cStr"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                string query = "INSERT INTO [dbo].[Food] VALUES (" + this.foodName + "," + this.price + "," + this.state + ")";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cStr"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                string query = "UPDATE [dbo].[Food] SET [food] = " +  this.foodName + ",[price] = " + this.price + ",[state] = " + this.state + "WHERE id = " + this.id;

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cStr"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                string query = "DELETE FROM [dbo].[Food] WHERE id = " + this.id;

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
