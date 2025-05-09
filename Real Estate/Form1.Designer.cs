namespace Real_Estate
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
            firstPicture = new PictureBox();
            secondPicture = new PictureBox();
            thirdPicture = new PictureBox();
            unit1Label = new Label();
            unit2Label = new Label();
            unit3Label = new Label();
            calculateButton = new Button();
            monthsOfPayment = new Label();
            amountPerMonth1 = new Label();
            monthsTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            amountPerMonth2 = new Label();
            amountPerMonth3 = new Label();
            ((System.ComponentModel.ISupportInitialize)firstPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secondPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)thirdPicture).BeginInit();
            SuspendLayout();
            // 
            // firstPicture
            // 
            firstPicture.Image = Properties.Resources.first;
            firstPicture.Location = new Point(74, 73);
            firstPicture.Name = "firstPicture";
            firstPicture.Size = new Size(125, 125);
            firstPicture.SizeMode = PictureBoxSizeMode.Zoom;
            firstPicture.TabIndex = 0;
            firstPicture.TabStop = false;
            // 
            // secondPicture
            // 
            secondPicture.Image = Properties.Resources.second;
            secondPicture.Location = new Point(318, 73);
            secondPicture.Name = "secondPicture";
            secondPicture.Size = new Size(125, 125);
            secondPicture.SizeMode = PictureBoxSizeMode.Zoom;
            secondPicture.TabIndex = 1;
            secondPicture.TabStop = false;
            // 
            // thirdPicture
            // 
            thirdPicture.Image = Properties.Resources.third;
            thirdPicture.Location = new Point(558, 73);
            thirdPicture.Name = "thirdPicture";
            thirdPicture.Size = new Size(125, 125);
            thirdPicture.SizeMode = PictureBoxSizeMode.Zoom;
            thirdPicture.TabIndex = 2;
            thirdPicture.TabStop = false;
            // 
            // unit1Label
            // 
            unit1Label.AutoSize = true;
            unit1Label.Font = new Font("Segoe UI", 9F);
            unit1Label.Location = new Point(74, 215);
            unit1Label.Name = "unit1Label";
            unit1Label.Size = new Size(48, 20);
            unit1Label.TabIndex = 3;
            unit1Label.Text = "Unit 1";
            // 
            // unit2Label
            // 
            unit2Label.AutoSize = true;
            unit2Label.Font = new Font("Segoe UI", 9F);
            unit2Label.Location = new Point(318, 215);
            unit2Label.Name = "unit2Label";
            unit2Label.Size = new Size(48, 20);
            unit2Label.TabIndex = 4;
            unit2Label.Text = "Unit 2";
            // 
            // unit3Label
            // 
            unit3Label.AutoSize = true;
            unit3Label.Font = new Font("Segoe UI", 9F);
            unit3Label.Location = new Point(558, 215);
            unit3Label.Name = "unit3Label";
            unit3Label.Size = new Size(48, 20);
            unit3Label.TabIndex = 5;
            unit3Label.Text = "Unit 3";
            // 
            // calculateButton
            // 
            calculateButton.BackColor = Color.CornflowerBlue;
            calculateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            calculateButton.ForeColor = SystemColors.ButtonHighlight;
            calculateButton.Location = new Point(515, 468);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(173, 36);
            calculateButton.TabIndex = 9;
            calculateButton.Text = "Calculate Payment";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // monthsOfPayment
            // 
            monthsOfPayment.AutoSize = true;
            monthsOfPayment.Location = new Point(369, 427);
            monthsOfPayment.Name = "monthsOfPayment";
            monthsOfPayment.Size = new Size(139, 20);
            monthsOfPayment.TabIndex = 10;
            monthsOfPayment.Text = "Months of Payment:";
            // 
            // amountPerMonth1
            // 
            amountPerMonth1.AutoSize = true;
            amountPerMonth1.Font = new Font("Segoe UI", 9F);
            amountPerMonth1.Location = new Point(74, 264);
            amountPerMonth1.Name = "amountPerMonth1";
            amountPerMonth1.Size = new Size(130, 20);
            amountPerMonth1.TabIndex = 11;
            amountPerMonth1.Text = "Monthly Payment: ";
            // 
            // monthsTextBox
            // 
            monthsTextBox.BackColor = Color.AliceBlue;
            monthsTextBox.Location = new Point(520, 424);
            monthsTextBox.Name = "monthsTextBox";
            monthsTextBox.Size = new Size(168, 27);
            monthsTextBox.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(74, 235);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 13;
            label1.Text = "₱3.3 million";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(318, 235);
            label2.Name = "label2";
            label2.Size = new Size(107, 23);
            label2.TabIndex = 14;
            label2.Text = "₱2.1 million";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(558, 235);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 15;
            label3.Text = "₱4.6 million";
            // 
            // amountPerMonth2
            // 
            amountPerMonth2.AutoSize = true;
            amountPerMonth2.Font = new Font("Segoe UI", 9F);
            amountPerMonth2.Location = new Point(318, 264);
            amountPerMonth2.Name = "amountPerMonth2";
            amountPerMonth2.Size = new Size(130, 20);
            amountPerMonth2.TabIndex = 16;
            amountPerMonth2.Text = "Monthly Payment: ";
            // 
            // amountPerMonth3
            // 
            amountPerMonth3.AutoSize = true;
            amountPerMonth3.Font = new Font("Segoe UI", 9F);
            amountPerMonth3.Location = new Point(558, 264);
            amountPerMonth3.Name = "amountPerMonth3";
            amountPerMonth3.Size = new Size(130, 20);
            amountPerMonth3.TabIndex = 17;
            amountPerMonth3.Text = "Monthly Payment: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(769, 554);
            Controls.Add(amountPerMonth3);
            Controls.Add(amountPerMonth2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(monthsTextBox);
            Controls.Add(amountPerMonth1);
            Controls.Add(monthsOfPayment);
            Controls.Add(calculateButton);
            Controls.Add(unit3Label);
            Controls.Add(unit2Label);
            Controls.Add(unit1Label);
            Controls.Add(thirdPicture);
            Controls.Add(secondPicture);
            Controls.Add(firstPicture);
            Name = "Form1";
            Text = "Condo Units";
            ((System.ComponentModel.ISupportInitialize)firstPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)secondPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)thirdPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox firstPicture;
        private PictureBox secondPicture;
        private PictureBox thirdPicture;
        private Label unit1Label;
        private Label unit2Label;
        private Label unit3Label;
        private Button calculateButton;
        private Label monthsOfPayment;
        private Label amountPerMonth1;
        private TextBox monthsTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label amountPerMonth2;
        private Label amountPerMonth3;
    }
}
