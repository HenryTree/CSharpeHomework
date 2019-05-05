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
    //修改订单时产生的窗口
    public partial class UpdateOrderItemsDialog : Form
    {
        public List<OrderItem> orderitems;
        public string inputGood { get; set; }
        public uint inputNumber { get; set; }
        public uint inputPrice { get; set; }
        public string inputDetail { get; set; }

        public UpdateOrderItemsDialog(List<OrderItem> orderitems)
        {
            this.orderitems = orderitems;
            InitializeComponent();
            this.OrderItemGoodTextBox.DataBindings.Add("Text", this, "inputGood");
            this.OrderItemNumberTextBox.DataBindings.Add("Text", this, "inputNumber");
            this.OrderItemDetailTextBox.DataBindings.Add("Text", this, "inputDetail");
            this.orderItemPriceTextBox.DataBindings.Add("Text", this, "inputPrice");
            this.orderItemBindingSource.DataSource = this.orderitems;
        }

        private void addOrderItemButton_Click(object sender, EventArgs e)
        {
            OrderItem newOrderItem = new OrderItem(inputGood, inputNumber, inputPrice,inputDetail);
            orderitems.Add(newOrderItem);
            orderItemBindingSource.ResetBindings(false);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void UpdateOrderItemsDialog_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
