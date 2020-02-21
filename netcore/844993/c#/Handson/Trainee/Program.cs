using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainee
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            List<Trainee> elist = new List<Trainee>();
            Console.WriteLine("enter no of trainee");
            int n = int.Parse(Console.ReadLine());
          /*  int pid*/;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter id ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("enter name ");
                string name = Console.ReadLine();
                Console.WriteLine("enter project id ");
                int pid = int.Parse(Console.ReadLine());
                elist.Add(new Trainee(id, name, pid));
            }
            List<Trainee> pi = elist.FindAll(y => y.Projectid!=-1);
            foreach(Trainee p in pi)
            {
                Console.WriteLine(p);
            }
            Console.ReadLine();
   
        }
    }
}
