
namespace PractWork25
{
    partial class TablesForm
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
            this.TablesTabControl = new System.Windows.Forms.TabControl();
            this.MainTabPage = new System.Windows.Forms.TabPage();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.ProductsButton = new System.Windows.Forms.Button();
            this.ProductsTabPage = new System.Windows.Forms.TabPage();
            this.ToMainProductsButton = new System.Windows.Forms.Button();
            this.OrdersTabPage = new System.Windows.Forms.TabPage();
            this.ToMainOrdersButton = new System.Windows.Forms.Button();
            this.CustomersTabPage = new System.Windows.Forms.TabPage();
            this.ToMainCustomersButton = new System.Windows.Forms.Button();
            this.TablesTabControl.SuspendLayout();
            this.MainTabPage.SuspendLayout();
            this.ProductsTabPage.SuspendLayout();
            this.OrdersTabPage.SuspendLayout();
            this.CustomersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablesTabControl
            // 
            this.TablesTabControl.Controls.Add(this.MainTabPage);
            this.TablesTabControl.Controls.Add(this.ProductsTabPage);
            this.TablesTabControl.Controls.Add(this.OrdersTabPage);
            this.TablesTabControl.Controls.Add(this.CustomersTabPage);
            this.TablesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablesTabControl.Location = new System.Drawing.Point(0, 100);
            this.TablesTabControl.Name = "TablesTabControl";
            this.TablesTabControl.SelectedIndex = 0;
            this.TablesTabControl.Size = new System.Drawing.Size(584, 259);
            this.TablesTabControl.TabIndex = 2;
            // 
            // MainTabPage
            // 
            this.MainTabPage.Controls.Add(this.CustomersButton);
            this.MainTabPage.Controls.Add(this.OrdersButton);
            this.MainTabPage.Controls.Add(this.ProductsButton);
            this.MainTabPage.Location = new System.Drawing.Point(4, 26);
            this.MainTabPage.Name = "MainTabPage";
            this.MainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainTabPage.Size = new System.Drawing.Size(576, 229);
            this.MainTabPage.TabIndex = 0;
            this.MainTabPage.Text = "Главная";
            this.MainTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomersButton
            // 
            this.CustomersButton.Location = new System.Drawing.Point(248, 154);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(90, 23);
            this.CustomersButton.TabIndex = 2;
            this.CustomersButton.Text = "Покупатели";
            this.CustomersButton.UseVisualStyleBackColor = true;
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // OrdersButton
            // 
            this.OrdersButton.Location = new System.Drawing.Point(248, 102);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(90, 23);
            this.OrdersButton.TabIndex = 1;
            this.OrdersButton.Text = "Заказы";
            this.OrdersButton.UseVisualStyleBackColor = true;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // ProductsButton
            // 
            this.ProductsButton.Location = new System.Drawing.Point(248, 50);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(90, 23);
            this.ProductsButton.TabIndex = 0;
            this.ProductsButton.Text = "Товары";
            this.ProductsButton.UseVisualStyleBackColor = true;
            this.ProductsButton.Click += new System.EventHandler(this.ProductsButton_Click);
            // 
            // ProductsTabPage
            // 
            this.ProductsTabPage.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ProductsTabPage.Controls.Add(this.ToMainProductsButton);
            this.ProductsTabPage.Location = new System.Drawing.Point(4, 26);
            this.ProductsTabPage.Name = "ProductsTabPage";
            this.ProductsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ProductsTabPage.Size = new System.Drawing.Size(576, 229);
            this.ProductsTabPage.TabIndex = 1;
            this.ProductsTabPage.Text = "Товары";
            // 
            // ToMainProductsButton
            // 
            this.ToMainProductsButton.Location = new System.Drawing.Point(8, 6);
            this.ToMainProductsButton.Name = "ToMainProductsButton";
            this.ToMainProductsButton.Size = new System.Drawing.Size(75, 23);
            this.ToMainProductsButton.TabIndex = 0;
            this.ToMainProductsButton.Text = "Назад";
            this.ToMainProductsButton.UseVisualStyleBackColor = true;
            this.ToMainProductsButton.Click += new System.EventHandler(this.ToMainButton_Click);
            // 
            // OrdersTabPage
            // 
            this.OrdersTabPage.BackColor = System.Drawing.Color.BurlyWood;
            this.OrdersTabPage.Controls.Add(this.ToMainOrdersButton);
            this.OrdersTabPage.Location = new System.Drawing.Point(4, 26);
            this.OrdersTabPage.Name = "OrdersTabPage";
            this.OrdersTabPage.Size = new System.Drawing.Size(576, 229);
            this.OrdersTabPage.TabIndex = 2;
            this.OrdersTabPage.Text = "Заказы";
            // 
            // ToMainOrdersButton
            // 
            this.ToMainOrdersButton.Location = new System.Drawing.Point(8, 6);
            this.ToMainOrdersButton.Name = "ToMainOrdersButton";
            this.ToMainOrdersButton.Size = new System.Drawing.Size(75, 23);
            this.ToMainOrdersButton.TabIndex = 0;
            this.ToMainOrdersButton.Text = "Назад";
            this.ToMainOrdersButton.UseVisualStyleBackColor = true;
            this.ToMainOrdersButton.Click += new System.EventHandler(this.ToMainButton_Click);
            // 
            // CustomersTabPage
            // 
            this.CustomersTabPage.BackColor = System.Drawing.Color.Salmon;
            this.CustomersTabPage.Controls.Add(this.ToMainCustomersButton);
            this.CustomersTabPage.Location = new System.Drawing.Point(4, 26);
            this.CustomersTabPage.Name = "CustomersTabPage";
            this.CustomersTabPage.Size = new System.Drawing.Size(576, 229);
            this.CustomersTabPage.TabIndex = 3;
            this.CustomersTabPage.Text = "Покупатели";
            // 
            // ToMainCustomersButton
            // 
            this.ToMainCustomersButton.Location = new System.Drawing.Point(8, 7);
            this.ToMainCustomersButton.Name = "ToMainCustomersButton";
            this.ToMainCustomersButton.Size = new System.Drawing.Size(75, 23);
            this.ToMainCustomersButton.TabIndex = 0;
            this.ToMainCustomersButton.Text = "Назад";
            this.ToMainCustomersButton.UseVisualStyleBackColor = true;
            this.ToMainCustomersButton.Click += new System.EventHandler(this.ToMainButton_Click);
            // 
            // TablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 409);
            this.Controls.Add(this.TablesTabControl);
            this.MinimumSize = new System.Drawing.Size(600, 448);
            this.Name = "TablesForm";
            this.Text = "TablesForm";
            this.Load += new System.EventHandler(this.TablesForm_Load);
            this.Controls.SetChildIndex(this.TablesTabControl, 0);
            this.TablesTabControl.ResumeLayout(false);
            this.MainTabPage.ResumeLayout(false);
            this.ProductsTabPage.ResumeLayout(false);
            this.OrdersTabPage.ResumeLayout(false);
            this.CustomersTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TablesTabControl;
        private System.Windows.Forms.TabPage MainTabPage;
        private System.Windows.Forms.TabPage ProductsTabPage;
        private System.Windows.Forms.TabPage OrdersTabPage;
        private System.Windows.Forms.TabPage CustomersTabPage;
        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.Button ProductsButton;
        private System.Windows.Forms.Button ToMainProductsButton;
        private System.Windows.Forms.Button ToMainOrdersButton;
        private System.Windows.Forms.Button ToMainCustomersButton;
    }
}