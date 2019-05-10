using System;
using System.Collections.Generic;

namespace EF.Core
{
    public partial class OrderDetails
    {
        public string Id { get; set; }
        public string Product { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string OrderId { get; set; }

        public virtual Orders Order { get; set; }
    }
}
