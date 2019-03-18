using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp8;

namespace ConsoleApp8
{
    enum OrderOp
    {
        增加订单=1,删除订单=2,修改订单=3,查询订单=4,查询全部订单=5,退出系统=6
    }


    class Order
    {
        private string myId;
        private string myClient;
        public List<OrderDetails> Details = new List<OrderDetails>();

        public string Id
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

        public void AddDetails(OrderDetails orderDetails)
        {
            Details.Add(orderDetails);
        }

        public void DeleteDetails(string name)
        {
            for (int i = 0; i < Details.Count; i++)
            {
                if (Details[i].Commodity == name)
                {
                    Details.RemoveAt(i);
                    break;
                }
            }
        }

        public void ChangeDetails(string name, int num)
        {
            for (int i = 0; i < Details.Count; i++)
            {
                if (Details[i].Commodity == name)
                {
                    Details[i].Num = num;
                    break;
                }
            }
        }

        public void ShowDetails()
        {
            Console.WriteLine("Here are the Details:");
            for (int i = 0; i < Details.Count; i++)
            {
                Console.WriteLine("Commodity:  " + Details[i].Commodity + "\nNumber:  " + Details[i].Num + ";");
            }
        }

        public void ShowOrder()
        {
            Console.WriteLine("OrderId:  " + Id + "\nClient:  " + Client);
        }

        public int ShowCommodityNum(string name)
        {
            for (int i = 0; i < Details.Count; i++)
            {
                if (Details[i].Commodity == name)
                {
                    return Details[i].Num;
                }
            }
            return 0;
        }
    }

    class OrderDetails
    {
        public string myId;
        public string myCommodity;
        public int myNum;

        public string Id
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


        public string Commodity
        {
            get
            {
                return myCommodity;
            }
            set
            {
                myCommodity = value;
            }
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
    }

    class OrderService
    {

        public List<Order> AddOrder(List<Order> orders)
        {
            int temp = orders.Count;
            Console.Write("请输入要进行添加的订单的数目:");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("请输入第{0}个订单的信息:", (i + 1));
                Console.Write("请输入要添加的订单的编号:");
                string orderid = Console.ReadLine();
                Console.Write("请输入要添加的订单的客户:");
                string orderclient = Console.ReadLine();

                Order order = new Order
                {
                    Id = orderid,
                    Client = orderclient
                };

                orders.Add(order);

                Console.WriteLine("请输入该订单含商品的种类:");
                int kinds = int.Parse(Console.ReadLine());
                for(int j = 0; j < kinds; j++)
                {
                    Console.WriteLine("请输入第{0}个商品的信息:", (j + 1));
                    
                    Console.Write("请输入要添加的商品名称:");
                    string commodityName = Console.ReadLine();
                    Console.Write("请输入该商品的数量:");
                    int commodityNum = int.Parse(Console.ReadLine());

                    OrderDetails orderDetails = new OrderDetails()
                    {
                        Id = orderid,
                        Commodity = commodityName,
                        Num = commodityNum
                    };

                    order.AddDetails(orderDetails);
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
            string strid = Console.ReadLine();
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
            }catch(DeleteException e)
            {
                Console.WriteLine("删除失败!!!!!");
            }
            
            return orders;
        }

        public void ChangeOrder(List<Order> orders)
        {
            bool flag = false;
            bool flag1 = false;
            Console.Write("请输入要进行修改的订单的编号:");
            string strId = Console.ReadLine();

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
            orders[temp1].ShowDetails();

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
                        string strorderid = Console.ReadLine();
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
                        }catch(ChangeException e)
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
                        }catch(ChangeException e)
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
                        }catch(ChangeException e)
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
                        string strorderid = Console.ReadLine();
                        foreach (Order item in orders)
                        {
                            if (item.Id == strorderid)
                            {
                                temp1 = column;
                            }
                            column++;
                        }
                        orders[temp1].ShowOrder();
                        orders[temp1].ShowDetails();
                    }
                    break;

                case 2:
                    {
                        Console.Write("请输入要查询的订单客户:");
                        string strorderclient = Console.ReadLine();
                        foreach (Order item in orders)
                        {
                            if (item.Client == strorderclient)
                            {
                                temp1 = column;
                            }
                            column++;
                        }
                        orders[temp1].ShowOrder();
                        orders[temp1].ShowDetails();
                    }
                    break;

                case 3:
                    {
                        Console.Write("请输入要查询的订单商品:");
                        string strordercommodity = Console.ReadLine();
                        foreach (Order item in orders)
                        {
                            foreach (OrderDetails item1 in orders[temp1].Details)
                            {
                                if(item1.Commodity == strordercommodity)
                                {
                                    temp2 = colunm1;
                                    orders[temp1].ShowOrder();
                                    orders[temp1].ShowDetails();
                                }
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

        public void ShowAllOrder(List<Order> orders)
        {
            int counti = 1;
            foreach (var item in orders)
            {
                item.ShowOrder();
                item.ShowDetails();
                counti++;
            }

            Console.WriteLine();
            Console.WriteLine("一共{0}条数据!!!!", orders.Count);
            Console.WriteLine();
        }
    }

    class DeleteException : ApplicationException
    {
        private bool myFlag;
        public DeleteException(string message,bool flag)
            :base(message)
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


    class MainClass
    {
        static void Main(string[] args)
        {
            bool flag = false;
            List<Order> OrderList = new List<Order>();
            Order order1 = new Order();
            OrderDetails orderDetails1 = new OrderDetails
            {
                Id = "001",
                Commodity = "Apple",
                Num = 5
            };
            order1.Id = "001";
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
                Console.WriteLine("*         6.退出系统            *");
                Console.WriteLine("*********************************");
                Console.Write("请输入你要进行的操作:");
                int number = int.Parse(Console.ReadLine());
                OrderOp orderOp = (OrderOp)number;
                switch (orderOp)
                {
                    case OrderOp.修改订单:
                        orderService.ChangeOrder(OrderList);
                        break;
                    case OrderOp.删除订单:
                        OrderList = orderService.DeleteOrder(OrderList);
                        break;
                    case OrderOp.增加订单:
                        OrderList = orderService.AddOrder(OrderList);
                        break;
                    case OrderOp.查询全部订单:
                        orderService.ShowAllOrder(OrderList);
                        break;
                    case OrderOp.查询订单:
                        orderService.ShowOrder(OrderList);
                        break;
                    case OrderOp.退出系统:
                        flag = true;
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
