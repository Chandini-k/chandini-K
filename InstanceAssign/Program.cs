using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employe> elist = new List<Employe>();
            int id;
            Console.WriteLine("Menu");
            Console.WriteLine("\n1.Insert EmployeeDetails\n2.Display all Employee details\n.3.Update employee details based on ID\n4.Delete specific employee");
            while (true)
            {
                Console.WriteLine("\nEnter choice");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                       
                        Console.WriteLine("enter no.of employees");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter Employee details");
                        //for (int i = 0; i < n1; i++)
                        //{
                            Console.WriteLine("enter id ");
                           id = int.Parse(Console.ReadLine());
                            Console.WriteLine("enter name ");
                            string name = Console.ReadLine();
                            Console.WriteLine("enter designation");
                            string desig = Console.ReadLine();
                            elist.Add(new Employe(id, name, desig));
                        //}
                        break;
                    case 2:
                        Console.WriteLine("display employee details");
                        foreach (var s in elist)
                            Console.WriteLine(s.ToString());
                        break;
                    case 3:
                        Console.WriteLine("enter id to update");
                        id = int.Parse(Console.ReadLine());
                        foreach(Employe i in elist)
                        {
                            if(i.EmpId==id)
                            {
                                Console.WriteLine("enter id and designation to update"); 
                            }
                            id = int.Parse(Console.ReadLine());
                            string des = Console.ReadLine();
                            i.EmpId = id;
                            i.Empdesig = des;
                            Console.WriteLine("press any key to continue\n");
                        }
                        break;
                    case 4:
                        Console.WriteLine("enter remove id");
                        id = int.Parse(Console.ReadLine());
                        Employe e = elist.Find(a => a.EmpId == id);
                        elist.Remove(e);
                        break;
                }
                Console.ReadLine();
            }
            
        }
            
    }
}
