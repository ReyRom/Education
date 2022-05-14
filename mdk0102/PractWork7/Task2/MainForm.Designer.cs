
namespace Task2
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
            this.ResetButton = new System.Windows.Forms.Button();
            this.FolderTextBox = new System.Windows.Forms.TextBox();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.FilesDataGrid = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtensionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfCreationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastWriteDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MajorRadioButton = new System.Windows.Forms.RadioButton();
            this.LessRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.FilesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.Location = new System.Drawing.Point(672, 41);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(116, 23);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Сбросить фильтр";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // FolderTextBox
            // 
            this.FolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderTextBox.Location = new System.Drawing.Point(12, 12);
            this.FolderTextBox.Name = "FolderTextBox";
            this.FolderTextBox.PlaceholderText = "Каталог";
            this.FolderTextBox.Size = new System.Drawing.Size(776, 23);
            this.FolderTextBox.TabIndex = 6;
            this.FolderTextBox.TextChanged += new System.EventHandler(this.FolderTextBox_TextChanged);
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterTextBox.Location = new System.Drawing.Point(450, 41);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.PlaceholderText = "Фильтр";
            this.FilterTextBox.Size = new System.Drawing.Size(221, 23);
            this.FilterTextBox.TabIndex = 5;
            this.FilterTextBox.TextChanged += new System.EventHandler(this.RenewEvent_Cause);
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
            this.FilesDataGrid.Size = new System.Drawing.Size(776, 351);
            this.FilesDataGrid.TabIndex = 4;
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
            // SizeNumericUpDown
            // 
            this.SizeNumericUpDown.Location = new System.Drawing.Point(65, 41);
            this.SizeNumericUpDown.Maximum = new decimal(new int[] {
            -1593835520,
            466537709,
            54210,
            0});
            this.SizeNumericUpDown.Name = "SizeNumericUpDown";
            this.SizeNumericUpDown.Size = new System.Drawing.Size(95, 23);
            this.SizeNumericUpDown.TabIndex = 8;
            this.SizeNumericUpDown.ValueChanged += new System.EventHandler(this.RenewEvent_Cause);
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Location = new System.Drawing.Point(12, 426);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(140, 15);
            this.ItemsLabel.TabIndex = 9;
            this.ItemsLabel.Text = "Показано 0 из 0 записей";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Размер";
            // 
            // MajorRadioButton
            // 
            this.MajorRadioButton.AutoSize = true;
            this.MajorRadioButton.Checked = true;
            this.MajorRadioButton.Location = new System.Drawing.Point(4, 3);
            this.MajorRadioButton.Name = "MajorRadioButton";
            this.MajorRadioButton.Size = new System.Drawing.Size(129, 19);
            this.MajorRadioButton.TabIndex = 11;
            this.MajorRadioButton.TabStop = true;
            this.MajorRadioButton.Text = "Больше или равно";
            this.MajorRadioButton.UseVisualStyleBackColor = true;
            this.MajorRadioButton.CheckedChanged += new System.EventHandler(this.RenewEvent_Cause);
            // 
            // LessRadioButton
            // 
            this.LessRadioButton.AutoSize = true;
            this.LessRadioButton.Location = new System.Drawing.Point(145, 3);
            this.LessRadioButton.Name = "LessRadioButton";
            this.LessRadioButton.Size = new System.Drawing.Size(132, 19);
            this.LessRadioButton.TabIndex = 12;
            this.LessRadioButton.TabStop = true;
            this.LessRadioButton.Text = "Меньше или равно";
            this.LessRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MajorRadioButton);
            this.panel1.Controls.Add(this.LessRadioButton);
            this.panel1.Location = new System.Drawing.Point(166, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 26);
            this.panel1.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemsLabel);
            this.Controls.Add(this.SizeNumericUpDown);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.FolderTextBox);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.FilesDataGrid);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.FilesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox FolderTextBox;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.DataGridView FilesDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtensionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PathColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfCreationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastWriteDateColumn;
        private System.Windows.Forms.NumericUpDown SizeNumericUpDown;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton MajorRadioButton;
        private System.Windows.Forms.RadioButton LessRadioButton;
        private System.Windows.Forms.Panel panel1;
    }
}

