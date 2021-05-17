
namespace NetCincer
{
    partial class CartForm
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
            this.orderButton = new System.Windows.Forms.Button();
            this.deleteCartLine = new System.Windows.Forms.Button();
            this.emptyCartButton = new System.Windows.Forms.Button();
            this.CartListView = new System.Windows.Forms.ListView();
            this.changeQuantity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(12, 12);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 23);
            this.orderButton.TabIndex = 1;
            this.orderButton.Text = "Rendelés";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // deleteCartLine
            // 
            this.deleteCartLine.Location = new System.Drawing.Point(104, 11);
            this.deleteCartLine.Name = "deleteCartLine";
            this.deleteCartLine.Size = new System.Drawing.Size(75, 23);
            this.deleteCartLine.TabIndex = 2;
            this.deleteCartLine.Text = "Törlés";
            this.deleteCartLine.UseVisualStyleBackColor = true;
            this.deleteCartLine.Click += new System.EventHandler(this.deleteCartLine_Click);
            // 
            // emptyCartButton
            // 
            this.emptyCartButton.Location = new System.Drawing.Point(267, 10);
            this.emptyCartButton.Name = "emptyCartButton";
            this.emptyCartButton.Size = new System.Drawing.Size(96, 23);
            this.emptyCartButton.TabIndex = 3;
            this.emptyCartButton.Text = "Kosár kiürítése";
            this.emptyCartButton.UseVisualStyleBackColor = true;
            this.emptyCartButton.Click += new System.EventHandler(this.emptyCartButton_Click);
            // 
            // CartListView
            // 
            this.CartListView.HideSelection = false;
            this.CartListView.Location = new System.Drawing.Point(12, 42);
            this.CartListView.Name = "CartListView";
            this.CartListView.Size = new System.Drawing.Size(776, 396);
            this.CartListView.TabIndex = 4;
            this.CartListView.UseCompatibleStateImageBehavior = false;
            this.CartListView.SelectedIndexChanged += new System.EventHandler(this.CartListView_SelectedIndexChanged);
            // 
            // changeQuantity
            // 
            this.changeQuantity.Location = new System.Drawing.Point(186, 10);
            this.changeQuantity.Name = "changeQuantity";
            this.changeQuantity.Size = new System.Drawing.Size(75, 23);
            this.changeQuantity.TabIndex = 5;
            this.changeQuantity.Text = "Mennyiség";
            this.changeQuantity.UseVisualStyleBackColor = true;
            this.changeQuantity.Click += new System.EventHandler(this.changeQuantity_Click);
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changeQuantity);
            this.Controls.Add(this.CartListView);
            this.Controls.Add(this.emptyCartButton);
            this.Controls.Add(this.deleteCartLine);
            this.Controls.Add(this.orderButton);
            this.Name = "CartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kosár";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button deleteCartLine;
        private System.Windows.Forms.Button emptyCartButton;
        private System.Windows.Forms.ListView CartListView;
        private System.Windows.Forms.Button changeQuantity;
    }
}