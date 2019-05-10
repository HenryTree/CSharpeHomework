using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core {
    public class Order {
        public String Id { get; set; }
        public String Customer { get; set; }
        public DateTime? CreateTime { get; set; }
        public List<OrderDetail> Details { get; set; }

        public Order() {
            Details = new List<OrderDetail>();
        }
    }
}
