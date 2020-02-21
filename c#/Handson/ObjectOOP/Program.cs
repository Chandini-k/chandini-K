using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOOP
{
    class Bike
    { 
        string name;
        string color;

        public void StartEngine()
        {
            Console.WriteLine("Bike Started at " + DateTime.Now.Hour);
        }
        public void FillGlass(int litre)
        {
            Console.WriteLine("Bill filled with " + litre + " litres");
        }
        public int Travel(int distance,int speed)
        {
            int time = (int)(distance / speed);
            Console.WriteLine("You will reach your destination in ");
            return time;
        }
        static void Main(string[] args)
        {
            Bike Enfield = new Bike();
            Enfield.StartEngine();
            Enfield.FillGlass(20);
            Console.WriteLine(+Enfield.Travel(100, 50)+"hr");
            Console.ReadLine();
        }
     
    }
    
}
