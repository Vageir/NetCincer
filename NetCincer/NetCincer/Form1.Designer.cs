
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(5, 10);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(472, 27);
            this.searchTextbox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(503, 7);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 29);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Keresés";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(622, 6);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(94, 29);
            this.filterButton.TabIndex = 2;
            this.filterButton.Text = "Szűrés";
            this.filterButton.UseVisualStyleBackColor = true;
            // 
            // ordersButton
            // 
            this.ordersButton.Location = new System.Drawing.Point(745, 7);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(94, 29);
            this.ordersButton.TabIndex = 3;
            this.ordersButton.Text = "Rendelések";
            this.ordersButton.UseVisualStyleBackColor = true;
            this.ordersButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // profileButton
            // 
            this.profileButton.Location = new System.Drawing.Point(1156, 7);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(94, 29);
            this.profileButton.TabIndex = 4;
            this.profileButton.Text = "Profilom";
            this.profileButton.UseVisualStyleBackColor = true;
            // 
            // cartButton
            // 
            this.cartButton.Location = new System.Drawing.Point(1056, 7);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(94, 29);
            this.cartButton.TabIndex = 5;
            this.cartButton.Text = "Kosár";
            this.cartButton.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(5, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1245, 617);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cartButton);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.ordersButton);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextbox);
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
        private System.Windows.Forms.ListView listView1;
    }
}

