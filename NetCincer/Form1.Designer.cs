
namespace NetCincer
{
    partial class Form1
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
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.ordersButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.cartButton = new System.Windows.Forms.Button();
            this.foodsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(4, 8);
            this.searchTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(414, 23);
            this.searchTextbox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(434, 7);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(82, 22);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Keresés";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(522, 7);
            this.filterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(82, 22);
            this.filterButton.TabIndex = 2;
            this.filterButton.Text = "Szűrés";
            this.filterButton.UseVisualStyleBackColor = true;
            // 
            // ordersButton
            // 
            this.ordersButton.Location = new System.Drawing.Point(610, 7);
            this.ordersButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(82, 22);
            this.ordersButton.TabIndex = 3;
            this.ordersButton.Text = "Rendelések";
            this.ordersButton.UseVisualStyleBackColor = true;
            // 
            // profileButton
            // 
            this.profileButton.Location = new System.Drawing.Point(1012, 5);
            this.profileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(82, 22);
            this.profileButton.TabIndex = 4;
            this.profileButton.Text = "Profilom";
            this.profileButton.UseVisualStyleBackColor = true;
            // 
            // cartButton
            // 
            this.cartButton.Location = new System.Drawing.Point(924, 5);
            this.cartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(82, 22);
            this.cartButton.TabIndex = 5;
            this.cartButton.Text = "Kosár";
            this.cartButton.UseVisualStyleBackColor = true;
            this.cartButton.Click += new System.EventHandler(this.cartButton_Click);
            // 
            // foodsButton
            // 
            this.foodsButton.Location = new System.Drawing.Point(698, 7);
            this.foodsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.foodsButton.Name = "foodsButton";
            this.foodsButton.Size = new System.Drawing.Size(82, 22);
            this.foodsButton.TabIndex = 6;
            this.foodsButton.Text = "Kínálat";
            this.foodsButton.UseVisualStyleBackColor = true;
            this.foodsButton.Click += new System.EventHandler(this.foodsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 505);
            this.Controls.Add(this.foodsButton);
            this.Controls.Add(this.cartButton);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.ordersButton);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextbox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "NetCincér";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button ordersButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.Button foodsButton;
    }
}

