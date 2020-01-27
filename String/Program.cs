using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strng
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string str = "welcome";
            Console.WriteLine(str.Length + "\n" + str.Replace("e", "a") + "\n" + str.ToLower());
            Console.WriteLine(str.Contains("lc"));
            Console.WriteLine(String.Compare("hello", "Hello"));
            string str2 = "WELCOME";
            Console.WriteLine(str.Equals(str2, StringComparison.InvariantCultureIgnoreCase));
            string st = "cts";
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(st);
            int n = string.Compare("welcome", 3, "come", 0, 4, StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine("compare "+n);
            n = string.Compare(st,"welcome to chennai",StringComparison.InvariantCultureIgnoreCase);
            //string st1 = "WELCOME";
            //Console.WriteLine(str.Equals(str2, StringComparison.InvariantCultureIgnoreCase));
            string input = Console.ReadLine();
            string[] data = input.Split(' ', '/');
            int[] num2 = Array.ConvertAll(data, Convert.ToInt32);
            int[] num = new int[data.Length];
            for(int j=0;j<data.Length;j++)
            {
                num[j] = Convert.ToInt32(data[0]);
            }
            foreach(string val in data)
            {
                Console.WriteLine(val);
            }
            foreach(int val in num2)
            {
                Console.WriteLine(val);
            }
            int k = 90;
            double d = 2.345;
            Console.WriteLine(k.ToString() + " " + d.ToString());
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString("dd/MM/yyyy") + " " + dt.ToString("dddd,dd/MM/yyyy") + " " + dt.ToString("MMM/dd/yyyy \t HH:mm:ss"));*/
            int[] ix = new int[] { 1, 2, 3, 4 };
            Emp[] eArray = new Emp[3] { new Emp("chandu", "100", 25000), new Emp("suma", "101", 25000), new Emp("srija", "102", 25000) };
            foreach(Emp e in eArray)
            {
                Console.WriteLine(e.ToString());
            }
            List<Emp> elist = new List<Emp>();
            elist.Add(new Emp("yash", "103", 22000));
            elist.Add(new Emp("bhagya", "104", 23000));
            elist.Add(new Emp("sanju", "105", 26000));
            foreach (Emp e in elist)
            {
                Console.WriteLine(e.ToString());
            }
            Emp e1 = new Emp("Ram", "300", 20000);
            Emp e2 = new Emp("Ram", "30", 20000);
            if(e1.Equals(e2))
            {
                Console.WriteLine("equal");
            }
            else
                Console.WriteLine("not equal");
            Console.ReadLine();
        }

    }
}
