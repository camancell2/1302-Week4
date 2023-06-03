namespace Q3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lightOffPictureBox = new System.Windows.Forms.PictureBox();
            lightOnPictureBox = new System.Windows.Forms.PictureBox();
            flipButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)lightOffPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lightOnPictureBox).BeginInit();
            SuspendLayout();
            // 
            // lightOffPictureBox
            // 
            lightOffPictureBox.BackgroundImage = (System.Drawing.Image)resources.GetObject("lightOffPictureBox.BackgroundImage");
            lightOffPictureBox.InitialImage = (System.Drawing.Image)resources.GetObject("lightOffPictureBox.InitialImage");
            lightOffPictureBox.Location = new System.Drawing.Point(75, 23);
            lightOffPictureBox.Name = "lightOffPictureBox";
            lightOffPictureBox.Size = new System.Drawing.Size(330, 441);
            lightOffPictureBox.TabIndex = 0;
            lightOffPictureBox.TabStop = false;
            // 
            // lightOnPictureBox
            // 
            lightOnPictureBox.Image = (System.Drawing.Image)resources.GetObject("lightOnPictureBox.Image");
            lightOnPictureBox.Location = new System.Drawing.Point(75, 23);
            lightOnPictureBox.Name = "lightOnPictureBox";
            lightOnPictureBox.Size = new System.Drawing.Size(330, 441);
            lightOnPictureBox.TabIndex = 1;
            lightOnPictureBox.TabStop = false;
            // 
            // flipButton
            // 
            flipButton.Location = new System.Drawing.Point(183, 470);
            flipButton.Name = "flipButton";
            flipButton.Size = new System.Drawing.Size(111, 38);
            flipButton.TabIndex = 2;
            flipButton.Text = "Flip";
            flipButton.UseVisualStyleBackColor = true;
            flipButton.Click += FlipButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(498, 629);
            Controls.Add(flipButton);
            Controls.Add(lightOnPictureBox);
            Controls.Add(lightOffPictureBox);
            Name = "Form1";
            Text = "Week 4 - Lab Q3";
            ((System.ComponentModel.ISupportInitialize)lightOffPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)lightOnPictureBox).EndInit();
            ResumeLayout(false);
        }

        private bool lightOn = true;

        private void Flip()
        {
            if (lightOn)
            {
                lightOnPictureBox.Visible = true;
                lightOffPictureBox.Visible = false;
            }
            else
            {
                lightOnPictureBox.Visible = false;
                lightOffPictureBox.Visible = true;
            }
        }

        private void FlipButton_Click(object sender, System.EventArgs e)
        {
            lightOn = !lightOn;
            Flip();
        }

        #endregion

        private System.Windows.Forms.PictureBox lightOffPictureBox;
        private System.Windows.Forms.PictureBox lightOnPictureBox;
        private System.Windows.Forms.Button flipButton;
    }
}
