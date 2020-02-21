using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIASSIGN.Controllers;
using APIASSIGN.Models;

namespace APIASSIGN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        CustomerDBContext db = new CustomerDBContext();
        [HttpGet]
        public List<Customer> GetAll()
        {
            return db.Customer.ToList();
        }
        [HttpGet("{id}")]
        [Route("GetById/{id}")]
        public Customer GetById(int id)
        {
            return db.Customer.Find(id);
        }
        [HttpGet("{city}")]
        [Route("GetByCity/{city}")]
        public List<Customer> GetByCity(string city)
        {
            return db.Customer.Where<Customer>(p=>p.City==city).ToList();
        }
        [HttpPost]
        [Route("AddCustomer")]
        public void Add(Customer item)
        {
            db.Customer.Add(item);
            db.SaveChanges();
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public void Delete(string id)
        {
            Customer c = db.Customer.Find(id);
            db.Remove(c);
            db.SaveChanges();
        }
        [HttpPut]
        [Route("Update/{id}")]
        public void Update(string id)
        {
            Customer p = db.Customer.Find(id);
            p.Cname = "Ammu";
            db.Customer.Update(p);
            db.SaveChanges();
        }
    }
}