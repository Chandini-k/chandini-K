using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {

            //Singleton fromEmployee = new Singleton();
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.printDetails("Emplyoee");
            //Singleton fromStudent = new Singleton();
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.printDetails("Student");
            Console.ReadLine();
        }
    }
}
