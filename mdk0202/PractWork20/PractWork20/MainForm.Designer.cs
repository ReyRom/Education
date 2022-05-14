
namespace PractWork20
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
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.MaxPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.IncreaesPriceButton = new System.Windows.Forms.Button();
            this.PercentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.IdProductTextBox = new System.Windows.Forms.TextBox();
            this.GetProductButton = new System.Windows.Forms.Button();
            this.GetOrderContentButton = new System.Windows.Forms.Button();
            this.IdOrderTextBox = new System.Windows.Forms.TextBox();
            this.OrderContentDataGridView = new System.Windows.Forms.DataGridView();
            this.IncreasePriceProcButton = new System.Windows.Forms.Button();
            this.MarkUpNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PercentNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderContentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkUpNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Location = new System.Drawing.Point(12, 65);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.Size = new System.Drawing.Size(570, 263);
            this.ProductsDataGridView.TabIndex = 0;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(13, 12);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.TypeComboBox.TabIndex = 1;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.RenewEvent_Cause);
            // 
            // MaxPriceNumericUpDown
            // 
            this.MaxPriceNumericUpDown.Location = new System.Drawing.Point(13, 39);
            this.MaxPriceNumericUpDown.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.MaxPriceNumericUpDown.Name = "MaxPriceNumericUpDown";
            this.MaxPriceNumericUpDown.Size = new System.Drawing.Size(99, 20);
            this.MaxPriceNumericUpDown.TabIndex = 2;
            this.MaxPriceNumericUpDown.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.MaxPriceNumericUpDown.ValueChanged += new System.EventHandler(this.RenewEvent_Cause);
            // 
            // IncreaesPriceButton
            // 
            this.IncreaesPriceButton.Location = new System.Drawing.Point(470, 12);
            this.IncreaesPriceButton.Name = "IncreaesPriceButton";
            this.IncreaesPriceButton.Size = new System.Drawing.Size(111, 23);
            this.IncreaesPriceButton.TabIndex = 3;
            this.IncreaesPriceButton.Text = "Увеличить цену";
            this.IncreaesPriceButton.UseVisualStyleBackColor = true;
            this.IncreaesPriceButton.Click += new System.EventHandler(this.IncreaesPriceButton_Click);
            // 
            // PercentNumericUpDown
            // 
            this.PercentNumericUpDown.Location = new System.Drawing.Point(414, 12);
            this.PercentNumericUpDown.Name = "PercentNumericUpDown";
            this.PercentNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.PercentNumericUpDown.TabIndex = 4;
            // 
            // IdProductTextBox
            // 
            this.IdProductTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IdProductTextBox.Location = new System.Drawing.Point(12, 334);
            this.IdProductTextBox.Name = "IdProductTextBox";
            this.IdProductTextBox.Size = new System.Drawing.Size(62, 20);
            this.IdProductTextBox.TabIndex = 5;
            // 
            // GetProductButton
            // 
            this.GetProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GetProductButton.Location = new System.Drawing.Point(80, 334);
            this.GetProductButton.Name = "GetProductButton";
            this.GetProductButton.Size = new System.Drawing.Size(120, 23);
            this.GetProductButton.TabIndex = 6;
            this.GetProductButton.Text = "Получить продукт";
            this.GetProductButton.UseVisualStyleBackColor = true;
            this.GetProductButton.Click += new System.EventHandler(this.GetProductButton_Click);
            // 
            // GetOrderContentButton
            // 
            this.GetOrderContentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GetOrderContentButton.Location = new System.Drawing.Point(285, 334);
            this.GetOrderContentButton.Name = "GetOrderContentButton";
            this.GetOrderContentButton.Size = new System.Drawing.Size(120, 23);
            this.GetOrderContentButton.TabIndex = 8;
            this.GetOrderContentButton.Text = "Получить заказ";
            this.GetOrderContentButton.UseVisualStyleBackColor = true;
            this.GetOrderContentButton.Click += new System.EventHandler(this.GetOrderContentButton_Click);
            // 
            // IdOrderTextBox
            // 
            this.IdOrderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IdOrderTextBox.Location = new System.Drawing.Point(217, 334);
            this.IdOrderTextBox.Name = "IdOrderTextBox";
            this.IdOrderTextBox.Size = new System.Drawing.Size(62, 20);
            this.IdOrderTextBox.TabIndex = 7;
            // 
            // OrderContentDataGridView
            // 
            this.OrderContentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderContentDataGridView.Location = new System.Drawing.Point(13, 361);
            this.OrderContentDataGridView.Name = "OrderContentDataGridView";
            this.OrderContentDataGridView.Size = new System.Drawing.Size(568, 223);
            this.OrderContentDataGridView.TabIndex = 9;
            // 
            // IncreasePriceProcButton
            // 
            this.IncreasePriceProcButton.Location = new System.Drawing.Point(414, 39);
            this.IncreasePriceProcButton.Name = "IncreasePriceProcButton";
            this.IncreasePriceProcButton.Size = new System.Drawing.Size(168, 23);
            this.IncreasePriceProcButton.TabIndex = 10;
            this.IncreasePriceProcButton.Text = "Увеличить цену (значение)";
            this.IncreasePriceProcButton.UseVisualStyleBackColor = true;
            this.IncreasePriceProcButton.Click += new System.EventHandler(this.IncreasePriceProcButton_Click);
            // 
            // MarkUpNumericUpDown
            // 
            this.MarkUpNumericUpDown.Location = new System.Drawing.Point(328, 39);
            this.MarkUpNumericUpDown.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.MarkUpNumericUpDown.Name = "MarkUpNumericUpDown";
            this.MarkUpNumericUpDown.Size = new System.Drawing.Size(80, 20);
            this.MarkUpNumericUpDown.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 596);
            this.Controls.Add(this.MarkUpNumericUpDown);
            this.Controls.Add(this.IncreasePriceProcButton);
            this.Controls.Add(this.OrderContentDataGridView);
            this.Controls.Add(this.GetOrderContentButton);
            this.Controls.Add(this.IdOrderTextBox);
            this.Controls.Add(this.GetProductButton);
            this.Controls.Add(this.IdProductTextBox);
            this.Controls.Add(this.PercentNumericUpDown);
            this.Controls.Add(this.IncreaesPriceButton);
            this.Controls.Add(this.MaxPriceNumericUpDown);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.ProductsDataGridView);
            this.Name = "MainForm";
            this.Text = "Продукты и заказы";
            this.Load += new System.EventHandler(this.RenewEvent_Cause);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PercentNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderContentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkUpNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.NumericUpDown MaxPriceNumericUpDown;
        private System.Windows.Forms.Button IncreaesPriceButton;
        private System.Windows.Forms.NumericUpDown PercentNumericUpDown;
        private System.Windows.Forms.TextBox IdProductTextBox;
        private System.Windows.Forms.Button GetProductButton;
        private System.Windows.Forms.Button GetOrderContentButton;
        private System.Windows.Forms.TextBox IdOrderTextBox;
        private System.Windows.Forms.DataGridView OrderContentDataGridView;
        private System.Windows.Forms.Button IncreasePriceProcButton;
        private System.Windows.Forms.NumericUpDown MarkUpNumericUpDown;
    }
}

