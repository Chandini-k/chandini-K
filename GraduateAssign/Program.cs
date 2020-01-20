using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            UnderGraduate ug = new UnderGraduate();
            Console.WriteLine("Grade for UG");
            int grade = int.Parse(Console.ReadLine());
            Console.WriteLine(ug.Ispassed(grade));
            Console.WriteLine("Grade for G");
            int grad = int.Parse(Console.ReadLine());
            Console.WriteLine(ug.Ispassed(grad));
            Console.ReadLine();

        }
    }
}
