using System;
using EFCOREDBFirst.Models;


namespace DBFirstClient
{
    class Program
    {
        static void Main(string[] args)
        {
           using(PracticeDBContext db=new PracticeDBContext())
            {
                Product p = new Product() { Pname="FSE",Pid=2};
                db.Add(p);
                //db.Remove(p);
                db.SaveChanges();
            }
        }
    }
}
