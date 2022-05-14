
namespace Task1
{
    partial class Clock
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ClockLabel = new System.Windows.Forms.Label();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ClockLabel
            // 
            this.ClockLabel.AutoSize = true;
            this.ClockLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClockLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClockLabel.Location = new System.Drawing.Point(0, 0);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(80, 25);
            this.ClockLabel.TabIndex = 0;
            this.ClockLabel.Text = "00:00:00";
            // 
            // ClockTimer
            // 
            this.ClockTimer.Interval = 1000;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.ClockLabel);
            this.Name = "Clock";
            this.Size = new System.Drawing.Size(80, 25);
            this.Load += new System.EventHandler(this.Clock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.Timer ClockTimer;
    }
}
