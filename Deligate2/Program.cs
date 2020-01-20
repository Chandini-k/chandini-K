using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligate2
{
    public delegate double calAreaPointer(double x);
    class Program
    {
        static void Main(string[] args)
        {
            //calAreaPointer cptr = new calAreaPointer(delegate (double r)
            //                                                    {
            //                                                        return 3.14 * r * r;
            //                                                    });
            //double area = cptr(12);
            //Console.WriteLine(area);
            //////above code you can simpilfy with lamda
            //calAreaPointer cptr1 = (r => 3.14 * r * r);
            //double area1 = cptr1(10);
            //Console.WriteLine(area1);
            //prebuild delegates Fun<>,Action<>,Predicate<>
            Func<double, double> f1 = (r => 3.14 * r * r);
            double area2=f1(12);
            Console.WriteLine(area2);
            Action<string> act = (x => Console.WriteLine(x));
            act("welcome");
            Predicate<string> pt = (y => y.Length > 3);
            Console.WriteLine(pt("ctsyrtr"));
            int[] array = new int[] { 1, 2, 3, 4 };
            List<string> names = new List<string>();
            names.Add("chandu");
            names.Add("suma");
            names.Add("srija");
            int a = array.Count(x => x > 4);
            Console.WriteLine(a);
            List<string> sn = names.FindAll(y => y.Contains('y'));
            foreach(string n in sn)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();

        }
        //public static double calArea(double r)
        //{
        //    return 3.14 * r * r;
        //}
    }
}
