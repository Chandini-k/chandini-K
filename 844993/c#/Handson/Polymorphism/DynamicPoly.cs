using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class A
    {
        public virtual void display()
        {
            Console.WriteLine("display A class details");
        }
    }
    class B:A
    {
        public override void display()
        {
            Console.WriteLine("display B class details");
        }
    }
    class C:A
    {
        public override
            void display()
        {
            Console.WriteLine("display C class details");
        }
    }
}

