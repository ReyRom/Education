
namespace Task3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HttpRichTextBox = new System.Windows.Forms.RichTextBox();
            this.HrefTextBox = new System.Windows.Forms.TextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.HttpPictureBox = new System.Windows.Forms.PictureBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.PostButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HttpPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HttpRichTextBox
            // 
            this.HttpRichTextBox.Location = new System.Drawing.Point(12, 70);
            this.HttpRichTextBox.Name = "HttpRichTextBox";
            this.HttpRichTextBox.Size = new System.Drawing.Size(397, 389);
            this.HttpRichTextBox.TabIndex = 0;
            this.HttpRichTextBox.Text = "";
            // 
            // HrefTextBox
            // 
            this.HrefTextBox.Location = new System.Drawing.Point(12, 13);
            this.HrefTextBox.Name = "HrefTextBox";
            this.HrefTextBox.PlaceholderText = "Адрес";
            this.HrefTextBox.Size = new System.Drawing.Size(261, 23);
            this.HrefTextBox.TabIndex = 1;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(279, 13);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 2;
            this.LoadButton.Text = "Загрузить";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_ClickAsync);
            // 
            // HttpPictureBox
            // 
            this.HttpPictureBox.Location = new System.Drawing.Point(373, 12);
            this.HttpPictureBox.Name = "HttpPictureBox";
            this.HttpPictureBox.Size = new System.Drawing.Size(36, 34);
            this.HttpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HttpPictureBox.TabIndex = 3;
            this.HttpPictureBox.TabStop = false;
            this.HttpPictureBox.Visible = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(279, 41);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PostButton
            // 
            this.PostButton.Location = new System.Drawing.Point(198, 41);
            this.PostButton.Name = "PostButton";
            this.PostButton.Size = new System.Drawing.Size(75, 23);
            this.PostButton.TabIndex = 5;
            this.PostButton.Text = "Отправить";
            this.PostButton.UseVisualStyleBackColor = true;
            this.PostButton.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 471);
            this.Controls.Add(this.PostButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.HttpPictureBox);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.HrefTextBox);
            this.Controls.Add(this.HttpRichTextBox);
            this.Name = "MainForm";
            this.Text = "Web";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HttpPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox HttpRichTextBox;
        private System.Windows.Forms.TextBox HrefTextBox;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.PictureBox HttpPictureBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button PostButton;
    }
}

