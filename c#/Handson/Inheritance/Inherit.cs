using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Inherit
    {
       /* static void Main(string[] args)
        {
            Parent pobj = new Parent();
            Child cobj = new Child();
            GrandChild gobj = new GrandChild();
            Console.WriteLine("parent class");
            pobj.getValues(12, "c#");
            pobj.display();
            Console.WriteLine("child class");
            cobj.getValues(25, "ASP.Net");
            cobj.display();
            cobj.Calculate(5);
            Console.WriteLine("Grandchild class");
            gobj.getValues(40, ".Net");
            gobj.display();
            gobj.Calculate(10);
            gobj.multiply(10);
            Protected.ExChild ex = new Protected.ExChild();
            ex.ExDisplay();
            Console.ReadLine();
        }*/
        static void Main(string[] args)
        {
            Vehicle veh = new Vehicle();
            Car alto = new Car();
            Bus volvo = new Bus();
            veh.start();
            veh.stop();
            alto.start();
            alto.Drive();
            alto.stop();
            volvo.start();
            volvo.Run();
            volvo.stop();
            Console.ReadLine();
        }
    }
}
