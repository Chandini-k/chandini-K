using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Models
{
    public class Employee1Repository:IEmployee1Repository
    {
        public List<Employee1> emplist;
        public Employee1Repository()
        {
            emplist=new List<Employee1>() { new Employee1(1,"Ajay","abcd@gmail.com",Dept.Insurance),
                new Employee1(2,"afe","abcd@gmail.com",Dept.HealthCare),
                new Employee1(3,"ewfcwe","abcd@cts.com",Dept.Accounts)};
        }
        public Employee1 GetEmployee1(int id)
        {
            Employee1 e = emplist.FirstOrDefault(e => e.Id == id);
            return e;
        }
        public List<Employee1> DisplayDetails()
        {
            return emplist;
        }
        public bool AddEmployee(Employee1 emp)
        {
            emp.Id = emplist.Max(e => e.Id) + 1;
            emplist.Add(emp);
            return true;
        }       
    }
}
