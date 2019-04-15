using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ConsoleApp9;

namespace ConsoleApp9
{
    enum OrderOp
    {
        增加订单 = 1, 删除订单 = 2, 修改订单 = 3, 查询订单 = 4, 查询全部订单 = 5,按订单号排序 = 6, 按订单金额排序 = 7,订单序列化XML = 8,XML载入订单 = 9,退出系统 = 10
    }

    public class OrderDetail
    {
        public string myName;
        private int myNum;

        public void GetCommodity(string myName)
        {
            Commodity commodity = new Commodity
            {
                Name = myName
            };
        }

        public int Num
        {
            get
            {
                return myNum;
            }
            set
            {
                myNum = value;
            }
        }

        public string Name
        {
            get
            {
                return myName;
            }
            set
            {
                myName = value;
            }
        }

        public override string ToString()
        {
            return "Commodity:  " + Name + "\nNumber:  " + Num + ";";
        }

        public override bool Equals(object obj)
        {
            OrderDetail orderDetail = obj as OrderDetail;
            if(this.Name == orderDetail.Name && this.Num == orderDetail.Num)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Commodity
    {
        private string myName;

        public string Name
        {
            get
            {
                return myName;
            }
            set
            {
                myName = value;
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Client
    {
        private string myName;

        public string Name
        {
            get
            {
                return myName;
            }
            set
            {
                myName = value;
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Order : IComparable
    {
        private int myId;
        private string myClient;
        private int myPrice;

        public List<OrderDetail> orderDetails = new List<OrderDetail>();

        public void GetClient(string myClient)
        {
            Client client = new Client
            {
                Name = myClient
            };
        }

        public int Id
        {
            get
            {
                return myId;
            }
            set
            {
                myId = value;
            }
        }
        public int Price
        {
            get
            {
                return myPrice;
            }
            set
            {
                myPrice = value;
            }
        }
        public string Client
        {
            get
            {
                return myClient;
            }
            set
            {
                myClient = value;
            }
        }

        public void AddDetails(OrderDetail orderDetail)
        {
            orderDetails.Add(orderDetail);
        }

        public void DeleteDetails(string name)
        {
            for (int i = 0; i < orderDetails.Count; i++)
            {
                if (orderDetails[i].Name == name)
                {
                    orderDetails.RemoveAt(i);
                    break;
                }
            }
        }

        public void ChangeDetails(string name, int num)
        {
            for (int i = 0; i < orderDetails.Count; i++)
            {
                if (orderDetails[i].Name == name)
                {
                    orderDetails[i].Num = num;
                    break;
                }
            }
        }

        public override string ToString()
        {
            return "OrderId:  " + Id + "\nClient:  " + Client + "\nPrice:" + Price;
        }

        public override bool Equals(object obj)

        {

            Order o = obj as Order;
            if (this.Id == o.Id)

            {

                return true;

            }

            else

            {

                return false;

            }

        }

        public int ShowCommodityNum(string name)
        {
            for (int i = 0; i < orderDetails.Count; i++)
            {
                if (orderDetails[i].Name == name)
                {
                    return orderDetails[i].Num;
                }
            }
            return 0;
        }

        public int CompareTo(object obj)
        {
            //实现接口方法一：
            if (obj == null) return 1;
            Order otherOrder = obj as Order;
            if (Id > otherOrder.Id) { return 1; }
            else
            {
                if (Id == otherOrder.Id) { return 0; }
                else { return -1; }
            }
        }
    }

    public class OrderService
    {
        public List<Order> AddOrder(List<Order> orders)
        {
            int count1 = 0;
            int temp = orders.Count;
            Console.Write("请输入要进行添加的订单的数目:");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("请输入第{0}个订单的信息:", (i + 1));
                Console.Write("请输入要添加的订单的编号:");
                int orderid = int.Parse(Console.ReadLine());
                Console.Write("请输入要添加的订单的客户:");
                string orderclient = Console.ReadLine();
                Console.Write("请输入要添加的订单的金额:");
                int orderprice = int.Parse(Console.ReadLine());

                Order order = new Order
                {
                    Id = orderid,
                    Client = orderclient,
                    Price = orderprice
                };

                orders.Add(order);

                Console.WriteLine("请输入该订单含商品的种类(请输入数字):");
                int kinds = int.Parse(Console.ReadLine());
                for (int j = 0; j < kinds; j++)
                {
                    Console.WriteLine("请输入第{0}个商品的信息:", (j + 1));

                    Console.Write("请输入要添加的商品名称:");
                    string commodityName = Console.ReadLine();
                    Console.Write("请输入该商品的数量:");
                    int commodityNum = int.Parse(Console.ReadLine());

                    OrderDetail orderDetail = new OrderDetail()
                    {
                        Name = commodityName,
                        Num = commodityNum
                    };

                    order.AddDetails(orderDetail);

                }
                



            }
            if (temp < orders.Count)
            {
                Console.WriteLine("添加成功!!!!!");
            }
            else
            {
                Console.WriteLine("添加失败!!!!!");
            }
            return orders;
        }

        public List<Order> DeleteOrder(List<Order> orders)
        {
            bool flag = false;
            int temp = orders.Count;
            Console.Write("请输入你要删除的订单的编号:");
            int strid = int.Parse(Console.ReadLine());
            int temp1 = 0;
            int column = 0;
            foreach (Order item in orders)
            {
                if (item.Id == strid)
                {
                    temp1 = column;
                }
                column++;
            }
            orders.RemoveAt(temp1);
            try
            {
                if (temp > orders.Count)
                {
                    flag = true;
                    Console.WriteLine("删除成功!!!!!");
                    column = 0;
                }
                else
                {
                    flag = false;
                    throw new DeleteException("删除失败", flag);
                }
            }
            catch (DeleteException e)
            {
                Console.WriteLine("删除失败!!!!!");
            }

            return orders;
        }

        public void ShowOrder(List<Order> orders)
        {
            int temp;
            temp = orders.Count;

            bool flag = false;
            int temp1 = 0;
            int temp2 = 0;
            int column = 0;
            int colunm1 = 0;



            Console.WriteLine("1.按订单编号查询！");
            Console.WriteLine("2.按订单客户查询！");
            Console.WriteLine("3.按订单商品查询！");
            Console.WriteLine("4.退出查询！");

            Console.Write("请选择:");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    {
                        Console.Write("请输入要查询的订单编号:");
                        int strorderid = int.Parse(Console.ReadLine());
                        var result = from o in orders where o.Id == strorderid select o;
                        foreach(var o in result)
                        {
                            Console.WriteLine(o.ToString());
                            for (int i = 0; i < o.orderDetails.Count; i++)
                            {
                                Console.WriteLine(o.orderDetails[i].ToString());
                            }
                        }
                        //orders[temp1].ShowOrder();
                    }
                    break;

                case 2:
                    {
                        Console.Write("请输入要查询的订单客户:");
                        string strorderclient = Console.ReadLine();
                        var result = from o in orders where o.Client == strorderclient select o;
                        foreach (var o in result)
                        {
                            Console.WriteLine(o.ToString());
                            for (int i = 0; i < o.orderDetails.Count; i++)
                            {
                                Console.WriteLine(o.orderDetails[i].ToString());
                            }
                        }
                    }
                    break;

                case 3:
                    {
                        Console.Write("请输入要查询的订单商品:");
                        string strordercommodity = Console.ReadLine();
                        foreach (Order item in orders)
                        {
                            foreach (OrderDetail item1 in orders[temp1].orderDetails)
                            {
                                var result = from od in orders[temp1].orderDetails where od.Name == strordercommodity select od;
                                foreach(var od in result)
                                {
                                    if (od != null)
                                    {
                                        Console.WriteLine(orders[temp1].ToString());
                                        for (int i = 0; i < orders[temp1].orderDetails.Count; i++)
                                        {
                                            Console.WriteLine(orders[temp1].orderDetails[i].ToString());
                                        }
                                    }
                                }
                                /*if (item1.Name == strordercommodity)
                                {
                                    temp2 = colunm1;
                                    Console.WriteLine(orders[temp1].ToString());
                                }*/
                                colunm1++;
                            }
                            temp1 = column;
                            column++;
                        }
                    }
                    break;

                case 4:
                    flag = true;
                    break;
            }

            if (flag)
            {
                Console.WriteLine("退出查询成功!!!!");
            }
        }

        public void ChangeOrder(List<Order> orders)
        {
            bool flag = false;
            bool flag1 = false;
            Console.Write("请输入要进行修改的订单的编号:");
            int strId = int.Parse(Console.ReadLine());

            int temp1 = 0;
            int column = 0;
            foreach (Order item in orders)
            {
                if (item.Id == strId)
                {
                    temp1 = column;
                }
                column++;
            }
            Console.WriteLine();
            Console.WriteLine("订单的信息为:");
            Console.WriteLine("订单的编号:{0}", orders[temp1].Id);
            Console.WriteLine("订单的客户:{0}", orders[temp1].Client);
            Console.WriteLine("订单的商品和对应的数量:");
            Console.WriteLine(orders[temp1].ToString());

            Console.WriteLine();
            Console.WriteLine("请选择要进行修改的信息:");
            Console.WriteLine("1.订单编号!!!");
            Console.WriteLine("2.订单客户!!!");
            Console.WriteLine("3.订单商品的数量!!!");
            Console.WriteLine("4.退出修改!!!");

            Console.Write("请选择:");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    {
                        Console.Write("请输入要修改成的订单编号:");
                        int strorderid = int.Parse(Console.ReadLine());
                        orders[temp1].Id = strorderid;
                        //判断是否修改成功
                        try
                        {
                            if (orders[temp1].Id == strorderid)
                            {
                                flag1 = true;
                                Console.WriteLine("修改成功!!!!!");
                            }
                            else
                            {
                                flag1 = false;
                                throw new ChangeException("修改失败", flag1);
                            }
                        }
                        catch (ChangeException e)
                        {
                            Console.WriteLine("修改失败!!!!!");
                        }

                    }
                    break;
                case 2:
                    {
                        Console.Write("请输入要修改成的订单客户:");
                        string strorderclient = Console.ReadLine();
                        orders[temp1].Client = strorderclient;
                        //判断是否修改成功
                        try
                        {
                            if (orders[temp1].Client == strorderclient)
                            {
                                flag1 = true;
                                Console.WriteLine("修改成功!!!!!");
                            }
                            else
                            {
                                flag1 = false;
                                throw new ChangeException("修改失败", flag1);
                            }
                        }
                        catch (ChangeException e)
                        {
                            Console.WriteLine("修改失败!!!!!");
                        }

                    }
                    break;
                case 3:
                    {
                        Console.Write("请输入要修改的订单商品名:");
                        string strcommodity = Console.ReadLine();
                        Console.Write("请输入修改后的订单商品数量:");
                        int strcommodityNum = int.Parse(Console.ReadLine());

                        orders[temp1].ChangeDetails(strcommodity, strcommodityNum);

                        //判断是否修改成功
                        try
                        {
                            if (orders[temp1].ShowCommodityNum(strcommodity) == strcommodityNum)
                            {
                                flag1 = true;
                                Console.WriteLine("修改成功!!!!!");
                            }
                            else
                            {
                                flag1 = false;
                                throw new ChangeException("修改失败", flag1);
                            }
                        }
                        catch (ChangeException e)
                        {
                            Console.WriteLine("修改失败!!!!!");
                        }

                    }
                    break;
                case 4:
                    flag = true;
                    break;
            }
            if (flag)
            {
                Console.WriteLine("退出修改成功!!!!");
            }

        }

        public void ShowAllOrder(List<Order> orders)
        {
            int counti = 1;
            foreach (var item in orders)
            {
                Console.WriteLine(item.ToString());
                for (int i = 0; i < item.orderDetails.Count; i++)
                {
                    Console.WriteLine(item.orderDetails[i].ToString());
                }
                counti++;
            }

            Console.WriteLine();
            Console.WriteLine("一共{0}条数据!!!!", orders.Count);
            Console.WriteLine();
        }

        public string Export<T>(T t)
        {
            /*FileStream fs = new FileStream(fileName, FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            xs.Serialize(fs, obj);
            fs.Close();*/
            using (StringWriter sw = new StringWriter())
            {
                XmlSerializer xz = new XmlSerializer(t.GetType());
                xz.Serialize(sw, t);
                return sw.ToString();
            }
        }

        public object Import(string fileName, Type type)
        {
            /*FileStream fs = new FileStream(fileName, FileMode.Open);
            XmlSerializer xs = new XmlSerializer(typeof(Order));
            orders = xs.Deserialize(fs) as List<Order>;
            fs.Close();*/
            using (StringReader sr = new StringReader(fileName))
            {
                XmlSerializer xz = new XmlSerializer(type);
                return xz.Deserialize(sr);
            }
        }
    }

    

    class DeleteException : ApplicationException
    {
        private bool myFlag;
        public DeleteException(string message, bool flag)
            : base(message)
        {
            this.myFlag = flag;
        }
    }

    class ChangeException : ApplicationException
    {
        private bool myFlag;
        public ChangeException(string message, bool flag)
            : base(message)
        {
            this.myFlag = flag;
        }
    }


    class OrderProgram
    {

        delegate void priceSort(List<Order> orders);

        static void Main(string[] args)
        {
            bool flag = false;
            List<Order> orderlist = new List<Order>();
            Order order1 = new Order();
            OrderDetail orderDetail = new OrderDetail
            {
                Name = "Apple",
                Num = 5
            };
            order1.Id = 1;
            order1.Client = "HenryTree";

            OrderService orderService = new OrderService();

            while (true)
            {
                Console.WriteLine("         订单管理系统");
                Console.WriteLine("*********************************");
                Console.WriteLine("*         1.增加订单            *");
                Console.WriteLine("*         2.删除订单            *");
                Console.WriteLine("*         3.修改订单            *");
                Console.WriteLine("*         4.查看订单            *");
                Console.WriteLine("*         5.查看全部订单        *");
                Console.WriteLine("*         6.按订单号排序        *");
                Console.WriteLine("*         7.按订单金额排序      *");
                Console.WriteLine("*         8.订单序列化XML       *");
                Console.WriteLine("*         9.XML载入订单         *");
                Console.WriteLine("*         10.退出系统            *");
                Console.WriteLine("*********************************");
                Console.Write("请输入你要进行的操作:");
                int number = int.Parse(Console.ReadLine());
                OrderOp orderOp = (OrderOp)number;
                switch (orderOp)
                {
                    case OrderOp.修改订单:
                        orderService.ChangeOrder(orderlist);
                        break;
                    case OrderOp.删除订单:
                        orderlist = orderService.DeleteOrder(orderlist);
                        break;
                    case OrderOp.增加订单:
                        orderlist = orderService.AddOrder(orderlist);
                        break;
                    case OrderOp.查询全部订单:
                        orderService.ShowAllOrder(orderlist);
                        break;
                    case OrderOp.查询订单:
                        orderService.ShowOrder(orderlist);
                        break;
                    case OrderOp.退出系统:
                        flag = true;
                        break;
                    case OrderOp.按订单号排序:
                        orderlist.Sort();
                        orderService.ShowAllOrder(orderlist);
                        break;
                    case OrderOp.按订单金额排序:
                        priceSort price = x =>
                        {
                            for (int i = 0; i < x.Count; i++)
                            {
                                for (int j = 0; j < x.Count - 1; j++)
                                {
                                    if (x[j].Price > x[j + 1].Price)
                                    {
                                        Order temp = new Order();
                                        temp = x[j];
                                        x[j] = x[j + 1];
                                        x[j + 1] = temp;
                                    }
                                }
                            }
                        };
                        price(orderlist);
                        orderService.ShowAllOrder(orderlist);
                        break;
                    case OrderOp.订单序列化XML:
                        orderService.Export(orderlist);
                        break;
                    case OrderOp.XML载入订单:
                        string s = orderService.Export<List<Order>>(orderlist);
                        break;
                    default:
                        Console.WriteLine("没有其对应的输入请重新输入!!!!!");
                        break;
                }

                if (flag)
                {
                    break;
                }
            }
            Console.WriteLine("退出订单管理系统成功!!!!!!");
        }
    }
}
