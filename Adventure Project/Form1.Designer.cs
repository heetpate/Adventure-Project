namespace Adventure_Project
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
            this.optionButton1 = new System.Windows.Forms.Button();
            this.optionButton3 = new System.Windows.Forms.Button();
            this.optionButton2 = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // optionButton1
            // 
            this.optionButton1.Location = new System.Drawing.Point(3, 280);
            this.optionButton1.Name = "optionButton1";
            this.optionButton1.Size = new System.Drawing.Size(196, 57);
            this.optionButton1.TabIndex = 1;
            this.optionButton1.Text = "option 1";
            this.optionButton1.UseVisualStyleBackColor = true;
            this.optionButton1.Click += new System.EventHandler(this.optionButton1_Click);
            // 
            // optionButton3
            // 
            this.optionButton3.Location = new System.Drawing.Point(528, 319);
            this.optionButton3.Name = "optionButton3";
            this.optionButton3.Size = new System.Drawing.Size(196, 57);
            this.optionButton3.TabIndex = 2;
            this.optionButton3.Text = "option 3";
            this.optionButton3.UseVisualStyleBackColor = true;
            this.optionButton3.Click += new System.EventHandler(this.optionButton3_Click);
            // 
            // optionButton2
            // 
            this.optionButton2.Location = new System.Drawing.Point(264, 325);
            this.optionButton2.Name = "optionButton2";
            this.optionButton2.Size = new System.Drawing.Size(196, 45);
            this.optionButton2.TabIndex = 3;
            this.optionButton2.Text = "option 2";
            this.optionButton2.UseVisualStyleBackColor = true;
            this.optionButton2.Click += new System.EventHandler(this.optionButton2_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(581, 112);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(51, 20);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "label2";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(556, 183);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(133, 76);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.optionButton2);
            this.Controls.Add(this.optionButton3);
            this.Controls.Add(this.optionButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button optionButton1;
        private System.Windows.Forms.Button optionButton3;
        private System.Windows.Forms.Button optionButton2;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button startButton;
    }
}

