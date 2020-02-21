using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class StudentDetails
    {
        string name;
        private string branch;
        int rollno, mark,sem;
        public string Name
        {
            get;
            set;
        }
        public int Rollno
        {
            get
            {
                return rollno;
            }
            set
            {
                rollno = value;
            }
        }
        private string Branch

        {
            get
            {
                return branch;
            }
            set
            {
                branch = value;
            }
            
        }
        public int Sem
        {
            get
            {
                return sem;
            }
            set
            {
                sem = value;
            }
        }
        public int Mark
        {
            get
            {
                return mark;
            }
           
        }
        public StudentDetails()//default
        {
            this.rollno = 0;
            this.Name = "c";
            this.mark = 0;
            this.sem = 8;
            this.branch = "cse";
           
        }
        public StudentDetails(string name,int rollno,string branch,int sem,int marks)
        {
            this.Name = name;
            this.rollno = rollno;
            this.branch = branch;
            this.sem = sem;
            this.mark = marks;
        }
        public void AcceptStudentDetails()
        {
           //Console.WriteLine("Student name");
            //Name = Console.ReadLine();
            Console.WriteLine("Student brach");
            this.Branch = Console.ReadLine();
            //Console.WriteLine("Student rollno");
            //Rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("Student marks");
            this.mark = int.Parse(Console.ReadLine());
            //Sem = int.Parse(Console.ReadLine());
            Console.WriteLine("Student details are accepted");
        }
        public void DisplayStudentDetails()
        {
            //Console.WriteLine("name: " + name);
            //Console.WriteLine("branch: " + branch);
            //Console.WriteLine("rollno: " + rollno);
            //Console.WriteLine("sem: " + sem);
           
            Console.WriteLine(this.Name+"\n"+this.Rollno+"\n"+this.Sem+"\n"+this.branch);
            Console.WriteLine("Student details are displayed");

        }
        static void Main(string[] args)
        {
            StudentDetails stu = new StudentDetails();
            //Console.WriteLine("Enter student details");
            //stu.Name = "chandu";
            //stu.Rollno = 25;
            //stu.Sem = 8;
            //stu.AcceptStudentDetails();
            stu.DisplayStudentDetails();
            StudentDetails stu1 = new StudentDetails("chandu", 25, "cse", 8, 98);
            stu1.DisplayStudentDetails();
            StudentDetails stu2 = new StudentDetails("yash", 28, "cse", 8, 95);
            stu2.DisplayStudentDetails();
            Console.ReadLine();
        }

    }
}
