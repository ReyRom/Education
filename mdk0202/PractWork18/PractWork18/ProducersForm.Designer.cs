
namespace PractWork18
{
    partial class ProducersForm
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
            this.ProducersDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProducersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProducersDataGridView
            // 
            this.ProducersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProducersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProducersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProducersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ProducersDataGridView.Name = "ProducersDataGridView";
            this.ProducersDataGridView.Size = new System.Drawing.Size(800, 450);
            this.ProducersDataGridView.TabIndex = 0;
            // 
            // ProducersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProducersDataGridView);
            this.Name = "ProducersForm";
            this.Text = "ProducersForm";
            this.Load += new System.EventHandler(this.ProducersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProducersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProducersDataGridView;
    }
}