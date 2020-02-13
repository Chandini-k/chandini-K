using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Parent
    {
       
           protected internal int a;
           protected string b;
            public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
            public string B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public void getValues(int x,string y)
        {
            this.A = x;
            this.B = y;
        }
        public void display()
        {
            Console.WriteLine(this.A + " " + this.B);
        }
    }
           
    class Child:Parent
    {
        protected int c;
        public void Calculate(int num)
        {
            c = this.a + num;                                                                                               um;
            Console.WriteLine(c);
        }
    }
    class GrandChild:Child
    {
        int d;
        public void multiply(int num2)
        {
            this.d = num2;
            Console.WriteLine(this.d * this.c * this.a);
        }
    }
        
}
namespace Protected
{
    class ExChild:Inheritance.Parent
    {
        public void ExDisplay()
        {
            Console.WriteLine(this.a + " " + this.b);
        }
    }
}