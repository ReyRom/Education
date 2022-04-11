
namespace PractWork18
{
    partial class ProductsPriceForm
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
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.MinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Location = new System.Drawing.Point(12, 43);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.Size = new System.Drawing.Size(564, 306);
            this.ProductsDataGridView.TabIndex = 0;
            // 
            // MinNumericUpDown
            // 
            this.MinNumericUpDown.Location = new System.Drawing.Point(13, 13);
            this.MinNumericUpDown.Name = "MinNumericUpDown";
            this.MinNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.MinNumericUpDown.TabIndex = 1;
            this.MinNumericUpDown.ValueChanged += new System.EventHandler(this.MaxMinNumericUpDown_ValueChanged);
            // 
            // MaxNumericUpDown
            // 
            this.MaxNumericUpDown.Location = new System.Drawing.Point(149, 13);
            this.MaxNumericUpDown.Name = "MaxNumericUpDown";
            this.MaxNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.MaxNumericUpDown.TabIndex = 2;
            this.MaxNumericUpDown.ValueChanged += new System.EventHandler(this.MaxMinNumericUpDown_ValueChanged);
            // 
            // ProductsPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 361);
            this.Controls.Add(this.MaxNumericUpDown);
            this.Controls.Add(this.MinNumericUpDown);
            this.Controls.Add(this.ProductsDataGridView);
            this.Name = "ProductsPrice";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ProductsPrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.NumericUpDown MinNumericUpDown;
        private System.Windows.Forms.NumericUpDown MaxNumericUpDown;
    }
}

