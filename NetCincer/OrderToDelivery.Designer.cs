﻿
namespace NetCincer
{
    partial class OrderToDelivery
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.isItPossibleLabel = new System.Windows.Forms.Label();
            this.giveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(254, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // isItPossibleLabel
            // 
            this.isItPossibleLabel.AutoSize = true;
            this.isItPossibleLabel.Location = new System.Drawing.Point(305, 198);
            this.isItPossibleLabel.Name = "isItPossibleLabel";
            this.isItPossibleLabel.Size = new System.Drawing.Size(38, 15);
            this.isItPossibleLabel.TabIndex = 1;
            this.isItPossibleLabel.Text = "label1";
            this.isItPossibleLabel.Visible = false;
            // 
            // giveButton
            // 
            this.giveButton.Location = new System.Drawing.Point(288, 235);
            this.giveButton.Name = "giveButton";
            this.giveButton.Size = new System.Drawing.Size(75, 23);
            this.giveButton.TabIndex = 2;
            this.giveButton.Text = "Átadás";
            this.giveButton.UseVisualStyleBackColor = true;
            this.giveButton.Click += new System.EventHandler(this.giveButton_Click);
            // 
            // OrderToDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.giveButton);
            this.Controls.Add(this.isItPossibleLabel);
            this.Controls.Add(this.comboBox1);
            this.Name = "OrderToDelivery";
            this.Text = "OrderToDelivery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label isItPossibleLabel;
        private System.Windows.Forms.Button giveButton;
    }
}