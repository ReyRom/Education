
namespace Task1
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
            this.PostsDataGridView = new System.Windows.Forms.DataGridView();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.CountLabel = new System.Windows.Forms.Label();
            this.AvgPostsLabel = new System.Windows.Forms.Label();
            this.UserCountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddresTextBox = new System.Windows.Forms.TextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.WebSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.DocxListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.PostsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PostsDataGridView
            // 
            this.PostsDataGridView.AllowUserToAddRows = false;
            this.PostsDataGridView.AllowUserToDeleteRows = false;
            this.PostsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PostsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PostsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PostsDataGridView.Location = new System.Drawing.Point(13, 51);
            this.PostsDataGridView.Name = "PostsDataGridView";
            this.PostsDataGridView.ReadOnly = true;
            this.PostsDataGridView.RowTemplate.Height = 25;
            this.PostsDataGridView.Size = new System.Drawing.Size(615, 305);
            this.PostsDataGridView.TabIndex = 0;
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(13, 12);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.PlaceholderText = "Идентификатор пользователя";
            this.UserTextBox.Size = new System.Drawing.Size(206, 23);
            this.UserTextBox.TabIndex = 1;
            this.UserTextBox.TextChanged += new System.EventHandler(this.UserTextBox_TextChanged);
            // 
            // CountLabel
            // 
            this.CountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(13, 374);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(13, 15);
            this.CountLabel.TabIndex = 2;
            this.CountLabel.Text = "0";
            // 
            // AvgPostsLabel
            // 
            this.AvgPostsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AvgPostsLabel.AutoSize = true;
            this.AvgPostsLabel.Location = new System.Drawing.Point(393, 374);
            this.AvgPostsLabel.Name = "AvgPostsLabel";
            this.AvgPostsLabel.Size = new System.Drawing.Size(13, 15);
            this.AvgPostsLabel.TabIndex = 3;
            this.AvgPostsLabel.Text = "0";
            // 
            // UserCountLabel
            // 
            this.UserCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UserCountLabel.AutoSize = true;
            this.UserCountLabel.Location = new System.Drawing.Point(206, 374);
            this.UserCountLabel.Name = "UserCountLabel";
            this.UserCountLabel.Size = new System.Drawing.Size(13, 15);
            this.UserCountLabel.TabIndex = 4;
            this.UserCountLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "общее количество записей";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "количество пользователей";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "среднее число постов";
            // 
            // AddresTextBox
            // 
            this.AddresTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddresTextBox.Location = new System.Drawing.Point(322, 13);
            this.AddresTextBox.Name = "AddresTextBox";
            this.AddresTextBox.PlaceholderText = "адрес файла";
            this.AddresTextBox.Size = new System.Drawing.Size(225, 23);
            this.AddresTextBox.TabIndex = 8;
            // 
            // LoadButton
            // 
            this.LoadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadButton.Location = new System.Drawing.Point(553, 13);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 9;
            this.LoadButton.Text = "Загрузить файл";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // DocxListBox
            // 
            this.DocxListBox.FormattingEnabled = true;
            this.DocxListBox.ItemHeight = 15;
            this.DocxListBox.Location = new System.Drawing.Point(634, 51);
            this.DocxListBox.Name = "DocxListBox";
            this.DocxListBox.Size = new System.Drawing.Size(217, 304);
            this.DocxListBox.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 409);
            this.Controls.Add(this.DocxListBox);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.AddresTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserCountLabel);
            this.Controls.Add(this.AvgPostsLabel);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.PostsDataGridView);
            this.Name = "MainForm";
            this.Text = "Posts";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PostsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PostsDataGridView;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label AvgPostsLabel;
        private System.Windows.Forms.Label UserCountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddresTextBox;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.SaveFileDialog WebSaveFileDialog;
        private System.Windows.Forms.ListBox DocxListBox;
    }
}

