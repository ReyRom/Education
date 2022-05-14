
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
            this.QueryTextBox = new System.Windows.Forms.TextBox();
            this.QueryButton = new System.Windows.Forms.Button();
            this.QueryScalarButton = new System.Windows.Forms.Button();
            this.QueryDataSetButton = new System.Windows.Forms.Button();
            this.QueryDataGridView = new System.Windows.Forms.DataGridView();
            this.TablesListBox = new System.Windows.Forms.ListBox();
            this.ColumnsListBox = new System.Windows.Forms.ListBox();
            this.GetColumnsButton = new System.Windows.Forms.Button();
            this.TableTextBox = new System.Windows.Forms.TextBox();
            this.GetSchemaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QueryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // QueryTextBox
            // 
            this.QueryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QueryTextBox.Location = new System.Drawing.Point(13, 13);
            this.QueryTextBox.Multiline = true;
            this.QueryTextBox.Name = "QueryTextBox";
            this.QueryTextBox.Size = new System.Drawing.Size(409, 81);
            this.QueryTextBox.TabIndex = 0;
            // 
            // QueryButton
            // 
            this.QueryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QueryButton.Location = new System.Drawing.Point(428, 13);
            this.QueryButton.Name = "QueryButton";
            this.QueryButton.Size = new System.Drawing.Size(139, 23);
            this.QueryButton.TabIndex = 1;
            this.QueryButton.Text = "Выполнить";
            this.QueryButton.UseVisualStyleBackColor = true;
            this.QueryButton.Click += new System.EventHandler(this.QueryButton_Click);
            // 
            // QueryScalarButton
            // 
            this.QueryScalarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QueryScalarButton.Location = new System.Drawing.Point(428, 42);
            this.QueryScalarButton.Name = "QueryScalarButton";
            this.QueryScalarButton.Size = new System.Drawing.Size(139, 23);
            this.QueryScalarButton.TabIndex = 2;
            this.QueryScalarButton.Text = "Выполнить скаляр";
            this.QueryScalarButton.UseVisualStyleBackColor = true;
            this.QueryScalarButton.Click += new System.EventHandler(this.QueryScalarButton_Click);
            // 
            // QueryDataSetButton
            // 
            this.QueryDataSetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QueryDataSetButton.Location = new System.Drawing.Point(428, 71);
            this.QueryDataSetButton.Name = "QueryDataSetButton";
            this.QueryDataSetButton.Size = new System.Drawing.Size(139, 23);
            this.QueryDataSetButton.TabIndex = 3;
            this.QueryDataSetButton.Text = "Выполнить набор";
            this.QueryDataSetButton.UseVisualStyleBackColor = true;
            this.QueryDataSetButton.Click += new System.EventHandler(this.QueryDataSetButton_Click);
            // 
            // QueryDataGridView
            // 
            this.QueryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QueryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QueryDataGridView.Location = new System.Drawing.Point(12, 100);
            this.QueryDataGridView.Name = "QueryDataGridView";
            this.QueryDataGridView.RowTemplate.Height = 25;
            this.QueryDataGridView.Size = new System.Drawing.Size(410, 358);
            this.QueryDataGridView.TabIndex = 4;
            // 
            // TablesListBox
            // 
            this.TablesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TablesListBox.FormattingEnabled = true;
            this.TablesListBox.ItemHeight = 15;
            this.TablesListBox.Location = new System.Drawing.Point(428, 346);
            this.TablesListBox.Name = "TablesListBox";
            this.TablesListBox.Size = new System.Drawing.Size(139, 109);
            this.TablesListBox.TabIndex = 5;
            // 
            // ColumnsListBox
            // 
            this.ColumnsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ColumnsListBox.FormattingEnabled = true;
            this.ColumnsListBox.ItemHeight = 15;
            this.ColumnsListBox.Location = new System.Drawing.Point(428, 231);
            this.ColumnsListBox.Name = "ColumnsListBox";
            this.ColumnsListBox.Size = new System.Drawing.Size(139, 109);
            this.ColumnsListBox.TabIndex = 6;
            // 
            // GetColumnsButton
            // 
            this.GetColumnsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GetColumnsButton.Location = new System.Drawing.Point(429, 202);
            this.GetColumnsButton.Name = "GetColumnsButton";
            this.GetColumnsButton.Size = new System.Drawing.Size(138, 23);
            this.GetColumnsButton.TabIndex = 7;
            this.GetColumnsButton.Text = "Получить столбцы";
            this.GetColumnsButton.UseVisualStyleBackColor = true;
            this.GetColumnsButton.Click += new System.EventHandler(this.GetColumnsButton_Click);
            // 
            // TableTextBox
            // 
            this.TableTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableTextBox.Location = new System.Drawing.Point(429, 148);
            this.TableTextBox.Name = "TableTextBox";
            this.TableTextBox.Size = new System.Drawing.Size(138, 23);
            this.TableTextBox.TabIndex = 8;
            // 
            // GetSchemaButton
            // 
            this.GetSchemaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GetSchemaButton.Location = new System.Drawing.Point(429, 177);
            this.GetSchemaButton.Name = "GetSchemaButton";
            this.GetSchemaButton.Size = new System.Drawing.Size(138, 23);
            this.GetSchemaButton.TabIndex = 9;
            this.GetSchemaButton.Text = "Получить схему";
            this.GetSchemaButton.UseVisualStyleBackColor = true;
            this.GetSchemaButton.Click += new System.EventHandler(this.GetSchemaButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 470);
            this.Controls.Add(this.GetSchemaButton);
            this.Controls.Add(this.TableTextBox);
            this.Controls.Add(this.GetColumnsButton);
            this.Controls.Add(this.ColumnsListBox);
            this.Controls.Add(this.TablesListBox);
            this.Controls.Add(this.QueryDataGridView);
            this.Controls.Add(this.QueryDataSetButton);
            this.Controls.Add(this.QueryScalarButton);
            this.Controls.Add(this.QueryButton);
            this.Controls.Add(this.QueryTextBox);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QueryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QueryTextBox;
        private System.Windows.Forms.Button QueryButton;
        private System.Windows.Forms.Button QueryScalarButton;
        private System.Windows.Forms.Button QueryDataSetButton;
        private System.Windows.Forms.DataGridView QueryDataGridView;
        private System.Windows.Forms.ListBox TablesListBox;
        private System.Windows.Forms.ListBox ColumnsListBox;
        private System.Windows.Forms.Button GetColumnsButton;
        private System.Windows.Forms.TextBox TableTextBox;
        private System.Windows.Forms.Button GetSchemaButton;
    }
}

