
namespace NetCincer
{
    partial class CustomerMain
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
            this.addToCartButton = new System.Windows.Forms.Button();
            this.cartButton = new System.Windows.Forms.Button();
            this.foodsButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
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
            this.searchButton.Location = new System.Drawing.Point(422, 9);
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
            this.filterButton.Location = new System.Drawing.Point(510, 9);
            this.filterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(82, 22);
            this.filterButton.TabIndex = 2;
            this.filterButton.Text = "Szűrés";
            this.filterButton.UseVisualStyleBackColor = true;
            // 
            // ordersButton
            // 
            this.ordersButton.Location = new System.Drawing.Point(598, 9);
            this.ordersButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(82, 22);
            this.ordersButton.TabIndex = 3;
            this.ordersButton.Text = "Rendelések";
            this.ordersButton.UseVisualStyleBackColor = true;
            this.ordersButton.Click += new System.EventHandler(this.ordersButton_Click);
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(862, 9);
            this.addToCartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(82, 22);
            this.addToCartButton.TabIndex = 4;
            this.addToCartButton.Text = "Kosárba";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // cartButton
            // 
            this.cartButton.Location = new System.Drawing.Point(950, 9);
            this.cartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(62, 22);
            this.cartButton.TabIndex = 5;
            this.cartButton.Text = "Kosár";
            this.cartButton.UseVisualStyleBackColor = true;
            this.cartButton.Click += new System.EventHandler(this.cartButton_Click);
            // 
            // foodsButton
            // 
            this.foodsButton.Location = new System.Drawing.Point(686, 9);
            this.foodsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.foodsButton.Name = "foodsButton";
            this.foodsButton.Size = new System.Drawing.Size(82, 22);
            this.foodsButton.TabIndex = 6;
            this.foodsButton.Text = "Kínálat";
            this.foodsButton.UseVisualStyleBackColor = true;
            this.foodsButton.Click += new System.EventHandler(this.foodsButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Enabled = false;
            this.goBackButton.Location = new System.Drawing.Point(774, 9);
            this.goBackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(82, 22);
            this.goBackButton.TabIndex = 7;
            this.goBackButton.Text = "Vissza";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(1018, 8);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(85, 23);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.Text = "Kijelentkezés";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // CustomerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 505);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.foodsButton);
            this.Controls.Add(this.cartButton);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.ordersButton);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextbox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomerMain";
            this.Text = "NetCincér";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button ordersButton;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.Button foodsButton;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button logoutButton;
    }
}

