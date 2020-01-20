using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        public static void Display(int a, int b)
        {
            for(int i=a+1;i<b;i++)
            {
                Console.Write(+i+"\t");
            }
        }
        public static void EvenorOdd(int c)
        {
            if (c % 2 == 0)
            {
                
                Console.WriteLine("even");
            }
            else
                Console.WriteLine("odd");
        }
        public static void EvenorOddCount(int d,int e)
        {
            int count = 0, count1 = 0;
            for (int i = d; i <= e; i++)
            {
                if (i == 0)
                {
                    break;
                }
                else if (i % 2 == 0)
                {
                    count++;
                }
                else
                    count1++;
            }
            Console.WriteLine("no.of even nos " + count);
            Console.WriteLine("no.of odd nos " + count1);
        }
        public static double Temperature(double f)
        {
            double cel = (f - 32) * 5 / 9;
            return cel;
        }
        public static void Squares(int g)
        {
            int j;
            for(int i=0;i<=g;i++)
            {
                j = i * i;
                Console.Write(+j+"\t");
            }
        }
        public static int Fact(int h)
        {
            int fact = 1;
            for(int i=1;i<=h;i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        public static void Fib(int k)
        {
            int f1 = 0, f2 = 1, next;
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            for (int i=0;i<=k;i++)
            {
                next = f1 + f2;
                f1 = f2;
                f2 = next;
                Console.WriteLine(next);
            }
        }
        public static void Mul(int l)
        {
            int j;
            for(int i=1;i<=20;i++)
            {
                j = l * i;
                Console.WriteLine(+l + "*" + i + "=" + j);
            }
        }
        public static void Div(int m,int n)
        {
            for(int i=m;i<=n;i++)
            {
                if(i%7==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void Length(string str)
        {
            int l = 0;
            foreach(char ch in str)
                {
                l += 1;
            }
            Console.WriteLine(l); 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcometo the world of C#");
            string name = Console.ReadLine();
            Console.WriteLine("Hi "+ name+"\nwelcome to the world of c#");
            Console.WriteLine("enter nos");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Display(a, b);
            Console.WriteLine("\nenter no to check even or odd");
            int c = int.Parse(Console.ReadLine());
            EvenorOdd(c);
            Console.WriteLine("\nenter nos to count even and odd numbers");
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            EvenorOddCount(d, e);
            Console.WriteLine("\ntemperature");
            double f = double.Parse(Console.ReadLine());
            Console.WriteLine(Temperature(f));
            Console.WriteLine("\nsquares of numbers");
            int g = int.Parse(Console.ReadLine());
            Squares(g);
            Console.WriteLine("\nFactorial");
            int h= int.Parse(Console.ReadLine());
            Console.WriteLine(Fact(h));
            Console.WriteLine("\nFib series");
            int k = int.Parse(Console.ReadLine());
            Fib(k);
            Console.WriteLine("\nMultiplication");
            int l = int.Parse(Console.ReadLine());
            Mul(l);
            Console.WriteLine("\nDiv");
            int m= int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Div(m,n);
            Console.WriteLine("\nString length");
            string str = Console.ReadLine();
            Length(str);
            Console.ReadKey();
        }
    }
}


