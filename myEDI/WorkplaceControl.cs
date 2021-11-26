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
    public partial class WorkplaceControl : UserControl
    {
        public WorkplaceControl()
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
			listBoxDeployment.Items.Add(value);
		}

		private void checkBox_other_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CreateAnObject_Click(object sender, EventArgs e)
        {
            ExtractResource click = new ExtractResource();

            // jezeli zaznaczono opcje z formularzem
            if (checkBoxSRQ.Checked)
            {
                //pobierz formularz
                Directory.CreateDirectory(@"C:\EDI\doc_temp");

                ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] Data processing...");

                click.Extract("myEDI", @"C:\EDI\doc_temp", "Resources", "deploy_request.docx");
                Workspace();
            }
            // jezeli bez formularza, to nie pobieraj szablonu
            else
            {
                Workspace();
            }
        }

		private void Workspace()
		{
			bool setup = checkBox_setup.Checked;
			bool maps = checkBox_maps.Checked;
			bool codelist = checkBox_cl.Checked;
			bool other = checkBox_other.Checked;

			string selectedFlow = comboBox_setup.GetItemText(comboBox_setup.SelectedItem); //wybieram zmienna z comboboxa

			if (String.IsNullOrEmpty(CHWnumberField.Text) && String.IsNullOrEmpty(SRQidField.Text))
			{
				MessageBox.Show("Enter any name and number which refers to the task, please.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else // jezeli spelniono warunki, czyli wybrano numer i nazwe zgloszenia
			{
				if (setup == true)
				{
					string task = " [STD LW Setup]";

					switch (selectedFlow)
					{
						case "other":
							string subdir1 = "other";
							WorkspaceFolder(subdir1, task);
							break;

						case "CL both flows":
							string subdir2 = "CL both flows";
							WorkspaceFolder(subdir2, task);
							break;

						case "CL in":
							string subdir3 = "CL in";
							WorkspaceFolder(subdir3, task);
							break;

						case "CL out":
							string subdir4 = "CL out";
							WorkspaceFolder(subdir4, task);
							break;

						case "CW in":
							string subdir5 = "CW in";
							WorkspaceFolder(subdir5, task);
							break;

						case "CW out":
							string subdir6 = "CW out";
							WorkspaceFolder(subdir6, task);
							break;

						case "CW both flows":
							string subdir7 = "CW both flows";
							WorkspaceFolder(subdir7, task);
							break;

						case "CW1 both flows":
							string subdir8 = "CW1 both flows";
							WorkspaceFolder(subdir8, task);
							break;

						case "CW1 in":
							string subdir9 = "CW1 in";
							WorkspaceFolder(subdir9, task);
							break;

						case "CW1 out":
							string subdir10 = "CW1 out";
							WorkspaceFolder(subdir10, task);
							break;

						case "myDSV":
							string subdir11 = "myDSV";
							WorkspaceFolder(subdir11, task);
							break;

						case "Passthrough":
							string subdir12 = "Passthrough";
							WorkspaceFolder(subdir12, task);
							break;
					}


				}

				else if (maps == true)
				{
					string subdir = String.Empty;
					string task = "maps";
					WorkspaceFolder(subdir, task);
				}

				else if (codelist == true)
				{
					string subdir = String.Empty;
					string task = " [codelist]";
					WorkspaceFolder(subdir, task);
				}

				else if (other == true)
				{
					string subdir = String.Empty;
					string task = "";
					WorkspaceFolder(subdir, task);
				}
			}
		}

		private void WorkspaceFolder(string subdir, string task)
		{
			try
			{
				bool form = checkBoxSRQ.Checked;
				string CHWnoField = CHWnumberField.Text;
				string idField = SRQidField.Text;

				Ticket folder = new Ticket();
				folder.NewTicket(CHWnoField, idField, task, form, subdir);

				ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + task + " folder has been created correctly at:");
				ListBox(folder.createdfolder);


				if (task == " [STD LW Setup]")
				{
					//Zwróć informacje o utworzonym dokumencie jezeli zostal wybrany i utworzony katalog ma w nazwie SRQ
					if (form == true && folder.createdfolder.Substring(7, 3) == "SRQ")
					{
						ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] The EDI Deploy Request document generated successfully.");
					}
				}

				if (MessageBox.Show("Folder created. \n Would you like to open it?", "myEDI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					Process.Start(folder.createdfolder);
				}
			}
			catch (Exception)
			{
				MessageBox.Show(@"Not executed due to an error. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
		private void SRQidField_TextChanged(object sender, EventArgs e)
		{
			SRQidField.CharacterCasing = CharacterCasing.Upper;
		}

        private void checkBoxSRQ_CheckedChanged(object sender, EventArgs e)
        {
			if (checkBoxSRQ.Checked)
				checkBoxSRQno.Checked = false;
			else
				checkBoxSRQno.Checked = true;
		}

        private void checkBoxSRQno_CheckedChanged(object sender, EventArgs e)
        {
			if (checkBoxSRQno.Checked)
				checkBoxSRQ.Checked = false;
			else
				checkBoxSRQ.Checked = true;
		}

        private void listBoxDeployment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
