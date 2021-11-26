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
            this.button_local_deploy = new System.Windows.Forms.Button();
            this.checkBox_RT = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deployComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateNoteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxWeek = new System.Windows.Forms.RichTextBox();
            this.richTextBoxToday = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxDeployment = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_reports
            // 
            this.button_reports.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button_reports.Location = new System.Drawing.Point(443, 273);
            this.button_reports.Name = "button_reports";
            this.button_reports.Size = new System.Drawing.Size(132, 34);
            this.button_reports.TabIndex = 49;
            this.button_reports.TabStop = false;
            this.button_reports.Text = "Reports";
            this.button_reports.UseVisualStyleBackColor = true;
            this.button_reports.Click += new System.EventHandler(this.button_reports_Click);
            // 
            // button_resources
            // 
            this.button_resources.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button_resources.Location = new System.Drawing.Point(443, 193);
            this.button_resources.Name = "button_resources";
            this.button_resources.Size = new System.Drawing.Size(132, 34);
            this.button_resources.TabIndex = 48;
            this.button_resources.TabStop = false;
            this.button_resources.Text = "Resources";
            this.button_resources.UseVisualStyleBackColor = true;
            this.button_resources.Click += new System.EventHandler(this.button_resources_Click);
            // 
            // extractRT_button
            // 
            this.extractRT_button.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.extractRT_button.Location = new System.Drawing.Point(443, 153);
            this.extractRT_button.Name = "extractRT_button";
            this.extractRT_button.Size = new System.Drawing.Size(132, 34);
            this.extractRT_button.TabIndex = 43;
            this.extractRT_button.TabStop = false;
            this.extractRT_button.Text = "Extract RT";
            this.extractRT_button.UseVisualStyleBackColor = true;
            this.extractRT_button.Click += new System.EventHandler(this.extractRT_button_Click);
            // 
            // button_logs
            // 
            this.button_logs.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button_logs.Location = new System.Drawing.Point(443, 313);
            this.button_logs.Name = "button_logs";
            this.button_logs.Size = new System.Drawing.Size(132, 34);
            this.button_logs.TabIndex = 47;
            this.button_logs.TabStop = false;
            this.button_logs.Text = "Logs";
            this.button_logs.UseVisualStyleBackColor = true;
            this.button_logs.Click += new System.EventHandler(this.button_logs_Click);
            // 
            // consoleQuery_button
            // 
            this.consoleQuery_button.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.consoleQuery_button.Location = new System.Drawing.Point(443, 233);
            this.consoleQuery_button.Name = "consoleQuery_button";
            this.consoleQuery_button.Size = new System.Drawing.Size(132, 34);
            this.consoleQuery_button.TabIndex = 46;
            this.consoleQuery_button.TabStop = false;
            this.consoleQuery_button.Text = "Console query";
            this.consoleQuery_button.UseVisualStyleBackColor = true;
            this.consoleQuery_button.Click += new System.EventHandler(this.consoleQuery_button_Click);
            // 
            // checkBox_Query
            // 
            this.checkBox_Query.AutoSize = true;
            this.checkBox_Query.Checked = true;
            this.checkBox_Query.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Query.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBox_Query.Location = new System.Drawing.Point(351, 233);
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
            this.label11.Location = new System.Drawing.Point(104, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(232, 23);
            this.label11.TabIndex = 44;
            this.label11.Text = "Create a console query:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button_local_deploy
            // 
            this.button_local_deploy.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button_local_deploy.Location = new System.Drawing.Point(443, 113);
            this.button_local_deploy.Name = "button_local_deploy";
            this.button_local_deploy.Size = new System.Drawing.Size(132, 34);
            this.button_local_deploy.TabIndex = 40;
            this.button_local_deploy.TabStop = false;
            this.button_local_deploy.Text = "Storage";
            this.button_local_deploy.UseVisualStyleBackColor = true;
            this.button_local_deploy.Click += new System.EventHandler(this.button_local_deploy_Click);
            // 
            // checkBox_RT
            // 
            this.checkBox_RT.AutoSize = true;
            this.checkBox_RT.Checked = true;
            this.checkBox_RT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_RT.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.checkBox_RT.Location = new System.Drawing.Point(351, 193);
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
            this.label4.Location = new System.Drawing.Point(104, 193);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(232, 35);
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
            this.label3.Size = new System.Drawing.Size(334, 27);
            this.label3.TabIndex = 36;
            this.label3.Text = "Please select the deployment environments:";
            // 
            // CreateNoteButton
            // 
            this.CreateNoteButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.CreateNoteButton.Location = new System.Drawing.Point(189, 275);
            this.CreateNoteButton.Name = "CreateNoteButton";
            this.CreateNoteButton.Size = new System.Drawing.Size(213, 33);
            this.CreateNoteButton.TabIndex = 38;
            this.CreateNoteButton.TabStop = false;
            this.CreateNoteButton.Text = "Create a note";
            this.CreateNoteButton.UseCompatibleTextRendering = true;
            this.CreateNoteButton.UseVisualStyleBackColor = true;
            this.CreateNoteButton.Click += new System.EventHandler(this.CreateNoteButton_Click);
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
            this.label2.Location = new System.Drawing.Point(549, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 37);
            this.label2.TabIndex = 51;
            this.label2.Text = "Release week:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // richTextBoxWeek
            // 
            this.richTextBoxWeek.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxWeek.Location = new System.Drawing.Point(674, 58);
            this.richTextBoxWeek.Name = "richTextBoxWeek";
            this.richTextBoxWeek.ReadOnly = true;
            this.richTextBoxWeek.Size = new System.Drawing.Size(30, 30);
            this.richTextBoxWeek.TabIndex = 52;
            this.richTextBoxWeek.TabStop = false;
            this.richTextBoxWeek.Text = "00";
            // 
            // richTextBoxToday
            // 
            this.richTextBoxToday.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxToday.Location = new System.Drawing.Point(674, 22);
            this.richTextBoxToday.Name = "richTextBoxToday";
            this.richTextBoxToday.ReadOnly = true;
            this.richTextBoxToday.Size = new System.Drawing.Size(132, 30);
            this.richTextBoxToday.TabIndex = 54;
            this.richTextBoxToday.TabStop = false;
            this.richTextBoxToday.Text = "00";
            this.richTextBoxToday.TextChanged += new System.EventHandler(this.richTextBoxToday_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label6.Location = new System.Drawing.Point(549, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 32);
            this.label6.TabIndex = 53;
            this.label6.Text = "Today is:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listBoxDeployment
            // 
            this.listBoxDeployment.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxDeployment.FormattingEnabled = true;
            this.listBoxDeployment.Location = new System.Drawing.Point(72, 415);
            this.listBoxDeployment.Name = "listBoxDeployment";
            this.listBoxDeployment.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxDeployment.Size = new System.Drawing.Size(595, 82);
            this.listBoxDeployment.TabIndex = 55;
            this.listBoxDeployment.SelectedIndexChanged += new System.EventHandler(this.listBoxDeployment_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label7.Location = new System.Drawing.Point(581, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 34);
            this.label7.TabIndex = 56;
            this.label7.Text = "<-- step 1. Upload today\'s catalog. ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label8.Location = new System.Drawing.Point(581, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 34);
            this.label8.TabIndex = 57;
            this.label8.Text = "<-- step 2. Export RT files.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label9.Location = new System.Drawing.Point(581, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 34);
            this.label9.TabIndex = 58;
            this.label9.Text = "<-- step 3. Review resources.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label10.Location = new System.Drawing.Point(581, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(214, 34);
            this.label10.TabIndex = 59;
            this.label10.Text = "<-- step 4. Prepare syntax for Putty.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label12.Location = new System.Drawing.Point(581, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(214, 34);
            this.label12.TabIndex = 60;
            this.label12.Text = "<-- step 5. Upload reports.";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label13.Location = new System.Drawing.Point(581, 314);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(214, 34);
            this.label13.TabIndex = 61;
            this.label13.Text = "<-- step 6. Check the logs.";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeploymentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxDeployment);
            this.Controls.Add(this.richTextBoxToday);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBoxWeek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_reports);
            this.Controls.Add(this.button_resources);
            this.Controls.Add(this.extractRT_button);
            this.Controls.Add(this.button_logs);
            this.Controls.Add(this.consoleQuery_button);
            this.Controls.Add(this.checkBox_Query);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button_local_deploy);
            this.Controls.Add(this.checkBox_RT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deployComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CreateNoteButton);
            this.Name = "DeploymentControl";
            this.Size = new System.Drawing.Size(818, 500);
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
        private System.Windows.Forms.Button button_local_deploy;
        private System.Windows.Forms.CheckBox checkBox_RT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox deployComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateNoteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxWeek;
        private System.Windows.Forms.RichTextBox richTextBoxToday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxDeployment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}
