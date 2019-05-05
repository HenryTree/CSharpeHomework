namespace OrderService
{
    partial class DeleteDialog
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
            this.inputIdLabel = new System.Windows.Forms.Label();
            this.inputIdConfirmButton = new System.Windows.Forms.Button();
            this.inputIdTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputIdLabel
            // 
            this.inputIdLabel.AutoSize = true;
            this.inputIdLabel.Location = new System.Drawing.Point(116, 188);
            this.inputIdLabel.Name = "inputIdLabel";
            this.inputIdLabel.Size = new System.Drawing.Size(274, 24);
            this.inputIdLabel.TabIndex = 0;
            this.inputIdLabel.Text = "请输入删除的订单ID号：";
            // 
            // inputIdConfirmButton
            // 
            this.inputIdConfirmButton.Location = new System.Drawing.Point(300, 314);
            this.inputIdConfirmButton.Name = "inputIdConfirmButton";
            this.inputIdConfirmButton.Size = new System.Drawing.Size(115, 57);
            this.inputIdConfirmButton.TabIndex = 1;
            this.inputIdConfirmButton.Text = "确认";
            this.inputIdConfirmButton.UseVisualStyleBackColor = true;
            this.inputIdConfirmButton.Click += new System.EventHandler(this.inputIdConfirmButton_Click);
            // 
            // inputIdTextBox
            // 
            this.inputIdTextBox.Location = new System.Drawing.Point(406, 177);
            this.inputIdTextBox.Name = "inputIdTextBox";
            this.inputIdTextBox.Size = new System.Drawing.Size(202, 35);
            this.inputIdTextBox.TabIndex = 2;
            // 
            // DeleteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputIdTextBox);
            this.Controls.Add(this.inputIdConfirmButton);
            this.Controls.Add(this.inputIdLabel);
            this.Name = "DeleteDialog";
            this.Text = "删除订单";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputIdLabel;
        private System.Windows.Forms.Button inputIdConfirmButton;
        private System.Windows.Forms.TextBox inputIdTextBox;
    }
}