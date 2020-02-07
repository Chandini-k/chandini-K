using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial
{
    partial class ClassA
    {
        partial void setData();
        public void print()
        {
            Console.WriteLine("class A printing");
            setData();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            ClassA obj = new ClassA();
            obj.print();
        }
    }
}
