
namespace LabWork12
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
            this.UsersButton = new System.Windows.Forms.Button();
            this.UsersDetailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsersButton
            // 
            this.UsersButton.Location = new System.Drawing.Point(73, 29);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(164, 23);
            this.UsersButton.TabIndex = 0;
            this.UsersButton.Text = "Пользователи Таблица";
            this.UsersButton.UseVisualStyleBackColor = true;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // UsersDetailsButton
            // 
            this.UsersDetailsButton.Location = new System.Drawing.Point(70, 74);
            this.UsersDetailsButton.Name = "UsersDetailsButton";
            this.UsersDetailsButton.Size = new System.Drawing.Size(164, 23);
            this.UsersDetailsButton.TabIndex = 1;
            this.UsersDetailsButton.Text = "Пользователи Сведения";
            this.UsersDetailsButton.UseVisualStyleBackColor = true;
            this.UsersDetailsButton.Click += new System.EventHandler(this.UsersDetailsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 171);
            this.Controls.Add(this.UsersDetailsButton);
            this.Controls.Add(this.UsersButton);
            this.Name = "MainForm";
            this.Text = "Главная";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button UsersDetailsButton;
    }
}

