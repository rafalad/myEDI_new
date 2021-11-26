using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace myEDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = buttonDeployment.Height;
            SidePanel.Top = buttonDeployment.Top;
            mySecondCustmControl1.BringToFront();
            Start();
        }

        private void Start()
        {
            LoginDSV name = new LoginDSV();
            //WebClient webClient = new WebClient();
            Resources resource = new Resources();

            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            //ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "Logged as: " + userName + " " + "(" + name.Login() + ")");
            //ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "App is ready to use.");

            resource.Dirs();
            resource.DocDirCleanUp();

            if (Resources.listBoxMessageDris != string.Empty) //jezeli nie znaleziono folderow i byla potrzeba ich utworzenia to zwroc komuniakt
            {
                //ListBox(Resources.listBoxMessageDris);
            }


            ver.Text = "v" + Application.ProductVersion;

            //Task.Delay(3000).ContinueWith(t => resource.LogToFTP()); //zapisz log na serwerze z opoźnieniem

            //latest_ver.Text = resource.CheckVersion(); //kontrola wersji programu

            //richTextBoxSelectedEnv.Text = deployComboBox.Text; // kontrolka wyboru srodowiska dla deploya
        }
    
        //poruszanie oknem
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            //firstCustomControl1.BringToFront();
        }
        */
        private void buttonDeployment_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonDeployment.Height;
            SidePanel.Top = buttonDeployment.Top;
            mySecondCustmControl1.BringToFront();
        }
        private void buttonWorkplace_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonWorkplace.Height;
            SidePanel.Top = buttonWorkplace.Top;
            srqWindow.BringToFront();
        }
        private void buttonAccounts_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonAccounts.Height;
            SidePanel.Top = buttonAccounts.Top;
            accountsWindow.BringToFront();
        }
        private void buttonPasswords_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonPasswords.Height;
            SidePanel.Top = buttonPasswords.Top;
            passwordWindow.BringToFront();
        }
        private void buttonForms_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonForms.Height;
            SidePanel.Top = buttonForms.Top;
            formsWindow.BringToFront();
        }
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonAbout.Height;
            SidePanel.Top = buttonAbout.Top;
            aboutWindow.BringToFront();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mySecondCustmControl1_Load(object sender, EventArgs e)
        {

        }

        private void workspaceWindow_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void srqWindow_Load(object sender, EventArgs e)
        {

        }

        private void aboutWindow_Load(object sender, EventArgs e)
        {

        }

        private void accountsWindow_Load(object sender, EventArgs e)
        {

        }

        private void passwordWindow_Load(object sender, EventArgs e)
        {

        }

        private void formsWindow_Load(object sender, EventArgs e)
        {

        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
