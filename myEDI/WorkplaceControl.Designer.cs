namespace myEDI
{
    partial class WorkplaceControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkplaceControl));
            this.checkBox_maps = new System.Windows.Forms.CheckBox();
            this.comboBox_setup = new System.Windows.Forms.ComboBox();
            this.checkBoxSRQ = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBox_other = new System.Windows.Forms.CheckBox();
            this.CHWnumberField = new System.Windows.Forms.TextBox();
            this.SRQidField = new System.Windows.Forms.TextBox();
            this.checkBox_cl = new System.Windows.Forms.CheckBox();
            this.CreateAnObject = new System.Windows.Forms.Button();
            this.checkBox_setup = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_ldap = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox_maps
            // 
            this.checkBox_maps.AutoSize = true;
            this.checkBox_maps.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBox_maps.Location = new System.Drawing.Point(190, 265);
            this.checkBox_maps.Name = "checkBox_maps";
            this.checkBox_maps.Size = new System.Drawing.Size(69, 24);
            this.checkBox_maps.TabIndex = 44;
            this.checkBox_maps.TabStop = false;
            this.checkBox_maps.Text = "Maps";
            this.checkBox_maps.UseVisualStyleBackColor = true;
            // 
            // comboBox_setup
            // 
            this.comboBox_setup.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.comboBox_setup.FormattingEnabled = true;
            this.comboBox_setup.Items.AddRange(new object[] {
            "CL both flows",
            "CL in",
            "CL out",
            "CW both flows",
            "CW in",
            "CW out",
            "CW1 both flows",
            "CW1 in",
            "CW1 out",
            "myDSV",
            "other",
            "Passthrough"});
            this.comboBox_setup.Location = new System.Drawing.Point(302, 238);
            this.comboBox_setup.Name = "comboBox_setup";
            this.comboBox_setup.Size = new System.Drawing.Size(144, 28);
            this.comboBox_setup.Sorted = true;
            this.comboBox_setup.TabIndex = 40;
            this.comboBox_setup.Text = "CL both flows";
            // 
            // checkBoxSRQ
            // 
            this.checkBoxSRQ.AutoSize = true;
            this.checkBoxSRQ.Checked = true;
            this.checkBoxSRQ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSRQ.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBoxSRQ.Location = new System.Drawing.Point(695, 299);
            this.checkBoxSRQ.Name = "checkBoxSRQ";
            this.checkBoxSRQ.Size = new System.Drawing.Size(51, 24);
            this.checkBoxSRQ.TabIndex = 38;
            this.checkBoxSRQ.TabStop = false;
            this.checkBoxSRQ.Text = "Yes";
            this.checkBoxSRQ.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label13.Location = new System.Drawing.Point(502, 299);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(213, 21);
            this.label13.TabIndex = 38;
            this.label13.Text = "+ Deploy Request Form?";
            // 
            // checkBox_other
            // 
            this.checkBox_other.AutoSize = true;
            this.checkBox_other.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBox_other.Location = new System.Drawing.Point(190, 340);
            this.checkBox_other.Name = "checkBox_other";
            this.checkBox_other.Size = new System.Drawing.Size(70, 24);
            this.checkBox_other.TabIndex = 41;
            this.checkBox_other.TabStop = false;
            this.checkBox_other.Text = "Other";
            this.checkBox_other.UseVisualStyleBackColor = true;
            this.checkBox_other.CheckedChanged += new System.EventHandler(this.checkBox_other_CheckedChanged);
            // 
            // CHWnumberField
            // 
            this.CHWnumberField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CHWnumberField.Location = new System.Drawing.Point(110, 133);
            this.CHWnumberField.Name = "CHWnumberField";
            this.CHWnumberField.Size = new System.Drawing.Size(244, 20);
            this.CHWnumberField.TabIndex = 1;
            // 
            // SRQidField
            // 
            this.SRQidField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SRQidField.Location = new System.Drawing.Point(110, 198);
            this.SRQidField.Name = "SRQidField";
            this.SRQidField.Size = new System.Drawing.Size(244, 20);
            this.SRQidField.TabIndex = 2;
            // 
            // checkBox_cl
            // 
            this.checkBox_cl.AutoSize = true;
            this.checkBox_cl.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBox_cl.Location = new System.Drawing.Point(190, 290);
            this.checkBox_cl.Name = "checkBox_cl";
            this.checkBox_cl.Size = new System.Drawing.Size(87, 24);
            this.checkBox_cl.TabIndex = 43;
            this.checkBox_cl.TabStop = false;
            this.checkBox_cl.Text = "Codelist";
            this.checkBox_cl.UseVisualStyleBackColor = true;
            // 
            // CreateAnObject
            // 
            this.CreateAnObject.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.CreateAnObject.Location = new System.Drawing.Point(610, 340);
            this.CreateAnObject.Name = "CreateAnObject";
            this.CreateAnObject.Size = new System.Drawing.Size(136, 37);
            this.CreateAnObject.TabIndex = 18;
            this.CreateAnObject.TabStop = false;
            this.CreateAnObject.Text = "Go";
            this.CreateAnObject.UseVisualStyleBackColor = true;
            // 
            // checkBox_setup
            // 
            this.checkBox_setup.AutoSize = true;
            this.checkBox_setup.Checked = true;
            this.checkBox_setup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_setup.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBox_setup.Location = new System.Drawing.Point(190, 240);
            this.checkBox_setup.Name = "checkBox_setup";
            this.checkBox_setup.Size = new System.Drawing.Size(68, 24);
            this.checkBox_setup.TabIndex = 42;
            this.checkBox_setup.TabStop = false;
            this.checkBox_setup.Text = "SETUP";
            this.checkBox_setup.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 41);
            this.label4.TabIndex = 24;
            this.label4.Text = "Workspace";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "SRQ / INC no. from Cherwell by copying:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Ticket name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Type of dir for:";
            // 
            // checkBox_ldap
            // 
            this.checkBox_ldap.AutoSize = true;
            this.checkBox_ldap.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBox_ldap.Location = new System.Drawing.Point(190, 315);
            this.checkBox_ldap.Name = "checkBox_ldap";
            this.checkBox_ldap.Size = new System.Drawing.Size(66, 24);
            this.checkBox_ldap.TabIndex = 48;
            this.checkBox_ldap.TabStop = false;
            this.checkBox_ldap.Text = "LDAP";
            this.checkBox_ldap.UseVisualStyleBackColor = true;
            // 
            // workplaceCustmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox_ldap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_maps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_setup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxSRQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.checkBox_other);
            this.Controls.Add(this.SRQidField);
            this.Controls.Add(this.CHWnumberField);
            this.Controls.Add(this.checkBox_cl);
            this.Controls.Add(this.checkBox_setup);
            this.Controls.Add(this.CreateAnObject);
            this.Name = "workplaceControl";
            this.Size = new System.Drawing.Size(817, 406);
            this.Load += new System.EventHandler(this.WorkplaceControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox_maps;
        private System.Windows.Forms.ComboBox comboBox_setup;
        private System.Windows.Forms.CheckBox checkBoxSRQ;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBox_other;
        private System.Windows.Forms.TextBox CHWnumberField;
        private System.Windows.Forms.TextBox SRQidField;
        private System.Windows.Forms.CheckBox checkBox_cl;
        private System.Windows.Forms.Button CreateAnObject;
        private System.Windows.Forms.CheckBox checkBox_setup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_ldap;
    }
}
