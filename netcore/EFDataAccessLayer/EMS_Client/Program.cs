using System;
using EFDataAccessLayer;
using EFDataAccessLayer.Context;
using EFDataAccessLayer.Models;
namespace EMS_Client
{
    class Program
    {
        static void Main(string[] args)
        {
           //Add new Project
           using(MyContext db=new MyContext())
            {
                Project p = new Project() { ProjectName = "BFS" };
                db.Add(p);
                db.SaveChanges();
            }
        }
    }
}
