using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceAssign
{
    class Employe
    {
        int empId;
        string empName;
        string empdesig;
        public Employe(int empid, string empName, string empdesig)
        {
            this.empId = empid;
            this.empName = empName;
            this.empdesig = empdesig;
        }

        public int EmpId { get => empId; set => empId = value; }
        public string EmpName { get => empName; set => empName = value; }
        public string Empdesig { get => empdesig; set => empdesig = value; }

        public override string ToString()
        {
            return "\nId " + this.empId + "\nName: " + this.empName + "\nProject Id: " + this.empdesig;
        }
        public override bool Equals(object obj)
        {
            Employe temp = (Employe)obj;
            if (this.empId == temp.empId)
                return true;
            else return false;
        }
    }
}
