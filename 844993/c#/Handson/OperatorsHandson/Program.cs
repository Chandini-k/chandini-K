using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsHandson
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 12;
            byte c = (byte)(b + 12);
            long l2 = 12500;
            int i2 = (int) l2;
            int i = 256;
            byte b1 = (byte)i;
            float f = 12.5f;
            int f1 = (int)f;
            Console.WriteLine(c);
            Console.WriteLine(i2);
            Console.WriteLine(b1);
            Console.WriteLine(f1);
            Console.ReadKey();
            
            
        }
    }
}
