using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myEDI
{
    public partial class DeploymentControl : UserControl
    {
		public DeploymentControl()
		{
			InitializeComponent();
		}
		
        private void MySecondCustmControl_Load(object sender, EventArgs e)
        {
			Kit set = new Kit();
			LoginDSV name = new LoginDSV();
			string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

			richTextBoxWeek.Text = set.Week().ToString();
			richTextBoxToday.Text = set.Day().ToString() + " " + set.Month().ToString();

			ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "Logged as: " + userName + " " + "(" + name.Login() + ")");
			ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + "App is ready to use.");
		}

        private void CreateNoteButton_Click(object sender, EventArgs e)
        {
			//1. Oczysc i przygotuj katalogi
			Resources dir = new Resources();
			dir.PrepareDirs();

			//2. Przygotuj pliki do utworzenia notatki i skryptu
			using (FileStream fs = File.Create(@"C:\DEPLOYMENTS\msteams_note.txt", 1024))
			{
				byte[] info = new UTF8Encoding(true).GetBytes("");
				fs.Write(info, 0, info.Length);
			}
			using (FileStream fs = File.Create(@"C:\DEPLOYMENTS\query.txt", 1024))
			{
				byte[] info = new UTF8Encoding(true).GetBytes("");
				fs.Write(info, 0, info.Length);
			}

			//3. Generuj notatke zgodnie z wybranymi parametrami
			if (checkBox_RT.Checked)
			{
				ExtractRT();
				if (checkBox_Query.Checked)
				{
					Note(new object(), new EventArgs());
					ConsoleQuery();
				}
				else
				{
					Note(new object(), new EventArgs());
				}
			}
			else
			{
				if (checkBox_Query.Checked)
				{
					Note(new object(), new EventArgs());
					ConsoleQuery();
				}
				else
				{
					Note(new object(), new EventArgs());
				}
			}
		}

		private void ListBox(string value)
		{
			listBoxDeployment.Items.Add(value);
		}

		private void ExtractRT()
		{
			Kit set = new Kit();
			int day = set.Day();
			string month = set.Month();

			var dirs = from dir in
						 Directory.EnumerateDirectories(set.deploymentsdir, month + "*" + day.ToString() + "*")
					   select dir;

			if (dirs.Count() == 0) //jezeli nie ma paczek do wdrozenia
			{

			}
			else // jezeli paczki sa, to stworz foldery RT i LW i skopiuj pliki .xml
			{
				string targetPath_RT = Path.Combine(@"C:\DEPLOYMENTS\RESOURCES\", "RT");
				string tagretPath_LW = Path.Combine(@"C:\DEPLOYMENTS\RESOURCES\", "LW");
				string tagretPath_SQL = Path.Combine(@"C:\DEPLOYMENTS\RESOURCES\", "SQL");

				int i = 0;
				int j = 0;
				int k = 0;

				Directory.CreateDirectory(targetPath_RT);
				Directory.CreateDirectory(tagretPath_LW);
				Directory.CreateDirectory(tagretPath_SQL);

				string[] rt_array = Directory.GetFiles(set.DeployPath(), "*exp.xml", SearchOption.AllDirectories);
				foreach (string rt_file in rt_array)
				{
					i += 1;
					string fileName = Path.GetFileName(rt_file);
					string destFile = Path.Combine(targetPath_RT, fileName);
					File.Copy(rt_file, destFile, true);
				}

				string[] lw_array = Directory.GetFiles(set.DeployPath(), "*_f*.xml", SearchOption.AllDirectories);
				foreach (string lw_file in lw_array)
				{
					j += 1;
					string fileName = Path.GetFileName(lw_file);
					string destFile = Path.Combine(tagretPath_LW, fileName);
					File.Copy(lw_file, destFile, true);
				}

				string[] sql_array = Directory.GetFiles(set.DeployPath(), "*.sql", SearchOption.AllDirectories);
				foreach (string sql_file in sql_array)
				{
					k += 1;
					string fileName = Path.GetFileName(sql_file);
					string destFile = Path.Combine(tagretPath_SQL, fileName);
					File.Copy(sql_file, destFile, true);
				}

				ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + @"RT for SI exported files:  " + i + @" + Lightwell RT files:  " + j + @" + SQL files:  " + k);
			}
		}

		private void Note(object sender, EventArgs e)
		{
			Kit set = new Kit();
			string selected = deployComboBox.GetItemText(deployComboBox.SelectedItem); //wybieram zmienna z comboboxa

			int day = set.Day();
			string month = set.Month();

			var dirs = from dir in Directory.EnumerateDirectories(set.deploymentsdir, month + "*" + day.ToString() + "*") select dir;

			if (dirs.Count() == 0) //jezeli nie ma folderow do wdrozenia
			{
				MessageBox.Show(@"Please upload the folder-package to C:\DEPLOYMENTS\DEPLOY\...because there is nothing to deploy for today.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else // jezeli folder sa
			{
				ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] Data processing...");

				if (string.IsNullOrEmpty(selected)) // jezeli nie wybrano srodowiska
				{
					MessageBox.Show(dirs.Count().ToString() + " directories found, but not selected deployment environment.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else // jezeli wybrano srodowisko, to zwroc informacje i kontynuuj dla wybranego srodowiska
				{
					if (selected == "QA only")
					{
						new Qa();

						string pathString = @"C:\DEPLOYMENTS\msteams_note.txt";

						string[] lines = File.ReadAllLines(pathString);
						ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + dirs.Count().ToString() + ". dir found. MS Teams note created.");
						ListBox("");

						foreach (string line in lines)
						{
							ListBox(line);
						}

						MessageBox.Show("Completed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);

					}
					else if (selected == "PROD only")
					{
						new Prod();

						string pathString = @"C:\DEPLOYMENTS\msteams_note.txt";

						string[] lines = File.ReadAllLines(pathString);
						ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] MS Teams note created.");
						ListBox("");

						foreach (string line in lines)
						{
							ListBox(line);
						}

						MessageBox.Show("Completed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);

					}
					else if (selected == "both - QA & PROD")
					{
						new Qaprod();

						string pathString = @"C:\DEPLOYMENTS\msteams_note.txt";

						string[] lines = File.ReadAllLines(pathString);
						ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] MS Teams note created.");
						ListBox("");

						foreach (string line in lines)
						{
							ListBox(line);
						}

						MessageBox.Show("Completed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}

			ListBox("");
		}

		private void ConsoleQuery()
		{
			ConsoleQuery query = new ConsoleQuery();
			Kit set = new Kit();

			query.Query();
		}

        private void richTextBoxToday_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_local_deploy_Click(object sender, EventArgs e)
        {
			Process.Start(@"C:\DEPLOYMENTS\DEPLOY");
		}

        private void extractRT_button_Click(object sender, EventArgs e)
        {
			if (File.Exists(@"C:\DEPLOYMENTS\msteams_note.txt"))
			{
				if (new FileInfo(@"C:\DEPLOYMENTS\msteams_note.txt").Length == 0)
				{
					MessageBox.Show("It looks like the deployment process hasn't been completed yet.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					ExtractRT();
					MessageBox.Show("Completed.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
			{
				MessageBox.Show("It looks like the deployment process hasn't been completed yet.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

        private void button_resources_Click(object sender, EventArgs e)
        {
			Process.Start(@"C:\DEPLOYMENTS\RESOURCES");
		}

        private void consoleQuery_button_Click(object sender, EventArgs e)
        {
			if (File.Exists(@"C:\DEPLOYMENTS\query.txt"))
			{
				if (new FileInfo(@"C:\DEPLOYMENTS\query.txt").Length == 0)
				{
					MessageBox.Show("It looks like the deployment process hasn't been completed yet ... syntax file is empty.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					Process.Start(@"C:\DEPLOYMENTS\query.txt");
				}
			}
			else
			{
				MessageBox.Show("It looks like the deployment process hasn't been started yet.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

        private void button_reports_Click(object sender, EventArgs e)
        {
			Process.Start(@"C:\DEPLOYMENTS\Reports");
		}

        private void button_logs_Click(object sender, EventArgs e)
        {
			string path = @"C:\DEPLOYMENTS\My_Logs.txt";

			string[] lines = File.ReadAllLines(path);
			ListBox("[" + DateTime.Now.ToString("HH:mm:ss") + "] Checking logs:");
			ListBox("");

			foreach (string line in lines)
			{
				ListBox(line);
			}
		}

        private void listBoxDeployment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
