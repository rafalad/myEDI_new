namespace myEDI
{
    partial class FirstCustomControl
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
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(680, 132);
            this.label4.TabIndex = 0;
            this.label4.Text = "► Keep local order in working with tickets\r\n► Streamline your deployment process\r" +
    "\n► Create LDAP user accounts and documentation\r\n► Generate passwords and forms";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FirstCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Name = "FirstCustomControl";
            this.Size = new System.Drawing.Size(817, 423);
            this.Load += new System.EventHandler(this.FirstCustomControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
    }
}
