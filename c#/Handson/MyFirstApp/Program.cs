﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome CTS..");
            Console.WriteLine("Enter your name..");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.ReadKey();//to read console output
        }
    }
}
