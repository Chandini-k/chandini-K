using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Year = 2019;
            //string[] ar = new string[] { "maruthi", "benz" };
            //c.Name = ar;
            c[0] = "maruthi";
            c[1] = "benz";
            c[2] = "honda";
            c.display();
        }
    }
}
