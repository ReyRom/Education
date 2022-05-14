
namespace PractWork6
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
            this.UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.LoginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersDataGridView
            // 
            this.UsersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoginColumn,
            this.PasswordColumn});
            this.UsersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.UsersDataGridView.Name = "UsersDataGridView";
            this.UsersDataGridView.ReadOnly = true;
            this.UsersDataGridView.RowTemplate.Height = 25;
            this.UsersDataGridView.Size = new System.Drawing.Size(568, 332);
            this.UsersDataGridView.TabIndex = 0;
            this.UsersDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDataGridView_CellDoubleClick);
            // 
            // LoginColumn
            // 
            this.LoginColumn.DataPropertyName = "Login";
            this.LoginColumn.HeaderText = "Логин";
            this.LoginColumn.Name = "LoginColumn";
            this.LoginColumn.ReadOnly = true;
            // 
            // PasswordColumn
            // 
            this.PasswordColumn.DataPropertyName = "Password";
            this.PasswordColumn.HeaderText = "Пароль";
            this.PasswordColumn.Name = "PasswordColumn";
            this.PasswordColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 356);
            this.Controls.Add(this.UsersDataGridView);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UsersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordColumn;
    }
}

