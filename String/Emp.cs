using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strng
{
    class Emp
    {
        string name;
        string empId;
        int salary;
        public Emp()
        {

        }
        public Emp(string name,string empId,int salary)
        {
            this.name = name;
            this.empId = empId;
            this.salary = salary;
        }
        public override string ToString()
        {
            return this.name + "\n" + this.empId + "\n" + this.salary;
        }
        public override bool Equals(object obj)
        {
            Emp temp = (Emp)obj;
            if(this.empId==temp.empId&&this.name==temp.name)
            {
                return true;
            }
            else
            return false;
        }
    }
}
