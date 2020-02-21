using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Shape
    {
        int length;
        int width;
        int breadth;
        string name;
        public void draw()
        {
            Console.WriteLine("A shape can be drawn");
        }
        public void draw(int l)
        {
            this.length = l;
            Console.WriteLine("A square can be drawn");
        }
        public void draw(int l,int w)
        {
            
            this.width = w;
            Console.WriteLine("A rectangle can be drawn");
        }
        public void draw(int l,int w,int b)
        {
            
            this.breadth = b;
            Console.WriteLine("A box can be drawn");
        }
        public void draw(int l, int w, int b,string name)
        {
            
            Console.WriteLine(name+"  can be drawn");
        }
    }
}
