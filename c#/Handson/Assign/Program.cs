using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the array size");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            if (size % 2 == 0)
            {
                Console.WriteLine("enter only odd number");
               
            }
            else
            {
                
                for (int i = 0; i < size; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
            }
            if (size == 1)
            {
                Console.WriteLine("largest is " + a[0]);

            }
            else
            {
                int first = a[0];
                int middle = a[size / 2];
                int last = a[size - 1];
                if (first > middle && first > last)
                {
                    Console.WriteLine("largest is " + first);
                }
                else if (middle > first && middle > last)
                {
                    Console.WriteLine("largest is " + middle);
                }
                else
                {
                    Console.WriteLine("largest is " + last);
                }
            }
            Console.ReadKey();
        }
    }
}
