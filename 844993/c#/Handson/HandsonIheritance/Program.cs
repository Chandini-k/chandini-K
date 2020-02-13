using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonIheritance
{
    abstract class Vehicle//it can have method with or without definitons
    {
        protected string color;
        public Vehicle()
        {
            this.color = "white";
            Console.WriteLine("constructor for vehicle");
        }
        public Vehicle(string clr)//parent parameter constructor has to be invoked using base keyword and providing value
        {
            this.color = clr;
            Console.WriteLine("parameter constructor");
        }
        public abstract void fill_fuel();//child should compulsory override
        public virtual void start()//child may or maynot override
        {

            Console.WriteLine("vehicle started");
        }
        public void stop()
        {
            Console.WriteLine("vehicle stopped");
        }
    }
    class Bus : Vehicle
    {
        int seating;
        int speed;
        public Bus():base("Red")
        {

            this.seating = 4;
            this.speed = 70;
            Console.WriteLine("constructor for bus");
        }
        public override void fill_fuel()
        {
            Console.WriteLine("diesel");
        }
        public override void start()
        {
            Console.WriteLine("Started");
        }
        public void Run()
        {
            Console.WriteLine(this.color + " Bus is running at speed " + this.speed + " with seating " + this.seating);
        }
    }
    class Car : Vehicle
    {
        string type;

        int speed;
        public Car()
        {
           
            this.type = "standard";
            this.speed = 70;
            Console.WriteLine("constructor for car");
        }
        public override void fill_fuel()
        {
            Console.WriteLine("diesel or petrol");
        }
        public Car(string colr,int speed,string type):base(colr)
        {
            //this.color = colr;
            this.speed = speed;
            this.type = type;
        }
        public void Drive()
        {
            Console.WriteLine(this.color + " car is driving at speed " + this.speed + "  with type " + this.type);
        }
    }
}
