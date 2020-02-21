using System;
using HandsOnEFCodeFirst.Models;
using HandsOnEFCodeFirst.Context;
using System.Linq;
using System.Collections.Generic;

namespace HandsOnEFCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
          using(MyContext db=new MyContext())
            {
                //insert new record
                //Student s = new Student() { Sname = "Suma", Age = 21, Std = "II" };
                //db.Students.Add(s);
                //db.SaveChanges();
                //fetch record
                //Student s = db.Students.Find(1);
                //Console.WriteLine("Welcome {0}", s.Sname);
                //fetch one record using non primary Key
                Student s1 = db.Students.SingleOrDefault(i => i.Sname == "Chandu");
                List<Student> list = db.Students.Where(i => i.Age == 21).ToList();
                List<Student> list1 = db.Students.Where(i => i.Age == 21 && i.Std == "II").ToList();
                //update record
                Student s2 = db.Students.Find(1);
                s2.Age = 19;//update value
                db.Students.Update(s2);
                db.SaveChanges();
                //delete record
                Student s3 = db.Students.SingleOrDefault(i => i.Sname == "Suma");
                db.Students.Remove(s3);
                db.SaveChanges();
            }
        }
    }
}
