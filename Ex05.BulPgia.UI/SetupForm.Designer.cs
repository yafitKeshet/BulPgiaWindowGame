namespace Ex05.BoolPgia.UI
{
    partial class SetupForm
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonNumOfChances = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonStart.Location = new System.Drawing.Point(334, 146);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(214, 73);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonNumOfChances
            // 
            this.buttonNumOfChances.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonNumOfChances.Location = new System.Drawing.Point(38, 24);
            this.buttonNumOfChances.Name = "buttonNumOfChances";
            this.buttonNumOfChances.Size = new System.Drawing.Size(510, 56);
            this.buttonNumOfChances.TabIndex = 1;
            this.buttonNumOfChances.Text = "Number of chances: 4";
            this.buttonNumOfChances.UseVisualStyleBackColor = true;
            this.buttonNumOfChances.Click += new System.EventHandler(this.buttonNumOfChances_Click);
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 246);
            this.Controls.Add(this.buttonNumOfChances);
            this.Controls.Add(this.buttonStart);
            this.Name = "SetupForm";
            this.Text = "Bool Pgia";
            this.Load += new System.EventHandler(this.setupForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonNumOfChances;
    }
}