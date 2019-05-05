namespace OrderService
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateOrderButton = new System.Windows.Forms.Button();
            this.NameQueryTextBox = new System.Windows.Forms.TextBox();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.IDQueryTextBox = new System.Windows.Forms.TextBox();
            this.nameQueryButton = new System.Windows.Forms.Button();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.IDQueryButton = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // buyerDataGridViewTextBoxColumn
            // 
            this.buyerDataGridViewTextBoxColumn.DataPropertyName = "Buyer";
            this.buyerDataGridViewTextBoxColumn.HeaderText = "Buyer";
            this.buyerDataGridViewTextBoxColumn.Name = "buyerDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.buyerDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(942, 729);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.updateOrderButton);
            this.panel1.Controls.Add(this.NameQueryTextBox);
            this.panel1.Controls.Add(this.deleteOrderButton);
            this.panel1.Controls.Add(this.IDQueryTextBox);
            this.panel1.Controls.Add(this.nameQueryButton);
            this.panel1.Controls.Add(this.createOrderButton);
            this.panel1.Controls.Add(this.IDQueryButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(942, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 729);
            this.panel1.TabIndex = 4;
            // 
            // updateOrderButton
            // 
            this.updateOrderButton.Location = new System.Drawing.Point(24, 163);
            this.updateOrderButton.Name = "updateOrderButton";
            this.updateOrderButton.Size = new System.Drawing.Size(151, 63);
            this.updateOrderButton.TabIndex = 6;
            this.updateOrderButton.Text = "修改订单";
            this.updateOrderButton.UseVisualStyleBackColor = true;
            this.updateOrderButton.Click += new System.EventHandler(this.updateOrderButton_Click);
            // 
            // NameQueryTextBox
            // 
            this.NameQueryTextBox.Location = new System.Drawing.Point(201, 462);
            this.NameQueryTextBox.Name = "NameQueryTextBox";
            this.NameQueryTextBox.Size = new System.Drawing.Size(274, 35);
            this.NameQueryTextBox.TabIndex = 2;
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Location = new System.Drawing.Point(24, 255);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(151, 63);
            this.deleteOrderButton.TabIndex = 5;
            this.deleteOrderButton.Text = "删除订单";
            this.deleteOrderButton.UseVisualStyleBackColor = true;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // IDQueryTextBox
            // 
            this.IDQueryTextBox.Location = new System.Drawing.Point(201, 366);
            this.IDQueryTextBox.Name = "IDQueryTextBox";
            this.IDQueryTextBox.Size = new System.Drawing.Size(274, 35);
            this.IDQueryTextBox.TabIndex = 1;
            // 
            // nameQueryButton
            // 
            this.nameQueryButton.Location = new System.Drawing.Point(24, 447);
            this.nameQueryButton.Name = "nameQueryButton";
            this.nameQueryButton.Size = new System.Drawing.Size(161, 61);
            this.nameQueryButton.TabIndex = 3;
            this.nameQueryButton.Text = "用户名查找";
            this.nameQueryButton.UseVisualStyleBackColor = true;
            this.nameQueryButton.Click += new System.EventHandler(this.nameQueryButton_Click);
            // 
            // createOrderButton
            // 
            this.createOrderButton.Location = new System.Drawing.Point(24, 79);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(151, 56);
            this.createOrderButton.TabIndex = 4;
            this.createOrderButton.Text = "创建订单";
            this.createOrderButton.UseVisualStyleBackColor = true;
            this.createOrderButton.Click += new System.EventHandler(this.createOrderButton_Click);
            // 
            // IDQueryButton
            // 
            this.IDQueryButton.Location = new System.Drawing.Point(24, 353);
            this.IDQueryButton.Name = "IDQueryButton";
            this.IDQueryButton.Size = new System.Drawing.Size(151, 57);
            this.IDQueryButton.TabIndex = 0;
            this.IDQueryButton.Text = "ID查找";
            this.IDQueryButton.UseVisualStyleBackColor = true;
            this.IDQueryButton.Click += new System.EventHandler(this.IDQueryButton_Click);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "订单Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // buyerDataGridViewTextBoxColumn1
            // 
            this.buyerDataGridViewTextBoxColumn1.DataPropertyName = "Buyer";
            this.buyerDataGridViewTextBoxColumn1.HeaderText = "客户名字";
            this.buyerDataGridViewTextBoxColumn1.Name = "buyerDataGridViewTextBoxColumn1";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "总价";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Order);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 729);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1500, 800);
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            this.Name = "Form1";
            this.Text = "订单管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerDataGridViewTextBoxColumn;
        public System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button IDQueryButton;
        private System.Windows.Forms.TextBox IDQueryTextBox;
        private System.Windows.Forms.TextBox NameQueryTextBox;
        private System.Windows.Forms.Button nameQueryButton;
        private System.Windows.Forms.Button deleteOrderButton;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Button updateOrderButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}

