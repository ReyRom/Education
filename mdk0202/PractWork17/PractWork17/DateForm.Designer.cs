
namespace PractWork17
{
    partial class DateForm
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
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.OrdersDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FilterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.Location = new System.Drawing.Point(12, 42);
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.Size = new System.Drawing.Size(776, 396);
            this.OrdersDataGridView.TabIndex = 2;
            // 
            // OrdersDateTimePicker
            // 
            this.OrdersDateTimePicker.CustomFormat = "MMMM yyyy";
            this.OrdersDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.OrdersDateTimePicker.Location = new System.Drawing.Point(12, 15);
            this.OrdersDateTimePicker.Name = "OrdersDateTimePicker";
            this.OrdersDateTimePicker.ShowCheckBox = true;
            this.OrdersDateTimePicker.Size = new System.Drawing.Size(180, 20);
            this.OrdersDateTimePicker.TabIndex = 3;
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(198, 15);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(87, 23);
            this.FilterButton.TabIndex = 5;
            this.FilterButton.Text = "Фильтровать";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.RenewEvent_Cause);
            // 
            // DateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.OrdersDateTimePicker);
            this.Controls.Add(this.OrdersDataGridView);
            this.Name = "DateForm";
            this.Text = "Заказы по дате";
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.DateTimePicker OrdersDateTimePicker;
        private System.Windows.Forms.Button FilterButton;
    }
}