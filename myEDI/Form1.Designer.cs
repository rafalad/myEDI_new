namespace myEDI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ver = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonForms = new System.Windows.Forms.Button();
            this.buttonPasswords = new System.Windows.Forms.Button();
            this.buttonAccounts = new System.Windows.Forms.Button();
            this.buttonWorkplace = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.buttonDeployment = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.formsWindow = new myEDI.FormsControl();
            this.passwordWindow = new myEDI.PasswordControl();
            this.accountsWindow = new myEDI.AccountsControl();
            this.aboutWindow = new myEDI.AboutControl();
            this.srqWindow = new myEDI.WorkplaceControl();
            this.mySecondCustmControl1 = new myEDI.DeploymentControl();
            this.firstCustomControl1 = new myEDI.FirstCustomControl();
            this.aboutControl1 = new myEDI.AboutControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.ver);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.buttonAbout);
            this.panel1.Controls.Add(this.buttonForms);
            this.panel1.Controls.Add(this.buttonPasswords);
            this.panel1.Controls.Add(this.buttonAccounts);
            this.panel1.Controls.Add(this.buttonWorkplace);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.buttonDeployment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 600);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ver
            // 
            this.ver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ver.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.ver.ForeColor = System.Drawing.Color.White;
            this.ver.Location = new System.Drawing.Point(146, 579);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(89, 18);
            this.ver.TabIndex = 32;
            this.ver.Text = "version";
            this.ver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(41)))), ((int)(((byte)(96)))));
            this.SidePanel.Location = new System.Drawing.Point(1, 61);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(14, 54);
            this.SidePanel.TabIndex = 4;
            this.SidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SidePanel_Paint);
            // 
            // buttonAbout
            // 
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.ForeColor = System.Drawing.Color.White;
            this.buttonAbout.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbout.Image")));
            this.buttonAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbout.Location = new System.Drawing.Point(13, 331);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(190, 54);
            this.buttonAbout.TabIndex = 4;
            this.buttonAbout.Text = "     About";
            this.buttonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonForms
            // 
            this.buttonForms.FlatAppearance.BorderSize = 0;
            this.buttonForms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonForms.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForms.ForeColor = System.Drawing.Color.White;
            this.buttonForms.Image = ((System.Drawing.Image)(resources.GetObject("buttonForms.Image")));
            this.buttonForms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonForms.Location = new System.Drawing.Point(13, 277);
            this.buttonForms.Name = "buttonForms";
            this.buttonForms.Size = new System.Drawing.Size(190, 54);
            this.buttonForms.TabIndex = 4;
            this.buttonForms.Text = "     Forms";
            this.buttonForms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonForms.UseVisualStyleBackColor = true;
            this.buttonForms.Click += new System.EventHandler(this.buttonForms_Click);
            // 
            // buttonPasswords
            // 
            this.buttonPasswords.FlatAppearance.BorderSize = 0;
            this.buttonPasswords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPasswords.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPasswords.ForeColor = System.Drawing.Color.White;
            this.buttonPasswords.Image = ((System.Drawing.Image)(resources.GetObject("buttonPasswords.Image")));
            this.buttonPasswords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPasswords.Location = new System.Drawing.Point(13, 223);
            this.buttonPasswords.Name = "buttonPasswords";
            this.buttonPasswords.Size = new System.Drawing.Size(190, 54);
            this.buttonPasswords.TabIndex = 4;
            this.buttonPasswords.Text = "     Passwords";
            this.buttonPasswords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPasswords.UseVisualStyleBackColor = true;
            this.buttonPasswords.Click += new System.EventHandler(this.buttonPasswords_Click);
            // 
            // buttonAccounts
            // 
            this.buttonAccounts.FlatAppearance.BorderSize = 0;
            this.buttonAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccounts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccounts.ForeColor = System.Drawing.Color.White;
            this.buttonAccounts.Image = ((System.Drawing.Image)(resources.GetObject("buttonAccounts.Image")));
            this.buttonAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAccounts.Location = new System.Drawing.Point(13, 169);
            this.buttonAccounts.Name = "buttonAccounts";
            this.buttonAccounts.Size = new System.Drawing.Size(190, 54);
            this.buttonAccounts.TabIndex = 4;
            this.buttonAccounts.Text = "     Accounts";
            this.buttonAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAccounts.UseVisualStyleBackColor = true;
            this.buttonAccounts.Click += new System.EventHandler(this.buttonAccounts_Click);
            // 
            // buttonWorkplace
            // 
            this.buttonWorkplace.FlatAppearance.BorderSize = 0;
            this.buttonWorkplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWorkplace.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWorkplace.ForeColor = System.Drawing.Color.White;
            this.buttonWorkplace.Image = ((System.Drawing.Image)(resources.GetObject("buttonWorkplace.Image")));
            this.buttonWorkplace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWorkplace.Location = new System.Drawing.Point(13, 115);
            this.buttonWorkplace.Name = "buttonWorkplace";
            this.buttonWorkplace.Size = new System.Drawing.Size(190, 54);
            this.buttonWorkplace.TabIndex = 4;
            this.buttonWorkplace.Text = "     Workplace";
            this.buttonWorkplace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonWorkplace.UseVisualStyleBackColor = true;
            this.buttonWorkplace.Click += new System.EventHandler(this.buttonWorkplace_Click);
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(3, 570);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(36, 34);
            this.button14.TabIndex = 4;
            this.button14.Text = "?";
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // buttonDeployment
            // 
            this.buttonDeployment.FlatAppearance.BorderSize = 0;
            this.buttonDeployment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeployment.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeployment.ForeColor = System.Drawing.Color.White;
            this.buttonDeployment.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeployment.Image")));
            this.buttonDeployment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeployment.Location = new System.Drawing.Point(13, 61);
            this.buttonDeployment.Name = "buttonDeployment";
            this.buttonDeployment.Size = new System.Drawing.Size(190, 54);
            this.buttonDeployment.TabIndex = 4;
            this.buttonDeployment.Text = "     Deployments";
            this.buttonDeployment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeployment.UseVisualStyleBackColor = true;
            this.buttonDeployment.Click += new System.EventHandler(this.buttonDeployment_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(41)))), ((int)(((byte)(96)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(203, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(857, 14);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(41)))), ((int)(((byte)(96)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(203, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(193, 55);
            this.panel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(68, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 42);
            this.label4.TabIndex = 7;
            this.label4.Text = "myEDI";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button13
            // 
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(1004, 20);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(44, 35);
            this.button13.TabIndex = 4;
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.buttonExit);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.ForeColor = System.Drawing.Color.White;
            this.buttonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.Image")));
            this.buttonMinimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMinimize.Location = new System.Drawing.Point(966, 20);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(43, 35);
            this.buttonMinimize.TabIndex = 4;
            this.buttonMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // formsWindow
            // 
            this.formsWindow.Location = new System.Drawing.Point(209, 61);
            this.formsWindow.Name = "formsWindow";
            this.formsWindow.Size = new System.Drawing.Size(818, 500);
            this.formsWindow.TabIndex = 0;
            this.formsWindow.Load += new System.EventHandler(this.formsWindow_Load);
            // 
            // passwordWindow
            // 
            this.passwordWindow.Location = new System.Drawing.Point(209, 61);
            this.passwordWindow.Name = "passwordWindow";
            this.passwordWindow.Size = new System.Drawing.Size(818, 500);
            this.passwordWindow.TabIndex = 0;
            this.passwordWindow.Load += new System.EventHandler(this.passwordWindow_Load);
            // 
            // accountsWindow
            // 
            this.accountsWindow.Location = new System.Drawing.Point(209, 61);
            this.accountsWindow.Name = "accountsWindow";
            this.accountsWindow.Size = new System.Drawing.Size(818, 500);
            this.accountsWindow.TabIndex = 9;
            this.accountsWindow.Load += new System.EventHandler(this.accountsWindow_Load);
            // 
            // aboutWindow
            // 
            this.aboutWindow.Location = new System.Drawing.Point(209, 61);
            this.aboutWindow.Name = "aboutWindow";
            this.aboutWindow.Size = new System.Drawing.Size(818, 500);
            this.aboutWindow.TabIndex = 8;
            this.aboutWindow.Load += new System.EventHandler(this.aboutWindow_Load);
            // 
            // srqWindow
            // 
            this.srqWindow.Location = new System.Drawing.Point(209, 61);
            this.srqWindow.Name = "srqWindow";
            this.srqWindow.Size = new System.Drawing.Size(818, 500);
            this.srqWindow.TabIndex = 7;
            this.srqWindow.Load += new System.EventHandler(this.srqWindow_Load);
            // 
            // mySecondCustmControl1
            // 
            this.mySecondCustmControl1.Location = new System.Drawing.Point(209, 61);
            this.mySecondCustmControl1.Name = "mySecondCustmControl1";
            this.mySecondCustmControl1.Size = new System.Drawing.Size(818, 500);
            this.mySecondCustmControl1.TabIndex = 6;
            this.mySecondCustmControl1.Load += new System.EventHandler(this.mySecondCustmControl1_Load);
            // 
            // firstCustomControl1
            // 
            this.firstCustomControl1.Location = new System.Drawing.Point(209, 61);
            this.firstCustomControl1.Name = "firstCustomControl1";
            this.firstCustomControl1.Size = new System.Drawing.Size(818, 500);
            this.firstCustomControl1.TabIndex = 5;
            // 
            // aboutControl1
            // 
            this.aboutControl1.Location = new System.Drawing.Point(209, 61);
            this.aboutControl1.Name = "aboutControl1";
            this.aboutControl1.Size = new System.Drawing.Size(818, 500);
            this.aboutControl1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1060, 600);
            this.Controls.Add(this.formsWindow);
            this.Controls.Add(this.passwordWindow);
            this.Controls.Add(this.accountsWindow);
            this.Controls.Add(this.aboutWindow);
            this.Controls.Add(this.srqWindow);
            this.Controls.Add(this.mySecondCustmControl1);
            this.Controls.Add(this.firstCustomControl1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        //private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonDeployment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonForms;
        private System.Windows.Forms.Button buttonPasswords;
        private System.Windows.Forms.Button buttonAccounts;
        private System.Windows.Forms.Button buttonWorkplace;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private FirstCustomControl firstCustomControl1;
        private DeploymentControl mySecondCustmControl1;
        private WorkplaceControl srqWindow;
        private AboutControl aboutControl1;
        private AboutControl aboutWindow;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Label label4;
        private AccountsControl accountsWindow;
        private PasswordControl passwordWindow;
        private FormsControl formsWindow;
        private System.Windows.Forms.Label ver;
        //private FormsControl formsControl;
        //private AccountsControl passwordControl;
        //private WorkplaceControl aboutWindow;
        //private DeploymentControl srqWindow;
        //private DeploymentControl deploymentControl1;
        //private DeploymentControl workspaceWindow;
    }
}

