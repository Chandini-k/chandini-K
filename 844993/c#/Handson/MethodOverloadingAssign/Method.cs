using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingAssign
{
    class Method
    {
      static void Main(string[] args)
        {
            Delivery d = new Delivery();
            Console.WriteLine("MENU\n");
            Console.WriteLine("\n1.Player Details\n2.Run details");
            Console.WriteLine("\nEnter choice");
            int ch = int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    Console.WriteLine("Enter bowler name");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter batsman name");
                    string bname = Console.ReadLine();
                    d.DisplayDeliveryDetails(name,bname);
                    break;
                case 2:
                    Console.WriteLine("Runs details");
                    int runs = int.Parse(Console.ReadLine());
                    d.DisplayDeliveryDetails(runs);
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;

            }
            Console.ReadLine();
        }
    }

}
