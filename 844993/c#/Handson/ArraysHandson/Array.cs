using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysHandson
{
    class Array
    {
        static void Main()
        {
            int[] b = new int[5] { 10, 12, 23, 34, 38 };
            int sum = 0;
            foreach (int i in b)
            //sum=sum+i;
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
