
namespace PractWork18
{
    partial class MainForm
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
            this.ProductsPriceButton = new System.Windows.Forms.Button();
            this.ProducersButton = new System.Windows.Forms.Button();
            this.OrdersSumButton = new System.Windows.Forms.Button();
            this.ProductsTypesButton = new System.Windows.Forms.Button();
            this.OrderProductsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductsPriceButton
            // 
            this.ProductsPriceButton.Location = new System.Drawing.Point(13, 13);
            this.ProductsPriceButton.Name = "ProductsPriceButton";
            this.ProductsPriceButton.Size = new System.Drawing.Size(142, 23);
            this.ProductsPriceButton.TabIndex = 0;
            this.ProductsPriceButton.Text = "Товары по ценам";
            this.ProductsPriceButton.UseVisualStyleBackColor = true;
            this.ProductsPriceButton.Click += new System.EventHandler(this.ProductsPriceButton_Click);
            // 
            // ProducersButton
            // 
            this.ProducersButton.Location = new System.Drawing.Point(12, 42);
            this.ProducersButton.Name = "ProducersButton";
            this.ProducersButton.Size = new System.Drawing.Size(142, 23);
            this.ProducersButton.TabIndex = 1;
            this.ProducersButton.Text = "Производители";
            this.ProducersButton.UseVisualStyleBackColor = true;
            this.ProducersButton.Click += new System.EventHandler(this.ProducersButton_Click);
            // 
            // OrdersSumButton
            // 
            this.OrdersSumButton.Location = new System.Drawing.Point(13, 71);
            this.OrdersSumButton.Name = "OrdersSumButton";
            this.OrdersSumButton.Size = new System.Drawing.Size(142, 23);
            this.OrdersSumButton.TabIndex = 2;
            this.OrdersSumButton.Text = "Заказы и суммы";
            this.OrdersSumButton.UseVisualStyleBackColor = true;
            this.OrdersSumButton.Click += new System.EventHandler(this.OrdersSumButton_Click);
            // 
            // ProductsTypesButton
            // 
            this.ProductsTypesButton.Location = new System.Drawing.Point(13, 100);
            this.ProductsTypesButton.Name = "ProductsTypesButton";
            this.ProductsTypesButton.Size = new System.Drawing.Size(142, 23);
            this.ProductsTypesButton.TabIndex = 3;
            this.ProductsTypesButton.Text = "Типы товаров";
            this.ProductsTypesButton.UseVisualStyleBackColor = true;
            this.ProductsTypesButton.Click += new System.EventHandler(this.ProductsTypesButton_Click);
            // 
            // OrderProductsButton
            // 
            this.OrderProductsButton.Location = new System.Drawing.Point(13, 129);
            this.OrderProductsButton.Name = "OrderProductsButton";
            this.OrderProductsButton.Size = new System.Drawing.Size(142, 23);
            this.OrderProductsButton.TabIndex = 4;
            this.OrderProductsButton.Text = "Заказы с товарами";
            this.OrderProductsButton.UseVisualStyleBackColor = true;
            this.OrderProductsButton.Click += new System.EventHandler(this.OrderProductsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 314);
            this.Controls.Add(this.OrderProductsButton);
            this.Controls.Add(this.ProductsTypesButton);
            this.Controls.Add(this.OrdersSumButton);
            this.Controls.Add(this.ProducersButton);
            this.Controls.Add(this.ProductsPriceButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ProductsPriceButton;
        private System.Windows.Forms.Button ProducersButton;
        private System.Windows.Forms.Button OrdersSumButton;
        private System.Windows.Forms.Button ProductsTypesButton;
        private System.Windows.Forms.Button OrderProductsButton;
    }
}