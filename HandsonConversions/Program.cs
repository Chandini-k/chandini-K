using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte i1 = sbyte.Parse("123");
            float f1 = float.Parse("123.3");
            decimal d1 = decimal.Parse("123.43");
            bool b = bool.Parse("true");
            Console.WriteLine("{0},{1},{2}", i1, f1, d1);
  
            Console.ReadKey();

        }
    }
    class Demo
    {
        static void Main(string[] arg)
        {
            string s = Convert.ToString(true);
            Console.WriteLine(s);
            s = Convert.ToString(1.23);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
