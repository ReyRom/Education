
namespace Task1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TaskTextBox = new System.Windows.Forms.TextBox();
            this.PractWorkNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PractWorkSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.VariantsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.NewDocumentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PractWorkNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VariantsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(116, 45);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(179, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // TaskTextBox
            // 
            this.TaskTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskTextBox.Location = new System.Drawing.Point(116, 71);
            this.TaskTextBox.Multiline = true;
            this.TaskTextBox.Name = "TaskTextBox";
            this.TaskTextBox.Size = new System.Drawing.Size(285, 196);
            this.TaskTextBox.TabIndex = 1;
            // 
            // PractWorkNumericUpDown
            // 
            this.PractWorkNumericUpDown.Location = new System.Drawing.Point(116, 19);
            this.PractWorkNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PractWorkNumericUpDown.Name = "PractWorkNumericUpDown";
            this.PractWorkNumericUpDown.Size = new System.Drawing.Size(57, 20);
            this.PractWorkNumericUpDown.TabIndex = 2;
            this.PractWorkNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Номер работы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Задание";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(224, 297);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(177, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Создать документ по шаблону";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // VariantsNumericUpDown
            // 
            this.VariantsNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VariantsNumericUpDown.Location = new System.Drawing.Point(116, 273);
            this.VariantsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.VariantsNumericUpDown.Name = "VariantsNumericUpDown";
            this.VariantsNumericUpDown.Size = new System.Drawing.Size(57, 20);
            this.VariantsNumericUpDown.TabIndex = 7;
            this.VariantsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Кол-во вариантов";
            // 
            // NewDocumentButton
            // 
            this.NewDocumentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NewDocumentButton.Location = new System.Drawing.Point(224, 272);
            this.NewDocumentButton.Name = "NewDocumentButton";
            this.NewDocumentButton.Size = new System.Drawing.Size(177, 23);
            this.NewDocumentButton.TabIndex = 9;
            this.NewDocumentButton.Text = "Создать новый документ";
            this.NewDocumentButton.UseVisualStyleBackColor = true;
            this.NewDocumentButton.Click += new System.EventHandler(this.NewDocumentButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 328);
            this.Controls.Add(this.NewDocumentButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VariantsNumericUpDown);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PractWorkNumericUpDown);
            this.Controls.Add(this.TaskTextBox);
            this.Controls.Add(this.NameTextBox);
            this.MinimumSize = new System.Drawing.Size(429, 367);
            this.Name = "MainForm";
            this.Text = "Практические работы";
            ((System.ComponentModel.ISupportInitialize)(this.PractWorkNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VariantsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox TaskTextBox;
        private System.Windows.Forms.NumericUpDown PractWorkNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.SaveFileDialog PractWorkSaveFileDialog;
        private System.Windows.Forms.NumericUpDown VariantsNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button NewDocumentButton;
    }
}

