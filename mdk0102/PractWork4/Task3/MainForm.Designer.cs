
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
            this.FolderTextBox = new System.Windows.Forms.TextBox();
            this.FilesDataGridView = new System.Windows.Forms.DataGridView();
            this.FilterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FilesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FolderTextBox
            // 
            this.FolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderTextBox.Location = new System.Drawing.Point(12, 12);
            this.FolderTextBox.Name = "FolderTextBox";
            this.FolderTextBox.Size = new System.Drawing.Size(401, 23);
            this.FolderTextBox.TabIndex = 1;
            this.FolderTextBox.TextChanged += new System.EventHandler(this.FolderTextBox_TextChanged);
            // 
            // FilesDataGridView
            // 
            this.FilesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FilesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilesDataGridView.Location = new System.Drawing.Point(12, 41);
            this.FilesDataGridView.Name = "FilesDataGridView";
            this.FilesDataGridView.RowTemplate.Height = 25;
            this.FilesDataGridView.Size = new System.Drawing.Size(497, 300);
            this.FilesDataGridView.TabIndex = 2;
            // 
            // FilterButton
            // 
            this.FilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterButton.Location = new System.Drawing.Point(419, 12);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(90, 23);
            this.FilterButton.TabIndex = 3;
            this.FilterButton.Text = "Фильтр";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 353);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.FilesDataGridView);
            this.Controls.Add(this.FolderTextBox);
            this.Name = "MainForm";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.FilesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox FolderTextBox;
        private System.Windows.Forms.DataGridView FilesDataGridView;
        private System.Windows.Forms.Button FilterButton;
    }
}

