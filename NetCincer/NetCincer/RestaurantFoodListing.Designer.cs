
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
            this.rProfileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rlistingButton
            // 
            this.rlistingButton.Location = new System.Drawing.Point(11, 10);
            this.rlistingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rlistingButton.Name = "rlistingButton";
            this.rlistingButton.Size = new System.Drawing.Size(82, 22);
            this.rlistingButton.TabIndex = 0;
            this.rlistingButton.Text = "Listázás";
            this.rlistingButton.UseVisualStyleBackColor = true;
            this.rlistingButton.Click += new System.EventHandler(this.rlistingButton_Click);
            // 
            // rAddCategory
            // 
            this.rAddCategory.Location = new System.Drawing.Point(118, 10);
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
            this.rNewFoodButton.Location = new System.Drawing.Point(241, 10);
            this.rNewFoodButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rNewFoodButton.Name = "rNewFoodButton";
            this.rNewFoodButton.Size = new System.Drawing.Size(82, 22);
            this.rNewFoodButton.TabIndex = 2;
            this.rNewFoodButton.Text = "Új étel";
            this.rNewFoodButton.UseVisualStyleBackColor = true;
            this.rNewFoodButton.Click += new System.EventHandler(this.rNewFoodButton_Click);
            // 
            // rProfileButton
            // 
            this.rProfileButton.Location = new System.Drawing.Point(1012, 10);
            this.rProfileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rProfileButton.Name = "rProfileButton";
            this.rProfileButton.Size = new System.Drawing.Size(82, 22);
            this.rProfileButton.TabIndex = 3;
            this.rProfileButton.Text = "Profilunk";
            this.rProfileButton.UseVisualStyleBackColor = true;
            // 
            // RestaurantFoodListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 505);
            this.Controls.Add(this.rProfileButton);
            this.Controls.Add(this.rNewFoodButton);
            this.Controls.Add(this.rAddCategory);
            this.Controls.Add(this.rlistingButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RestaurantFoodListing";
            this.Text = "NetCincér (Étterem)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rlistingButton;
        private System.Windows.Forms.Button rAddCategory;
        private System.Windows.Forms.Button rNewFoodButton;
        private System.Windows.Forms.Button rProfileButton;
    }
}