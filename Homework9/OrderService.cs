using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace OrderService
{
    public class OrderService
    {
        Form1 caller;

        public OrderService(Form1 caller)
        {
            this.caller = caller;
        }

        public bool AddOrder(Order neworder)
        {
            using (var orderDatabase = new OrderDBContext())
            {
                foreach (Order order in orderDatabase.Orders.ToList<Order>())
                {
                    if (order.Equals(neworder))
                        return false;
                }
                orderDatabase.Entry(neworder).State = System.Data.Entity.EntityState.Added;
                orderDatabase.SaveChanges();
                
                return true;
            }
        }

        public bool DeleteOrderById(uint id)
        {
            using (var orderDatabase = new OrderDBContext())
            {
                for (int i = 0; i < orderDatabase.Orders.ToList().Count(); i++)
                {
                    if (orderDatabase.Orders.ToList()[i].Id == id)
                    {
                        orderDatabase.Orders.Remove(orderDatabase.Orders.ToList()[i]);
                        orderDatabase.SaveChanges();
                        return true;
                    }
                }
                
                return false;
            }

        }

        public List<Order> SearchOrderById(uint id)
        {
            using (var orderDatabase = new OrderDBContext())
            {
                var searchResult = from order in orderDatabase.Orders.ToList() where order.Id == id select order;
                List<Order> resultList = new List<Order>();
                foreach (Order order in searchResult)
                {
                    resultList.Add(order);
                }
                return resultList;
            }

        }

        public List<Order> SearchOrderByUsername(string username)
        {
            using (var orderDatabase = new OrderDBContext())
            {
                var searchResult = orderDatabase.Orders.ToList().Where(order => order.Buyer.Equals(username));
                List<Order> resultList = new List<Order>();
                foreach (Order order in searchResult)
                {
                    resultList.Add(order);
                }
                return resultList;
            }
        }


        public void Display()
        {
            using (var orderDatabase = new OrderDBContext())
            {
                foreach (Order order in orderDatabase.Orders.ToList())
                {
                    Console.WriteLine(order);
                }
            }
        }


        //TODO: 使用using
        public void Export(String filename)
        {
            /*
            using (var orderDatabase = new OrderDBContext())
            {
                FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
                xmlSerializer.Serialize(fs, orderDatabase);
                fs.Close();
            }
            */
        }

        public void Import(String filename)
        {
            /*
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            this.orderDatabase.Orders.ToList()= (List<Order>)xmlSerializer.Deserialize(fs);
            fs.Close();
            */
        }

        public List<Order> GetAllRecord()
        {
            using (var orderDatabase = new OrderDBContext())
            {
                return orderDatabase.Orders.ToList();
            }
        }

        
}
}
