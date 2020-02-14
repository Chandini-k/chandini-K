using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonConditionalStmnts
{
    class Program
    {
        public static string EvenorOdd(int i)
        {
            if (i % 2 == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        }
        public static int Max(int i,int j,int k)
        {
            if(i>j)
            {
                if (i > k)
                    return i;
                else
                    return k;
            }
            else
            {
                if (j > k)
                    return j;
                else
                    return k;
            }
        }
        public static string Result(double m1,double m2, double m3,double m4)
        {
            double avg = (m1 + m2 + m3 + m4) / 5;
            if (avg >= 70)
                return "distinction with"+avg+"%";
            else if (avg >= 60 && avg < 70)
                return "first class with" + avg + "%";
            else if (avg >= 50 && avg < 60)
                return "second class with" + avg + "%";
            else
                return "fail";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter no");
            int i = int.Parse(Console.ReadLine());
            string res=EvenorOdd(i);
            Console.WriteLine(res);
            Console.WriteLine(Max(12, 24, 22));
            Console.WriteLine(Result(80, 90, 90, 95));
            Console.ReadKey();
          
        }
    }
}
