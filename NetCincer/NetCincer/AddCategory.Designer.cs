
namespace NetCincer
{
    partial class AddCategory
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cCancelButton = new System.Windows.Forms.Button();
            this.cAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(433, 27);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Új kategória neve:";
            // 
            // cCancelButton
            // 
            this.cCancelButton.Location = new System.Drawing.Point(266, 222);
            this.cCancelButton.Name = "cCancelButton";
            this.cCancelButton.Size = new System.Drawing.Size(94, 29);
            this.cCancelButton.TabIndex = 2;
            this.cCancelButton.Text = "Mégse";
            this.cCancelButton.UseVisualStyleBackColor = true;
            // 
            // cAddButton
            // 
            this.cAddButton.Location = new System.Drawing.Point(403, 222);
            this.cAddButton.Name = "cAddButton";
            this.cAddButton.Size = new System.Drawing.Size(94, 29);
            this.cAddButton.TabIndex = 3;
            this.cAddButton.Text = "Hozzáad";
            this.cAddButton.UseVisualStyleBackColor = true;
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cAddButton);
            this.Controls.Add(this.cCancelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "AddCategory";
            this.Text = "Kategória hozzáadása";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cCancelButton;
        private System.Windows.Forms.Button cAddButton;
    }
}