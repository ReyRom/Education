
namespace PractWork16
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CustomerLoginButton = new System.Windows.Forms.Button();
            this.ProductsPriceDescButton = new System.Windows.Forms.Button();
            this.OrdersDateDescButton = new System.Windows.Forms.Button();
            this.ProductsPriceTypeButton = new System.Windows.Forms.Button();
            this.ProductsTypePriceDescButton = new System.Windows.Forms.Button();
            this.ProductsProducerModelButton = new System.Windows.Forms.Button();
            this.CustomersListButton = new System.Windows.Forms.Button();
            this.ProductsButton = new System.Windows.Forms.Button();
            this.ProductsMultiSortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerLoginButton
            // 
            this.CustomerLoginButton.Location = new System.Drawing.Point(13, 13);
            this.CustomerLoginButton.Name = "CustomerLoginButton";
            this.CustomerLoginButton.Size = new System.Drawing.Size(75, 23);
            this.CustomerLoginButton.TabIndex = 0;
            this.CustomerLoginButton.Text = "Task1.1";
            this.CustomerLoginButton.UseVisualStyleBackColor = true;
            this.CustomerLoginButton.Click += new System.EventHandler(this.CustomerLoginButton_Click);
            // 
            // ProductsPriceDescButton
            // 
            this.ProductsPriceDescButton.Location = new System.Drawing.Point(13, 42);
            this.ProductsPriceDescButton.Name = "ProductsPriceDescButton";
            this.ProductsPriceDescButton.Size = new System.Drawing.Size(75, 23);
            this.ProductsPriceDescButton.TabIndex = 1;
            this.ProductsPriceDescButton.Text = "Task1.2";
            this.ProductsPriceDescButton.UseVisualStyleBackColor = true;
            this.ProductsPriceDescButton.Click += new System.EventHandler(this.ProductsPriceDescButton_Click);
            // 
            // OrdersDateDescButton
            // 
            this.OrdersDateDescButton.Location = new System.Drawing.Point(13, 71);
            this.OrdersDateDescButton.Name = "OrdersDateDescButton";
            this.OrdersDateDescButton.Size = new System.Drawing.Size(75, 23);
            this.OrdersDateDescButton.TabIndex = 2;
            this.OrdersDateDescButton.Text = "Task1.3";
            this.OrdersDateDescButton.UseVisualStyleBackColor = true;
            this.OrdersDateDescButton.Click += new System.EventHandler(this.OrdersDateDescButton_Click);
            // 
            // ProductsPriceTypeButton
            // 
            this.ProductsPriceTypeButton.Location = new System.Drawing.Point(94, 13);
            this.ProductsPriceTypeButton.Name = "ProductsPriceTypeButton";
            this.ProductsPriceTypeButton.Size = new System.Drawing.Size(75, 23);
            this.ProductsPriceTypeButton.TabIndex = 3;
            this.ProductsPriceTypeButton.Text = "Task2.1";
            this.ProductsPriceTypeButton.UseVisualStyleBackColor = true;
            this.ProductsPriceTypeButton.Click += new System.EventHandler(this.ProductsPriceTypeButton_Click);
            // 
            // ProductsTypePriceDescButton
            // 
            this.ProductsTypePriceDescButton.Location = new System.Drawing.Point(94, 42);
            this.ProductsTypePriceDescButton.Name = "ProductsTypePriceDescButton";
            this.ProductsTypePriceDescButton.Size = new System.Drawing.Size(75, 23);
            this.ProductsTypePriceDescButton.TabIndex = 4;
            this.ProductsTypePriceDescButton.Text = "Task2.2";
            this.ProductsTypePriceDescButton.UseVisualStyleBackColor = true;
            this.ProductsTypePriceDescButton.Click += new System.EventHandler(this.ProductsTypePriceDescButton_Click);
            // 
            // ProductsProducerModelButton
            // 
            this.ProductsProducerModelButton.Location = new System.Drawing.Point(94, 71);
            this.ProductsProducerModelButton.Name = "ProductsProducerModelButton";
            this.ProductsProducerModelButton.Size = new System.Drawing.Size(75, 23);
            this.ProductsProducerModelButton.TabIndex = 5;
            this.ProductsProducerModelButton.Text = "Task2.3";
            this.ProductsProducerModelButton.UseVisualStyleBackColor = true;
            this.ProductsProducerModelButton.Click += new System.EventHandler(this.ProductsProducerModelButton_Click);
            // 
            // CustomersListButton
            // 
            this.CustomersListButton.Location = new System.Drawing.Point(176, 13);
            this.CustomersListButton.Name = "CustomersListButton";
            this.CustomersListButton.Size = new System.Drawing.Size(75, 23);
            this.CustomersListButton.TabIndex = 6;
            this.CustomersListButton.Text = "Task3";
            this.CustomersListButton.UseVisualStyleBackColor = true;
            this.CustomersListButton.Click += new System.EventHandler(this.CustomersListButton_Click);
            // 
            // ProductsButton
            // 
            this.ProductsButton.Location = new System.Drawing.Point(257, 12);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(75, 23);
            this.ProductsButton.TabIndex = 7;
            this.ProductsButton.Text = "Task4";
            this.ProductsButton.UseVisualStyleBackColor = true;
            this.ProductsButton.Click += new System.EventHandler(this.ProductsButton_Click);
            // 
            // ProductsMultiSortButton
            // 
            this.ProductsMultiSortButton.Location = new System.Drawing.Point(338, 12);
            this.ProductsMultiSortButton.Name = "ProductsMultiSortButton";
            this.ProductsMultiSortButton.Size = new System.Drawing.Size(75, 23);
            this.ProductsMultiSortButton.TabIndex = 8;
            this.ProductsMultiSortButton.Text = "Task5";
            this.ProductsMultiSortButton.UseVisualStyleBackColor = true;
            this.ProductsMultiSortButton.Click += new System.EventHandler(this.ProductsMultiSortButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 419);
            this.Controls.Add(this.ProductsMultiSortButton);
            this.Controls.Add(this.ProductsButton);
            this.Controls.Add(this.CustomersListButton);
            this.Controls.Add(this.ProductsProducerModelButton);
            this.Controls.Add(this.ProductsTypePriceDescButton);
            this.Controls.Add(this.ProductsPriceTypeButton);
            this.Controls.Add(this.OrdersDateDescButton);
            this.Controls.Add(this.ProductsPriceDescButton);
            this.Controls.Add(this.CustomerLoginButton);
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CustomerLoginButton;
        private System.Windows.Forms.Button ProductsPriceDescButton;
        private System.Windows.Forms.Button OrdersDateDescButton;
        private System.Windows.Forms.Button ProductsPriceTypeButton;
        private System.Windows.Forms.Button ProductsTypePriceDescButton;
        private System.Windows.Forms.Button ProductsProducerModelButton;
        private System.Windows.Forms.Button CustomersListButton;
        private System.Windows.Forms.Button ProductsButton;
        private System.Windows.Forms.Button ProductsMultiSortButton;
    }
}

