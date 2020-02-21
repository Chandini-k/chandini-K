using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCAssign.Models;

namespace MVCAssign.Repositories
{
    public class EmployeeRepository
    {
        public static List<Employee> elist = new List<Employee>()
        {
            new Employee() {
             Empid=123,
            Name = "Chandu",
             Designation="FSE",
            Pwd = "1234"
            }
        };

        public EmployeeRepository()
        {
        }
        public void Add(Employee e)
        {
            elist.Add(e);//Add User data into list
        }
        public Employee Validate(int empid, string pwd)
        {
            foreach (var e in elist)
            {
                if (e.Empid == empid && e.Pwd == pwd)
                {
                    return e;
                }
            }
            return null;
        }
    }
}
