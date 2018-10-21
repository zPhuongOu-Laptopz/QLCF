using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.Model
{
    public class Employee
    {
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

        public int SelectallObject()
        {

            return 0;
        }
    }
}
