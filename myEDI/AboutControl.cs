using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using MsOutlook = Microsoft.Office.Interop.Outlook;

namespace myEDI
{
    public partial class AboutControl : UserControl
    {
        public AboutControl()
        {
            InitializeComponent();
        }

        private void AboutControl2_Load(object sender, EventArgs e)
        {

        }

        private void buttonTextMe_Click(object sender, EventArgs e)
        {
            SendMailWithOutlook();
        }

        public bool SendMailWithOutlook()
        {
            try
            {
                // create the outlook application.
                MsOutlook.Application outlookApp = new MsOutlook.Application();
                if (outlookApp == null)
                    return false;

                // create a new mail item.
                MsOutlook.MailItem mail = (MsOutlook.MailItem)outlookApp.CreateItem(MsOutlook.OlItemType.olMailItem);

                mail.Subject = "[myEDI] Feedback";
                mail.To = "rafal.adamczyk@dsv.com";

                mail.Display(true);

                mail = null;
                outlookApp = null;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
