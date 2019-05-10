using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Core
{
    public class DTO
    {
        public string Id { get; set; }
        public string Product { get; set; }
        public double UnitPrice { get; set; }
        public string Quantity { get; set; }
        public DateTime CreateTime { get; set; }
        public string Customer { get; set; }
    }
}
