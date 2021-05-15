
namespace NetCincer
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.lUsernameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lPasswordTextBox = new System.Windows.Forms.TextBox();
            this.lRegistrationButton = new System.Windows.Forms.Button();
            this.lLoginButton = new System.Windows.Forms.Button();
            this.lGuestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felhasználónév:";
            // 
            // lUsernameTextBox
            // 
            this.lUsernameTextBox.Location = new System.Drawing.Point(337, 104);
            this.lUsernameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lUsernameTextBox.Name = "lUsernameTextBox";
            this.lUsernameTextBox.Size = new System.Drawing.Size(413, 23);
            this.lUsernameTextBox.TabIndex = 1;
            this.lUsernameTextBox.Text = "Dio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jelszó";
            // 
            // lPasswordTextBox
            // 
            this.lPasswordTextBox.Location = new System.Drawing.Point(337, 188);
            this.lPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lPasswordTextBox.Name = "lPasswordTextBox";
            this.lPasswordTextBox.PasswordChar = '*';
            this.lPasswordTextBox.Size = new System.Drawing.Size(413, 23);
            this.lPasswordTextBox.TabIndex = 3;
            this.lPasswordTextBox.Text = "wryyy";
            // 
            // lRegistrationButton
            // 
            this.lRegistrationButton.Location = new System.Drawing.Point(337, 234);
            this.lRegistrationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lRegistrationButton.Name = "lRegistrationButton";
            this.lRegistrationButton.Size = new System.Drawing.Size(98, 34);
            this.lRegistrationButton.TabIndex = 4;
            this.lRegistrationButton.Text = "Regisztráció";
            this.lRegistrationButton.UseVisualStyleBackColor = true;
            this.lRegistrationButton.Click += new System.EventHandler(this.lRegistrationButton_Click);
            // 
            // lLoginButton
            // 
            this.lLoginButton.Location = new System.Drawing.Point(467, 234);
            this.lLoginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lLoginButton.Name = "lLoginButton";
            this.lLoginButton.Size = new System.Drawing.Size(106, 34);
            this.lLoginButton.TabIndex = 5;
            this.lLoginButton.Text = "Bejelentkezés";
            this.lLoginButton.UseVisualStyleBackColor = true;
            this.lLoginButton.Click += new System.EventHandler(this.lLoginButton_Click);
            // 
            // lGuestButton
            // 
            this.lGuestButton.Location = new System.Drawing.Point(605, 234);
            this.lGuestButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lGuestButton.Name = "lGuestButton";
            this.lGuestButton.Size = new System.Drawing.Size(144, 34);
            this.lGuestButton.TabIndex = 6;
            this.lGuestButton.Text = "Folytatás vendégként";
            this.lGuestButton.UseVisualStyleBackColor = true;
            this.lGuestButton.Click += new System.EventHandler(this.lGuestButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 505);
            this.Controls.Add(this.lGuestButton);
            this.Controls.Add(this.lLoginButton);
            this.Controls.Add(this.lRegistrationButton);
            this.Controls.Add(this.lPasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lUsernameTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Bejelentkezés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lUsernameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lPasswordTextBox;
        private System.Windows.Forms.Button lRegistrationButton;
        private System.Windows.Forms.Button lLoginButton;
        private System.Windows.Forms.Button lGuestButton;
    }
}