using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myEDI
{
    public partial class AccountsControl : UserControl
    {
        public AccountsControl()
        {
            InitializeComponent();
        }

        private void WorkplaceControl_Load(object sender, EventArgs e)
        {
            LoginDSV name = new LoginDSV();
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "Logged as: " + userName + " " + "(" + name.Login() + ")");
            ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "App is ready to use.");
        }

        private void ListBox(string value)
        {
            listBoxAccounts.Items.Add(value);
        }

        private void checkBox_other_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonGoLDAP_Click(object sender, EventArgs e)
        {

        }
    }
}
