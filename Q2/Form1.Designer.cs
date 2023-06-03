using System.Windows.Forms;

namespace Q2
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
            numberOfOrganismsLabel = new System.Windows.Forms.Label();
            averageDailyIncreaseLabel = new System.Windows.Forms.Label();
            numberOfDaysLabel = new System.Windows.Forms.Label();
            numberOfOrganismsInput = new System.Windows.Forms.TextBox();
            averageDailyIncreaseInput = new System.Windows.Forms.TextBox();
            numberOfDaysInput = new System.Windows.Forms.TextBox();
            displayButton = new System.Windows.Forms.Button();
            outputListBox = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // numberOfOrganismsLabel
            // 
            numberOfOrganismsLabel.AutoSize = true;
            numberOfOrganismsLabel.Location = new System.Drawing.Point(40, 39);
            numberOfOrganismsLabel.Name = "numberOfOrganismsLabel";
            numberOfOrganismsLabel.Size = new System.Drawing.Size(125, 15);
            numberOfOrganismsLabel.TabIndex = 0;
            numberOfOrganismsLabel.Text = "Number of Organisms";
            // 
            // averageDailyIncreaseLabel
            // 
            averageDailyIncreaseLabel.AutoSize = true;
            averageDailyIncreaseLabel.Location = new System.Drawing.Point(40, 71);
            averageDailyIncreaseLabel.Name = "averageDailyIncreaseLabel";
            averageDailyIncreaseLabel.Size = new System.Drawing.Size(125, 15);
            averageDailyIncreaseLabel.TabIndex = 1;
            averageDailyIncreaseLabel.Text = "Average Daily Increase";
            // 
            // numberOfDaysLabel
            // 
            numberOfDaysLabel.AutoSize = true;
            numberOfDaysLabel.Location = new System.Drawing.Point(40, 105);
            numberOfDaysLabel.Name = "numberOfDaysLabel";
            numberOfDaysLabel.Size = new System.Drawing.Size(93, 15);
            numberOfDaysLabel.TabIndex = 2;
            numberOfDaysLabel.Text = "Number of Days";
            // 
            // numberOfOrganismsInput
            // 
            numberOfOrganismsInput.Location = new System.Drawing.Point(187, 36);
            numberOfOrganismsInput.Name = "numberOfOrganismsInput";
            numberOfOrganismsInput.Size = new System.Drawing.Size(100, 23);
            numberOfOrganismsInput.TabIndex = 3;
            // 
            // averageDailyIncreaseInput
            // 
            averageDailyIncreaseInput.Location = new System.Drawing.Point(187, 71);
            averageDailyIncreaseInput.Name = "averageDailyIncreaseInput";
            averageDailyIncreaseInput.Size = new System.Drawing.Size(100, 23);
            averageDailyIncreaseInput.TabIndex = 4;
            // 
            // numberOfDaysInput
            // 
            numberOfDaysInput.Location = new System.Drawing.Point(187, 102);
            numberOfDaysInput.Name = "numberOfDaysInput";
            numberOfDaysInput.Size = new System.Drawing.Size(100, 23);
            numberOfDaysInput.TabIndex = 5;
            // 
            // displayButton
            // 
            displayButton.Location = new System.Drawing.Point(40, 138);
            displayButton.Name = "displayButton";
            displayButton.Size = new System.Drawing.Size(75, 23);
            displayButton.TabIndex = 6;
            displayButton.Text = "Display";
            displayButton.UseVisualStyleBackColor = true;
            displayButton.Click += DisplayButton_Click;
            // 
            // outputListBox
            // 
            outputListBox.FormattingEnabled = true;
            outputListBox.ItemHeight = 15;
            outputListBox.Location = new System.Drawing.Point(40, 187);
            outputListBox.Name = "outputListBox";
            outputListBox.Size = new System.Drawing.Size(247, 214);
            outputListBox.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(342, 450);
            Controls.Add(outputListBox);
            Controls.Add(displayButton);
            Controls.Add(numberOfDaysInput);
            Controls.Add(averageDailyIncreaseInput);
            Controls.Add(numberOfOrganismsInput);
            Controls.Add(numberOfDaysLabel);
            Controls.Add(averageDailyIncreaseLabel);
            Controls.Add(numberOfOrganismsLabel);
            Name = "Form1";
            Text = "Week 4 - Lab Q2";
            ResumeLayout(false);
            PerformLayout();
        }

        private void DisplayButton_Click(object sender, System.EventArgs e)
        {
            double numberOfOrganisms, averageDailyIncrease, numberOfDays = 0.0;

            if (double.TryParse(numberOfOrganismsInput.Text, out numberOfOrganisms) &&
                double.TryParse(averageDailyIncreaseInput.Text, out averageDailyIncrease) &&
                double.TryParse(numberOfDaysInput.Text, out numberOfDays))
            {
                outputListBox.Items.Add("Day \t Avg Population");

                double sum = numberOfOrganisms;

                for (int i = 1; i <= numberOfDays; i++)
                {
                    outputListBox.Items.Add($"{i} \t {sum}");
                    sum = sum * (1 + averageDailyIncrease / 100);
                }
            }
            else
            {
                MessageBox.Show("Please ensure data inputted is in the form of numbers (decimals)");
            }
        }

        #endregion

        private System.Windows.Forms.Label numberOfOrganismsLabel;
        private System.Windows.Forms.Label averageDailyIncreaseLabel;
        private System.Windows.Forms.Label numberOfDaysLabel;
        private System.Windows.Forms.TextBox numberOfOrganismsInput;
        private System.Windows.Forms.TextBox averageDailyIncreaseInput;
        private System.Windows.Forms.TextBox numberOfDaysInput;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.ListBox outputListBox;
    }
}
