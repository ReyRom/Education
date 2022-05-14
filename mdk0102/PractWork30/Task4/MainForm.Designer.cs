
namespace Task4
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
            this.OpenAuthButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenAuthButton
            // 
            this.OpenAuthButton.Location = new System.Drawing.Point(175, 113);
            this.OpenAuthButton.Name = "OpenAuthButton";
            this.OpenAuthButton.Size = new System.Drawing.Size(97, 23);
            this.OpenAuthButton.TabIndex = 1;
            this.OpenAuthButton.Text = "Авторизация";
            this.OpenAuthButton.UseVisualStyleBackColor = true;
            this.OpenAuthButton.Click += new System.EventHandler(this.OpenAuthButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 248);
            this.Controls.Add(this.OpenAuthButton);
            this.Name = "MainForm";
            this.Text = "Главная";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenAuthButton;
    }
}

