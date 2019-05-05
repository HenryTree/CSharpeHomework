using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OrderService
{
    [Serializable]
    public class Order : IComparable<Order>
    {
        [Key]
        public uint Id { get; set; }
        public string Buyer { get; set; }
        public double Price { get; set; }

        public List<OrderItem> orderitems;


        public Order()
        {
            orderitems = new List<OrderItem>();
        }

        public Order(uint id, string guest)
        {
            this.Buyer = guest;
            this.Id = id;
            orderitems = new List<OrderItem>();
            Price = 0;
        }

        public bool AddItem(string good, uint number, uint price, string detail = "NULL")
        {
            OrderItem newitem = new OrderItem(good, number, price, detail);
            foreach (OrderItem orderitem in orderitems)
            {
                if (orderitem.Equals(newitem))
                    return false;
            }
            orderitems.Add(newitem);
            UpdatePrice();
            return true;
        }

        public void UpdatePrice()
        {
            Price = 0;
            foreach (OrderItem item in orderitems)
            {
                Price += item.Price * item.Number;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is Order)
            {
                Order ord = (Order)obj;
                return ord.Id == this.Id;
            }
            return false;
        }

        public override string ToString()
        {
            string items = "";
            foreach (OrderItem item in orderitems)
            {
                items += item.Good + " ";
            }
            if (items == "")
            {
                items = "NONE";
            }
            return $"OrderID: {Id}  Buyer: {Buyer}  Item: {items}  Price: {Price}";
        }

        public int CompareTo(Order obj)
        {
            return (int)(this.Id - obj.Id);
        }
    }
}
