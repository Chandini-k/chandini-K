using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignJagged
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] a = new int[2][];
            for(int row=0;row<2;row++)
            {
                for(int col=0;col<a[row].Length;col++)
                {
                    Console.Write(" " + a[row][col] + "\t");
                }
                Console.WriteLine();
            }
            for(int row=0;row<2;row++ )
            {
                for(int col=0;col<a[row].Length;col++)
                {

                }
            }

        }
    }
}
