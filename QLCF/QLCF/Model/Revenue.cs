using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.Model
{
    public class Revenue
    {
        public int id { get; set; }

        public string name { get; set; }
        public string month { get; set; }
        public string year { get; set; }
        public double money { get; set; }

        public Revenue(int id, string name, string month, string year, double money)
        {
            this.id = id;
            this.name = name;
            this.month = month;
            this.year = year;
            this.money = money;
        }

        public Revenue(string name, string month, string year, double money)
        {
            this.name = name;
            this.month = month;
            this.year = year;
            this.money = money;
        }

        public Revenue()
        {
        }

        public static List<Revenue> SelectallObject()
        {
            List<Revenue> list = new List<Revenue>();
            string connectionString = ConfigurationManager.ConnectionStrings["cStr"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                string query = "SELECT * FROM revenue";

                SqlCommand cmd = new SqlCommand(query, cn);
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Revenue fo = new Revenue();
                        fo.id = Convert.ToInt32(dataReader["id"]);
                        fo.name = dataReader["name"].ToString();
                        fo.year = dataReader["year"].ToString();
                        fo.month = dataReader["month"].ToString();
                        fo.money = Convert.ToDouble(dataReader["money"].ToString());
                        list.Add(fo);
                    }
                }
                cn.Close();
            }

            return list;
        }

        public void Insert()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cStr"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                string query = "INSERT INTO [dbo].[revenue] VALUES (N'" + this.name + "'," + this.month + "," + this.year + "," + this.money + ")";

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
                string query = "UPDATE [dbo].[revenue] SET [name] = N'" + this.name + "',[money] = " + this.money + " WHERE [month] = " + this.month + " AND [year] = " + this.year;

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
            }
        }

        public static List<Revenue> SelectallObject_WithYear(string year)
        {
            List<Revenue> list = new List<Revenue>();
            string connectionString = ConfigurationManager.ConnectionStrings["cStr"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                string query = "SELECT * FROM revenue where year = " + year + "Order by month";

                SqlCommand cmd = new SqlCommand(query, cn);
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Revenue fo = new Revenue();
                        fo.id = Convert.ToInt32(dataReader["id"]);
                        fo.name = dataReader["name"].ToString();
                        fo.year = dataReader["year"].ToString();
                        fo.month = dataReader["month"].ToString();
                        fo.money = Convert.ToDouble(dataReader["money"].ToString());
                        list.Add(fo);
                    }
                }
                cn.Close();
            }

            return list;
        }

        public static List<Revenue> SelectallObject_WithMonthYear(string month, string year)
        {
            List<Revenue> list = new List<Revenue>();
            string connectionString = ConfigurationManager.ConnectionStrings["cStr"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                string query = "SELECT * FROM revenue where year = " + year + " and month = " + month;

                SqlCommand cmd = new SqlCommand(query, cn);
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Revenue fo = new Revenue();
                        fo.id = Convert.ToInt32(dataReader["id"]);
                        fo.name = dataReader["name"].ToString();
                        fo.year = dataReader["year"].ToString();
                        fo.month = dataReader["month"].ToString();
                        fo.money = Convert.ToDouble(dataReader["money"].ToString());
                        list.Add(fo);
                    }
                }
                cn.Close();
            }

            return list;
        }
    }
}
