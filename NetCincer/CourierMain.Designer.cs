
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
            this.addCityButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.refuseButton = new System.Windows.Forms.Button();
            this.deliveredButton = new System.Windows.Forms.Button();
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
            // addCityButton
            // 
            this.addCityButton.Location = new System.Drawing.Point(761, 12);
            this.addCityButton.Name = "addCityButton";
            this.addCityButton.Size = new System.Drawing.Size(149, 23);
            this.addCityButton.TabIndex = 3;
            this.addCityButton.Text = "Város hozzáadása";
            this.addCityButton.UseVisualStyleBackColor = true;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(93, 12);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 4;
            this.acceptButton.Text = "Elfogad";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Visible = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_ClickAsync);
            // 
            // refuseButton
            // 
            this.refuseButton.Location = new System.Drawing.Point(174, 12);
            this.refuseButton.Name = "refuseButton";
            this.refuseButton.Size = new System.Drawing.Size(75, 23);
            this.refuseButton.TabIndex = 5;
            this.refuseButton.Text = "Elutasít";
            this.refuseButton.UseVisualStyleBackColor = true;
            this.refuseButton.Visible = false;
            this.refuseButton.Click += new System.EventHandler(this.refuseButton_Click);
            // 
            // deliveredButton
            // 
            this.deliveredButton.Location = new System.Drawing.Point(255, 12);
            this.deliveredButton.Name = "deliveredButton";
            this.deliveredButton.Size = new System.Drawing.Size(75, 23);
            this.deliveredButton.TabIndex = 6;
            this.deliveredButton.Text = "Kiszállítva";
            this.deliveredButton.UseVisualStyleBackColor = true;
            this.deliveredButton.Visible = false;
            this.deliveredButton.Click += new System.EventHandler(this.deliveredButton_Click);
            // 
            // CourierMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 505);
            this.Controls.Add(this.deliveredButton);
            this.Controls.Add(this.refuseButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.addCityButton);
            this.Controls.Add(this.workButton);
            this.Controls.Add(this.cuProfileButton);
            this.Controls.Add(this.cuLogoutButton);
            this.Name = "CourierMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourierMain";
            this.Load += new System.EventHandler(this.CourierMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cuLogoutButton;
        private System.Windows.Forms.Button cuProfileButton;
        private System.Windows.Forms.Button workButton;
        private System.Windows.Forms.Button addCityButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button refuseButton;
        private System.Windows.Forms.Button deliveredButton;
    }
}