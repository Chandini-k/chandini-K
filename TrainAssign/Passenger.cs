using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainAssign
{
    class Progra
    {
        static void Main(string[] args)
        {
            Passenger pa = new Passenger("chandu",25);
            Console.WriteLine("Enter noof tickets");
            int no_of_tickets = int.Parse(Console.ReadLine());
            pa.TicketBooking(no_of_tickets);
            Console.ReadLine();
        }
    }
    public class TicketException:Exception
    {
        public TicketException(string s) : base(s)
        {

        }

    }
    class Passenger
    {
        string name;
        int age;
        public Passenger(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public void TicketBooking(int no_of_tickets)
        {
            try
            {
                if (no_of_tickets > 2)
                    throw new TicketException("cannot book more than 2");
                else
                    Console.WriteLine("Tickets booked Successfully");
            }
            catch(TicketException t)
            {
                Console.WriteLine(t.Message + " " + t.StackTrace);
            }
            
        }
    }
}
