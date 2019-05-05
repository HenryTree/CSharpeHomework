using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService
{
    [Serializable]
    public class OrderItem
    {
        public string Good { get; set; }
        public uint Number { get; set; }
        public uint Price { get; set; }
        public string Detail { get; set; }


        public OrderItem()
        {

        }
        public OrderItem(string good, uint number, uint price, string detail = "NULL")
        {
            this.Good = good;
            this.Number = number;
            this.Price = price;
            this.Detail = detail;

        }



        public override string ToString()
        {
            return $"{Good}*{this.Number}({this.Detail})";
        }

        public override bool Equals(object obj)
        {
            if (obj is OrderItem)
            {
                OrderItem orderItem = (OrderItem)obj;
                return this.Good.Equals(orderItem.Good);
            }
            return false;
        }

    }
}
