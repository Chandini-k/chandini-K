using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using orderservice.Models;


namespace orderservice.Repositories
{
   public interface IOrderRepository
    {
        List<Orders> GetAllOrders();
        Orders GetById(string id);
        void AddOrder(Orders obj);
        void DeleteOrder(string id);
        void UpdateOrder(Orders obj);
    }
}
