
namespace NetCincer
{
    partial class CustomerFilter
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
            this.label1 = new System.Windows.Forms.Label();
            this.customerCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.filterStartButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategória:";
            // 
            // customerCheckedListBox
            // 
            this.customerCheckedListBox.FormattingEnabled = true;
            this.customerCheckedListBox.Location = new System.Drawing.Point(11, 28);
            this.customerCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerCheckedListBox.Name = "customerCheckedListBox";
            this.customerCheckedListBox.Size = new System.Drawing.Size(669, 256);
            this.customerCheckedListBox.TabIndex = 1;
            // 
            // filterStartButton
            // 
            this.filterStartButton.Location = new System.Drawing.Point(598, 307);
            this.filterStartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterStartButton.Name = "filterStartButton";
            this.filterStartButton.Size = new System.Drawing.Size(82, 22);
            this.filterStartButton.TabIndex = 2;
            this.filterStartButton.Text = "Szűrés";
            this.filterStartButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(496, 307);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(82, 22);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Mégse";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // CustomerFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.filterStartButton);
            this.Controls.Add(this.customerCheckedListBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomerFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szűrés";
            this.Load += new System.EventHandler(this.CustomerFilter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox customerCheckedListBox;
        private System.Windows.Forms.Button filterStartButton;
        private System.Windows.Forms.Button cancelButton;
    }
}