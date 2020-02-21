using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            Console.WriteLine("enter numbers");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int result=cal.Add(x,y);
            Console.WriteLine("add:" + result);
            cal.Subtract(x, y, out int sub);
            Console.WriteLine("sub:" + sub);
            cal.swap(ref x,ref y);
            Console.WriteLine("x value:"+x);
            Console.WriteLine("y value:" + y);
            Console.ReadLine();

        }
    }
}
