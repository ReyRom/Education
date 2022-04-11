
namespace PractWork22
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ProductsProducersChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.YearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.OrdersCostChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SaveCsvButton = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.SaveBillButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OrdersComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.SaveExcelButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsProducersChart)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YearNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersCostChart)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(547, 378);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SaveButton);
            this.tabPage1.Controls.Add(this.ProductsProducersChart);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(539, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Task1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(9, 7);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ProductsProducersChart
            // 
            this.ProductsProducersChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.ProductsProducersChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ProductsProducersChart.Legends.Add(legend1);
            this.ProductsProducersChart.Location = new System.Drawing.Point(6, 46);
            this.ProductsProducersChart.Name = "ProductsProducersChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ProductsProducersChart.Series.Add(series1);
            this.ProductsProducersChart.Size = new System.Drawing.Size(525, 300);
            this.ProductsProducersChart.TabIndex = 0;
            this.ProductsProducersChart.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.YearNumericUpDown);
            this.tabPage2.Controls.Add(this.TypeComboBox);
            this.tabPage2.Controls.Add(this.OrdersCostChart);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(539, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Task2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // YearNumericUpDown
            // 
            this.YearNumericUpDown.Location = new System.Drawing.Point(9, 6);
            this.YearNumericUpDown.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.YearNumericUpDown.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.YearNumericUpDown.Name = "YearNumericUpDown";
            this.YearNumericUpDown.Size = new System.Drawing.Size(76, 20);
            this.YearNumericUpDown.TabIndex = 2;
            this.YearNumericUpDown.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.YearNumericUpDown.ValueChanged += new System.EventHandler(this.YearNumericUpDown_ValueChanged);
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "вертикальные столбцы",
            "горизонтальные столбцы",
            "точки"});
            this.TypeComboBox.Location = new System.Drawing.Point(378, 6);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(153, 21);
            this.TypeComboBox.TabIndex = 1;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // OrdersCostChart
            // 
            chartArea2.Name = "ChartArea1";
            this.OrdersCostChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.OrdersCostChart.Legends.Add(legend2);
            this.OrdersCostChart.Location = new System.Drawing.Point(8, 44);
            this.OrdersCostChart.Name = "OrdersCostChart";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.OrdersCostChart.Series.Add(series2);
            this.OrdersCostChart.Size = new System.Drawing.Size(523, 300);
            this.OrdersCostChart.TabIndex = 0;
            this.OrdersCostChart.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.SaveCsvButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(539, 352);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Task3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // SaveCsvButton
            // 
            this.SaveCsvButton.Location = new System.Drawing.Point(161, 152);
            this.SaveCsvButton.Name = "SaveCsvButton";
            this.SaveCsvButton.Size = new System.Drawing.Size(209, 23);
            this.SaveCsvButton.TabIndex = 0;
            this.SaveCsvButton.Text = "Сохранить данные о товарах";
            this.SaveCsvButton.UseVisualStyleBackColor = true;
            this.SaveCsvButton.Click += new System.EventHandler(this.SaveCsvButton_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.SaveBillButton);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.OrdersComboBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(539, 352);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Task4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // SaveBillButton
            // 
            this.SaveBillButton.Location = new System.Drawing.Point(136, 15);
            this.SaveBillButton.Name = "SaveBillButton";
            this.SaveBillButton.Size = new System.Drawing.Size(114, 23);
            this.SaveBillButton.TabIndex = 2;
            this.SaveBillButton.Text = "Сохранить чек";
            this.SaveBillButton.UseVisualStyleBackColor = true;
            this.SaveBillButton.Click += new System.EventHandler(this.SaveBillButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Заказ №";
            // 
            // OrdersComboBox
            // 
            this.OrdersComboBox.FormattingEnabled = true;
            this.OrdersComboBox.Location = new System.Drawing.Point(67, 17);
            this.OrdersComboBox.Name = "OrdersComboBox";
            this.OrdersComboBox.Size = new System.Drawing.Size(47, 21);
            this.OrdersComboBox.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.SaveExcelButton);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(539, 352);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Task5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // SaveExcelButton
            // 
            this.SaveExcelButton.Location = new System.Drawing.Point(165, 165);
            this.SaveExcelButton.Name = "SaveExcelButton";
            this.SaveExcelButton.Size = new System.Drawing.Size(209, 23);
            this.SaveExcelButton.TabIndex = 1;
            this.SaveExcelButton.Text = "Сохранить данные о товарах";
            this.SaveExcelButton.UseVisualStyleBackColor = true;
            this.SaveExcelButton.Click += new System.EventHandler(this.SaveExcelButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 378);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsProducersChart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.YearNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersCostChart)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ProductsProducersChart;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart OrdersCostChart;
        private System.Windows.Forms.NumericUpDown YearNumericUpDown;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button SaveCsvButton;
        private System.Windows.Forms.Button SaveBillButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox OrdersComboBox;
        private System.Windows.Forms.Button SaveExcelButton;
    }
}

