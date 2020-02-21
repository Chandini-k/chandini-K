using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignOOP
{
    class Student
    {
        static string clgname;
        string name, branch;
        int rollno,clas,sem;
        int[] marks = new int[5];
        static Student()
        {
            clgname = "CRR";
        }
        public Student(int rollno,string name,int cls,int sem,string branch)
        {
            this.rollno = rollno;
            this.name = name;
            this.clas = cls;
            this.sem = sem;
            this.branch = branch;

        }
        public void displayresult()
        {
            int flag= 0;
            float avg, total = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("subject " + i);
                marks[i] = int.Parse(Console.ReadLine());
                total = total + marks[i];
            }
            avg = total / 5;
            Console.WriteLine("the avg marks of student " + avg);
            for (int i = 0; i < 5; i++)
            {
                if (marks[i] < 35)
                {
                    Console.WriteLine("Failed");
                    flag = 1;
                   
                }
                else if (marks[i] > 35)
                {
                    if (avg < 50)
                        {
                            Console.WriteLine("failed");
                            
                        }
                        else
                        {
                            Console.WriteLine("pass");
                          
                        }

                }
            }
        }
        public void display()
        {
            Console.WriteLine("Name: " + name + "\nrollno: " + rollno + "\nbranch: " + branch + "\nsem: " + sem);
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("enter rollno");
            int rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter class");
            int cls = int.Parse(Console.ReadLine());
            Console.WriteLine("enter sem");
            int sem = int.Parse(Console.ReadLine());
            Console.WriteLine("enter branch");
            string branch=Console.ReadLine();
            Student stu = new Student(rollno,name,cls,sem,branch);
            int[] marks = new int[5];
            stu.display();
            stu.displayresult();
            
            Console.ReadLine();
        }
    }
}
