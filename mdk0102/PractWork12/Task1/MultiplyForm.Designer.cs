
namespace Task1
{
    partial class MultiplyForm
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
            this.MultiplyTableButton = new System.Windows.Forms.Button();
            this.TableSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // MultiplyTableButton
            // 
            this.MultiplyTableButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultiplyTableButton.Location = new System.Drawing.Point(0, 0);
            this.MultiplyTableButton.Name = "MultiplyTableButton";
            this.MultiplyTableButton.Size = new System.Drawing.Size(265, 52);
            this.MultiplyTableButton.TabIndex = 0;
            this.MultiplyTableButton.Text = "Таблица умножения";
            this.MultiplyTableButton.UseVisualStyleBackColor = true;
            this.MultiplyTableButton.Click += new System.EventHandler(this.MultiplyTableButton_Click);
            // 
            // MultiplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 52);
            this.Controls.Add(this.MultiplyTableButton);
            this.Name = "MultiplyForm";
            this.Text = "Таблица умножения";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MultiplyTableButton;
        private System.Windows.Forms.SaveFileDialog TableSaveFileDialog;
    }
}

