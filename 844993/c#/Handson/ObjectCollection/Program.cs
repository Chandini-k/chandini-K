using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCollection
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> elist = new List<Employee>();
            elist.Add(new Employee("chandu", "100", 250000));
            elist.Add(new Employee("yash", "101", 240000));
            elist.Add(new Employee("bhagya", "102", 270000));
            elist.Add(new Employee("sanj", "103", 260000));
            elist.Add(new Employee("suma", "104", 290000));
            List<Employee> highpay = elist.FindAll(e => e.salary > 260000);
            foreach(Employee el in highpay)
            {
                Console.WriteLine(el.ToString());
            }
            Console.ReadLine();


        }
    }
}
