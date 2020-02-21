using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateAssign
{
   abstract class Student
    {
        string name;
        int studentId;
        int grade;
        public abstract Boolean Ispassed(int grade);
    }
    class UnderGraduate : Student
    {
        public override bool Ispassed(int grade)
        {
           
            if (grade > 70)
                return true;
            else
                return false;
        }
    }
    class Graduate : Student
    {
        public override bool Ispassed(int grade)
        {
            
            if (grade > 80)
                return true;
            else
                return false;
        }
    }

}
