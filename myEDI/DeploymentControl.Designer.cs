namespace myEDI
{
    partial class DeploymentControl
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
            this.button_reports = new System.Windows.Forms.Button();
            this.button_resources = new System.Windows.Forms.Button();
            this.extractRT_button = new System.Windows.Forms.Button();
            this.button_logs = new System.Windows.Forms.Button();
            this.consoleQuery_button = new System.Windows.Forms.Button();
            this.checkBox_Query = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBoxSelectedEnv = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_local_deploy = new System.Windows.Forms.Button();
            this.checkBox_RT = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deployComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateNoteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_reports
            // 
            this.button_reports.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button_reports.Location = new System.Drawing.Point(540, 182);
            this.button_reports.Name = "button_reports";
            this.button_reports.Size = new System.Drawing.Size(132, 34);
            this.button_reports.TabIndex = 49;
            this.button_reports.TabStop = false;
            this.button_reports.Text = "Reports";
            this.button_reports.UseVisualStyleBackColor = true;
            // 
            // button_resources
            // 
            this.button_resources.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button_resources.Location = new System.Drawing.Point(540, 142);
            this.button_resources.Name = "button_resources";
            this.button_resources.Size = new System.Drawing.Size(132, 34);
            this.button_resources.TabIndex = 48;
            this.button_resources.TabStop = false;
            this.button_resources.Text = "Resources";
            this.button_resources.UseVisualStyleBackColor = true;
            // 
            // extractRT_button
            // 
            this.extractRT_button.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.extractRT_button.Location = new System.Drawing.Point(540, 222);
            this.extractRT_button.Name = "extractRT_button";
            this.extractRT_button.Size = new System.Drawing.Size(132, 34);
            this.extractRT_button.TabIndex = 43;
            this.extractRT_button.TabStop = false;
            this.extractRT_button.Text = "Extract RT";
            this.extractRT_button.UseVisualStyleBackColor = true;
            // 
            // button_logs
            // 
            this.button_logs.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button_logs.Location = new System.Drawing.Point(540, 300);
            this.button_logs.Name = "button_logs";
            this.button_logs.Size = new System.Drawing.Size(132, 34);
            this.button_logs.TabIndex = 47;
            this.button_logs.TabStop = false;
            this.button_logs.Text = "Logs";
            this.button_logs.UseVisualStyleBackColor = true;
            // 
            // consoleQuery_button
            // 
            this.consoleQuery_button.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.consoleQuery_button.Location = new System.Drawing.Point(540, 260);
            this.consoleQuery_button.Name = "consoleQuery_button";
            this.consoleQuery_button.Size = new System.Drawing.Size(132, 34);
            this.consoleQuery_button.TabIndex = 46;
            this.consoleQuery_button.TabStop = false;
            this.consoleQuery_button.Text = "Console query";
            this.consoleQuery_button.UseVisualStyleBackColor = true;
            // 
            // checkBox_Query
            // 
            this.checkBox_Query.AutoSize = true;
            this.checkBox_Query.Checked = true;
            this.checkBox_Query.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Query.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBox_Query.Location = new System.Drawing.Point(350, 299);
            this.checkBox_Query.Name = "checkBox_Query";
            this.checkBox_Query.Size = new System.Drawing.Size(51, 24);
            this.checkBox_Query.TabIndex = 45;
            this.checkBox_Query.TabStop = false;
            this.checkBox_Query.Text = "Yes";
            this.checkBox_Query.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label11.Location = new System.Drawing.Point(103, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(231, 33);
            this.label11.TabIndex = 44;
            this.label11.Text = "Create a console query:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // richTextBoxSelectedEnv
            // 
            this.richTextBoxSelectedEnv.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxSelectedEnv.Location = new System.Drawing.Point(256, 193);
            this.richTextBoxSelectedEnv.Name = "richTextBoxSelectedEnv";
            this.richTextBoxSelectedEnv.ReadOnly = true;
            this.richTextBoxSelectedEnv.Size = new System.Drawing.Size(145, 31);
            this.richTextBoxSelectedEnv.TabIndex = 41;
            this.richTextBoxSelectedEnv.TabStop = false;
            this.richTextBoxSelectedEnv.Text = "not selected";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label5.Location = new System.Drawing.Point(119, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 31);
            this.label5.TabIndex = 42;
            this.label5.Text = "Selected env.";
            // 
            // button_local_deploy
            // 
            this.button_local_deploy.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button_local_deploy.Location = new System.Drawing.Point(540, 104);
            this.button_local_deploy.Name = "button_local_deploy";
            this.button_local_deploy.Size = new System.Drawing.Size(132, 34);
            this.button_local_deploy.TabIndex = 40;
            this.button_local_deploy.TabStop = false;
            this.button_local_deploy.Text = "Storage";
            this.button_local_deploy.UseVisualStyleBackColor = true;
            // 
            // checkBox_RT
            // 
            this.checkBox_RT.AutoSize = true;
            this.checkBox_RT.Checked = true;
            this.checkBox_RT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_RT.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBox_RT.Location = new System.Drawing.Point(350, 259);
            this.checkBox_RT.Name = "checkBox_RT";
            this.checkBox_RT.Size = new System.Drawing.Size(51, 24);
            this.checkBox_RT.TabIndex = 39;
            this.checkBox_RT.TabStop = false;
            this.checkBox_RT.Text = "Yes";
            this.checkBox_RT.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label4.Location = new System.Drawing.Point(103, 259);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(231, 33);
            this.label4.TabIndex = 37;
            this.label4.Text = "Copy RT files to separate dirs:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // deployComboBox
            // 
            this.deployComboBox.AccessibleName = "";
            this.deployComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.deployComboBox.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.deployComboBox.FormattingEnabled = true;
            this.deployComboBox.Items.AddRange(new object[] {
            "QA only",
            "PROD only",
            "both - QA & PROD"});
            this.deployComboBox.Location = new System.Drawing.Point(188, 147);
            this.deployComboBox.Name = "deployComboBox";
            this.deployComboBox.Size = new System.Drawing.Size(213, 28);
            this.deployComboBox.TabIndex = 35;
            this.deployComboBox.TabStop = false;
            this.deployComboBox.Text = "QA only";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.Location = new System.Drawing.Point(68, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 27);
            this.label3.TabIndex = 36;
            this.label3.Text = "Please select the deployment environments:";
            // 
            // CreateNoteButton
            // 
            this.CreateNoteButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.CreateNoteButton.Location = new System.Drawing.Point(188, 341);
            this.CreateNoteButton.Name = "CreateNoteButton";
            this.CreateNoteButton.Size = new System.Drawing.Size(213, 33);
            this.CreateNoteButton.TabIndex = 38;
            this.CreateNoteButton.TabStop = false;
            this.CreateNoteButton.Text = "Create a note";
            this.CreateNoteButton.UseCompatibleTextRendering = true;
            this.CreateNoteButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 41);
            this.label1.TabIndex = 50;
            this.label1.Text = "Deployment";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.Location = new System.Drawing.Point(595, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 30);
            this.label2.TabIndex = 51;
            this.label2.Text = "Release week:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(728, 44);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(30, 30);
            this.richTextBox1.TabIndex = 52;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "00";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox2.Location = new System.Drawing.Point(728, 8);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(86, 30);
            this.richTextBox2.TabIndex = 54;
            this.richTextBox2.TabStop = false;
            this.richTextBox2.Text = "00";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label6.Location = new System.Drawing.Point(595, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 30);
            this.label6.TabIndex = 53;
            this.label6.Text = "Today is:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DeploymentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_reports);
            this.Controls.Add(this.button_resources);
            this.Controls.Add(this.extractRT_button);
            this.Controls.Add(this.button_logs);
            this.Controls.Add(this.consoleQuery_button);
            this.Controls.Add(this.checkBox_Query);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.richTextBoxSelectedEnv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_local_deploy);
            this.Controls.Add(this.checkBox_RT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deployComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CreateNoteButton);
            this.Name = "DeploymentControl";
            this.Size = new System.Drawing.Size(817, 406);
            this.Load += new System.EventHandler(this.MySecondCustmControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_reports;
        private System.Windows.Forms.Button button_resources;
        private System.Windows.Forms.Button extractRT_button;
        private System.Windows.Forms.Button button_logs;
        private System.Windows.Forms.Button consoleQuery_button;
        private System.Windows.Forms.CheckBox checkBox_Query;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richTextBoxSelectedEnv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_local_deploy;
        private System.Windows.Forms.CheckBox checkBox_RT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox deployComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateNoteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label6;
    }
}
