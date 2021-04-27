
namespace NetCincer
{
    partial class AddFood
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
            this.fAddButton = new System.Windows.Forms.Button();
            this.fCancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.fPriceTextBox = new System.Windows.Forms.TextBox();
            this.fPictureUpload = new System.Windows.Forms.Button();
            this.fAllergensTextBox = new System.Windows.Forms.TextBox();
            this.fDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.fAvaibilityCheckBox = new System.Windows.Forms.CheckBox();
            this.mettolDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.meddigDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // fAddButton
            // 
            this.fAddButton.Location = new System.Drawing.Point(1012, 474);
            this.fAddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fAddButton.Name = "fAddButton";
            this.fAddButton.Size = new System.Drawing.Size(82, 22);
            this.fAddButton.TabIndex = 0;
            this.fAddButton.Text = "Hozzáad";
            this.fAddButton.UseVisualStyleBackColor = true;
            this.fAddButton.Click += new System.EventHandler(this.fAddButton_Click);
            // 
            // fCancelButton
            // 
            this.fCancelButton.Location = new System.Drawing.Point(924, 474);
            this.fCancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fCancelButton.Name = "fCancelButton";
            this.fCancelButton.Size = new System.Drawing.Size(82, 22);
            this.fCancelButton.TabIndex = 1;
            this.fCancelButton.Text = "Mégse";
            this.fCancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Étel neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Étel ára (Ft-ban):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kép feltöltése:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Allergének:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Leírás (max 300 karakter):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Időszakos étel:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mettől:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(486, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Meddig:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Kategória:";
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.Location = new System.Drawing.Point(80, 10);
            this.fNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(1014, 23);
            this.fNameTextBox.TabIndex = 11;
            // 
            // fPriceTextBox
            // 
            this.fPriceTextBox.Location = new System.Drawing.Point(121, 36);
            this.fPriceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fPriceTextBox.Name = "fPriceTextBox";
            this.fPriceTextBox.Size = new System.Drawing.Size(974, 23);
            this.fPriceTextBox.TabIndex = 12;
            // 
            // fPictureUpload
            // 
            this.fPictureUpload.Location = new System.Drawing.Point(123, 61);
            this.fPictureUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fPictureUpload.Name = "fPictureUpload";
            this.fPictureUpload.Size = new System.Drawing.Size(116, 22);
            this.fPictureUpload.TabIndex = 13;
            this.fPictureUpload.Text = "Fájl feltöltése";
            this.fPictureUpload.UseVisualStyleBackColor = true;
            // 
            // fAllergensTextBox
            // 
            this.fAllergensTextBox.Location = new System.Drawing.Point(90, 86);
            this.fAllergensTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fAllergensTextBox.Name = "fAllergensTextBox";
            this.fAllergensTextBox.Size = new System.Drawing.Size(1004, 23);
            this.fAllergensTextBox.TabIndex = 14;
            // 
            // fDescriptionRichTextBox
            // 
            this.fDescriptionRichTextBox.Location = new System.Drawing.Point(11, 129);
            this.fDescriptionRichTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fDescriptionRichTextBox.Name = "fDescriptionRichTextBox";
            this.fDescriptionRichTextBox.Size = new System.Drawing.Size(1083, 236);
            this.fDescriptionRichTextBox.TabIndex = 15;
            this.fDescriptionRichTextBox.Text = "";
            // 
            // fAvaibilityCheckBox
            // 
            this.fAvaibilityCheckBox.AutoSize = true;
            this.fAvaibilityCheckBox.Location = new System.Drawing.Point(139, 377);
            this.fAvaibilityCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fAvaibilityCheckBox.Name = "fAvaibilityCheckBox";
            this.fAvaibilityCheckBox.Size = new System.Drawing.Size(15, 14);
            this.fAvaibilityCheckBox.TabIndex = 16;
            this.fAvaibilityCheckBox.UseVisualStyleBackColor = true;
            // 
            // mettolDateTimePicker
            // 
            this.mettolDateTimePicker.Location = new System.Drawing.Point(245, 374);
            this.mettolDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mettolDateTimePicker.Name = "mettolDateTimePicker";
            this.mettolDateTimePicker.Size = new System.Drawing.Size(219, 23);
            this.mettolDateTimePicker.TabIndex = 17;
            // 
            // meddigDateTimePicker
            // 
            this.meddigDateTimePicker.Location = new System.Drawing.Point(559, 374);
            this.meddigDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.meddigDateTimePicker.Name = "meddigDateTimePicker";
            this.meddigDateTimePicker.Size = new System.Drawing.Size(219, 23);
            this.meddigDateTimePicker.TabIndex = 18;
            // 
            // fCategoryComboBox
            // 
            this.fCategoryComboBox.FormattingEnabled = true;
            this.fCategoryComboBox.Location = new System.Drawing.Point(98, 400);
            this.fCategoryComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fCategoryComboBox.Name = "fCategoryComboBox";
            this.fCategoryComboBox.Size = new System.Drawing.Size(366, 23);
            this.fCategoryComboBox.TabIndex = 19;
            // 
            // AddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 505);
            this.Controls.Add(this.fCategoryComboBox);
            this.Controls.Add(this.meddigDateTimePicker);
            this.Controls.Add(this.mettolDateTimePicker);
            this.Controls.Add(this.fAvaibilityCheckBox);
            this.Controls.Add(this.fDescriptionRichTextBox);
            this.Controls.Add(this.fAllergensTextBox);
            this.Controls.Add(this.fPictureUpload);
            this.Controls.Add(this.fPriceTextBox);
            this.Controls.Add(this.fNameTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fCancelButton);
            this.Controls.Add(this.fAddButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddFood";
            this.Text = "Étel hozzáadása";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fAddButton;
        private System.Windows.Forms.Button fCancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.TextBox fPriceTextBox;
        private System.Windows.Forms.Button fPictureUpload;
        private System.Windows.Forms.TextBox fAllergensTextBox;
        private System.Windows.Forms.RichTextBox fDescriptionRichTextBox;
        private System.Windows.Forms.CheckBox fAvaibilityCheckBox;
        private System.Windows.Forms.DateTimePicker mettolDateTimePicker;
        private System.Windows.Forms.DateTimePicker meddigDateTimePicker;
        private System.Windows.Forms.ComboBox fCategoryComboBox;
    }
}