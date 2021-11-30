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

        private void checkBox_setup_CheckedChanged(object sender, EventArgs e)
        {
			if (checkBox_setup.Checked)
			{
				checkBox_maps.Checked = false;
				checkBox_cl.Checked = false;
				checkBox_other.Checked = false;
				checkBox_ldap.Checked = false;
				checkBoxSRQ.Checked = true;
				checkBoxSRQ.Enabled = true;
				checkBoxSRQno.Enabled = true;
				comboBox_setup.Enabled = true;
			}
		}

        private void checkBox_maps_CheckedChanged(object sender, EventArgs e)
        {
			if (checkBox_maps.Checked)
			{
				checkBox_cl.Checked = false;
				checkBox_setup.Checked = false;
				checkBox_other.Checked = false;
				checkBox_ldap.Checked = false;
				checkBoxSRQ.Checked = false;
				checkBoxSRQ.Enabled = true;
				checkBoxSRQno.Enabled = true;
				comboBox_setup.Enabled = false;
			}
		}

        private void checkBox_cl_CheckedChanged(object sender, EventArgs e)
        {
			if (checkBox_cl.Checked)
			{
				checkBox_maps.Checked = false;
				checkBox_setup.Checked = false;
				checkBox_ldap.Checked = false;
				checkBox_other.Checked = false;
				checkBoxSRQ.Checked = false;
				checkBoxSRQ.Enabled = false;
				checkBoxSRQno.Enabled = false;
				checkBoxSRQno.Checked = false;
				comboBox_setup.Enabled = false;
			}
		}

        private void checkBox_ldap_CheckedChanged(object sender, EventArgs e)
        {
			if (checkBox_ldap.Checked)
			{
				checkBox_maps.Checked = false;
				checkBox_setup.Checked = false;
				checkBox_other.Checked = false;
				checkBoxSRQ.Checked = false;
				checkBoxSRQ.Enabled = false;
				checkBoxSRQno.Enabled = false;
				checkBoxSRQno.Checked = false;
				comboBox_setup.Enabled = false;
				checkBox_cl.Checked = false;
			}
		}

		private void checkBox_other_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_other.Checked)
			{
				checkBox_maps.Checked = false;
				checkBox_setup.Checked = false;
				checkBox_cl.Checked = false;
				checkBoxSRQ.Checked = false;
				checkBoxSRQ.Enabled = true;
				checkBoxSRQno.Enabled = true;
				checkBoxSRQno.Checked = true;
				comboBox_setup.Enabled = false;
				checkBox_ldap.Checked = false;
			}
		}

        private void checkBox_cl_in_CheckedChanged(object sender, EventArgs e)
        {
			if (checkBox_cl_in.Checked)
			{
				checkBox_cl_out.Checked = false;
				checkBox_cl_both.Checked = false;
				textBoxChildID.Enabled = true;
			}
		}

        private void checkBox_cl_out_CheckedChanged(object sender, EventArgs e)
        {
			if (checkBox_cl_out.Checked)
			{
				checkBox_cl_in.Checked = false;
				checkBox_cl_both.Checked = false;
				textBoxChildID.Enabled = false;
			}
		}

        private void checkBox_cl_both_CheckedChanged(object sender, EventArgs e)
        {
			if (checkBox_cl_both.Checked)
			{
				checkBox_cl_in.Checked = false;
				checkBox_cl_out.Checked = false;
				textBoxChildID.Enabled = true;
			}
		}

        private void buttonCreateCL_Click(object sender, EventArgs e)
        {
			if (checkBox_cl_in.Checked == false && checkBox_cl_out.Checked == false && checkBox_cl_both.Checked == false)
				MessageBox.Show("Select the flow direction.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);


			if (checkBox_cl_both.Checked)
				CL_both();
			if (checkBox_cl_in.Checked)
				CL_inbound();
			if (checkBox_cl_out.Checked)
				CL_outbound();
		}

		private void CL_both ()
		{
			string parentID = textBoxParentID.Text;
			string childID = textBoxChildID.Text;

			if (String.IsNullOrEmpty(parentID))
			{
				MessageBox.Show("Enter the parent name, please.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (String.IsNullOrEmpty(childID))
			{
				MessageBox.Show("Enter the child name, please.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			else
			{
				string codelist_ReceiveEncoding = "DSV_CL_RECEIVE_ENCODING_" + childID + "_cl";
				string codelist_SourceIDLookup = "DSV_CL_SourceIDLookup_" + parentID + "_D10B_CDM_V2_cl";
				string codelist_SendEncoding = "DSV_CL_SEND_ENCODING_" + parentID + "_cl";

				string pathString = Path.Combine(@"C:\EDI", "codelist.txt");

				string[] naglowek = { codelist_ReceiveEncoding, codelist_SourceIDLookup, codelist_SendEncoding };
				File.WriteAllLines(pathString, naglowek);

				ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] CL has been created.");

				Process.Start(pathString);

				MessageBox.Show("A codelist name has been created for both flows." + Environment.NewLine +
					"The file will be saved in: " + pathString, "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void CL_inbound ()
		{
			string parentID = textBoxParentID.Text;
			string childID = textBoxChildID.Text;

			if (String.IsNullOrEmpty(parentID))
			{
				MessageBox.Show("Enter the parent name, please.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (String.IsNullOrEmpty(childID))
			{
				MessageBox.Show("Enter the child name, please.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			else
			{
				string codelist_ReceiveEncoding = "DSV_CL_RECEIVE_ENCODING_" + childID + "_cl";
				string codelist_SourceIDLookup = "DSV_CL_SourceIDLookup_" + parentID + "_D10B_CDM_V2_cl";

				string pathString = Path.Combine(@"C:\EDI", "codelist.txt");

				string[] naglowek = { codelist_ReceiveEncoding, codelist_SourceIDLookup };
				File.WriteAllLines(pathString, naglowek);

				ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] CL has been created.");

				Process.Start(pathString);

				MessageBox.Show("A codelist name has been created for the Inbound flow." + Environment.NewLine +
					"The file will be saved in: " + pathString, "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void CL_outbound ()
		{
			string parentID = textBoxParentID.Text;

			if (String.IsNullOrEmpty(parentID))
			{
				MessageBox.Show("Enter the parent name, please.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			else
			{
				string codelist_SendEncoding = "DSV_CL_SEND_ENCODING_" + parentID + "_cl";

				string pathString = Path.Combine(@"C:\EDI", "codelist.txt");

				string[] naglowek = { codelist_SendEncoding };
				File.WriteAllLines(pathString, naglowek);

				ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] CL has been created.");

				Process.Start(pathString);

				MessageBox.Show("A codelist name has been created for the Outbound flow." + Environment.NewLine +
					"The file will be saved in: " + pathString, "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

        private void textBoxParentID_TextChanged(object sender, EventArgs e)
        {
			textBoxParentID.CharacterCasing = CharacterCasing.Upper;
		}

        private void textBoxChildID_TextChanged(object sender, EventArgs e)
        {
			textBoxChildID.CharacterCasing = CharacterCasing.Upper;
		}

        private void SRQidField_TextChanged_1(object sender, EventArgs e)
		{
			SRQidField.CharacterCasing = CharacterCasing.Upper;
		}
    }
}
