using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo {
    class Program {
    static void Main(string[] args) {
      OrderService orderService = new OrderService();
      //orderService.Delete("001");

      List<OrderDetail> items = new List<OrderDetail>() {
                new OrderDetail("1", "apple", 10.0, 20),
                new OrderDetail("2", "egg", 2.0, 100)
            };

      Order order = new Order("001", "jia", DateTime.Now, items);

      orderService.Add(order);

      Order order2 = new Order("001", "jia2", DateTime.Now, items);
      List<OrderDetail> removed = new List<OrderDetail>();
      List<OrderDetail> newItems = new List<OrderDetail>();
      removed.Add(new OrderDetail("1", "apple", 10.0, 20));
      newItems.Add(new OrderDetail("3", "orange", 30.0, 20));
      orderService.Update(order2,removed,newItems);






      List<Order> orders = orderService.QueryByCustormer("jia2");
      orders.ForEach(
        o => Console.WriteLine($"{o.Id},{o.Customer}"));


     }
    }
}
