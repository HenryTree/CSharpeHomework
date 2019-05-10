using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using EF.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using Model.Core;
using Newtonsoft.Json;

namespace WebApi.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="custmer"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetOrders")]
        public OkObjectResult GetOrders(string custmer)
        {
            var res = string.Empty;
            using (orderDB2Context context = new orderDB2Context())
            {
                var q = from order in context.Orders
                    join detail in context.OrderDetails on order.Id equals detail.OrderId
                    select new
                    {
                        Id = order.Id,
                        Product = detail.Product,
                        UnitPrice = detail.UnitPrice,
                        Quantity = detail.Quantity,
                        CreateTime = order.CreateTime,
                        Customer = order.Customer
                    };

                if (!string.IsNullOrEmpty(custmer))
                {
                    q = q.Where(p => p.Customer.Equals(custmer));
                }
                res = JsonConvert.SerializeObject(q.ToList());
            }

            return Ok(res);
        }

        /// <summary>
        /// 新增数据，支持批量新增
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddOrders")]
        public OkObjectResult AddOrders(List<Model.Core.Order> orders)
        {
            try
            {
                List<EF.Core.Orders> dbOrders = new List<Orders>();
                List<EF.Core.OrderDetails> dbDetailses = new List<OrderDetails>();
                int res = 0;
                if (orders != null && orders.Count > 0)
                {
                    foreach (var order in orders)
                    {
                        if (order.Details != null && order.Details.Count > 0)
                        {
                            if (string.IsNullOrEmpty(order.Id))
                            {
                                order.Id = Guid.NewGuid().ToString();
                            }
                            foreach (var t in order.Details)
                            {
                                if (string.IsNullOrEmpty(t.Id))
                                {
                                    t.Id = Guid.NewGuid().ToString();
                                }

                                if (string.IsNullOrEmpty(t.Order_Id))
                                {
                                    t.Order_Id = order.Id;
                                }
                                var model = new EF.Core.OrderDetails
                                {
                                    Id = t.Id,
                                    Product = t.Product,
                                    UnitPrice = t.UnitPrice,
                                    OrderId = t.Order_Id,
                                    Quantity = t.Quantity
                                };
                                dbDetailses.Add(model);
                            }
                        }

                        var oModel = new EF.Core.Orders
                        {
                            Id = order.Id,
                            Customer = order.Customer,
                            CreateTime = order.CreateTime ?? DateTime.Now
                        };
                        dbOrders.Add(oModel);
                    }

                    using (orderDB2Context context = new orderDB2Context())
                    {
                        foreach (var order in dbOrders)
                        {
                            context.Orders.Add(order);
                        }

                        foreach (var detailse in dbDetailses)
                        {
                            context.OrderDetails.Add(detailse);
                        }

                        res = context.SaveChanges();
                    }
                }

                return Ok($"插入{res}行数据");
            }
            catch (Exception e)
            {
                return Ok(e);
            }
        }

        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("ModifyOrder")]
        public OkObjectResult ModifyOrder(EF.Core.Orders order)
        {
            if (order == null || string.IsNullOrEmpty(order.Id))
            {
                return Ok("此数据不存在");
            }

            using (orderDB2Context context = new orderDB2Context())
            {
                try
                {
                    context.Orders.Update(order);
                    context.SaveChanges();
                    return Ok("修改成功");
                }
                catch (Exception e)
                {
                    return Ok(JsonConvert.SerializeObject(e));
                }
                
            }
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("Delete/{id}")]
        public OkObjectResult Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return Ok("id不能为空");
            }
            else
            {
                using (orderDB2Context context = new orderDB2Context())
                {
                    var order = context.Orders.FirstOrDefault(p => p.Id.Equals(id));
                    var details = context.OrderDetails.Where(p => p.OrderId.Equals(id)).AsEnumerable();
                    if (order != null)
                    {
                        try
                        {
                            context.OrderDetails.RemoveRange(details);
                            context.Orders.Remove(order);
                            var res = context.SaveChanges();
                            return Ok($"删除{res}条数据");
                        }
                        catch (Exception e)
                        {
                            return Ok(JsonConvert.SerializeObject(e));
                        }

                    }
                    else
                    {
                        return Ok($"id为{id}的数据不存在");
                    }
                    
                }
            }
        }
    }
}
