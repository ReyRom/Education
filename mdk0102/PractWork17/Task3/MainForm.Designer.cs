
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
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.CountLabel = new System.Windows.Forms.Label();
            this.XmlOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.LastButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.FirstButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.BookTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(12, 71);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.PlaceholderText = "Страна";
            this.CountryTextBox.Size = new System.Drawing.Size(317, 23);
            this.CountryTextBox.TabIndex = 8;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(12, 42);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.PlaceholderText = "Фамилия";
            this.SurnameTextBox.Size = new System.Drawing.Size(317, 23);
            this.SurnameTextBox.TabIndex = 7;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 12);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PlaceholderText = "Имя";
            this.NameTextBox.Size = new System.Drawing.Size(317, 23);
            this.NameTextBox.TabIndex = 6;
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(254, 100);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 5;
            this.OpenButton.Text = "Открыть";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(12, 104);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(13, 15);
            this.CountLabel.TabIndex = 9;
            this.CountLabel.Text = "0";
            // 
            // XmlOpenFileDialog
            // 
            this.XmlOpenFileDialog.FileName = "openFileDialog1";
            // 
            // LastButton
            // 
            this.LastButton.Enabled = false;
            this.LastButton.Location = new System.Drawing.Point(199, 100);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(33, 23);
            this.LastButton.TabIndex = 10;
            this.LastButton.Text = ">>";
            this.LastButton.UseVisualStyleBackColor = true;
            this.LastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Location = new System.Drawing.Point(160, 100);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(33, 23);
            this.NextButton.TabIndex = 11;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Enabled = false;
            this.PreviousButton.Location = new System.Drawing.Point(121, 100);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(33, 23);
            this.PreviousButton.TabIndex = 12;
            this.PreviousButton.Text = "<";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // FirstButton
            // 
            this.FirstButton.Enabled = false;
            this.FirstButton.Location = new System.Drawing.Point(82, 100);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(33, 23);
            this.FirstButton.TabIndex = 13;
            this.FirstButton.Text = "<<";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Enabled = false;
            this.AddButton.Location = new System.Drawing.Point(255, 129);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // BookTextBox
            // 
            this.BookTextBox.Location = new System.Drawing.Point(12, 129);
            this.BookTextBox.Name = "BookTextBox";
            this.BookTextBox.PlaceholderText = "Книга";
            this.BookTextBox.Size = new System.Drawing.Size(237, 23);
            this.BookTextBox.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 161);
            this.Controls.Add(this.BookTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.FirstButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.LastButton);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.OpenButton);
            this.Name = "MainForm";
            this.Text = "Чтение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.OpenFileDialog XmlOpenFileDialog;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox BookTextBox;
    }
}

