
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBoxPlaceholder1 = new Task1.TextBoxPlaceholder(this.components);
            this.textBoxPlaceholder2 = new Task1.TextBoxPlaceholder(this.components);
            this.ellipsPictureBox1 = new Task1.EllipsPictureBox(this.components);
            this.clock1 = new Task1.Clock();
            this.runningString1 = new Task1.RunningString();
            this.ellipsButton1 = new Task1.EllipsButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ellipsPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPlaceholder1
            // 
            this.textBoxPlaceholder1.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxPlaceholder1.Location = new System.Drawing.Point(59, 271);
            this.textBoxPlaceholder1.Name = "textBoxPlaceholder1";
            this.textBoxPlaceholder1.Placeholder = "123";
            this.textBoxPlaceholder1.Size = new System.Drawing.Size(100, 23);
            this.textBoxPlaceholder1.TabIndex = 1;
            this.textBoxPlaceholder1.Text = "123";
            // 
            // textBoxPlaceholder2
            // 
            this.textBoxPlaceholder2.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxPlaceholder2.Location = new System.Drawing.Point(185, 271);
            this.textBoxPlaceholder2.Name = "textBoxPlaceholder2";
            this.textBoxPlaceholder2.Placeholder = "12234";
            this.textBoxPlaceholder2.Size = new System.Drawing.Size(100, 23);
            this.textBoxPlaceholder2.TabIndex = 2;
            this.textBoxPlaceholder2.Text = "12234";
            // 
            // ellipsPictureBox1
            // 
            this.ellipsPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("ellipsPictureBox1.Image")));
            this.ellipsPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.ellipsPictureBox1.Name = "ellipsPictureBox1";
            this.ellipsPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.ellipsPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ellipsPictureBox1.TabIndex = 3;
            this.ellipsPictureBox1.TabStop = false;
            // 
            // clock1
            // 
            this.clock1.AutoSize = true;
            this.clock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clock1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clock1.Location = new System.Drawing.Point(379, 14);
            this.clock1.Margin = new System.Windows.Forms.Padding(5);
            this.clock1.Name = "clock1";
            this.clock1.Size = new System.Drawing.Size(125, 40);
            this.clock1.TabIndex = 4;
            // 
            // runningString1
            // 
            this.runningString1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.runningString1.Location = new System.Drawing.Point(28, 207);
            this.runningString1.Name = "runningString1";
            this.runningString1.Size = new System.Drawing.Size(445, 18);
            this.runningString1.TabIndex = 5;
            // 
            // ellipsButton1
            // 
            this.ellipsButton1.BackColor = System.Drawing.Color.Aquamarine;
            this.ellipsButton1.ButtonShape = Task1.ButtonShape.Ellips;
            this.ellipsButton1.FlatAppearance.BorderSize = 0;
            this.ellipsButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellipsButton1.Location = new System.Drawing.Point(247, 77);
            this.ellipsButton1.Name = "ellipsButton1";
            this.ellipsButton1.Size = new System.Drawing.Size(117, 100);
            this.ellipsButton1.TabIndex = 6;
            this.ellipsButton1.Text = "ellipsButton1";
            this.ellipsButton1.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(518, 322);
            this.Controls.Add(this.ellipsButton1);
            this.Controls.Add(this.runningString1);
            this.Controls.Add(this.clock1);
            this.Controls.Add(this.ellipsPictureBox1);
            this.Controls.Add(this.textBoxPlaceholder2);
            this.Controls.Add(this.textBoxPlaceholder1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.ellipsPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EllipsPictureBox myPictureBox1;
        private TextBoxPlaceholder textBoxPlaceholder1;
        private TextBoxPlaceholder textBoxPlaceholder2;
        private EllipsPictureBox ellipsPictureBox1;
        private Clock clock1;
        private RunningString runningString1;
        private EllipsButton ellipsButton1;
    }
}

