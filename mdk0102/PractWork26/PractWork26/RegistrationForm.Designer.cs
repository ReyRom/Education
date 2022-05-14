
namespace PractWork26
{
    partial class RegistrationForm
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
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmTextBox = new System.Windows.Forms.TextBox();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.LoginErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.AgeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PasswordErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.EmailErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LoginErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginTextBox.Location = new System.Drawing.Point(13, 13);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.PlaceholderText = "Логин";
            this.LoginTextBox.Size = new System.Drawing.Size(418, 23);
            this.LoginTextBox.TabIndex = 0;
            this.LoginTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.LoginTextBox_Validating);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(13, 43);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.PlaceholderText = "e-mail";
            this.EmailTextBox.Size = new System.Drawing.Size(418, 23);
            this.EmailTextBox.TabIndex = 1;
            this.EmailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.EmailTextBox_Validating);
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgeTextBox.Location = new System.Drawing.Point(13, 73);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.PlaceholderText = "Возраст";
            this.AgeTextBox.Size = new System.Drawing.Size(418, 23);
            this.AgeTextBox.TabIndex = 2;
            this.AgeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.AgeTextBox_Validating);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTextBox.Location = new System.Drawing.Point(13, 103);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PlaceholderText = "Пароль";
            this.PasswordTextBox.Size = new System.Drawing.Size(418, 23);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PasswordTextBox_Validating);
            // 
            // ConfirmTextBox
            // 
            this.ConfirmTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmTextBox.Location = new System.Drawing.Point(13, 133);
            this.ConfirmTextBox.Name = "ConfirmTextBox";
            this.ConfirmTextBox.PlaceholderText = "Подтверждение пароля";
            this.ConfirmTextBox.Size = new System.Drawing.Size(418, 23);
            this.ConfirmTextBox.TabIndex = 4;
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(296, 163);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(135, 23);
            this.RegistrationButton.TabIndex = 5;
            this.RegistrationButton.Text = "Зарегистрироваться";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // LoginErrorProvider
            // 
            this.LoginErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.LoginErrorProvider.ContainerControl = this;
            // 
            // AgeErrorProvider
            // 
            this.AgeErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.AgeErrorProvider.ContainerControl = this;
            // 
            // PasswordErrorProvider
            // 
            this.PasswordErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.PasswordErrorProvider.ContainerControl = this;
            // 
            // EmailErrorProvider
            // 
            this.EmailErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.EmailErrorProvider.ContainerControl = this;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 196);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.ConfirmTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Name = "RegistrationForm";
            this.Text = "Регистрация";
            ((System.ComponentModel.ISupportInitialize)(this.LoginErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox ConfirmTextBox;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.ErrorProvider LoginErrorProvider;
        private System.Windows.Forms.ErrorProvider AgeErrorProvider;
        private System.Windows.Forms.ErrorProvider PasswordErrorProvider;
        private System.Windows.Forms.ErrorProvider EmailErrorProvider;
    }
}

