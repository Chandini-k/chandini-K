using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonIterativeStmnts
{
    class Program
    {
        public static void Greet(string name)
        {
            int flag = 1;
            while(flag<=10)
            {
                Console.WriteLine("Hello " + name);
                flag++;
            }
        }
        public static void DisplayNaturalNo(int i)
        {
            int flag = 1;
            while (flag <= i)
            {
                Console.Write(flag +" ");
                flag++;
            }
        }
        public static void DisplayWhole(int i)
        {
            int flag = 0;
            do
            {
                Console.Write(flag+"\t");
                flag++;
            } while (flag <= i);
        }
        public static int Factorial(int i)
        {
            int fact = 1,j=1;
            //for(int j=1;j<=i;j++)
            //{
              //  fact = fact * j;
            //}
            for(; ; )
            {
                if (j <= i)
                {
                    fact = fact * j;
                    j++;
                }
                else break;
            }
            return fact;
        }
        public static void DisplayEven(int n)
        {
            for(int j=1;j<=n;j++)
            {
                if (j % 2 == 1)
                    continue;
                Console.Write(j+"\t");
            }
        }
        public static string Vowel(char ch)
        {
            string result = null;
            switch(ch)
            {
                case 'a':
                    result = "vowel";
                    break;
                case '1':
                    result = "vowel";
                    break;
                case 'e':
                    result = "vowel";
                    break;
                case 'o':
                    result = "vowel";
                    break;
                case 'u':
                    result = "vowel";
                    break;
                default:
                    result = "invalid";
                    break;

            }
            return result;
        }
        public static void Menu(int n)
        {
            
            Console.WriteLine("enter your choice");
            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    if (n % 2 == 0)
                        Console.WriteLine("even");
                    else
                        Console.WriteLine("odd");
                    break;
                case 2:
                    for(int i=1;i<=n;i++)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                case 3:
                    for (int i = 1; i <= 10; i++)
                    {
                        int j;
                        j = n * i;
                        Console.WriteLine(n+"*"+i+ "=" +j);
                    }
                    break;
                case 4:
                    break;

            }
        }


        static void Main(string[] args)
        {
            //Greet("chandu");
            //DisplayNaturalNo(100);
            //DisplayWhole(40);
            //Console.WriteLine(Factorial(5));
            //DisplayEven(100);
            //Console.WriteLine(Vowel('a'));
            Console.WriteLine("enter your no");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("1.Even or odd\n2.Naturalno\n3.Multiplication\n4.exit");
            Menu(n);

            Console.ReadKey();
        }
    }
}
