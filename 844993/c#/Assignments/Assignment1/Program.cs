using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Input Your Year of Graduation: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("My Name is " + name + " and i will graduate in " + year);
        }
    }
}
