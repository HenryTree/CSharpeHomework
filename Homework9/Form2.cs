using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OrderService
{
    //创建订单时产生的窗口
    public partial class Form2 : Form
    {
        public uint inputOrderID { get; set; }
        public string inputGuestName { get; set; }
        public Order order;

        public Form2(Order order)
        {
            InitializeComponent();
            this.order = order;
            guestNameTextBox.DataBindings.Add("Text", this, "inputGuestName");
            orderIdTextBox.DataBindings.Add("Text", this, "inputOrderID");
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            this.order.Id = this.inputOrderID;
            this.order.Buyer = this.inputGuestName;
            this.order.orderitems = new List<OrderItem>();
            this.Dispose();
        }
    }
}
