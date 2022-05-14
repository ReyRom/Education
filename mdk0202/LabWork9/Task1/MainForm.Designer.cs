
namespace Task1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ToShowButton = new System.Windows.Forms.Button();
            this.ProductsButton = new System.Windows.Forms.Button();
            this.ProducersButton = new System.Windows.Forms.Button();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToShowButton
            // 
            this.ToShowButton.Location = new System.Drawing.Point(13, 13);
            this.ToShowButton.Name = "ToShowButton";
            this.ToShowButton.Size = new System.Drawing.Size(75, 23);
            this.ToShowButton.TabIndex = 0;
            this.ToShowButton.Text = "Показать";
            this.ToShowButton.UseVisualStyleBackColor = true;
            this.ToShowButton.Click += new System.EventHandler(this.ToShowButton_Click);
            // 
            // ProductsButton
            // 
            this.ProductsButton.Location = new System.Drawing.Point(114, 12);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(105, 23);
            this.ProductsButton.TabIndex = 1;
            this.ProductsButton.Text = "Продукты";
            this.ProductsButton.UseVisualStyleBackColor = true;
            this.ProductsButton.Click += new System.EventHandler(this.ProductsButton_Click);
            // 
            // ProducersButton
            // 
            this.ProducersButton.Location = new System.Drawing.Point(114, 42);
            this.ProducersButton.Name = "ProducersButton";
            this.ProducersButton.Size = new System.Drawing.Size(105, 23);
            this.ProducersButton.TabIndex = 2;
            this.ProducersButton.Text = "Производители";
            this.ProducersButton.UseVisualStyleBackColor = true;
            this.ProducersButton.Click += new System.EventHandler(this.ProducersButton_Click);
            // 
            // CustomersButton
            // 
            this.CustomersButton.Location = new System.Drawing.Point(114, 72);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(105, 23);
            this.CustomersButton.TabIndex = 3;
            this.CustomersButton.Text = "Покупатели";
            this.CustomersButton.UseVisualStyleBackColor = true;
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 148);
            this.Controls.Add(this.CustomersButton);
            this.Controls.Add(this.ProducersButton);
            this.Controls.Add(this.ProductsButton);
            this.Controls.Add(this.ToShowButton);
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ToShowButton;
        private System.Windows.Forms.Button ProductsButton;
        private System.Windows.Forms.Button ProducersButton;
        private System.Windows.Forms.Button CustomersButton;
    }
}

