using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace OrderService
{
    //主窗口（负责增加订单、删除订单、修改订单）
    public partial class Form1 : Form
    {
        
        OrderService service;
        public uint InputIdQuery { get; set; }
        public string InputNameQuery { get; set; }



        public Form1()
        {
            service = new OrderService(this);

 
            Order order1 = new Order(300001, "guest1");
            Order order2 = new Order(300002, "guest2");

            order1.AddItem("good1", 1, 1);
            order2.AddItem("good2", 1, 2);
            service.AddOrder(order1);
            service.AddOrder(order2);

            InitializeComponent();
            orderBindingSource.DataSource = service.GetAllRecord();
            IDQueryTextBox.DataBindings.Add("Text", this, "InputIdQuery");
            NameQueryTextBox.DataBindings.Add("Text", this, "InputNameQuery");

        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            uint[] idToDelete = new uint[1];

            DeleteDialog dialog1 = new DeleteDialog(idToDelete);
            dialog1.Visible = false;
            dialog1.ShowDialog();

            if (service.DeleteOrderById(idToDelete[0]))
            {
                MessageBox.Show("删除成功", "消息");
            }
            else
            {
                MessageBox.Show("删除失败", "消息");
            }
            orderBindingSource.ResetBindings(false);

        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            Order neworder = new Order();
            Form2 dialog1 = new Form2(neworder);
            dialog1.Visible = false;
            dialog1.ShowDialog();
            if (!service.AddOrder(neworder))
            {
                MessageBox.Show("您输入的订单号已存在，请重新输入", "消息");
            }
            else
            {
                MessageBox.Show("创建成功！", "消息");
            }
            orderBindingSource.ResetBindings(false);
        }

        private void IDQueryButton_Click(object sender, EventArgs e)
        {
            if (InputIdQuery == 0)
            {
                orderBindingSource.DataSource = service.GetAllRecord();
            }
            else
            {
                orderBindingSource.DataSource = service.SearchOrderById(InputIdQuery);
            }
        }

        private void nameQueryButton_Click(object sender, EventArgs e)
        {
            if (InputNameQuery == "")
            {
                orderBindingSource.DataSource = service.GetAllRecord();
            }
            else
            {
                orderBindingSource.DataSource = service.SearchOrderByUsername(InputNameQuery);
            }
        }

        private void updateOrderButton_Click(object sender, EventArgs e)
        {
            UpdateOrderItemsDialog dialog = new UpdateOrderItemsDialog(this.service.GetAllRecord()[this.dataGridView1.CurrentCellAddress.X].orderitems);
            dialog.Visible = false;
            dialog.ShowDialog();
            this.service.GetAllRecord()[this.dataGridView1.CurrentCellAddress.X].UpdatePrice();
            orderBindingSource.ResetBindings(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
