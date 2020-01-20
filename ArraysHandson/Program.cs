using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysHandson
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] i = new int[4];
            i[0] = 12;
            i[1] = 20;
            i[2] = 68;
            i[3] = 40;
            //accessing array value at index 2
            int k = i[2];
            Console.WriteLine(k);
            //display all array ele
            for(int a=0;a<4;a++)
            {
                Console.WriteLine(i[a]);
            }
            foreach(int j in i)
            {
                Console.WriteLine(j);
            }
            Console.ReadKey();
        }
    }
}
