using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIDemo2.Models;
using APIDemo2.Repositories;

namespace APIDemo2.Repositories
{
    public class ProjectRepository
    {
        public List<Project> GetAll()
        {
            using (EMSDBContext db = new EMSDBContext())
            {
                return db.Project.ToList();
            }
        }
        public Project GetById(int id)
        {
            using (EMSDBContext db = new EMSDBContext())
            {
                return db.Project.Find(id);
            }
        }
        //Add Employee
        public void Add(Project item)
        {
            using (EMSDBContext db = new EMSDBContext())
            {
                db.Project.Add(item);
                db.SaveChanges();
            }
        }
        //Delete Record
        public void Delete(int id)
        {
            using (EMSDBContext db = new EMSDBContext())
            {
                Project e = db.Project.Find(id);
                db.Project.Remove(e);
                db.SaveChanges();
            }
        }
        public void Update(Project item)
        {
            using (EMSDBContext db = new EMSDBContext())
            {
                db.Project.Update(item);
                db.SaveChanges();
            }
        }

}
}
