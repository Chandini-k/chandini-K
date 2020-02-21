using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingAssign
{
    class Delivery
    {
        public 
            void DisplayDeliveryDetails(string bowler,string batsman)
        {
            Console.WriteLine("Name of bowler: " + bowler + "\nName of batsman: " + batsman);
        }
        public void DisplayDeliveryDetails(long runs)
        {
            if (runs == 6)
            {
                Console.WriteLine("SIX: " + runs);
            }
            else if (runs == 4)
            {
                Console.WriteLine("FOUR: " + runs);
            }
            else
                Console.WriteLine(runs);
        }
    }
}
