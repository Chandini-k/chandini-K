using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] marks = new int[5, 3];
            int col;
            Console.WriteLine("enter marks");
            for(int row=0;row<5;row++)
            {
                for(col=0;col<3;col++)
                {
                    marks[row, col] = int.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine("marks");
            for (int row = 0; row < 5; row++)
            {
                for (col = 0; col < 3; col++)
                {
                    Console.Write(" "+marks[row, col]+"\t");
                   

                }
                Console.WriteLine("\t");
            }
            //foreach (int x in marks)
                //Console.WriteLine(x);
            int topscore = 0;
            for (col=0;col<3;col++)
            {
                
                for(int row=0;row<5;row++)
                {
                    if (row == 0)
                        topscore = marks[row, col];
                    else
                    {
                        if (marks[row, col] > topscore) topscore = marks[row, col];

                    }
                }
                Console.WriteLine("highest of sub " + (col + 1) + " is " + topscore);
            }
            
            Console.ReadKey();
        }
    }
}
