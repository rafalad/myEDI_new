namespace myEDI
{
    partial class AccountsControl
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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxLDAPno = new System.Windows.Forms.CheckBox();
            this.checkBoxLDAP = new System.Windows.Forms.CheckBox();
            this.checkBoxPass16 = new System.Windows.Forms.CheckBox();
            this.textBoxAddUserLDAP = new System.Windows.Forms.TextBox();
            this.checkBoxPass24 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonGoLDAP = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxLDAP = new System.Windows.Forms.ComboBox();
            this.checkBoxPass8 = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 41);
            this.label4.TabIndex = 24;
            this.label4.Text = "LDAP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Please enter your username (cus.xxxx)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Type of file:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.checkBoxLDAPno);
            this.groupBox2.Controls.Add(this.checkBoxLDAP);
            this.groupBox2.Controls.Add(this.checkBoxPass16);
            this.groupBox2.Controls.Add(this.textBoxAddUserLDAP);
            this.groupBox2.Controls.Add(this.checkBoxPass24);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonGoLDAP);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.comboBoxLDAP);
            this.groupBox2.Controls.Add(this.checkBoxPass8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(14, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 400);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            // 
            // checkBoxLDAPno
            // 
            this.checkBoxLDAPno.AutoSize = true;
            this.checkBoxLDAPno.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBoxLDAPno.Location = new System.Drawing.Point(305, 261);
            this.checkBoxLDAPno.Name = "checkBoxLDAPno";
            this.checkBoxLDAPno.Size = new System.Drawing.Size(49, 24);
            this.checkBoxLDAPno.TabIndex = 40;
            this.checkBoxLDAPno.TabStop = false;
            this.checkBoxLDAPno.Text = "No";
            this.checkBoxLDAPno.UseVisualStyleBackColor = true;
            // 
            // checkBoxLDAP
            // 
            this.checkBoxLDAP.AutoSize = true;
            this.checkBoxLDAP.Checked = true;
            this.checkBoxLDAP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLDAP.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBoxLDAP.Location = new System.Drawing.Point(391, 261);
            this.checkBoxLDAP.Name = "checkBoxLDAP";
            this.checkBoxLDAP.Size = new System.Drawing.Size(51, 24);
            this.checkBoxLDAP.TabIndex = 36;
            this.checkBoxLDAP.TabStop = false;
            this.checkBoxLDAP.Text = "Yes";
            this.checkBoxLDAP.UseVisualStyleBackColor = true;
            // 
            // checkBoxPass16
            // 
            this.checkBoxPass16.AutoSize = true;
            this.checkBoxPass16.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBoxPass16.Location = new System.Drawing.Point(252, 216);
            this.checkBoxPass16.Name = "checkBoxPass16";
            this.checkBoxPass16.Size = new System.Drawing.Size(44, 24);
            this.checkBoxPass16.TabIndex = 39;
            this.checkBoxPass16.TabStop = false;
            this.checkBoxPass16.Text = "16";
            this.checkBoxPass16.UseVisualStyleBackColor = true;
            // 
            // textBoxAddUserLDAP
            // 
            this.textBoxAddUserLDAP.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.textBoxAddUserLDAP.Location = new System.Drawing.Point(110, 131);
            this.textBoxAddUserLDAP.Name = "textBoxAddUserLDAP";
            this.textBoxAddUserLDAP.Size = new System.Drawing.Size(244, 26);
            this.textBoxAddUserLDAP.TabIndex = 4;
            // 
            // checkBoxPass24
            // 
            this.checkBoxPass24.AutoSize = true;
            this.checkBoxPass24.Checked = true;
            this.checkBoxPass24.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPass24.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBoxPass24.Location = new System.Drawing.Point(310, 215);
            this.checkBoxPass24.Name = "checkBoxPass24";
            this.checkBoxPass24.Size = new System.Drawing.Size(44, 24);
            this.checkBoxPass24.TabIndex = 24;
            this.checkBoxPass24.TabStop = false;
            this.checkBoxPass24.Text = "24";
            this.checkBoxPass24.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label12.Location = new System.Drawing.Point(35, 262);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(316, 49);
            this.label12.TabIndex = 36;
            this.label12.Text = "+ Word Doc credentials Form?";
            // 
            // buttonGoLDAP
            // 
            this.buttonGoLDAP.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.buttonGoLDAP.Location = new System.Drawing.Point(248, 330);
            this.buttonGoLDAP.Name = "buttonGoLDAP";
            this.buttonGoLDAP.Size = new System.Drawing.Size(136, 37);
            this.buttonGoLDAP.TabIndex = 24;
            this.buttonGoLDAP.TabStop = false;
            this.buttonGoLDAP.Text = "Go";
            this.buttonGoLDAP.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label14.Location = new System.Drawing.Point(35, 218);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 46);
            this.label14.TabIndex = 38;
            this.label14.Text = "Password length:";
            // 
            // comboBoxLDAP
            // 
            this.comboBoxLDAP.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.comboBoxLDAP.FormattingEnabled = true;
            this.comboBoxLDAP.Items.AddRange(new object[] {
            "New user",
            "Bulk user",
            "SSHKey user",
            "Modify user",
            "Delete user",
            "Remove SSHkey"});
            this.comboBoxLDAP.Location = new System.Drawing.Point(210, 174);
            this.comboBoxLDAP.Name = "comboBoxLDAP";
            this.comboBoxLDAP.Size = new System.Drawing.Size(144, 28);
            this.comboBoxLDAP.TabIndex = 5;
            this.comboBoxLDAP.Text = "New user";
            // 
            // checkBoxPass8
            // 
            this.checkBoxPass8.AutoSize = true;
            this.checkBoxPass8.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBoxPass8.Location = new System.Drawing.Point(210, 217);
            this.checkBoxPass8.Name = "checkBoxPass8";
            this.checkBoxPass8.Size = new System.Drawing.Size(36, 24);
            this.checkBoxPass8.TabIndex = 37;
            this.checkBoxPass8.TabStop = false;
            this.checkBoxPass8.Text = "8";
            this.checkBoxPass8.UseVisualStyleBackColor = true;
            // 
            // AccountsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "AccountsControl";
            this.Size = new System.Drawing.Size(817, 406);
            this.Load += new System.EventHandler(this.WorkplaceControl_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxLDAPno;
        private System.Windows.Forms.CheckBox checkBoxPass24;
        private System.Windows.Forms.CheckBox checkBoxPass16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBoxPass8;
        private System.Windows.Forms.CheckBox checkBoxLDAP;
        private System.Windows.Forms.ComboBox comboBoxLDAP;
        private System.Windows.Forms.Button buttonGoLDAP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxAddUserLDAP;
    }
}
