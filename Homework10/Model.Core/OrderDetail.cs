using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Core
{
    public class OrderDetail {
        public string Id { get; set; }
        public string Product { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }

        public string Order_Id { get; set; }

  }
}