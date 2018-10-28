using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.Model
{
    public class Branch
    {
        public int id { get; set; }
        public string branchName { get; set; }
        public string address { get; set; }
        public int eNumber { get; set; }
        public int eNumberExpect { get; set; }

        public Branch()
        {
        }

        public Branch(string branchName, string address, int eNumber, int eNumberExpect)
        {
            this.branchName = branchName;
            this.address = address;
            this.eNumber = eNumber;
            this.eNumberExpect = eNumberExpect;
        }

        public static List<Branch> SelectallObject()
        {
            List<Branch> list = new List<Branch>();
            string connectionString = ConfigurationManager.ConnectionStrings["cStr"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                string query = "SELECT * FROM Branch";

                SqlCommand cmd = new SqlCommand(query, cn);
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Branch br = new Branch();
                        br.branchName = dataReader["branchName"].ToString();
                        br.id = Convert.ToInt32(dataReader["id"]);
                        br.address = dataReader["address"].ToString();
                        br.eNumberExpect = Convert.ToInt32(dataReader["eNumber"]);
                        br.eNumber = Convert.ToInt32(dataReader["eNumberExpect"]);
                        list.Add(br);
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
                string query = "SELECT * FROM Branch WHERE id = " + id;

                SqlCommand cmd = new SqlCommand(query, cn);
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        this.id = Convert.ToInt32(dataReader["id"]);
                        this.branchName = dataReader["branchName"].ToString();
                        this.address = dataReader["address"].ToString();
                        this.eNumberExpect = Convert.ToInt32(dataReader["eNumber"]);
                        this.eNumber = Convert.ToInt32(dataReader["eNumberExpect"]);
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
                string query = "INSERT INTO [dbo].[Branch] VALUES (" + this.branchName + "," + this.address + "," + this.eNumber + "," + this.eNumberExpect + ")";

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
                string query = "UPDATE [dbo].[Branch] SET [branchName] = " + this.branchName + ",[address] = " + this.address + ",[eNumber] = " + this.eNumber + ",[eNumberExpect] = " + this.eNumberExpect + "WHERE id = " + this.id;

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
                string query = "DELETE FROM [dbo].[Branch] WHERE id = " + this.id;

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
