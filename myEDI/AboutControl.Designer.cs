namespace myEDI
{
    partial class AboutControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTextMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 41);
            this.label4.TabIndex = 25;
            this.label4.Text = "About";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.Location = new System.Drawing.Point(68, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(633, 121);
            this.label3.TabIndex = 58;
            this.label3.Text = "If you have any suggestions or recommendations about the functionality of the app" +
    ",\r\nPlease feel free to send me an email with your ideas.\r\n\r\nBest regards,\r\nrafal" +
    ".adamczyk@dsv.com";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.Location = new System.Drawing.Point(68, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 44);
            this.label1.TabIndex = 59;
            this.label1.Text = "Enjoy using the app!";
            // 
            // buttonTextMe
            // 
            this.buttonTextMe.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.buttonTextMe.Location = new System.Drawing.Point(417, 315);
            this.buttonTextMe.Name = "buttonTextMe";
            this.buttonTextMe.Size = new System.Drawing.Size(284, 37);
            this.buttonTextMe.TabIndex = 60;
            this.buttonTextMe.TabStop = false;
            this.buttonTextMe.Text = "Share your feedback here.";
            this.buttonTextMe.UseVisualStyleBackColor = true;
            this.buttonTextMe.Click += new System.EventHandler(this.buttonTextMe_Click);
            // 
            // AboutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonTextMe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "AboutControl";
            this.Size = new System.Drawing.Size(817, 500);
            this.Load += new System.EventHandler(this.AboutControl2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTextMe;
    }
}
