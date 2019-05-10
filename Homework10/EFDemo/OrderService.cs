using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo {
  public class OrderService {

    public void Add(Order order) {
      using (var db = new OrderDB()) {
        db.Entry(order).State = EntityState.Added;
        db.SaveChanges();
      }
    }

    public void Delete(String orderId) {
      using (var db = new OrderDB()) {
        var order = db.Order.Include("Details").SingleOrDefault(o => o.Id == orderId);
        db.OrderItem.RemoveRange(order.Details);
        db.Order.Remove(order);
        db.SaveChanges();
      }
    }


    public void Update(Order newOrder) {
      using (var db = new OrderDB()) {
        Order oldOrder = db.Order.Include("Details").SingleOrDefault(o => o.Id == newOrder.Id);
        db.OrderItem.RemoveRange(oldOrder.Details);
        db.SaveChanges();
      }

      using (var db = new OrderDB()) {
        foreach (OrderDetail detail in newOrder.Details) {
          db.Entry(detail).State = EntityState.Added;
        }
        //db.SaveChanges();//先保存items部分的修改
        db.Entry(newOrder).State = EntityState.Modified;
        db.SaveChanges();//保存Order的属性修改
      }
    }

    public void Update(Order order,List<OrderDetail> removed,List<OrderDetail> newItems) {
      using (var db = new OrderDB()) {
        order.Details.AddRange(newItems);
        foreach (OrderDetail item in order.Details) {
          if (removed.Contains(item)) {
            db.Entry(item).State = EntityState.Deleted;
          }else if (newItems.Contains(item)) {
            db.Entry(item).State = EntityState.Added;
          } else {
            db.Entry(item).State = EntityState.Modified;
          }
        }
        db.SaveChanges();//先保存items部分的修改
        db.Entry(order).State = EntityState.Modified;
        db.SaveChanges();//保存Order的属性修改
      }
    }

    public Order GetOrder(String Id) {
      using (var db = new OrderDB()) {
        return db.Order.Include("Details").
          SingleOrDefault(o => o.Id == Id);
      }
    }

    public List<Order> GetAllOrders() {
      using (var db = new OrderDB()) {
        return db.Order.Include("Details").ToList<Order>();
      }
    }


    public List<Order> QueryByCustormer(String custormer) {
      using (var db = new OrderDB()) {
        return db.Order.Include("Details")
          .Where(o => o.Customer.Equals(custormer)).ToList<Order>();
      }
    }

    public List<Order> QueryByGoods(String product) {
      using (var db = new OrderDB()) {
        var query = db.Order.Include("Details")
          .Where(o => o.Details.Where(
            item => item.Product.Equals(product)).Count() > 0);
        return query.ToList<Order>();
      }
    }




  }
}
