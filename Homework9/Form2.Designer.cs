namespace OrderService
{
    partial class Form2
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
            this.confirmButton = new System.Windows.Forms.Button();
            this.guestNameTextBox = new System.Windows.Forms.TextBox();
            this.orderIdTextBox = new System.Windows.Forms.TextBox();
            this.orderIDLabel = new System.Windows.Forms.Label();
            this.guestNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(185, 286);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(115, 45);
            this.confirmButton.TabIndex = 0;
            this.confirmButton.Text = "确认";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // guestNameTextBox
            // 
            this.guestNameTextBox.Location = new System.Drawing.Point(266, 179);
            this.guestNameTextBox.Name = "guestNameTextBox";
            this.guestNameTextBox.Size = new System.Drawing.Size(196, 35);
            this.guestNameTextBox.TabIndex = 1;
            // 
            // orderIdTextBox
            // 
            this.orderIdTextBox.Location = new System.Drawing.Point(266, 125);
            this.orderIdTextBox.Name = "orderIdTextBox";
            this.orderIdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.orderIdTextBox.Size = new System.Drawing.Size(196, 35);
            this.orderIdTextBox.TabIndex = 2;
            // 
            // orderIDLabel
            // 
            this.orderIDLabel.AutoSize = true;
            this.orderIDLabel.Location = new System.Drawing.Point(133, 128);
            this.orderIDLabel.Name = "orderIDLabel";
            this.orderIDLabel.Size = new System.Drawing.Size(94, 24);
            this.orderIDLabel.TabIndex = 4;
            this.orderIDLabel.Text = "OrderID";
            // 
            // guestNameLabel
            // 
            this.guestNameLabel.AutoSize = true;
            this.guestNameLabel.Location = new System.Drawing.Point(132, 182);
            this.guestNameLabel.Name = "guestNameLabel";
            this.guestNameLabel.Size = new System.Drawing.Size(106, 24);
            this.guestNameLabel.TabIndex = 5;
            this.guestNameLabel.Text = "客户姓名";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 429);
            this.Controls.Add(this.guestNameLabel);
            this.Controls.Add(this.orderIDLabel);
            this.Controls.Add(this.orderIdTextBox);
            this.Controls.Add(this.guestNameTextBox);
            this.Controls.Add(this.confirmButton);
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Form2";
            this.Text = "新建订单";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox guestNameTextBox;
        private System.Windows.Forms.TextBox orderIdTextBox;
        private System.Windows.Forms.Label orderIDLabel;
        private System.Windows.Forms.Label guestNameLabel;
    }
}