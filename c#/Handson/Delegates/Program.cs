using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void deligatePointer();
    public delegate double calareaPointer(double x);
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            Program p = new Program();
            Calculate c = new Calculate();
            // deligatePointer mydeligate = new deligatePointer(p.print);
            deligatePointer mydeligate = p.print;
            mydeligate += p.display;
            mydeligate();
            mydeligate -= p.display;
            mydeligate();
            calareaPointer cptr = Calculate.calArea;
            double area = cptr(20);
            Console.WriteLine(area);
            Console.ReadLine();
        }
        public void print()
        {
            Console.WriteLine("deligate");
        }
        public void display()
        {
            Console.WriteLine("Welcome");
        }
    }
}
