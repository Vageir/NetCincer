
namespace NetCincer
{
    partial class CartOrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.takeAwayYesRadioButton = new System.Windows.Forms.RadioButton();
            this.takeAwayNoRadioButton = new System.Windows.Forms.RadioButton();
            this.cartListView = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.streetextBox = new System.Windows.Forms.TextBox();
            this.houseNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.houseNumberNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(335, 391);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 23);
            this.orderButton.TabIndex = 0;
            this.orderButton.Text = "Rendelés";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Város:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Személyes átvétel:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(290, 42);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(203, 23);
            this.usernameTextBox.TabIndex = 6;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(290, 77);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(203, 23);
            this.cityTextBox.TabIndex = 7;
            this.cityTextBox.TextChanged += new System.EventHandler(this.cityTextBox_TextChanged);
            // 
            // takeAwayYesRadioButton
            // 
            this.takeAwayYesRadioButton.AutoSize = true;
            this.takeAwayYesRadioButton.Location = new System.Drawing.Point(313, 203);
            this.takeAwayYesRadioButton.Name = "takeAwayYesRadioButton";
            this.takeAwayYesRadioButton.Size = new System.Drawing.Size(48, 19);
            this.takeAwayYesRadioButton.TabIndex = 8;
            this.takeAwayYesRadioButton.Text = "Igen";
            this.takeAwayYesRadioButton.UseVisualStyleBackColor = true;
            // 
            // takeAwayNoRadioButton
            // 
            this.takeAwayNoRadioButton.AutoSize = true;
            this.takeAwayNoRadioButton.Checked = true;
            this.takeAwayNoRadioButton.Location = new System.Drawing.Point(415, 203);
            this.takeAwayNoRadioButton.Name = "takeAwayNoRadioButton";
            this.takeAwayNoRadioButton.Size = new System.Drawing.Size(51, 19);
            this.takeAwayNoRadioButton.TabIndex = 9;
            this.takeAwayNoRadioButton.TabStop = true;
            this.takeAwayNoRadioButton.Text = "Nem";
            this.takeAwayNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // cartListView
            // 
            this.cartListView.HideSelection = false;
            this.cartListView.Location = new System.Drawing.Point(229, 228);
            this.cartListView.Name = "cartListView";
            this.cartListView.Size = new System.Drawing.Size(323, 120);
            this.cartListView.TabIndex = 10;
            this.cartListView.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Végösszeg:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Utca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ház szám";
            // 
            // streetextBox
            // 
            this.streetextBox.Location = new System.Drawing.Point(290, 110);
            this.streetextBox.Name = "streetextBox";
            this.streetextBox.Size = new System.Drawing.Size(203, 23);
            this.streetextBox.TabIndex = 15;
            this.streetextBox.TextChanged += new System.EventHandler(this.streetextBox_TextChanged);
            // 
            // houseNumberNumericUpDown
            // 
            this.houseNumberNumericUpDown.Location = new System.Drawing.Point(290, 146);
            this.houseNumberNumericUpDown.Name = "houseNumberNumericUpDown";
            this.houseNumberNumericUpDown.Size = new System.Drawing.Size(81, 23);
            this.houseNumberNumericUpDown.TabIndex = 17;
            this.houseNumberNumericUpDown.ValueChanged += new System.EventHandler(this.houseNumberNumericUpDown_ValueChanged);
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(354, 360);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(28, 15);
            this.totalPriceLabel.TabIndex = 18;
            this.totalPriceLabel.Text = "0 FT";
            // 
            // CartOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.houseNumberNumericUpDown);
            this.Controls.Add(this.streetextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cartListView);
            this.Controls.Add(this.takeAwayNoRadioButton);
            this.Controls.Add(this.takeAwayYesRadioButton);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderButton);
            this.Name = "CartOrderForm";
            this.Text = "Rendelés";
            ((System.ComponentModel.ISupportInitialize)(this.houseNumberNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.RadioButton takeAwayYesRadioButton;
        private System.Windows.Forms.RadioButton takeAwayNoRadioButton;
        private System.Windows.Forms.ListView cartListView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox streetextBox;
        private System.Windows.Forms.NumericUpDown houseNumberNumericUpDown;
        private System.Windows.Forms.Label totalPriceLabel;
    }
}