
namespace Task1
{
    partial class ShowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShowButton = new System.Windows.Forms.Button();
            this.TableTextBox = new System.Windows.Forms.TextBox();
            this.TableDataGridView = new System.Windows.Forms.DataGridView();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowButton
            // 
            this.ShowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowButton.Location = new System.Drawing.Point(356, 15);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(66, 23);
            this.ShowButton.TabIndex = 0;
            this.ShowButton.Text = "Показать";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // TableTextBox
            // 
            this.TableTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableTextBox.Location = new System.Drawing.Point(12, 14);
            this.TableTextBox.Name = "TableTextBox";
            this.TableTextBox.Size = new System.Drawing.Size(338, 23);
            this.TableTextBox.TabIndex = 1;
            // 
            // TableDataGridView
            // 
            this.TableDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableDataGridView.Location = new System.Drawing.Point(13, 44);
            this.TableDataGridView.Name = "TableDataGridView";
            this.TableDataGridView.RowTemplate.Height = 25;
            this.TableDataGridView.Size = new System.Drawing.Size(492, 296);
            this.TableDataGridView.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(428, 15);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(77, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 352);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TableDataGridView);
            this.Controls.Add(this.TableTextBox);
            this.Controls.Add(this.ShowButton);
            this.MinimumSize = new System.Drawing.Size(458, 391);
            this.Name = "ShowForm";
            this.Text = "ShowForm";
            ((System.ComponentModel.ISupportInitialize)(this.TableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.TextBox TableTextBox;
        private System.Windows.Forms.DataGridView TableDataGridView;
        private System.Windows.Forms.Button SaveButton;
    }
}