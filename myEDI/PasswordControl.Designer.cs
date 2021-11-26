namespace myEDI
{
    partial class PasswordControl
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
            this.listBoxPassword = new System.Windows.Forms.ListBox();
            this.comboBoxPass = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonGenerateRandomPassword = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxLength = new System.Windows.Forms.ComboBox();
            this.comboBoxAmount = new System.Windows.Forms.ComboBox();
            this.checkBoxSCyes = new System.Windows.Forms.CheckBox();
            this.checkBoxDyes = new System.Windows.Forms.CheckBox();
            this.checkBoxSLyes = new System.Windows.Forms.CheckBox();
            this.checkBoxCLyes = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxCLno = new System.Windows.Forms.CheckBox();
            this.checkBoxSLno = new System.Windows.Forms.CheckBox();
            this.checkBoxDno = new System.Windows.Forms.CheckBox();
            this.checkBoxSCno = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 41);
            this.label4.TabIndex = 24;
            this.label4.Text = "Passwords";
            // 
            // listBoxPassword
            // 
            this.listBoxPassword.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxPassword.FormattingEnabled = true;
            this.listBoxPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBoxPassword.Location = new System.Drawing.Point(72, 415);
            this.listBoxPassword.Name = "listBoxPassword";
            this.listBoxPassword.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxPassword.Size = new System.Drawing.Size(595, 82);
            this.listBoxPassword.TabIndex = 56;
            // 
            // comboBoxPass
            // 
            this.comboBoxPass.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.comboBoxPass.FormattingEnabled = true;
            this.comboBoxPass.Items.AddRange(new object[] {
            "multiple",
            "single"});
            this.comboBoxPass.Location = new System.Drawing.Point(302, 114);
            this.comboBoxPass.Name = "comboBoxPass";
            this.comboBoxPass.Size = new System.Drawing.Size(95, 28);
            this.comboBoxPass.Sorted = true;
            this.comboBoxPass.TabIndex = 60;
            this.comboBoxPass.Text = "single";
            this.comboBoxPass.SelectedIndexChanged += new System.EventHandler(this.comboBoxPass_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label9.Location = new System.Drawing.Point(68, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 27);
            this.label9.TabIndex = 57;
            this.label9.Text = "Choose your password type:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonGenerateRandomPassword
            // 
            this.buttonGenerateRandomPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonGenerateRandomPassword.Location = new System.Drawing.Point(559, 323);
            this.buttonGenerateRandomPassword.Name = "buttonGenerateRandomPassword";
            this.buttonGenerateRandomPassword.Size = new System.Drawing.Size(136, 37);
            this.buttonGenerateRandomPassword.TabIndex = 58;
            this.buttonGenerateRandomPassword.TabStop = false;
            this.buttonGenerateRandomPassword.Text = "Go";
            this.buttonGenerateRandomPassword.UseVisualStyleBackColor = true;
            this.buttonGenerateRandomPassword.Click += new System.EventHandler(this.buttonGenerateRandomPassword_Click);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label15.Location = new System.Drawing.Point(213, 192);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 28);
            this.label15.TabIndex = 72;
            this.label15.Text = "Length: ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label14.Location = new System.Drawing.Point(213, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 28);
            this.label14.TabIndex = 71;
            this.label14.Text = "Amount:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxLength
            // 
            this.comboBoxLength.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.comboBoxLength.FormattingEnabled = true;
            this.comboBoxLength.Items.AddRange(new object[] {
            "16",
            "24",
            "32"});
            this.comboBoxLength.Location = new System.Drawing.Point(302, 193);
            this.comboBoxLength.Name = "comboBoxLength";
            this.comboBoxLength.Size = new System.Drawing.Size(56, 28);
            this.comboBoxLength.Sorted = true;
            this.comboBoxLength.TabIndex = 70;
            this.comboBoxLength.Text = "16";
            // 
            // comboBoxAmount
            // 
            this.comboBoxAmount.Enabled = false;
            this.comboBoxAmount.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.comboBoxAmount.FormattingEnabled = true;
            this.comboBoxAmount.Items.AddRange(new object[] {
            "10",
            "100",
            "1000"});
            this.comboBoxAmount.Location = new System.Drawing.Point(302, 153);
            this.comboBoxAmount.Name = "comboBoxAmount";
            this.comboBoxAmount.Size = new System.Drawing.Size(56, 28);
            this.comboBoxAmount.Sorted = true;
            this.comboBoxAmount.TabIndex = 69;
            this.comboBoxAmount.Text = "1";
            this.comboBoxAmount.SelectedIndexChanged += new System.EventHandler(this.comboBoxAmount_SelectedIndexChanged);
            // 
            // checkBoxSCyes
            // 
            this.checkBoxSCyes.AutoSize = true;
            this.checkBoxSCyes.Checked = true;
            this.checkBoxSCyes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSCyes.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBoxSCyes.Location = new System.Drawing.Point(589, 235);
            this.checkBoxSCyes.Name = "checkBoxSCyes";
            this.checkBoxSCyes.Size = new System.Drawing.Size(51, 24);
            this.checkBoxSCyes.TabIndex = 68;
            this.checkBoxSCyes.TabStop = false;
            this.checkBoxSCyes.Text = "Yes";
            this.checkBoxSCyes.UseVisualStyleBackColor = true;
            this.checkBoxSCyes.CheckedChanged += new System.EventHandler(this.checkBoxSCyes_CheckedChanged);
            // 
            // checkBoxDyes
            // 
            this.checkBoxDyes.AutoSize = true;
            this.checkBoxDyes.Checked = true;
            this.checkBoxDyes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDyes.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBoxDyes.Location = new System.Drawing.Point(589, 195);
            this.checkBoxDyes.Name = "checkBoxDyes";
            this.checkBoxDyes.Size = new System.Drawing.Size(51, 24);
            this.checkBoxDyes.TabIndex = 67;
            this.checkBoxDyes.TabStop = false;
            this.checkBoxDyes.Text = "Yes";
            this.checkBoxDyes.UseVisualStyleBackColor = true;
            this.checkBoxDyes.CheckedChanged += new System.EventHandler(this.checkBoxDyes_CheckedChanged);
            // 
            // checkBoxSLyes
            // 
            this.checkBoxSLyes.AutoSize = true;
            this.checkBoxSLyes.Checked = true;
            this.checkBoxSLyes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSLyes.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBoxSLyes.Location = new System.Drawing.Point(589, 155);
            this.checkBoxSLyes.Name = "checkBoxSLyes";
            this.checkBoxSLyes.Size = new System.Drawing.Size(51, 24);
            this.checkBoxSLyes.TabIndex = 66;
            this.checkBoxSLyes.TabStop = false;
            this.checkBoxSLyes.Text = "Yes";
            this.checkBoxSLyes.UseVisualStyleBackColor = true;
            this.checkBoxSLyes.CheckedChanged += new System.EventHandler(this.checkBoxSLyes_CheckedChanged);
            // 
            // checkBoxCLyes
            // 
            this.checkBoxCLyes.AutoSize = true;
            this.checkBoxCLyes.Checked = true;
            this.checkBoxCLyes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCLyes.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBoxCLyes.Location = new System.Drawing.Point(589, 115);
            this.checkBoxCLyes.Name = "checkBoxCLyes";
            this.checkBoxCLyes.Size = new System.Drawing.Size(51, 24);
            this.checkBoxCLyes.TabIndex = 65;
            this.checkBoxCLyes.TabStop = false;
            this.checkBoxCLyes.Text = "Yes";
            this.checkBoxCLyes.UseVisualStyleBackColor = true;
            this.checkBoxCLyes.CheckedChanged += new System.EventHandler(this.checkBoxCLyes_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.Location = new System.Drawing.Point(416, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 34);
            this.label1.TabIndex = 64;
            this.label1.Text = "Special characters:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.Location = new System.Drawing.Point(416, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 27);
            this.label3.TabIndex = 63;
            this.label3.Text = "Digits:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.Location = new System.Drawing.Point(416, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 21);
            this.label2.TabIndex = 62;
            this.label2.Text = "Small letters:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label5.Location = new System.Drawing.Point(416, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 23);
            this.label5.TabIndex = 61;
            this.label5.Text = "Capital letters:";
            // 
            // checkBoxCLno
            // 
            this.checkBoxCLno.AutoSize = true;
            this.checkBoxCLno.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBoxCLno.Location = new System.Drawing.Point(646, 115);
            this.checkBoxCLno.Name = "checkBoxCLno";
            this.checkBoxCLno.Size = new System.Drawing.Size(49, 24);
            this.checkBoxCLno.TabIndex = 73;
            this.checkBoxCLno.TabStop = false;
            this.checkBoxCLno.Text = "No";
            this.checkBoxCLno.UseVisualStyleBackColor = true;
            this.checkBoxCLno.CheckedChanged += new System.EventHandler(this.checkBoxCLno_CheckedChanged);
            // 
            // checkBoxSLno
            // 
            this.checkBoxSLno.AutoSize = true;
            this.checkBoxSLno.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBoxSLno.Location = new System.Drawing.Point(646, 155);
            this.checkBoxSLno.Name = "checkBoxSLno";
            this.checkBoxSLno.Size = new System.Drawing.Size(49, 24);
            this.checkBoxSLno.TabIndex = 74;
            this.checkBoxSLno.TabStop = false;
            this.checkBoxSLno.Text = "No";
            this.checkBoxSLno.UseVisualStyleBackColor = true;
            this.checkBoxSLno.CheckedChanged += new System.EventHandler(this.checkBoxSLno_CheckedChanged);
            // 
            // checkBoxDno
            // 
            this.checkBoxDno.AutoSize = true;
            this.checkBoxDno.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBoxDno.Location = new System.Drawing.Point(646, 195);
            this.checkBoxDno.Name = "checkBoxDno";
            this.checkBoxDno.Size = new System.Drawing.Size(49, 24);
            this.checkBoxDno.TabIndex = 75;
            this.checkBoxDno.TabStop = false;
            this.checkBoxDno.Text = "No";
            this.checkBoxDno.UseVisualStyleBackColor = true;
            this.checkBoxDno.CheckedChanged += new System.EventHandler(this.checkBoxDno_CheckedChanged);
            // 
            // checkBoxSCno
            // 
            this.checkBoxSCno.AutoSize = true;
            this.checkBoxSCno.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBoxSCno.Location = new System.Drawing.Point(646, 235);
            this.checkBoxSCno.Name = "checkBoxSCno";
            this.checkBoxSCno.Size = new System.Drawing.Size(49, 24);
            this.checkBoxSCno.TabIndex = 76;
            this.checkBoxSCno.TabStop = false;
            this.checkBoxSCno.Text = "No";
            this.checkBoxSCno.UseVisualStyleBackColor = true;
            this.checkBoxSCno.CheckedChanged += new System.EventHandler(this.checkBoxSCno_CheckedChanged);
            // 
            // PasswordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxSCno);
            this.Controls.Add(this.checkBoxDno);
            this.Controls.Add(this.checkBoxSLno);
            this.Controls.Add(this.checkBoxCLno);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBoxLength);
            this.Controls.Add(this.comboBoxAmount);
            this.Controls.Add(this.checkBoxSCyes);
            this.Controls.Add(this.checkBoxDyes);
            this.Controls.Add(this.checkBoxSLyes);
            this.Controls.Add(this.checkBoxCLyes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxPass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonGenerateRandomPassword);
            this.Controls.Add(this.listBoxPassword);
            this.Controls.Add(this.label4);
            this.Name = "PasswordControl";
            this.Size = new System.Drawing.Size(818, 500);
            this.Load += new System.EventHandler(this.PasswordControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxPassword;
        private System.Windows.Forms.ComboBox comboBoxPass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonGenerateRandomPassword;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxLength;
        private System.Windows.Forms.ComboBox comboBoxAmount;
        private System.Windows.Forms.CheckBox checkBoxSCyes;
        private System.Windows.Forms.CheckBox checkBoxDyes;
        private System.Windows.Forms.CheckBox checkBoxSLyes;
        private System.Windows.Forms.CheckBox checkBoxCLyes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxCLno;
        private System.Windows.Forms.CheckBox checkBoxSLno;
        private System.Windows.Forms.CheckBox checkBoxDno;
        private System.Windows.Forms.CheckBox checkBoxSCno;
    }
}
