using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Shape pic = new Shape();
            //    pic.draw();
            //    pic.draw(10);
            //    pic.draw(10, 20);
            //    pic.draw(10, 20, 30);
            //    pic.draw(1, 1, 1, "cube");
            //    Console.ReadLine();
            A obj = new A();
            obj.display();
            obj = new B();
            obj.display();
            obj = new C();
            obj.display();
            Console.ReadLine();
        }
    }
}
