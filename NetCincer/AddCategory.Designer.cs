
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
            this.textBox1.Location = new System.Drawing.Point(150, 134);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(379, 23);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Új kategória neve:";
            // 
            // cCancelButton
            // 
            this.cCancelButton.Location = new System.Drawing.Point(233, 166);
            this.cCancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cCancelButton.Name = "cCancelButton";
            this.cCancelButton.Size = new System.Drawing.Size(82, 22);
            this.cCancelButton.TabIndex = 2;
            this.cCancelButton.Text = "Mégse";
            this.cCancelButton.UseVisualStyleBackColor = true;
            this.cCancelButton.Click += new System.EventHandler(this.cCancelButton_Click);
            // 
            // cAddButton
            // 
            this.cAddButton.Location = new System.Drawing.Point(353, 166);
            this.cAddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cAddButton.Name = "cAddButton";
            this.cAddButton.Size = new System.Drawing.Size(82, 22);
            this.cAddButton.TabIndex = 3;
            this.cAddButton.Text = "Hozzáad";
            this.cAddButton.UseVisualStyleBackColor = true;
            this.cAddButton.Click += new System.EventHandler(this.cAddButton_Click);
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.cAddButton);
            this.Controls.Add(this.cCancelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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