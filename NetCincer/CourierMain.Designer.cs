﻿
namespace NetCincer
{
    partial class CourierMain
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
            this.cuLogoutButton = new System.Windows.Forms.Button();
            this.cuProfileButton = new System.Windows.Forms.Button();
            this.workButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cuLogoutButton
            // 
            this.cuLogoutButton.Location = new System.Drawing.Point(997, 12);
            this.cuLogoutButton.Name = "cuLogoutButton";
            this.cuLogoutButton.Size = new System.Drawing.Size(95, 23);
            this.cuLogoutButton.TabIndex = 0;
            this.cuLogoutButton.Text = "Kijelentkezés";
            this.cuLogoutButton.UseVisualStyleBackColor = true;
            this.cuLogoutButton.Click += new System.EventHandler(this.cuLogoutButton_Click);
            // 
            // cuProfileButton
            // 
            this.cuProfileButton.Location = new System.Drawing.Point(916, 12);
            this.cuProfileButton.Name = "cuProfileButton";
            this.cuProfileButton.Size = new System.Drawing.Size(75, 23);
            this.cuProfileButton.TabIndex = 1;
            this.cuProfileButton.Text = "Profilom";
            this.cuProfileButton.UseVisualStyleBackColor = true;
            // 
            // workButton
            // 
            this.workButton.Location = new System.Drawing.Point(12, 12);
            this.workButton.Name = "workButton";
            this.workButton.Size = new System.Drawing.Size(75, 23);
            this.workButton.TabIndex = 2;
            this.workButton.Text = "Dolgozom";
            this.workButton.UseVisualStyleBackColor = true;
            this.workButton.Click += new System.EventHandler(this.workButton_Click);
            // 
            // CourierMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 505);
            this.Controls.Add(this.workButton);
            this.Controls.Add(this.cuProfileButton);
            this.Controls.Add(this.cuLogoutButton);
            this.Name = "CourierMain";
            this.Text = "CourierMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cuLogoutButton;
        private System.Windows.Forms.Button cuProfileButton;
        private System.Windows.Forms.Button workButton;
    }
}