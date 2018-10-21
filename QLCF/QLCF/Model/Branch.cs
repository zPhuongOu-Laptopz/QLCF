using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.Model
{
    public class Branch
    {
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
    }
}
