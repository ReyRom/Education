
namespace Task1
{
    partial class Form1
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
            this.CustomersButton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomersButton
            // 
            this.CustomersButton.Location = new System.Drawing.Point(13, 13);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(166, 23);
            this.CustomersButton.TabIndex = 0;
            this.CustomersButton.Text = "Покупатели";
            this.CustomersButton.UseVisualStyleBackColor = true;
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(13, 43);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(166, 23);
            this.AddProductButton.TabIndex = 1;
            this.AddProductButton.Text = "Добавление товара";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 70);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.CustomersButton);
            this.Name = "Form1";
            this.Text = "Navigation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Button AddProductButton;
    }
}

