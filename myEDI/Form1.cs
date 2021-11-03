using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            mySecondCustmControl1.BringToFront();
        }
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            //firstCustomControl1.BringToFront();
        }
        */
        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            mySecondCustmControl1.BringToFront();
        }
        private void buttonWorkplace_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonWorkplace.Height;
            SidePanel.Top = buttonWorkplace.Top;
            srqWindow.BringToFront();
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

        private void buttonExit(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void buttonAccounts_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonAbout.Height;
            SidePanel.Top = buttonAbout.Top;
            accountsWindow.BringToFront();
        }
    }
}
