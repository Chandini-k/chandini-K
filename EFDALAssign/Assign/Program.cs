using System;
using EFDALAssign.Context;
using EFDALAssign.Models;

namespace Assign
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyContext db = new MyContext())
            {
                Item p = new Item() { ItemName = "Mobile" };
                db.Add(p);
                db.SaveChanges();
            }
        }
    }
}
