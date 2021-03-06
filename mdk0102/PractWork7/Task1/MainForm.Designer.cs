
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
            this.FilesDataGrid = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtensionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfCreationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastWriteDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.FolderTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ItemsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FilesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FilesDataGrid
            // 
            this.FilesDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FilesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.ExtensionColumn,
            this.PathColumn,
            this.SizeColumn,
            this.DateOfCreationColumn,
            this.LastWriteDateColumn});
            this.FilesDataGrid.Location = new System.Drawing.Point(12, 70);
            this.FilesDataGrid.Name = "FilesDataGrid";
            this.FilesDataGrid.RowTemplate.Height = 25;
            this.FilesDataGrid.Size = new System.Drawing.Size(776, 368);
            this.FilesDataGrid.TabIndex = 0;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "Имя файла";
            this.NameColumn.Name = "NameColumn";
            // 
            // ExtensionColumn
            // 
            this.ExtensionColumn.DataPropertyName = "Extension";
            this.ExtensionColumn.HeaderText = "Расширение";
            this.ExtensionColumn.Name = "ExtensionColumn";
            // 
            // PathColumn
            // 
            this.PathColumn.DataPropertyName = "DirectoryName";
            this.PathColumn.HeaderText = "Путь";
            this.PathColumn.Name = "PathColumn";
            // 
            // SizeColumn
            // 
            this.SizeColumn.DataPropertyName = "Length";
            this.SizeColumn.HeaderText = "Размер";
            this.SizeColumn.Name = "SizeColumn";
            // 
            // DateOfCreationColumn
            // 
            this.DateOfCreationColumn.DataPropertyName = "CreationTime";
            this.DateOfCreationColumn.HeaderText = "Дата создания";
            this.DateOfCreationColumn.Name = "DateOfCreationColumn";
            // 
            // LastWriteDateColumn
            // 
            this.LastWriteDateColumn.DataPropertyName = "LastWriteTime";
            this.LastWriteDateColumn.HeaderText = "Дата изменения";
            this.LastWriteDateColumn.Name = "LastWriteDateColumn";
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterTextBox.Location = new System.Drawing.Point(410, 41);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.PlaceholderText = "Фильтр";
            this.FilterTextBox.Size = new System.Drawing.Size(256, 23);
            this.FilterTextBox.TabIndex = 1;
            this.FilterTextBox.TextChanged += new System.EventHandler(this.FilterTextBox_TextChanged);
            // 
            // FolderTextBox
            // 
            this.FolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderTextBox.Location = new System.Drawing.Point(12, 12);
            this.FolderTextBox.Name = "FolderTextBox";
            this.FolderTextBox.PlaceholderText = "Каталог";
            this.FolderTextBox.Size = new System.Drawing.Size(776, 23);
            this.FolderTextBox.TabIndex = 2;
            this.FolderTextBox.TextChanged += new System.EventHandler(this.FolderTextBox_TextChanged);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.Location = new System.Drawing.Point(672, 41);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(116, 23);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Сбросить фильтр";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Location = new System.Drawing.Point(12, 45);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(140, 15);
            this.ItemsLabel.TabIndex = 4;
            this.ItemsLabel.Text = "Показано 0 из 0 записей";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ItemsLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.FolderTextBox);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.FilesDataGrid);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.FilesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FilesDataGrid;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.TextBox FolderTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtensionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PathColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfCreationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastWriteDateColumn;
        private System.Windows.Forms.Label ItemsLabel;
    }
}

