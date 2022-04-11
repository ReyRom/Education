
namespace PractWork17
{
    partial class ModelForm
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
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.CountLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WithoutRegisterRadioButton = new System.Windows.Forms.RadioButton();
            this.RegisterRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Location = new System.Drawing.Point(12, 47);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.Size = new System.Drawing.Size(776, 375);
            this.ProductsDataGridView.TabIndex = 0;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(14, 19);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(187, 20);
            this.ModelTextBox.TabIndex = 1;
            this.ModelTextBox.TextChanged += new System.EventHandler(this.RenewEvent_Cause);
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(13, 428);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(149, 13);
            this.CountLabel.TabIndex = 2;
            this.CountLabel.Text = "Показано {x} из {y} записей";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.WithoutRegisterRadioButton);
            this.panel1.Controls.Add(this.RegisterRadioButton);
            this.panel1.Location = new System.Drawing.Point(212, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 40);
            this.panel1.TabIndex = 3;
            // 
            // WithoutRegisterRadioButton
            // 
            this.WithoutRegisterRadioButton.AutoSize = true;
            this.WithoutRegisterRadioButton.Checked = true;
            this.WithoutRegisterRadioButton.Location = new System.Drawing.Point(4, 20);
            this.WithoutRegisterRadioButton.Name = "WithoutRegisterRadioButton";
            this.WithoutRegisterRadioButton.Size = new System.Drawing.Size(123, 17);
            this.WithoutRegisterRadioButton.TabIndex = 1;
            this.WithoutRegisterRadioButton.TabStop = true;
            this.WithoutRegisterRadioButton.Text = "Без учета регистра";
            this.WithoutRegisterRadioButton.UseVisualStyleBackColor = true;
            // 
            // RegisterRadioButton
            // 
            this.RegisterRadioButton.AutoSize = true;
            this.RegisterRadioButton.Location = new System.Drawing.Point(4, 1);
            this.RegisterRadioButton.Name = "RegisterRadioButton";
            this.RegisterRadioButton.Size = new System.Drawing.Size(119, 17);
            this.RegisterRadioButton.TabIndex = 0;
            this.RegisterRadioButton.Text = "С учетом регистра";
            this.RegisterRadioButton.UseVisualStyleBackColor = true;
            this.RegisterRadioButton.CheckedChanged += new System.EventHandler(this.RenewEvent_Cause);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Фильтр";
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.ProductsDataGridView);
            this.Name = "ProductsForm";
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.RenewEvent_Cause);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton WithoutRegisterRadioButton;
        private System.Windows.Forms.RadioButton RegisterRadioButton;
        private System.Windows.Forms.Label label1;
    }
}