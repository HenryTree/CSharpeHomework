using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo {
    public class Order {
        [Key]
        public String Id { get; set; }
        public String Customer { get; set; }
        public DateTime CreateTime { get; set; }
        public List<OrderDetail> Details { get; set; }

        public Order() {
            Details = new List<OrderDetail>();
        }

        public Order(string id, string customer, DateTime createTime, List<OrderDetail> details) {
            Id = id;
            Customer = customer;
            CreateTime = createTime;
            this.Details = details;
        }
    }
}
