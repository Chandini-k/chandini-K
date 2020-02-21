using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesWithDataTypes
{
    class Program
    {
        string name;//instance variable
        static double salary= 1000
            ;//static variable
        static void Main(string[] args)
        {
            int i=2;
            int[] a = new int[4] { 12, 13, 14, 15 }; 
            Console.WriteLine(i);
            Console.WriteLine(Program.salary);
            Program obj = new Program();
            Console.WriteLine(obj.name);
            object o1 = 100;
            o1 = "Ram";
            o1 = 14.5;
            Console.WriteLine(o1);
            int k =10;
            double sal = 1000;
            string name = "ROHAN";
            Console.WriteLine("Name:{0}\nAge:{1}\nSalary:{2}", name, k, sal) ;
            Console.ReadKey();
        }
    }
}
