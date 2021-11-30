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
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_ldap = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxSRQno = new System.Windows.Forms.CheckBox();
            this.listBoxDeployment = new System.Windows.Forms.ListBox();
            this.checkBox_cl_both = new System.Windows.Forms.CheckBox();
            this.checkBox_cl_out = new System.Windows.Forms.CheckBox();
            this.checkBox_cl_in = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxChildID = new System.Windows.Forms.TextBox();
            this.buttonCreateCL = new System.Windows.Forms.Button();
            this.textBoxParentID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox_maps
            // 
            this.checkBox_maps.AutoSize = true;
            this.checkBox_maps.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBox_maps.Location = new System.Drawing.Point(192, 219);
            this.checkBox_maps.Name = "checkBox_maps";
            this.checkBox_maps.Size = new System.Drawing.Size(69, 24);
            this.checkBox_maps.TabIndex = 44;
            this.checkBox_maps.TabStop = false;
            this.checkBox_maps.Text = "Maps";
            this.checkBox_maps.UseVisualStyleBackColor = true;
            this.checkBox_maps.CheckedChanged += new System.EventHandler(this.checkBox_maps_CheckedChanged);
            // 
            // comboBox_setup
            // 
            this.comboBox_setup.FlatStyle = System.Windows.Forms.FlatStyle.System;
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
            this.comboBox_setup.Location = new System.Drawing.Point(267, 191);
            this.comboBox_setup.Name = "comboBox_setup";
            this.comboBox_setup.Size = new System.Drawing.Size(144, 28);
            this.comboBox_setup.Sorted = true;
            this.comboBox_setup.TabIndex = 40;
            this.comboBox_setup.Text = "CL both flows";
            // 
            // checkBoxSRQ
            // 
            this.checkBoxSRQ.AutoSize = true;
            this.checkBoxSRQ.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBoxSRQ.Location = new System.Drawing.Point(304, 327);
            this.checkBoxSRQ.Name = "checkBoxSRQ";
            this.checkBoxSRQ.Size = new System.Drawing.Size(51, 24);
            this.checkBoxSRQ.TabIndex = 38;
            this.checkBoxSRQ.TabStop = false;
            this.checkBoxSRQ.Text = "Yes";
            this.checkBoxSRQ.UseVisualStyleBackColor = true;
            this.checkBoxSRQ.CheckedChanged += new System.EventHandler(this.checkBoxSRQ_CheckedChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label13.Location = new System.Drawing.Point(68, 328);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(358, 31);
            this.label13.TabIndex = 38;
            this.label13.Text = "Attach the pre-Deploy Doc ?";
            // 
            // checkBox_other
            // 
            this.checkBox_other.AutoSize = true;
            this.checkBox_other.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBox_other.Location = new System.Drawing.Point(192, 294);
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
            this.CHWnumberField.Location = new System.Drawing.Point(225, 140);
            this.CHWnumberField.Name = "CHWnumberField";
            this.CHWnumberField.Size = new System.Drawing.Size(185, 20);
            this.CHWnumberField.TabIndex = 1;
            // 
            // SRQidField
            // 
            this.SRQidField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SRQidField.Location = new System.Drawing.Point(267, 165);
            this.SRQidField.Name = "SRQidField";
            this.SRQidField.Size = new System.Drawing.Size(144, 20);
            this.SRQidField.TabIndex = 2;
            this.SRQidField.TextChanged += new System.EventHandler(this.SRQidField_TextChanged_1);
            // 
            // checkBox_cl
            // 
            this.checkBox_cl.AutoSize = true;
            this.checkBox_cl.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBox_cl.Location = new System.Drawing.Point(192, 244);
            this.checkBox_cl.Name = "checkBox_cl";
            this.checkBox_cl.Size = new System.Drawing.Size(87, 24);
            this.checkBox_cl.TabIndex = 43;
            this.checkBox_cl.TabStop = false;
            this.checkBox_cl.Text = "Codelist";
            this.checkBox_cl.UseVisualStyleBackColor = true;
            this.checkBox_cl.CheckedChanged += new System.EventHandler(this.checkBox_cl_CheckedChanged);
            // 
            // CreateAnObject
            // 
            this.CreateAnObject.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.CreateAnObject.Location = new System.Drawing.Point(274, 362);
            this.CreateAnObject.Name = "CreateAnObject";
            this.CreateAnObject.Size = new System.Drawing.Size(136, 37);
            this.CreateAnObject.TabIndex = 18;
            this.CreateAnObject.TabStop = false;
            this.CreateAnObject.Text = "Go";
            this.CreateAnObject.UseVisualStyleBackColor = true;
            this.CreateAnObject.Click += new System.EventHandler(this.CreateAnObject_Click);
            // 
            // checkBox_setup
            // 
            this.checkBox_setup.AutoSize = true;
            this.checkBox_setup.Checked = true;
            this.checkBox_setup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_setup.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBox_setup.Location = new System.Drawing.Point(192, 194);
            this.checkBox_setup.Name = "checkBox_setup";
            this.checkBox_setup.Size = new System.Drawing.Size(68, 24);
            this.checkBox_setup.TabIndex = 42;
            this.checkBox_setup.TabStop = false;
            this.checkBox_setup.Text = "SETUP";
            this.checkBox_setup.UseVisualStyleBackColor = true;
            this.checkBox_setup.CheckedChanged += new System.EventHandler(this.checkBox_setup_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 41);
            this.label4.TabIndex = 24;
            this.label4.Text = "Workspace";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "SRQ / INC no. from Cherwell by copying:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Type:";
            // 
            // checkBox_ldap
            // 
            this.checkBox_ldap.AutoSize = true;
            this.checkBox_ldap.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBox_ldap.Location = new System.Drawing.Point(192, 269);
            this.checkBox_ldap.Name = "checkBox_ldap";
            this.checkBox_ldap.Size = new System.Drawing.Size(66, 24);
            this.checkBox_ldap.TabIndex = 48;
            this.checkBox_ldap.TabStop = false;
            this.checkBox_ldap.Text = "LDAP";
            this.checkBox_ldap.UseVisualStyleBackColor = true;
            this.checkBox_ldap.CheckedChanged += new System.EventHandler(this.checkBox_ldap_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.Location = new System.Drawing.Point(111, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "Ticket identity:";
            // 
            // checkBoxSRQno
            // 
            this.checkBoxSRQno.AutoSize = true;
            this.checkBoxSRQno.Checked = true;
            this.checkBoxSRQno.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSRQno.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBoxSRQno.Location = new System.Drawing.Point(361, 327);
            this.checkBoxSRQno.Name = "checkBoxSRQno";
            this.checkBoxSRQno.Size = new System.Drawing.Size(49, 24);
            this.checkBoxSRQno.TabIndex = 50;
            this.checkBoxSRQno.TabStop = false;
            this.checkBoxSRQno.Text = "No";
            this.checkBoxSRQno.UseVisualStyleBackColor = true;
            this.checkBoxSRQno.CheckedChanged += new System.EventHandler(this.checkBoxSRQno_CheckedChanged);
            // 
            // listBoxDeployment
            // 
            this.listBoxDeployment.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxDeployment.FormattingEnabled = true;
            this.listBoxDeployment.Location = new System.Drawing.Point(72, 415);
            this.listBoxDeployment.Name = "listBoxDeployment";
            this.listBoxDeployment.Size = new System.Drawing.Size(595, 82);
            this.listBoxDeployment.TabIndex = 56;
            this.listBoxDeployment.SelectedIndexChanged += new System.EventHandler(this.listBoxDeployment_SelectedIndexChanged);
            // 
            // checkBox_cl_both
            // 
            this.checkBox_cl_both.AutoSize = true;
            this.checkBox_cl_both.Checked = true;
            this.checkBox_cl_both.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_cl_both.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBox_cl_both.Location = new System.Drawing.Point(493, 221);
            this.checkBox_cl_both.Name = "checkBox_cl_both";
            this.checkBox_cl_both.Size = new System.Drawing.Size(62, 24);
            this.checkBox_cl_both.TabIndex = 41;
            this.checkBox_cl_both.TabStop = false;
            this.checkBox_cl_both.Text = "both";
            this.checkBox_cl_both.UseVisualStyleBackColor = true;
            this.checkBox_cl_both.CheckedChanged += new System.EventHandler(this.checkBox_cl_both_CheckedChanged);
            // 
            // checkBox_cl_out
            // 
            this.checkBox_cl_out.AutoSize = true;
            this.checkBox_cl_out.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBox_cl_out.Location = new System.Drawing.Point(493, 191);
            this.checkBox_cl_out.Name = "checkBox_cl_out";
            this.checkBox_cl_out.Size = new System.Drawing.Size(103, 24);
            this.checkBox_cl_out.TabIndex = 43;
            this.checkBox_cl_out.TabStop = false;
            this.checkBox_cl_out.Text = "Outbound";
            this.checkBox_cl_out.UseVisualStyleBackColor = true;
            this.checkBox_cl_out.CheckedChanged += new System.EventHandler(this.checkBox_cl_out_CheckedChanged);
            // 
            // checkBox_cl_in
            // 
            this.checkBox_cl_in.AutoSize = true;
            this.checkBox_cl_in.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBox_cl_in.Location = new System.Drawing.Point(493, 161);
            this.checkBox_cl_in.Name = "checkBox_cl_in";
            this.checkBox_cl_in.Size = new System.Drawing.Size(90, 24);
            this.checkBox_cl_in.TabIndex = 42;
            this.checkBox_cl_in.TabStop = false;
            this.checkBox_cl_in.Text = "Inbound";
            this.checkBox_cl_in.UseVisualStyleBackColor = true;
            this.checkBox_cl_in.CheckedChanged += new System.EventHandler(this.checkBox_cl_in_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 41);
            this.label1.TabIndex = 58;
            this.label1.Text = "Code lists for setups";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(455, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "Flow direction:";
            // 
            // textBoxChildID
            // 
            this.textBoxChildID.Location = new System.Drawing.Point(585, 298);
            this.textBoxChildID.Name = "textBoxChildID";
            this.textBoxChildID.Size = new System.Drawing.Size(187, 20);
            this.textBoxChildID.TabIndex = 61;
            this.textBoxChildID.TextChanged += new System.EventHandler(this.textBoxChildID_TextChanged);
            // 
            // buttonCreateCL
            // 
            this.buttonCreateCL.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.buttonCreateCL.Location = new System.Drawing.Point(636, 362);
            this.buttonCreateCL.Name = "buttonCreateCL";
            this.buttonCreateCL.Size = new System.Drawing.Size(136, 37);
            this.buttonCreateCL.TabIndex = 62;
            this.buttonCreateCL.Text = "Create";
            this.buttonCreateCL.UseVisualStyleBackColor = true;
            this.buttonCreateCL.Click += new System.EventHandler(this.buttonCreateCL_Click);
            // 
            // textBoxParentID
            // 
            this.textBoxParentID.Location = new System.Drawing.Point(585, 263);
            this.textBoxParentID.Name = "textBoxParentID";
            this.textBoxParentID.Size = new System.Drawing.Size(187, 20);
            this.textBoxParentID.TabIndex = 60;
            this.textBoxParentID.TextChanged += new System.EventHandler(this.textBoxParentID_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(455, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 65;
            this.label9.Text = "Parent name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(466, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 66;
            this.label10.Text = "Child name:";
            // 
            // WorkplaceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxChildID);
            this.Controls.Add(this.buttonCreateCL);
            this.Controls.Add(this.textBoxParentID);
            this.Controls.Add(this.checkBox_cl_both);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox_cl_out);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_cl_in);
            this.Controls.Add(this.listBoxDeployment);
            this.Controls.Add(this.checkBoxSRQno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox_ldap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_maps);
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
            this.Name = "WorkplaceControl";
            this.Size = new System.Drawing.Size(818, 500);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_ldap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxSRQno;
        private System.Windows.Forms.ListBox listBoxDeployment;
        private System.Windows.Forms.CheckBox checkBox_cl_both;
        private System.Windows.Forms.CheckBox checkBox_cl_out;
        private System.Windows.Forms.CheckBox checkBox_cl_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxChildID;
        private System.Windows.Forms.Button buttonCreateCL;
        private System.Windows.Forms.TextBox textBoxParentID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}
