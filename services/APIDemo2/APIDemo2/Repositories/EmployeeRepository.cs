using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIDemo2.Models;

namespace APIDemo2.Repositories
{
    public class EmployeeRepository
    {
       public List<Employee> GetAll()
        {
            using(EMSDBContext db=new EMSDBContext())
            {
                return db.Employee.ToList();
            }
        }
        public Employee GetById(int id)
        {
            using(EMSDBContext db=new EMSDBContext())
            {
                return db.Employee.Find(id);
            }
        }
        //Add Employee
        public void Add(Employee item)
        {
            using(EMSDBContext db=new EMSDBContext())
            {
                db.Employee.Add(item);
                db.SaveChanges();
            }
        }
        //Delete Record
        public void Delete(int id)
        {
            using (EMSDBContext db = new EMSDBContext())
            {
                Employee e = db.Employee.Find(id);
                db.Employee.Remove(e);
                db.SaveChanges();
            }
        }
        public void Update(Employee item)
        {
            using(EMSDBContext db=new EMSDBContext())
            {
                db.Employee.Update(item);
                db.SaveChanges();
            }
        }
    }
}
