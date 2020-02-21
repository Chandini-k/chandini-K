using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Vehicle
    {
        protected string color;
        public Vehicle()
        {
            this.color = "white";
            Console.WriteLine("constructor for vehicle");
        }
        public void start()
        {
            
            Console.WriteLine("vehicle started");
        }
        public void stop()
        {
            Console.WriteLine("vehicle stopped");
        }
    }
    class Bus:Vehicle
    {
        int seating;
        int speed;
        public Bus()
        {
            
            this.seating = 4;
            this.speed = 70;
            Console.WriteLine("constructor for bus");
        }
        public void Run()
        {
            Console.WriteLine(this.color+"Bus is running at speed "+this.speed+" with seating "+this.seating );
        }
    }
    class Car:Vehicle
    {
        string type;

        int speed;
        public Car()
        {

            this.type = "standard";
            this.speed = 70;
            Console.WriteLine("constructor for bus");
        }
        public void Drive()
        {
            Console.WriteLine(this.color+"car is driving at speed " + this.speed + "  with type " + this.type);
        }
    }
}
