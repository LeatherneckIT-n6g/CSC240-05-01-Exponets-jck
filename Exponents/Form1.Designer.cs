namespace Exponents
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
            this.xInputTextBox = new System.Windows.Forms.TextBox();
            this.xInputLabel = new System.Windows.Forms.Label();
            this.xOutputLabel = new System.Windows.Forms.Label();
            this.xGoButton = new System.Windows.Forms.Button();
            this.xResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xInputTextBox
            // 
            this.xInputTextBox.Location = new System.Drawing.Point(198, 92);
            this.xInputTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xInputTextBox.Name = "xInputTextBox";
            this.xInputTextBox.Size = new System.Drawing.Size(132, 22);
            this.xInputTextBox.TabIndex = 0;
            // 
            // xInputLabel
            // 
            this.xInputLabel.AutoSize = true;
            this.xInputLabel.Location = new System.Drawing.Point(212, 21);
            this.xInputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xInputLabel.Name = "xInputLabel";
            this.xInputLabel.Size = new System.Drawing.Size(103, 16);
            this.xInputLabel.TabIndex = 3;
            this.xInputLabel.Text = "Enter an integer:";
            // 
            // xOutputLabel
            // 
            this.xOutputLabel.AutoSize = true;
            this.xOutputLabel.Location = new System.Drawing.Point(222, 423);
            this.xOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xOutputLabel.Name = "xOutputLabel";
            this.xOutputLabel.Size = new System.Drawing.Size(0, 16);
            this.xOutputLabel.TabIndex = 4;
            this.xOutputLabel.Visible = false;
            // 
            // xGoButton
            // 
            this.xGoButton.Location = new System.Drawing.Point(215, 212);
            this.xGoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xGoButton.Name = "xGoButton";
            this.xGoButton.Size = new System.Drawing.Size(100, 82);
            this.xGoButton.TabIndex = 6;
            this.xGoButton.Text = "Go!";
            this.xGoButton.UseVisualStyleBackColor = true;
            this.xGoButton.Click += new System.EventHandler(this.xGoButton_Click);
            // 
            // xResetButton
            // 
            this.xResetButton.Location = new System.Drawing.Point(215, 391);
            this.xResetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xResetButton.Name = "xResetButton";
            this.xResetButton.Size = new System.Drawing.Size(100, 28);
            this.xResetButton.TabIndex = 7;
            this.xResetButton.Text = "Reset";
            this.xResetButton.UseVisualStyleBackColor = true;
            this.xResetButton.Click += new System.EventHandler(this.xResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 483);
            this.Controls.Add(this.xResetButton);
            this.Controls.Add(this.xGoButton);
            this.Controls.Add(this.xOutputLabel);
            this.Controls.Add(this.xInputLabel);
            this.Controls.Add(this.xInputTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Exponents Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xInputTextBox;
        private System.Windows.Forms.Label xInputLabel;
        private System.Windows.Forms.Label xOutputLabel;
        private System.Windows.Forms.Button xGoButton;
        private System.Windows.Forms.Button xResetButton;
    }
}

