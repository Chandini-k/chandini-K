using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankk
{
    class Program
    {
        static void Main(string[] args)
        {
            ICICI chn = new ICICI("icici 001", "chennai", "Arun");
            SBI hyd = new SBI("SBI 003", "hyd", "cha");
            chn.displayDetails();
            chn.getinterest();
            chn.displaydmat();
            hyd.displayDetails();
            hyd.getinterest();
            hyd.goldinterest();
            Console.ReadLine();
        }
    }
}
