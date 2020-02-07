using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestAndSmallestArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of array");
            int n = int.Parse(Console.ReadLine());
            int[] number = new int[n];
            int high, low;
            Console.WriteLine("enter the numbers of array");
            for (int i = 0; i < n; i++)
            {
                number[i] = int.Parse(Console.ReadLine());

            }
            high = number[0];
            low = number[0];
            for (int i = 0; i < n; i++)
            {
                if(number[i]>high)
                {
                    high = number[i];
                    
                }
                if (number[i] < low)
                    low = number[i];

            }
            Console.WriteLine("high "+high);
            Console.WriteLine("low"+low);
            Console.ReadKey();
        }
    }
}
