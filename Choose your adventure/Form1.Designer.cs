namespace Choose_your_adventure
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.option1 = new System.Windows.Forms.Label();
            this.option1Button = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.option2 = new System.Windows.Forms.Label();
            this.option3Button = new System.Windows.Forms.Button();
            this.option3 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(12, 2);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(776, 139);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // option1
            // 
            this.option1.ForeColor = System.Drawing.Color.White;
            this.option1.Location = new System.Drawing.Point(93, 407);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(302, 47);
            this.option1.TabIndex = 2;
            this.option1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // option1Button
            // 
            this.option1Button.Location = new System.Drawing.Point(12, 407);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(75, 47);
            this.option1Button.TabIndex = 3;
            this.option1Button.Text = "button1";
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // option2Button
            // 
            this.option2Button.Location = new System.Drawing.Point(713, 407);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(75, 47);
            this.option2Button.TabIndex = 4;
            this.option2Button.Text = "button2";
            this.option2Button.UseVisualStyleBackColor = true;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option2
            // 
            this.option2.ForeColor = System.Drawing.Color.White;
            this.option2.Location = new System.Drawing.Point(405, 407);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(302, 47);
            this.option2.TabIndex = 5;
            this.option2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // option3Button
            // 
            this.option3Button.Location = new System.Drawing.Point(12, 470);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(75, 47);
            this.option3Button.TabIndex = 6;
            this.option3Button.Text = "button3";
            this.option3Button.UseVisualStyleBackColor = true;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // option3
            // 
            this.option3.ForeColor = System.Drawing.Color.White;
            this.option3.Location = new System.Drawing.Point(93, 470);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(306, 47);
            this.option3.TabIndex = 7;
            this.option3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Location = new System.Drawing.Point(185, 144);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(405, 260);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.outputLabel);
            this.Name = "Form1";
            this.Text = "Choose your Adventure!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label option1;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Label option2;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Label option3;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

