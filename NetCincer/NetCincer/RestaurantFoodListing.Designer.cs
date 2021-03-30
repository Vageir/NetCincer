
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // rlistingButton
            // 
            this.rlistingButton.Location = new System.Drawing.Point(13, 13);
            this.rlistingButton.Name = "rlistingButton";
            this.rlistingButton.Size = new System.Drawing.Size(94, 29);
            this.rlistingButton.TabIndex = 0;
            this.rlistingButton.Text = "Listázás";
            this.rlistingButton.UseVisualStyleBackColor = true;
            // 
            // rAddCategory
            // 
            this.rAddCategory.Location = new System.Drawing.Point(135, 13);
            this.rAddCategory.Name = "rAddCategory";
            this.rAddCategory.Size = new System.Drawing.Size(111, 29);
            this.rAddCategory.TabIndex = 1;
            this.rAddCategory.Text = "Új kategória";
            this.rAddCategory.UseVisualStyleBackColor = true;
            // 
            // rNewFoodButton
            // 
            this.rNewFoodButton.Location = new System.Drawing.Point(275, 13);
            this.rNewFoodButton.Name = "rNewFoodButton";
            this.rNewFoodButton.Size = new System.Drawing.Size(94, 29);
            this.rNewFoodButton.TabIndex = 2;
            this.rNewFoodButton.Text = "Új étel";
            this.rNewFoodButton.UseVisualStyleBackColor = true;
            // 
            // rProfileButton
            // 
            this.rProfileButton.Location = new System.Drawing.Point(1156, 13);
            this.rProfileButton.Name = "rProfileButton";
            this.rProfileButton.Size = new System.Drawing.Size(94, 29);
            this.rProfileButton.TabIndex = 3;
            this.rProfileButton.Text = "Profilunk";
            this.rProfileButton.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 49);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1237, 612);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // RestaurantFoodListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.rProfileButton);
            this.Controls.Add(this.rNewFoodButton);
            this.Controls.Add(this.rAddCategory);
            this.Controls.Add(this.rlistingButton);
            this.Name = "RestaurantFoodListing";
            this.Text = "NetCincér (Étterem)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rlistingButton;
        private System.Windows.Forms.Button rAddCategory;
        private System.Windows.Forms.Button rNewFoodButton;
        private System.Windows.Forms.Button rProfileButton;
        private System.Windows.Forms.ListView listView1;
    }
}