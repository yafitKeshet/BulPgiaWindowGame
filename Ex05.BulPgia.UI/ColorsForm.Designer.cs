namespace Ex05.BoolPgia.UI
{
    partial class ColorsForm
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
            this.purpleButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.lightBlueButton = new System.Windows.Forms.Button();
            this.whiteButton = new System.Windows.Forms.Button();
            this.darkRedButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // purpleButton
            // 
            this.purpleButton.BackColor = System.Drawing.Color.Fuchsia;
            this.purpleButton.ForeColor = System.Drawing.Color.Black;
            this.purpleButton.Location = new System.Drawing.Point(16, 12);
            this.purpleButton.Name = "purpleButton";
            this.purpleButton.Size = new System.Drawing.Size(60, 60);
            this.purpleButton.TabIndex = 0;
            this.purpleButton.UseVisualStyleBackColor = false;
            this.purpleButton.Click += new System.EventHandler(this.button_Click);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.ForeColor = System.Drawing.Color.Black;
            this.redButton.Location = new System.Drawing.Point(84, 12);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(60, 60);
            this.redButton.TabIndex = 1;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.button_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.LawnGreen;
            this.greenButton.ForeColor = System.Drawing.Color.Black;
            this.greenButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.greenButton.Location = new System.Drawing.Point(150, 12);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(60, 60);
            this.greenButton.TabIndex = 2;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.button_Click);
            // 
            // lightBlueButton
            // 
            this.lightBlueButton.BackColor = System.Drawing.Color.Cyan;
            this.lightBlueButton.ForeColor = System.Drawing.Color.Black;
            this.lightBlueButton.Location = new System.Drawing.Point(216, 12);
            this.lightBlueButton.Name = "lightBlueButton";
            this.lightBlueButton.Size = new System.Drawing.Size(60, 60);
            this.lightBlueButton.TabIndex = 3;
            this.lightBlueButton.UseVisualStyleBackColor = false;
            this.lightBlueButton.Click += new System.EventHandler(this.button_Click);
            // 
            // whiteButton
            // 
            this.whiteButton.BackColor = System.Drawing.Color.White;
            this.whiteButton.ForeColor = System.Drawing.Color.Black;
            this.whiteButton.Location = new System.Drawing.Point(216, 81);
            this.whiteButton.Name = "whiteButton";
            this.whiteButton.Size = new System.Drawing.Size(60, 60);
            this.whiteButton.TabIndex = 7;
            this.whiteButton.UseVisualStyleBackColor = false;
            this.whiteButton.Click += new System.EventHandler(this.button_Click);
            // 
            // darkRedButton
            // 
            this.darkRedButton.BackColor = System.Drawing.Color.Maroon;
            this.darkRedButton.ForeColor = System.Drawing.Color.Black;
            this.darkRedButton.Location = new System.Drawing.Point(150, 81);
            this.darkRedButton.Name = "darkRedButton";
            this.darkRedButton.Size = new System.Drawing.Size(60, 60);
            this.darkRedButton.TabIndex = 6;
            this.darkRedButton.UseVisualStyleBackColor = false;
            this.darkRedButton.Click += new System.EventHandler(this.button_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.ForeColor = System.Drawing.Color.Black;
            this.yellowButton.Location = new System.Drawing.Point(84, 81);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(60, 60);
            this.yellowButton.TabIndex = 5;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.button_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.ForeColor = System.Drawing.Color.Black;
            this.blueButton.Location = new System.Drawing.Point(18, 78);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(60, 60);
            this.blueButton.TabIndex = 4;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.button_Click);
            // 
            // ColorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 153);
            this.Controls.Add(this.whiteButton);
            this.Controls.Add(this.darkRedButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.lightBlueButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.purpleButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ColorsForm";
            this.Text = "Pick A Color:";
            this.Load += new System.EventHandler(this.colorsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button purpleButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button lightBlueButton;
        private System.Windows.Forms.Button whiteButton;
        private System.Windows.Forms.Button darkRedButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button blueButton;
    }
}