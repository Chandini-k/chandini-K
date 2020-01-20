using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonIheritance
{
    class Inheritanc
    {
        static void Main(string[] args)
        {
            //Vehicle veh = new Vehicle();
            Car alto = new Car("blue",150,"premium");
            Bus volvo = new Bus();
            //veh.start();
            //veh.stop();
            Console.WriteLine("\ncar");
            alto.start();
            alto.Drive();
            alto.fill_fuel();
            alto.stop();
            Console.WriteLine("\nBus");
            volvo.start();
            volvo.Run();
            volvo.fill_fuel();
            volvo.stop();
            Console.ReadLine();
        }
    }
}
