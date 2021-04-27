
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
            this.button2 = new System.Windows.Forms.Button();
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
            // 
            // deleteCartLine
            // 
            this.deleteCartLine.Location = new System.Drawing.Point(104, 11);
            this.deleteCartLine.Name = "deleteCartLine";
            this.deleteCartLine.Size = new System.Drawing.Size(75, 23);
            this.deleteCartLine.TabIndex = 2;
            this.deleteCartLine.Text = "Törlés";
            this.deleteCartLine.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.deleteCartLine);
            this.Controls.Add(this.orderButton);
            this.Name = "CartForm";
            this.Text = "CartForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button deleteCartLine;
        private System.Windows.Forms.Button button2;
    }
}