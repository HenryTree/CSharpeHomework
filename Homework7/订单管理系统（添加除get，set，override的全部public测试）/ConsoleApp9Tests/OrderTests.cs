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
    public class OrderTests
    {
        [TestMethod()]
        public void AddDetailsTest()
        {
            OrderDetail orderDetail = new OrderDetail()
            {
                Name = "apple"
            };
            Order order = new Order();
            order.AddDetails(orderDetail);
            Assert.AreEqual(order.orderDetails[0].Name, orderDetail.Name);
            //Assert.Fail();
        }

        [TestMethod()]
        public void DeleteDetailsTest()
        {
            OrderDetail od1 = new OrderDetail()
            {
                Name = "apple"
            };

            OrderDetail od2 = new OrderDetail()
            {
                Name = "banana"
            };

            Order order = new Order();
            order.AddDetails(od1);
            order.AddDetails(od2);

            order.DeleteDetails("apple");

            Assert.AreEqual(order.orderDetails[0].Name, od2.Name);
        }

        [TestMethod()]
        public void ChangeDetailsTest()
        {
            OrderDetail orderDetail = new OrderDetail()
            {
                Name = "apple",
                Num = 3
            };

            Order order = new Order();

            order.AddDetails(orderDetail);
            order.ChangeDetails("apple", 5);
            Assert.AreEqual(order.orderDetails[0].Num, 5);
        }

        [TestMethod()]
        public void ShowCommodityNumTest()
        {
            OrderDetail orderDetail = new OrderDetail()
            {
                Name = "apple",
                Num = 3
            };

            Order order = new Order();

            order.AddDetails(orderDetail);
            Assert.AreEqual(order.orderDetails[0].Num, 3);
        }
    }
}