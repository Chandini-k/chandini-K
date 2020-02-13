using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysHandson
{
    class Search
    {
        static void Main()
        {
            string[] names = new string[8]
            {
                "chandu",
                "yash",
                "bhagya",
                "sanj",
                "rohi",
                "suma",
                "srija",
                "suppii"
            };
            int flag = 0;
            Console.WriteLine("enter string");
            string s = Console.ReadLine();
            foreach(string i in names)
            {
               
                if (s == i)
                {
                    flag = 1;
                    Console.WriteLine("exists");
                    break;
                }
                
            }
        if(flag==0)
                Console.WriteLine("not exists");

            Console.ReadKey();
        }
    }
}
