namespace myEDI
{
    partial class FormsControl
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
            this.listBoxForms = new System.Windows.Forms.ListBox();
            this.buttonDeployDoc = new System.Windows.Forms.Button();
            this.buttonFAQ = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 41);
            this.label4.TabIndex = 24;
            this.label4.Text = "Forms";
            // 
            // listBoxForms
            // 
            this.listBoxForms.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxForms.FormattingEnabled = true;
            this.listBoxForms.Location = new System.Drawing.Point(72, 415);
            this.listBoxForms.Name = "listBoxForms";
            this.listBoxForms.Size = new System.Drawing.Size(595, 82);
            this.listBoxForms.TabIndex = 56;
            // 
            // buttonDeployDoc
            // 
            this.buttonDeployDoc.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.buttonDeployDoc.Location = new System.Drawing.Point(72, 141);
            this.buttonDeployDoc.Name = "buttonDeployDoc";
            this.buttonDeployDoc.Size = new System.Drawing.Size(284, 37);
            this.buttonDeployDoc.TabIndex = 61;
            this.buttonDeployDoc.TabStop = false;
            this.buttonDeployDoc.Text = "Deploy Doc";
            this.buttonDeployDoc.UseVisualStyleBackColor = true;
            // 
            // buttonFAQ
            // 
            this.buttonFAQ.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.buttonFAQ.Location = new System.Drawing.Point(72, 184);
            this.buttonFAQ.Name = "buttonFAQ";
            this.buttonFAQ.Size = new System.Drawing.Size(284, 37);
            this.buttonFAQ.TabIndex = 62;
            this.buttonFAQ.TabStop = false;
            this.buttonFAQ.Text = "FAQ to Requester (missing details.)";
            this.buttonFAQ.UseVisualStyleBackColor = true;
            this.buttonFAQ.Click += new System.EventHandler(this.buttonFAQ_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button2.Location = new System.Drawing.Point(72, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(284, 37);
            this.button2.TabIndex = 63;
            this.button2.TabStop = false;
            this.button2.Text = "Generic list deployment for Gentran";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonFAQ);
            this.Controls.Add(this.buttonDeployDoc);
            this.Controls.Add(this.listBoxForms);
            this.Controls.Add(this.label4);
            this.Name = "FormsControl";
            this.Size = new System.Drawing.Size(818, 500);
            this.Load += new System.EventHandler(this.FormsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxForms;
        private System.Windows.Forms.Button buttonDeployDoc;
        private System.Windows.Forms.Button buttonFAQ;
        private System.Windows.Forms.Button button2;
    }
}
