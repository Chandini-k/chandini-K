using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAssign
{
    public class Student
    {
        protected int id;
        protected string name;
        protected double examFee;
        public Student(int id, string name, double examfee)
        {
            this.id = id;
            this.name = name;
            this.examFee = examfee;
        }
        public void displaydetails()
        {
            Console.WriteLine("Student id: " + this.id + " with name " + this.name + " and the examfee " + this.examFee);
        }
        public double payFee()
        {
            Console.WriteLine("you should pay fee" + this.examFee);
            return examFee;
        }
    }
    public class Dayscholar : Student
    {
        double transportFee;
        public Dayscholar(int id, string name, double examfee, double transFee) : base(id, name, examfee)
        {
            this.transportFee = transFee;
        }
        public void displaydetails()
        {
            Console.WriteLine("Student id: " + this.id + " with name " + this.name + " and the examfee " + this.examFee+" with transport fee "+this.transportFee);
        }
    }
}
    


