using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DAYSCHOLAR");
            string name = Console.ReadLine();
            int Id = int.Parse(Console.ReadLine());

            Dayscholar ds = new Dayscholar(name,Id);
            Console.WriteLine("RESIDENT");
            string name1 = Console.ReadLine();
            int Id1 = int.Parse(Console.ReadLine());

            Resident rs = new Resident(name1,Id1);
       
            ds.ShowDetails();
            rs.ShowDetails();
            Console.ReadLine();
        }
    }
}
