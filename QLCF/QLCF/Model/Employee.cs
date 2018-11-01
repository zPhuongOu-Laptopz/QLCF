using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace QLCF.Model
{
    public class Employee
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public DateTime dayofbirth { get; set; }
        public string address { get; set; }
        public string hometown { get; set; }
        public string position { get; set; }
        public string phonenumber { get; set; }
        public string idcardnumber { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime startdate { get; set; }
        public DateTime enddate { get; set; }
        public bool active { get; set; }
        public double salary { get; set; }
        public double bonus { get; set; }
        public string branchWork { get; set; }

        public Employee()
        {
        }

        public Employee(string firstname, string lastname, DateTime dayofbirth, string address, string hometown, string position, string phonenumber, string idcardnumber, string email, string password, DateTime startdate, DateTime enddate, bool active, double salary, double bonus)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.dayofbirth = dayofbirth;
            this.address = address;
            this.hometown = hometown;
            this.position = position;
            this.phonenumber = phonenumber;
            this.idcardnumber = idcardnumber;
            this.email = email;
            this.password = password;
            this.startdate = startdate;
            this.enddate = enddate;
            this.active = active;
            this.salary = salary;
            this.bonus = bonus;
        }

        public static List<Employee> SelectallObject()
        {
            List<Employee> list = new List<Employee>();
            string connectionString = ConfigurationManager.ConnectionStrings["cStr"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                string query = "SELECT * FROM Employee";

                SqlCommand cmd = new SqlCommand(query, cn);
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Employee emp = new Employee();
                        emp.id = Convert.ToInt32(dataReader["id"]);
                        emp.firstname = dataReader["firstName"].ToString();
                        emp.lastname = dataReader["lastName"].ToString();
                        emp.dayofbirth = Convert.ToDateTime(dataReader["dob"]);
                        emp.address = dataReader["address"].ToString();
                        emp.hometown = dataReader["homeTown"].ToString();
                        emp.position = dataReader["position"].ToString();
                        emp.phonenumber = dataReader["phoneNumber"].ToString();
                        emp.idcardnumber = dataReader["idCardNumber"].ToString();
                        emp.email = dataReader["email"].ToString();
                        emp.password = dataReader["password"].ToString();
                        emp.startdate = Convert.ToDateTime(dataReader["startDay"]);
                        emp.enddate = Convert.ToDateTime(dataReader["endDay"]);
                        emp.salary = Convert.ToDouble(dataReader["salary"]);
                        emp.bonus = Convert.ToDouble(dataReader["bonus"]);
                        emp.branchWork = dataReader["branchWork"].ToString();
                        list.Add(emp);
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
                string query = "SELECT * FROM Employee WHERE id = " + id;

                SqlCommand cmd = new SqlCommand(query, cn);
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        this.id = Convert.ToInt32(dataReader["id"]);
                        this.firstname = dataReader["firstName"].ToString();
                        this.lastname = dataReader["lastName"].ToString();
                        this.dayofbirth = Convert.ToDateTime(dataReader["dob"]);
                        this.address = dataReader["address"].ToString();
                        this.hometown = dataReader["homeTown"].ToString();
                        this.position = dataReader["position"].ToString();
                        this.phonenumber = dataReader["phoneNumber"].ToString();
                        this.idcardnumber = dataReader["idCardNumber"].ToString();
                        this.email = dataReader["email"].ToString();
                        this.password = dataReader["password"].ToString();
                        this.startdate = Convert.ToDateTime(dataReader["startDay"]);
                        this.enddate = Convert.ToDateTime(dataReader["endDay"]);
                        this.salary = Convert.ToDouble(dataReader["salary"]);
                        this.bonus = Convert.ToDouble(dataReader["bonus"]);
                        this.branchWork = dataReader["branchWork"].ToString();
                    }
                }
                cn.Close();
            }
        }

        public void SelectObjectwithEmail(string email)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cStr"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                string query = "SELECT * FROM Employee WHERE email = " + email;

                SqlCommand cmd = new SqlCommand(query, cn);
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        this.id = Convert.ToInt32(dataReader["id"]);
                        this.firstname = dataReader["firstName"].ToString();
                        this.lastname = dataReader["lastName"].ToString();
                        this.dayofbirth = Convert.ToDateTime(dataReader["dob"]);
                        this.address = dataReader["address"].ToString();
                        this.hometown = dataReader["homeTown"].ToString();
                        this.position = dataReader["position"].ToString();
                        this.phonenumber = dataReader["phoneNumber"].ToString();
                        this.idcardnumber = dataReader["idCardNumber"].ToString();
                        this.email = dataReader["email"].ToString();
                        this.password = dataReader["password"].ToString();
                        this.startdate = Convert.ToDateTime(dataReader["startDay"]);
                        this.enddate = Convert.ToDateTime(dataReader["endDay"]);
                        this.salary = Convert.ToDouble(dataReader["salary"]);
                        this.bonus = Convert.ToDouble(dataReader["bonus"]);
                        this.branchWork = dataReader["branchWork"].ToString();
                    }
                }
                cn.Close();
            }
        }

        public void InsertEmployee()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cStr"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                string query = "INSERT INTO [dbo].[Employee] VALUES(N@firstName,N@lastName,@dob,N@[address],N@homeTown,N@position,@phoneNumber,@idCardNumber,@email,@[password],@startDay,@endDay,@active,@salary,@bonus,N@branchWork)";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@firstName", this.firstname);
                cmd.Parameters.AddWithValue("@lastName", this.lastname);
                cmd.Parameters.AddWithValue("@dob", this.dayofbirth);
                cmd.Parameters.AddWithValue("@[address]", this.address);
                cmd.Parameters.AddWithValue("@homeTown", this.hometown);
                cmd.Parameters.AddWithValue("@position", this.position);
                cmd.Parameters.AddWithValue("@phoneNumber", this.phonenumber);
                cmd.Parameters.AddWithValue("@idCardNumber", this.idcardnumber);
                cmd.Parameters.AddWithValue("@email", this.email);
                cmd.Parameters.AddWithValue("@[password]", this.password);
                cmd.Parameters.AddWithValue("@startDay", this.startdate);
                cmd.Parameters.AddWithValue("@endDay", this.enddate);
                cmd.Parameters.AddWithValue("@active", this.active);
                cmd.Parameters.AddWithValue("@salary", this.salary);
                cmd.Parameters.AddWithValue("@bonus", this.bonus);
                cmd.Parameters.AddWithValue("@branchWork", this.branchWork);

                cmd.ExecuteNonQuery();
            }
        }

        public void Update()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cStr"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                string query = "UPDATE [dbo].[Employee] SET [firstName] = N'" + this.firstname 
                    + "',[lastName] = N'" + this.lastname 
                    + "',[dob] = " + this.dayofbirth
                    + ",[address] = N'" + this.address
                    + "',homeTown = N'" + this.hometown
                    + "',position = N'" + this.position
                    + "',phoneNumber = " + this.phonenumber
                    + ",idCardNumber = " + this.idcardnumber
                    + ",startDay = " + this.startdate
                    + ",endDay = " + this.enddate
                    + ",active = " + this.active
                    + ",salary = " + this.salary
                    + ",bonus = " + this.bonus
                    + ",branchWork = N'" + this.branchWork
                    + "' WHERE id = " + this.id;

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
            }
        }

        public static bool Login(string username, string password)
        {
            Employee emp = null;
            try
            {
                emp = new Employee();
                emp.SelectObjectwithEmail(username);
            }
            catch 
            {
                return false;
            }
            if (emp != null && emp.password == username)
            {
                return true;
            }
            return false;
        }

        public void Search_Employee(string key, string value)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cStr"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                string query = "SELECT * FROM Employee WHERE " + key + " LIKE '%" + value + "%'";

                SqlCommand cmd = new SqlCommand(query, cn);
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        this.id = Convert.ToInt32(dataReader["id"]);
                        this.firstname = dataReader["firstName"].ToString();
                        this.lastname = dataReader["lastName"].ToString();
                        this.dayofbirth = Convert.ToDateTime(dataReader["dob"]);
                        this.address = dataReader["address"].ToString();
                        this.hometown = dataReader["homeTown"].ToString();
                        this.position = dataReader["position"].ToString();
                        this.phonenumber = dataReader["phoneNumber"].ToString();
                        this.idcardnumber = dataReader["idCardNumber"].ToString();
                        this.email = dataReader["email"].ToString();
                        this.password = dataReader["password"].ToString();
                        this.startdate = Convert.ToDateTime(dataReader["startDay"]);
                        this.enddate = Convert.ToDateTime(dataReader["endDay"]);
                        this.salary = Convert.ToDouble(dataReader["salary"]);
                        this.bonus = Convert.ToDouble(dataReader["bonus"]);
                        this.branchWork = dataReader["branchWork"].ToString();
                    }
                }
                cn.Close();
            }
        }
    }
}
