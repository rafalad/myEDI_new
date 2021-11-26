using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace myEDI
{
	class Option
	{
		public int Length { get; set; }
		public int Amount { get; set; }
		public bool CL { get; set; }
		public bool SL { get; set; }
		public bool D { get; set; }
		public bool SC { get; set; }
	}
	public partial class PasswordControl : UserControl
    {
		static RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();

		public PasswordControl()
        {
            InitializeComponent();
        }

        private void PasswordControl_Load(object sender, EventArgs e)
        {
			LoginDSV name = new LoginDSV();
			string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

			ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "Logged as: " + userName + " " + "(" + name.Login() + ")");
			ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "App is ready to use.");
		}

		private void ListBox(string value)
		{
            listBoxPassword.Items.Add(value);
		}

		private void checkBox_other_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = comboBoxPass.GetItemText(comboBoxPass.SelectedItem); //wybieram zmienna z comboboxa

            if (selectedType == "multiple")
            {
                comboBoxAmount.Enabled = true;
                comboBoxAmount.Text = "10";
                //comboBoxLength.Enabled = true;
                //buttonMoreSettings.Enabled = true;
                //buttonGenerateRandomPassword.Enabled = false;
            }
            else
            {
                comboBoxAmount.Enabled = false;
                comboBoxAmount.Text = "1";
                //comboBoxLength.Enabled = false;
                //buttonMoreSettings.Enabled = false;
                //buttonGenerateRandomPassword.Enabled = true;
            }
        }

        private void checkBoxCLyes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCLyes.Checked)
                checkBoxCLno.Checked = false;
            else
                checkBoxCLno.Checked = true;
        }

        private void checkBoxCLno_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCLno.Checked)
                checkBoxCLyes.Checked = false;
            else
                checkBoxCLyes.Checked = true;
        }

        private void checkBoxSLyes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSLyes.Checked)
                checkBoxSLno.Checked = false;
            else
                checkBoxSLno.Checked = true;
        }

        private void checkBoxSLno_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSLno.Checked)
                checkBoxSLyes.Checked = false;
            else
                checkBoxSLyes.Checked = true;
        }

        private void checkBoxDyes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDyes.Checked)
                checkBoxDno.Checked = false;
            else
                checkBoxDno.Checked = true;
        }

        private void checkBoxDno_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDno.Checked)
                checkBoxDyes.Checked = false;
            else
                checkBoxDyes.Checked = true;
        }

        private void checkBoxSCyes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSCyes.Checked)
                checkBoxSCno.Checked = false;
            else
                checkBoxSCno.Checked = true;
        }

        private void checkBoxSCno_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSCno.Checked)
                checkBoxSCyes.Checked = false;
            else
                checkBoxSCyes.Checked = true;
        }

        private void buttonGenerateRandomPassword_Click(object sender, EventArgs e)
        {
			Option _Length = new Option();
			Option _CL = new Option();
			Option _SL = new Option();
			Option _D = new Option();
			Option _SC = new Option();

			_Length.Length = Convert.ToInt32(comboBoxLength.GetItemText(this.comboBoxLength.SelectedItem));

			// sprawdzam warunki, jezeli wybrano duze litery
			_CL.CL = checkBoxCLyes.Checked;

			// jezeli wybrano male litery
			_SL.SL = checkBoxSLyes.Checked;

			// jeżeli wybrano cyfry
			_D.D = checkBoxSLyes.Checked;

			// jezeli wybrano znaki specjalne
			_SC.SC = checkBoxSCyes.Checked;

			Multipass(Amount(), _Length.Length, _CL.CL, _SL.SL, _D.D, _SC.SC);
		}

		private int Amount()
        {
			int howManyPasswords;

			Option _Amount = new Option();

			try 
			{
				_Amount.Amount = Convert.ToInt32(comboBoxAmount.GetItemText(this.comboBoxAmount.SelectedItem));
				return howManyPasswords = _Amount.Amount;
			}
			catch
			{ 
				return howManyPasswords = 1; 
			}
		}

		private void comboBoxAmount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

		public void Multipass(int Amount, int Length, bool CL, bool SL, bool D, bool SC)
		{
			DateTime thisDay = DateTime.Today;

			string path = @"C:\EDI\passwords_" + thisDay.ToString("ddMMyyyyhhmmss") + ".txt";

			string CapitalLetters = "QWERTYUIOPASDFGHJKLZXCVBNM";
			string SmallLetters = "qwertyuiopasdfghjklzxcvbnm";
			string Digits = "0123456789";
			string SpecialCharacters = "!@#$%^&*_+";

			string[] AllPasswords = new string[Amount];

			//jezeli wszystkie warunki sa prawdziwe
			if (CL && SL && D && SC == true)
			{
				string AllChar1 = CapitalLetters + SmallLetters + Digits + SpecialCharacters;

				for (int i = 0; i < Amount; i++)
				{
					StringBuilder sb = new StringBuilder();
					for (int n = 0; n < Length; n++)
					{
						sb = sb.Append(GenerateChar(AllChar1));
					}

					AllPasswords[i] = sb.ToString();
				}

				if (Amount > 1)
				{
					foreach (string singlePassword in AllPasswords)
					{
						string appendText = singlePassword + Environment.NewLine;
						File.AppendAllText(path, appendText, Encoding.UTF8);

					}

					MessageBox.Show("The list of random passwords created successfully." + Environment.NewLine +
						"The file saved in: " + path, "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);

					Process.Start(path);
				}
				else
				{
					foreach (string singlePassword in AllPasswords)
					{
						Clipboard.SetText(singlePassword);
						ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] Password has been copied to the clipboard.");
						MessageBox.Show("=== Password has been copied to the clipboard. ===", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}

			//jezeli nie wybrano znakow specjalnych
			else if (CL && SL && D == true || SC == false)
			{
				string AllChar2 = CapitalLetters + SmallLetters + Digits;

				for (int i = 0; i < Amount; i++)
				{
					StringBuilder sb = new StringBuilder();
					for (int n = 0; n < Length; n++)
					{
						sb = sb.Append(GenerateChar(AllChar2));
					}

					AllPasswords[i] = sb.ToString();
				}

				if (Amount > 1)
				{
					foreach (string singlePassword in AllPasswords)
					{
						string appendText = singlePassword + Environment.NewLine;
						File.AppendAllText(path, appendText, Encoding.UTF8);

					}

					MessageBox.Show("The list of random passwords created successfully." + Environment.NewLine +
						"The file saved in: " + path, "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Process.Start(path);
				}
				else
				{
					foreach (string singlePassword in AllPasswords)
					{
						Clipboard.SetText(singlePassword);
						ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] Password has been copied to the clipboard.");
						MessageBox.Show("=== Password has been copied to the clipboard. ===", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}

			// jezeli wybrano tylko duze i male litery
			else if (CL && SL == true || D && SC == false)
			{
				string AllChar3 = CapitalLetters + SmallLetters;

				for (int i = 0; i < Amount; i++)
				{
					StringBuilder sb = new StringBuilder();
					for (int n = 0; n < Length; n++)
					{
						sb = sb.Append(GenerateChar(AllChar3));
					}

					AllPasswords[i] = sb.ToString();
				}

				if (Amount > 1)
				{
					foreach (string singlePassword in AllPasswords)
					{
					string appendText = singlePassword + Environment.NewLine;
					File.AppendAllText(path, appendText, Encoding.UTF8);
					}

					MessageBox.Show("The list of random passwords created successfully." + Environment.NewLine +
					"The file saved in: " + path, "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Process.Start(path);
				}
				else
				{
					foreach (string singlePassword in AllPasswords)
					{
						Clipboard.SetText(singlePassword);
						ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] Password has been copied to the clipboard.");
						MessageBox.Show("=== Password has been copied to the clipboard. ===", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}

			// jezeli wybrano tylko duze litery
			else if (CL == true || SL && D && SC == false)
			{
				string AllChar = CapitalLetters;

				for (int i = 0; i < Amount; i++)
				{
					StringBuilder sb = new StringBuilder();
					for (int n = 0; n < Length; n++)
					{
						sb = sb.Append(GenerateChar(AllChar));
					}

					AllPasswords[i] = sb.ToString();
				}

				if (Amount > 1)
				{
					foreach (string singlePassword in AllPasswords)
					{
					string appendText = singlePassword + Environment.NewLine;
					File.AppendAllText(path, appendText, Encoding.UTF8);
					}

					MessageBox.Show("The list of random passwords created successfully." + Environment.NewLine +
					"The file saved in: " + path, "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Process.Start(path);
				}
				else
				{
					foreach (string singlePassword in AllPasswords)
					{
						Clipboard.SetText(singlePassword);
						ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] Password has been copied to the clipboard.");
						MessageBox.Show("=== Password has been copied to the clipboard. ===", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
			else
			{
				MessageBox.Show("Please choose any password component and try again.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private static char GenerateChar(string availableChars)
		{
			var byteArray = new byte[1];
			char c;
			do
			{
				provider.GetBytes(byteArray);
				c = (char)byteArray[0];

			} while (!availableChars.Any(x => x == c));

			return c;
		}

		private void checkBoxD_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void PassSettings_Load(object sender, EventArgs e)
		{

		}
	}
}
