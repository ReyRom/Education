
namespace PractWork15
{
    partial class ProductsForm
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
            this.PageSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ToPreviousButton = new System.Windows.Forms.Button();
            this.ToNextButton = new System.Windows.Forms.Button();
            this.ToFirstButton = new System.Windows.Forms.Button();
            this.ToLastButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.CountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageSizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.AllowUserToAddRows = false;
            this.ProductsDataGridView.AllowUserToDeleteRows = false;
            this.ProductsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Location = new System.Drawing.Point(12, 50);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.ReadOnly = true;
            this.ProductsDataGridView.Size = new System.Drawing.Size(481, 434);
            this.ProductsDataGridView.TabIndex = 0;
            // 
            // PageSizeNumericUpDown
            // 
            this.PageSizeNumericUpDown.Location = new System.Drawing.Point(12, 21);
            this.PageSizeNumericUpDown.Name = "PageSizeNumericUpDown";
            this.PageSizeNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.PageSizeNumericUpDown.TabIndex = 1;
            this.PageSizeNumericUpDown.ValueChanged += new System.EventHandler(this.PageSizeNumericUpDown_ValueChanged);
            // 
            // PageNumericUpDown
            // 
            this.PageNumericUpDown.Location = new System.Drawing.Point(210, 23);
            this.PageNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PageNumericUpDown.Name = "PageNumericUpDown";
            this.PageNumericUpDown.Size = new System.Drawing.Size(57, 20);
            this.PageNumericUpDown.TabIndex = 2;
            this.PageNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PageNumericUpDown.ValueChanged += new System.EventHandler(this.PageNumericUpDown_ValueChanged);
            this.PageNumericUpDown.Enter += new System.EventHandler(this.PageNumericUpDown_Enter);
            // 
            // ToPreviousButton
            // 
            this.ToPreviousButton.Location = new System.Drawing.Point(173, 21);
            this.ToPreviousButton.Name = "ToPreviousButton";
            this.ToPreviousButton.Size = new System.Drawing.Size(31, 23);
            this.ToPreviousButton.TabIndex = 3;
            this.ToPreviousButton.Text = "<";
            this.ToPreviousButton.UseVisualStyleBackColor = true;
            this.ToPreviousButton.Click += new System.EventHandler(this.ToPreviousButton_Click);
            // 
            // ToNextButton
            // 
            this.ToNextButton.Location = new System.Drawing.Point(273, 21);
            this.ToNextButton.Name = "ToNextButton";
            this.ToNextButton.Size = new System.Drawing.Size(31, 23);
            this.ToNextButton.TabIndex = 4;
            this.ToNextButton.Text = ">";
            this.ToNextButton.UseVisualStyleBackColor = true;
            this.ToNextButton.Click += new System.EventHandler(this.ToNextButton_Click);
            // 
            // ToFirstButton
            // 
            this.ToFirstButton.Location = new System.Drawing.Point(136, 21);
            this.ToFirstButton.Name = "ToFirstButton";
            this.ToFirstButton.Size = new System.Drawing.Size(31, 23);
            this.ToFirstButton.TabIndex = 5;
            this.ToFirstButton.Text = "|<";
            this.ToFirstButton.UseVisualStyleBackColor = true;
            this.ToFirstButton.Click += new System.EventHandler(this.ToFirstButton_Click);
            // 
            // ToLastButton
            // 
            this.ToLastButton.Location = new System.Drawing.Point(310, 21);
            this.ToLastButton.Name = "ToLastButton";
            this.ToLastButton.Size = new System.Drawing.Size(31, 23);
            this.ToLastButton.TabIndex = 6;
            this.ToLastButton.Text = ">|";
            this.ToLastButton.UseVisualStyleBackColor = true;
            this.ToLastButton.Click += new System.EventHandler(this.ToLastButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(359, 21);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(134, 23);
            this.ShowButton.TabIndex = 7;
            this.ShowButton.Text = "Показать еще";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(13, 491);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(149, 13);
            this.CountLabel.TabIndex = 8;
            this.CountLabel.Text = "Показано {x} из {y} записей";
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 511);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.ToLastButton);
            this.Controls.Add(this.ToFirstButton);
            this.Controls.Add(this.ToNextButton);
            this.Controls.Add(this.ToPreviousButton);
            this.Controls.Add(this.PageNumericUpDown);
            this.Controls.Add(this.PageSizeNumericUpDown);
            this.Controls.Add(this.ProductsDataGridView);
            this.Name = "ProductsForm";
            this.Text = "Продукты";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageSizeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.NumericUpDown PageSizeNumericUpDown;
        private System.Windows.Forms.NumericUpDown PageNumericUpDown;
        private System.Windows.Forms.Button ToPreviousButton;
        private System.Windows.Forms.Button ToNextButton;
        private System.Windows.Forms.Button ToFirstButton;
        private System.Windows.Forms.Button ToLastButton;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Label CountLabel;
    }
}

