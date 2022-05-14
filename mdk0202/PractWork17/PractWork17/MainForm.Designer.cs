
namespace PractWork17
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
            this.ProductsButton = new System.Windows.Forms.Button();
            this.ProductsPriceButton = new System.Windows.Forms.Button();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.ProducersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductsButton
            // 
            this.ProductsButton.Location = new System.Drawing.Point(12, 12);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(96, 23);
            this.ProductsButton.TabIndex = 0;
            this.ProductsButton.Text = "Продукты";
            this.ProductsButton.UseVisualStyleBackColor = true;
            this.ProductsButton.Click += new System.EventHandler(this.ProductsButton_Click);
            // 
            // ProductsPriceButton
            // 
            this.ProductsPriceButton.Location = new System.Drawing.Point(114, 12);
            this.ProductsPriceButton.Name = "ProductsPriceButton";
            this.ProductsPriceButton.Size = new System.Drawing.Size(96, 23);
            this.ProductsPriceButton.TabIndex = 1;
            this.ProductsPriceButton.Text = "Товары по цене";
            this.ProductsPriceButton.UseVisualStyleBackColor = true;
            this.ProductsPriceButton.Click += new System.EventHandler(this.ProductsPriceButton_Click);
            // 
            // OrdersButton
            // 
            this.OrdersButton.Location = new System.Drawing.Point(216, 12);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(96, 23);
            this.OrdersButton.TabIndex = 2;
            this.OrdersButton.Text = "Заказы по дате";
            this.OrdersButton.UseVisualStyleBackColor = true;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // ProducersButton
            // 
            this.ProducersButton.Location = new System.Drawing.Point(318, 12);
            this.ProducersButton.Name = "ProducersButton";
            this.ProducersButton.Size = new System.Drawing.Size(171, 23);
            this.ProducersButton.TabIndex = 3;
            this.ProducersButton.Text = "Товары по производителям";
            this.ProducersButton.UseVisualStyleBackColor = true;
            this.ProducersButton.Click += new System.EventHandler(this.ProducersButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 383);
            this.Controls.Add(this.ProducersButton);
            this.Controls.Add(this.OrdersButton);
            this.Controls.Add(this.ProductsPriceButton);
            this.Controls.Add(this.ProductsButton);
            this.Name = "MainForm";
            this.Text = "Главная";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ProductsButton;
        private System.Windows.Forms.Button ProductsPriceButton;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.Button ProducersButton;
    }
}

