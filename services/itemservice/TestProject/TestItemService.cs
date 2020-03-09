using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using itemservice.Models;
using itemservice.Repositories;

namespace TestProject
{
    [TestFixture]
   public class TestItemService
    {
        IItemRepository _repo;
        [SetUp]
        public void SetUp()
        {
            _repo = new ItemRepository(new ShopDBContext());
        }
        [Test]
        public void TestGetAllItems()
        {
            var result = _repo.GetAllItems();
            Assert.IsNotNull(result);
            Assert.GreaterOrEqual(result.Count,1);
        }
        [Test]
        public void TestGetById()
        {
            var result = _repo.GetById("I0001");
            Assert.IsNotNull(result);
        }
        [Test]
        public void TestAddItem()
        {
            _repo.AddItem(new Items()
            {
                Itemid = "I0008",
                Name = "Chandu",
                Price = 1000,
                Stock = 42
            });
            var result = _repo.GetById("I0008");
            Assert.NotNull(result);
        }
        [Test]
        [Description("Test DeleteItem()")]
        public void TestDeleteItem()
        {
            _repo.DeleteItem("I0008");
            var result = _repo.GetById("I0008");
            Assert.Null(result);
        }
        [Test]
        public void TestUpdate()
        {
            Items items = _repo.GetById("I0001");
            items.Price = 200;
            _repo.UpdateItem(items);
            Items items1 = _repo.GetById("I0001");
            Assert.AreSame(items, items1);
        }
    }
}
