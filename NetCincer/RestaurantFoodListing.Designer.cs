
namespace NetCincer
{
    partial class RestaurantFoodListing
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
            this.rlistingButton = new System.Windows.Forms.Button();
            this.rAddCategory = new System.Windows.Forms.Button();
            this.rNewFoodButton = new System.Windows.Forms.Button();
            this.rLogoutButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.acceptRefuseButton = new System.Windows.Forms.Button();
            this.giveToDeliveryButton = new System.Windows.Forms.Button();
            this.DiscountButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.readyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rlistingButton
            // 
            this.rlistingButton.Location = new System.Drawing.Point(11, 10);
            this.rlistingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rlistingButton.Name = "rlistingButton";
            this.rlistingButton.Size = new System.Drawing.Size(82, 22);
            this.rlistingButton.TabIndex = 0;
            this.rlistingButton.Text = "Ételek";
            this.rlistingButton.UseVisualStyleBackColor = true;
            this.rlistingButton.Click += new System.EventHandler(this.rlistingButton_Click);
            // 
            // rAddCategory
            // 
            this.rAddCategory.Location = new System.Drawing.Point(99, 10);
            this.rAddCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rAddCategory.Name = "rAddCategory";
            this.rAddCategory.Size = new System.Drawing.Size(97, 22);
            this.rAddCategory.TabIndex = 1;
            this.rAddCategory.Text = "Új kategória";
            this.rAddCategory.UseVisualStyleBackColor = true;
            this.rAddCategory.Click += new System.EventHandler(this.rAddCategory_Click);
            // 
            // rNewFoodButton
            // 
            this.rNewFoodButton.Location = new System.Drawing.Point(202, 10);
            this.rNewFoodButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rNewFoodButton.Name = "rNewFoodButton";
            this.rNewFoodButton.Size = new System.Drawing.Size(82, 22);
            this.rNewFoodButton.TabIndex = 2;
            this.rNewFoodButton.Text = "Új étel";
            this.rNewFoodButton.UseVisualStyleBackColor = true;
            this.rNewFoodButton.Click += new System.EventHandler(this.rNewFoodButton_Click);
            // 
            // rLogoutButton
            // 
            this.rLogoutButton.Location = new System.Drawing.Point(996, 10);
            this.rLogoutButton.Name = "rLogoutButton";
            this.rLogoutButton.Size = new System.Drawing.Size(96, 23);
            this.rLogoutButton.TabIndex = 4;
            this.rLogoutButton.Text = "Kijelentkezés";
            this.rLogoutButton.UseVisualStyleBackColor = true;
            this.rLogoutButton.Click += new System.EventHandler(this.rLogoutButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Rendelések";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // acceptRefuseButton
            // 
            this.acceptRefuseButton.Location = new System.Drawing.Point(459, 10);
            this.acceptRefuseButton.Name = "acceptRefuseButton";
            this.acceptRefuseButton.Size = new System.Drawing.Size(106, 23);
            this.acceptRefuseButton.TabIndex = 6;
            this.acceptRefuseButton.Text = "Elfogad/Elutasít";
            this.acceptRefuseButton.UseVisualStyleBackColor = true;
            this.acceptRefuseButton.Click += new System.EventHandler(this.acceptRefuseButton_Click);
            // 
            // giveToDeliveryButton
            // 
            this.giveToDeliveryButton.Location = new System.Drawing.Point(571, 10);
            this.giveToDeliveryButton.Name = "giveToDeliveryButton";
            this.giveToDeliveryButton.Size = new System.Drawing.Size(107, 23);
            this.giveToDeliveryButton.TabIndex = 7;
            this.giveToDeliveryButton.Text = "Futárnak átadás";
            this.giveToDeliveryButton.UseVisualStyleBackColor = true;
            this.giveToDeliveryButton.Click += new System.EventHandler(this.giveToDeliveryButton_Click);
            // 
            // DiscountButton
            // 
            this.DiscountButton.Location = new System.Drawing.Point(290, 10);
            this.DiscountButton.Name = "DiscountButton";
            this.DiscountButton.Size = new System.Drawing.Size(82, 23);
            this.DiscountButton.TabIndex = 8;
            this.DiscountButton.Text = "Leárazás";
            this.DiscountButton.UseVisualStyleBackColor = true;
            this.DiscountButton.Click += new System.EventHandler(this.DiscountButton_Click);
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(765, 10);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 9;
            this.doneButton.Text = "Átadva";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Visible = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // readyButton
            // 
            this.readyButton.Location = new System.Drawing.Point(684, 10);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(75, 23);
            this.readyButton.TabIndex = 10;
            this.readyButton.Text = "Kész";
            this.readyButton.UseVisualStyleBackColor = true;
            this.readyButton.Visible = false;
            this.readyButton.Click += new System.EventHandler(this.readyButton_Click);
            // 
            // RestaurantFoodListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 505);
            this.Controls.Add(this.readyButton);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.DiscountButton);
            this.Controls.Add(this.giveToDeliveryButton);
            this.Controls.Add(this.acceptRefuseButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rLogoutButton);
            this.Controls.Add(this.rNewFoodButton);
            this.Controls.Add(this.rAddCategory);
            this.Controls.Add(this.rlistingButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RestaurantFoodListing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetCincér (Étterem)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RestaurantFoodListing_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rlistingButton;
        private System.Windows.Forms.Button rAddCategory;
        private System.Windows.Forms.Button rNewFoodButton;
        private System.Windows.Forms.Button rLogoutButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button acceptRefuseButton;
        private System.Windows.Forms.Button giveToDeliveryButton;
        private System.Windows.Forms.Button DiscountButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button readyButton;
    }
}