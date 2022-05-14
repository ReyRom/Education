
namespace PractWork30
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
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.TextLabel = new System.Windows.Forms.Label();
            this.FileTextBox = new System.Windows.Forms.TextBox();
            this.HtmlWebBrowser = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenAuthButton
            // 
            this.OpenAuthButton.Location = new System.Drawing.Point(12, 12);
            this.OpenAuthButton.Name = "OpenAuthButton";
            this.OpenAuthButton.Size = new System.Drawing.Size(97, 23);
            this.OpenAuthButton.TabIndex = 0;
            this.OpenAuthButton.Text = "Авторизация";
            this.OpenAuthButton.UseVisualStyleBackColor = true;
            this.OpenAuthButton.Click += new System.EventHandler(this.OpenAuthButton_Click);
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.Location = new System.Drawing.Point(12, 51);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(163, 166);
            this.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagePictureBox.TabIndex = 1;
            this.ImagePictureBox.TabStop = false;
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(182, 51);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(35, 13);
            this.TextLabel.TabIndex = 2;
            this.TextLabel.Text = "label1";
            // 
            // FileTextBox
            // 
            this.FileTextBox.AcceptsReturn = true;
            this.FileTextBox.AcceptsTab = true;
            this.FileTextBox.Location = new System.Drawing.Point(12, 223);
            this.FileTextBox.Multiline = true;
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.Size = new System.Drawing.Size(410, 241);
            this.FileTextBox.TabIndex = 3;
            // 
            // HtmlWebBrowser
            // 
            this.HtmlWebBrowser.Location = new System.Drawing.Point(428, 51);
            this.HtmlWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.HtmlWebBrowser.Name = "HtmlWebBrowser";
            this.HtmlWebBrowser.Size = new System.Drawing.Size(254, 413);
            this.HtmlWebBrowser.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 476);
            this.Controls.Add(this.HtmlWebBrowser);
            this.Controls.Add(this.FileTextBox);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.ImagePictureBox);
            this.Controls.Add(this.OpenAuthButton);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenAuthButton;
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.TextBox FileTextBox;
        private System.Windows.Forms.WebBrowser HtmlWebBrowser;
    }
}

