using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void AddOrderTest()
        {
            List<Order> orders = new List<Order>();
            Order order = new Order()
            {
                Id = 1,
                Client = "Ken",
                Price = 5
            };
            orders.Add(order);

            OrderDetail orderDetail = new OrderDetail()
            {
                Name = "apple",
                Num = 5
            };

            order.AddDetails(orderDetail);

            OrderService orderService = new OrderService();
            orders = orderService.AddOrder(orders);

            Assert.AreEqual(orders[0].Id, order.Id);
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            List<Order> orders = new List<Order>();
            Order order = new Order()
            {
                Id = 1,
                Client = "Ken",
                Price = 5
            };
            orders.Add(order);

            OrderDetail orderDetail = new OrderDetail()
            {
                Name = "apple",
                Num = 5
            };

            order.AddDetails(orderDetail);

            OrderService orderService = new OrderService();
            orderService.DeleteOrder(orders);

            Assert.AreEqual(orders.Count, 0);

        }

        [TestMethod()]
        public void ShowOrderTest()
        {
            List<Order> orders = new List<Order>();
            Order order = new Order()
            {
                Id = 1,
                Client = "Ken",
                Price = 5
            };
            orders.Add(order);

            OrderDetail orderDetail = new OrderDetail()
            {
                Name = "apple",
                Num = 5
            };

            order.AddDetails(orderDetail);

            OrderService orderService = new OrderService();

            Assert.AreEqual(orders.Count, 1);
        }

        [TestMethod()]
        public void ChangeOrderTest()
        {
            List<Order> orders = new List<Order>();
            Order order = new Order()
            {
                Id = 1,
                Client = "Ken",
                Price = 5
            };
            orders.Add(order);

            OrderDetail orderDetail = new OrderDetail()
            {
                Name = "apple",
                Num = 5
            };

            order.AddDetails(orderDetail);

            OrderService orderService = new OrderService();
            orderService.ChangeOrder(orders);
            Assert.AreEqual(orders[0].Id, 2);
        }

        [TestMethod()]
        public void ShowAllOrderTest()
        {
            List<Order> orders = new List<Order>();
            Order order = new Order()
            {
                Id = 1,
                Client = "Ken",
                Price = 5
            };
            orders.Add(order);

            OrderDetail orderDetail = new OrderDetail()
            {
                Name = "apple",
                Num = 5
            };

            order.AddDetails(orderDetail);

            OrderService orderService = new OrderService();

            Assert.AreEqual(orders.Count, 1);
        }
    }
}