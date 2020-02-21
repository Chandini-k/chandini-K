using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using orderservice.Models;
using orderservice.Repositories;

namespace orderservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _repo;
        public OrderController(IOrderRepository repo)
        {
            _repo = repo;
        }
        //Get All items
        [HttpGet]
        [Route("GetOrders")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_repo.GetAllOrders());
            }
            catch (Exception e)
            {
                return NotFound(e.InnerException.Message);
            }
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult Get(string id)
        {
            try
            {
                return Ok(_repo.GetById(id));
            }
            catch (Exception e)
            {
                return NotFound(e.InnerException.Message);
            }
        }
        [HttpPost]
        [Route("AddOrder")]
        public IActionResult Post(Orders order)
        {
            try
            {
                _repo.AddOrder(order);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.InnerException.Message);
            }
        }
        [HttpPut]
        [Route("UpdateOrder")]
        public IActionResult Put(Orders order)
        {
            try
            {
                _repo.UpdateOrder(order);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.InnerException.Message);
            }
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                _repo.DeleteOrder(id);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.InnerException.Message);
            }
        }
    }
}