
namespace Prog3
{
    partial class Form1
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
            this.gardenTypeInputComboBox = new System.Windows.Forms.ComboBox();
            this.gardenTypeLabel = new System.Windows.Forms.Label();
            this.itemNumberInputTextBox = new System.Windows.Forms.TextBox();
            this.itemNumberLabel = new System.Windows.Forms.Label();
            this.quantityInputTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.flowersCostOutputLabel = new System.Windows.Forms.Label();
            this.baseAdjustedCostOutputLabel = new System.Windows.Forms.Label();
            this.discountPercentOutputLabel = new System.Windows.Forms.Label();
            this.totalPriceOutputLabel = new System.Windows.Forms.Label();
            this.flowerCostLabel = new System.Windows.Forms.Label();
            this.baseAdjustedCostLabel = new System.Windows.Forms.Label();
            this.discountPercentLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gardenTypeInputComboBox
            // 
            this.gardenTypeInputComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gardenTypeInputComboBox.FormattingEnabled = true;
            this.gardenTypeInputComboBox.Items.AddRange(new object[] {
            "Discount",
            "Standard",
            "Premium"});
            this.gardenTypeInputComboBox.Location = new System.Drawing.Point(152, 24);
            this.gardenTypeInputComboBox.Name = "gardenTypeInputComboBox";
            this.gardenTypeInputComboBox.Size = new System.Drawing.Size(139, 21);
            this.gardenTypeInputComboBox.TabIndex = 0;
            // 
            // gardenTypeLabel
            // 
            this.gardenTypeLabel.AutoSize = true;
            this.gardenTypeLabel.Location = new System.Drawing.Point(101, 27);
            this.gardenTypeLabel.Name = "gardenTypeLabel";
            this.gardenTypeLabel.Size = new System.Drawing.Size(45, 13);
            this.gardenTypeLabel.TabIndex = 1;
            this.gardenTypeLabel.Text = "Garden:";
            // 
            // itemNumberInputTextBox
            // 
            this.itemNumberInputTextBox.Location = new System.Drawing.Point(152, 51);
            this.itemNumberInputTextBox.Name = "itemNumberInputTextBox";
            this.itemNumberInputTextBox.Size = new System.Drawing.Size(139, 20);
            this.itemNumberInputTextBox.TabIndex = 2;
            // 
            // itemNumberLabel
            // 
            this.itemNumberLabel.AutoSize = true;
            this.itemNumberLabel.Location = new System.Drawing.Point(40, 54);
            this.itemNumberLabel.Name = "itemNumberLabel";
            this.itemNumberLabel.Size = new System.Drawing.Size(106, 13);
            this.itemNumberLabel.TabIndex = 3;
            this.itemNumberLabel.Text = "Entree/Item Number:";
            // 
            // quantityInputTextBox
            // 
            this.quantityInputTextBox.Location = new System.Drawing.Point(152, 77);
            this.quantityInputTextBox.Name = "quantityInputTextBox";
            this.quantityInputTextBox.Size = new System.Drawing.Size(139, 20);
            this.quantityInputTextBox.TabIndex = 4;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(97, 80);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(49, 13);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "Quantity:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(182, 113);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // flowersCostOutputLabel
            // 
            this.flowersCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowersCostOutputLabel.Location = new System.Drawing.Point(152, 151);
            this.flowersCostOutputLabel.Name = "flowersCostOutputLabel";
            this.flowersCostOutputLabel.Size = new System.Drawing.Size(139, 20);
            this.flowersCostOutputLabel.TabIndex = 7;
            this.flowersCostOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // baseAdjustedCostOutputLabel
            // 
            this.baseAdjustedCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baseAdjustedCostOutputLabel.Location = new System.Drawing.Point(152, 180);
            this.baseAdjustedCostOutputLabel.Name = "baseAdjustedCostOutputLabel";
            this.baseAdjustedCostOutputLabel.Size = new System.Drawing.Size(139, 20);
            this.baseAdjustedCostOutputLabel.TabIndex = 8;
            this.baseAdjustedCostOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // discountPercentOutputLabel
            // 
            this.discountPercentOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discountPercentOutputLabel.Location = new System.Drawing.Point(152, 209);
            this.discountPercentOutputLabel.Name = "discountPercentOutputLabel";
            this.discountPercentOutputLabel.Size = new System.Drawing.Size(139, 20);
            this.discountPercentOutputLabel.TabIndex = 9;
            this.discountPercentOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalPriceOutputLabel
            // 
            this.totalPriceOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceOutputLabel.Location = new System.Drawing.Point(152, 238);
            this.totalPriceOutputLabel.Name = "totalPriceOutputLabel";
            this.totalPriceOutputLabel.Size = new System.Drawing.Size(139, 20);
            this.totalPriceOutputLabel.TabIndex = 10;
            this.totalPriceOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowerCostLabel
            // 
            this.flowerCostLabel.AutoSize = true;
            this.flowerCostLabel.Location = new System.Drawing.Point(76, 155);
            this.flowerCostLabel.Name = "flowerCostLabel";
            this.flowerCostLabel.Size = new System.Drawing.Size(70, 13);
            this.flowerCostLabel.TabIndex = 11;
            this.flowerCostLabel.Text = "Flowers Cost:";
            // 
            // baseAdjustedCostLabel
            // 
            this.baseAdjustedCostLabel.AutoSize = true;
            this.baseAdjustedCostLabel.Location = new System.Drawing.Point(44, 184);
            this.baseAdjustedCostLabel.Name = "baseAdjustedCostLabel";
            this.baseAdjustedCostLabel.Size = new System.Drawing.Size(102, 13);
            this.baseAdjustedCostLabel.TabIndex = 12;
            this.baseAdjustedCostLabel.Text = "Base Adjusted Cost:";
            // 
            // discountPercentLabel
            // 
            this.discountPercentLabel.AutoSize = true;
            this.discountPercentLabel.Location = new System.Drawing.Point(54, 213);
            this.discountPercentLabel.Name = "discountPercentLabel";
            this.discountPercentLabel.Size = new System.Drawing.Size(92, 13);
            this.discountPercentLabel.TabIndex = 13;
            this.discountPercentLabel.Text = "Discount Percent:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(85, 242);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(61, 13);
            this.totalPriceLabel.TabIndex = 14;
            this.totalPriceLabel.Text = "Total Price:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 272);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.discountPercentLabel);
            this.Controls.Add(this.baseAdjustedCostLabel);
            this.Controls.Add(this.flowerCostLabel);
            this.Controls.Add(this.totalPriceOutputLabel);
            this.Controls.Add(this.discountPercentOutputLabel);
            this.Controls.Add(this.baseAdjustedCostOutputLabel);
            this.Controls.Add(this.flowersCostOutputLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.quantityInputTextBox);
            this.Controls.Add(this.itemNumberLabel);
            this.Controls.Add(this.itemNumberInputTextBox);
            this.Controls.Add(this.gardenTypeLabel);
            this.Controls.Add(this.gardenTypeInputComboBox);
            this.Name = "Form1";
            this.Text = "The Happy Garden Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox gardenTypeInputComboBox;
        private System.Windows.Forms.Label gardenTypeLabel;
        private System.Windows.Forms.TextBox itemNumberInputTextBox;
        private System.Windows.Forms.Label itemNumberLabel;
        private System.Windows.Forms.TextBox quantityInputTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label flowersCostOutputLabel;
        private System.Windows.Forms.Label baseAdjustedCostOutputLabel;
        private System.Windows.Forms.Label discountPercentOutputLabel;
        private System.Windows.Forms.Label totalPriceOutputLabel;
        private System.Windows.Forms.Label flowerCostLabel;
        private System.Windows.Forms.Label baseAdjustedCostLabel;
        private System.Windows.Forms.Label discountPercentLabel;
        private System.Windows.Forms.Label totalPriceLabel;
    }
}

