using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIDemo2.Models;
using APIDemo2.Repositories;

namespace APIDemo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeRepository repository = new EmployeeRepository();
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(repository.GetAll());
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult Get(int id)
        {
            return Ok(repository.GetById(id));
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Employee item)
        {
            repository.Add(item);
            return Ok();
        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update(Employee item)
        {
            repository.Update(item);
            return Ok();
        }
        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete(int id)
        {
            repository.Delete(id);
            return Ok("Record Deleted");
        }
    }
}