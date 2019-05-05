namespace OrderService
{
    partial class UpdateOrderItemsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderItemPriceTextBox = new System.Windows.Forms.TextBox();
            this.orderItemPriceLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.addOrderItemButton = new System.Windows.Forms.Button();
            this.OrderItemDetailTextBox = new System.Windows.Forms.TextBox();
            this.OrderItemNumberTextBox = new System.Windows.Forms.TextBox();
            this.OrderItemGoodTextBox = new System.Windows.Forms.TextBox();
            this.orderItemDetailLabel = new System.Windows.Forms.Label();
            this.orderItemNumberLabel = new System.Windows.Forms.Label();
            this.orderItemGoodLabel = new System.Windows.Forms.Label();
            this.goodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderItemBindingSource
            //
            this.orderItemBindingSource.DataSource = typeof(OrderItem);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.detailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderItemBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1412, 700);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.orderItemPriceTextBox);
            this.panel1.Controls.Add(this.orderItemPriceLabel);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.addOrderItemButton);
            this.panel1.Controls.Add(this.OrderItemDetailTextBox);
            this.panel1.Controls.Add(this.OrderItemNumberTextBox);
            this.panel1.Controls.Add(this.OrderItemGoodTextBox);
            this.panel1.Controls.Add(this.orderItemDetailLabel);
            this.panel1.Controls.Add(this.orderItemNumberLabel);
            this.panel1.Controls.Add(this.orderItemGoodLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(812, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 700);
            this.panel1.TabIndex = 1;
            // 
            // orderItemPriceTextBox
            // 
            this.orderItemPriceTextBox.Location = new System.Drawing.Point(130, 197);
            this.orderItemPriceTextBox.Name = "orderItemPriceTextBox";
            this.orderItemPriceTextBox.Size = new System.Drawing.Size(190, 35);
            this.orderItemPriceTextBox.TabIndex = 9;
            // 
            // orderItemPriceLabel
            // 
            this.orderItemPriceLabel.AutoSize = true;
            this.orderItemPriceLabel.Location = new System.Drawing.Point(26, 200);
            this.orderItemPriceLabel.Name = "orderItemPriceLabel";
            this.orderItemPriceLabel.Size = new System.Drawing.Size(58, 24);
            this.orderItemPriceLabel.TabIndex = 8;
            this.orderItemPriceLabel.Text = "单价";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(255, 314);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(170, 43);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "完成";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addOrderItemButton
            // 
            this.addOrderItemButton.Location = new System.Drawing.Point(33, 314);
            this.addOrderItemButton.Name = "addOrderItemButton";
            this.addOrderItemButton.Size = new System.Drawing.Size(175, 43);
            this.addOrderItemButton.TabIndex = 6;
            this.addOrderItemButton.Text = "增加商品";
            this.addOrderItemButton.UseVisualStyleBackColor = true;
            this.addOrderItemButton.Click += new System.EventHandler(this.addOrderItemButton_Click);
            // 
            // OrderItemDetailTextBox
            // 
            this.OrderItemDetailTextBox.Location = new System.Drawing.Point(130, 247);
            this.OrderItemDetailTextBox.Name = "OrderItemDetailTextBox";
            this.OrderItemDetailTextBox.Size = new System.Drawing.Size(190, 35);
            this.OrderItemDetailTextBox.TabIndex = 5;
            this.OrderItemDetailTextBox.Text = "NULL";
            // 
            // OrderItemNumberTextBox
            // 
            this.OrderItemNumberTextBox.Location = new System.Drawing.Point(130, 143);
            this.OrderItemNumberTextBox.Name = "OrderItemNumberTextBox";
            this.OrderItemNumberTextBox.Size = new System.Drawing.Size(190, 35);
            this.OrderItemNumberTextBox.TabIndex = 4;
            // 
            // OrderItemGoodTextBox
            // 
            this.OrderItemGoodTextBox.Location = new System.Drawing.Point(130, 89);
            this.OrderItemGoodTextBox.Name = "OrderItemGoodTextBox";
            this.OrderItemGoodTextBox.Size = new System.Drawing.Size(190, 35);
            this.OrderItemGoodTextBox.TabIndex = 3;
            // 
            // orderItemDetailLabel
            // 
            this.orderItemDetailLabel.AutoSize = true;
            this.orderItemDetailLabel.Location = new System.Drawing.Point(29, 250);
            this.orderItemDetailLabel.Name = "orderItemDetailLabel";
            this.orderItemDetailLabel.Size = new System.Drawing.Size(58, 24);
            this.orderItemDetailLabel.TabIndex = 2;
            this.orderItemDetailLabel.Text = "细节";
            // 
            // orderItemNumberLabel
            // 
            this.orderItemNumberLabel.AutoSize = true;
            this.orderItemNumberLabel.Location = new System.Drawing.Point(26, 146);
            this.orderItemNumberLabel.Name = "orderItemNumberLabel";
            this.orderItemNumberLabel.Size = new System.Drawing.Size(58, 24);
            this.orderItemNumberLabel.TabIndex = 1;
            this.orderItemNumberLabel.Text = "数量";
            // 
            // orderItemGoodLabel
            // 
            this.orderItemGoodLabel.AutoSize = true;
            this.orderItemGoodLabel.Location = new System.Drawing.Point(26, 92);
            this.orderItemGoodLabel.Name = "orderItemGoodLabel";
            this.orderItemGoodLabel.Size = new System.Drawing.Size(58, 24);
            this.orderItemGoodLabel.TabIndex = 0;
            this.orderItemGoodLabel.Text = "名字";
            // 
            // goodDataGridViewTextBoxColumn
            // 
            this.goodDataGridViewTextBoxColumn.DataPropertyName = "Good";
            this.goodDataGridViewTextBoxColumn.HeaderText = "名称";
            this.goodDataGridViewTextBoxColumn.Name = "goodDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "数量";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // detailDataGridViewTextBoxColumn
            // 
            this.detailDataGridViewTextBoxColumn.DataPropertyName = "Detail";
            this.detailDataGridViewTextBoxColumn.HeaderText = "细节";
            this.detailDataGridViewTextBoxColumn.Name = "detailDataGridViewTextBoxColumn";
            // 
            // UpdateOrderItemsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UpdateOrderItemsDialog";
            this.Text = "更改订单信息";
            this.Load += new System.EventHandler(this.UpdateOrderItemsDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource orderItemBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addOrderItemButton;
        private System.Windows.Forms.TextBox OrderItemDetailTextBox;
        private System.Windows.Forms.TextBox OrderItemNumberTextBox;
        private System.Windows.Forms.TextBox OrderItemGoodTextBox;
        private System.Windows.Forms.Label orderItemDetailLabel;
        private System.Windows.Forms.Label orderItemNumberLabel;
        private System.Windows.Forms.Label orderItemGoodLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox orderItemPriceTextBox;
        private System.Windows.Forms.Label orderItemPriceLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailDataGridViewTextBoxColumn;
    }
}