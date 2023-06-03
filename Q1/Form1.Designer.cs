using System.Windows.Forms;

namespace Q1
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
            vehicleSpeedInMphLabel = new System.Windows.Forms.Label();
            hoursTravelledLabel = new System.Windows.Forms.Label();
            vehiclesSpeedInMphInput = new System.Windows.Forms.TextBox();
            hoursTravelledInput = new System.Windows.Forms.TextBox();
            outputListBox = new System.Windows.Forms.ListBox();
            calculateButton = new System.Windows.Forms.Button();
            exitButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // vehicleSpeedInMphLabel
            // 
            vehicleSpeedInMphLabel.AutoSize = true;
            vehicleSpeedInMphLabel.Location = new System.Drawing.Point(62, 40);
            vehicleSpeedInMphLabel.Name = "vehicleSpeedInMphLabel";
            vehicleSpeedInMphLabel.Size = new System.Drawing.Size(120, 15);
            vehicleSpeedInMphLabel.TabIndex = 0;
            vehicleSpeedInMphLabel.Text = "Vehicle Speed in Mph";
            // 
            // hoursTravelledLabel
            // 
            hoursTravelledLabel.AutoSize = true;
            hoursTravelledLabel.Location = new System.Drawing.Point(94, 66);
            hoursTravelledLabel.Name = "hoursTravelledLabel";
            hoursTravelledLabel.Size = new System.Drawing.Size(88, 15);
            hoursTravelledLabel.TabIndex = 1;
            hoursTravelledLabel.Text = "Hours Travelled";
            // 
            // vehiclesSpeedInMphInput
            // 
            vehiclesSpeedInMphInput.Location = new System.Drawing.Point(188, 37);
            vehiclesSpeedInMphInput.Name = "vehiclesSpeedInMphInput";
            vehiclesSpeedInMphInput.Size = new System.Drawing.Size(100, 23);
            vehiclesSpeedInMphInput.TabIndex = 2;
            // 
            // hoursTravelledInput
            // 
            hoursTravelledInput.Location = new System.Drawing.Point(188, 63);
            hoursTravelledInput.Name = "hoursTravelledInput";
            hoursTravelledInput.Size = new System.Drawing.Size(100, 23);
            hoursTravelledInput.TabIndex = 3;
            // 
            // outputListBox
            // 
            outputListBox.FormattingEnabled = true;
            outputListBox.ItemHeight = 15;
            outputListBox.Location = new System.Drawing.Point(62, 92);
            outputListBox.Name = "outputListBox";
            outputListBox.Size = new System.Drawing.Size(226, 154);
            outputListBox.TabIndex = 4;
            // 
            // calculateButton
            // 
            calculateButton.Location = new System.Drawing.Point(94, 252);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new System.Drawing.Size(75, 23);
            calculateButton.TabIndex = 5;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += CalculateButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new System.Drawing.Point(188, 252);
            exitButton.Name = "exitButton";
            exitButton.Size = new System.Drawing.Size(75, 23);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += ExitButton_Click;

            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(355, 301);
            Controls.Add(exitButton);
            Controls.Add(calculateButton);
            Controls.Add(outputListBox);
            Controls.Add(hoursTravelledInput);
            Controls.Add(vehiclesSpeedInMphInput);
            Controls.Add(hoursTravelledLabel);
            Controls.Add(vehicleSpeedInMphLabel);
            Name = "Form1";
            Text = "Week 4 - Lab Q1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void CalculateButton_Click(object sender, System.EventArgs e)
        {
            double vehicleSpeedInMph, hoursTravelled;

            if (double.TryParse(vehiclesSpeedInMphInput.Text, out vehicleSpeedInMph) &&
                double.TryParse(hoursTravelledInput.Text, out hoursTravelled))
            {
                for (int i = 1; i <= hoursTravelled; i++)
                    outputListBox.Items.Add($"After hour {i} the distance is {vehicleSpeedInMph * i}");
            }
        }

        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private System.Windows.Forms.Label vehicleSpeedInMphLabel;
        private System.Windows.Forms.Label hoursTravelledLabel;
        private System.Windows.Forms.TextBox vehiclesSpeedInMphInput;
        private System.Windows.Forms.TextBox hoursTravelledInput;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}
