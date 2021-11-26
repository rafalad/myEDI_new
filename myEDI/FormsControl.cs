using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace myEDI
{
    public partial class FormsControl : UserControl
    {
        public FormsControl()
        {
            InitializeComponent();
        }

        private void FormsControl_Load(object sender, EventArgs e)
        {
			LoginDSV name = new LoginDSV();
			string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

			ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "Logged as: " + userName + " " + "(" + name.Login() + ")");
			ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "App is ready to use.");
		}

		private void ListBox(string value)
		{
			listBoxForms.Items.Add(value);
		}

		private void checkBox_other_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonFAQ_Click(object sender, EventArgs e)
        {
            string content = @"In order for us to help you with your reported case, please fill in the missing details:" + Environment.NewLine +

                                "- Customer Name" + Environment.NewLine +
                                "- Time interval during which the fault occurred" +Environment.NewLine +
                                "-Reference number" + Environment.NewLine +
                                "- DSV target / source system(CW, CW1, CargoLink, etc.)" + Environment.NewLine +

                                "Once we have received the data, we will be able to trace the issue." + Environment.NewLine +
                                "If you have any questions, please contact us.";

            Clipboard.SetText(content);
            ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] The form has been copied to the clipboard.");
            MessageBox.Show("The form has been copied to the clipboard.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
