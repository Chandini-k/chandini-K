﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.Month);
            Console.WriteLine(dt.Date);
            Console.WriteLine(dt.Year);
            Console.WriteLine(dt.AddDays(20));
            dt = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(dt);
            dt = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            Console.WriteLine(dt);
            string s = Console.ReadLine();
            if (DateTime.TryParse(s, out dt))
                Console.WriteLine(dt);
            else
                Console.WriteLine("not valid date");
                       Console.ReadLine();
        }
    }
}
