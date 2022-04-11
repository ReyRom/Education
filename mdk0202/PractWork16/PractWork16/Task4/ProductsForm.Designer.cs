
namespace PractWork16.Task4
{
    partial class ProductsForm
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
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PriceRadioButton = new System.Windows.Forms.RadioButton();
            this.PriceDescRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.ProductsDataGridView.Location = new System.Drawing.Point(12, 43);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.ReadOnly = true;
            this.ProductsDataGridView.Size = new System.Drawing.Size(429, 383);
            this.ProductsDataGridView.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PriceDescRadioButton);
            this.panel1.Controls.Add(this.PriceRadioButton);
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 37);
            this.panel1.TabIndex = 3;
            // 
            // PriceRadioButton
            // 
            this.PriceRadioButton.AutoSize = true;
            this.PriceRadioButton.Checked = true;
            this.PriceRadioButton.Location = new System.Drawing.Point(15, 12);
            this.PriceRadioButton.Name = "PriceRadioButton";
            this.PriceRadioButton.Size = new System.Drawing.Size(136, 17);
            this.PriceRadioButton.TabIndex = 0;
            this.PriceRadioButton.TabStop = true;
            this.PriceRadioButton.Text = "по возрастанию цены";
            this.PriceRadioButton.UseVisualStyleBackColor = true;
            this.PriceRadioButton.CheckedChanged += new System.EventHandler(this.PriceRadioButton_CheckedChanged);
            // 
            // PriceDescRadioButton
            // 
            this.PriceDescRadioButton.AutoSize = true;
            this.PriceDescRadioButton.Location = new System.Drawing.Point(178, 12);
            this.PriceDescRadioButton.Name = "PriceDescRadioButton";
            this.PriceDescRadioButton.Size = new System.Drawing.Size(120, 17);
            this.PriceDescRadioButton.TabIndex = 1;
            this.PriceDescRadioButton.TabStop = true;
            this.PriceDescRadioButton.Text = "по убыванию цены";
            this.PriceDescRadioButton.UseVisualStyleBackColor = true;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProductsDataGridView);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton PriceDescRadioButton;
        private System.Windows.Forms.RadioButton PriceRadioButton;
    }
}