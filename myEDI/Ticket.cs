﻿using System;
using System.IO;
using System.Windows.Forms;

namespace myEDI
{
	class Ticket : SRQform
	{
		public string createdfolder;
		public string fileDocName;
		public string number;
		public string messageSRQForm1;

		public void NewTicket(string CHWnoField, string idField, string task, bool form, string subdir)
		{
			string type = string.Empty;
			string no = string.Empty;

			string type_srq = "DSV_SRQ";
			string type_inc = "DSV_INC";

			string type_srq_folder = "SRQ";
			string type_inc_folder = "INC";

			//przechodzę o po znakach w poszukiwania liczb, jeżeli znajdę to przypisuję do zmiennej
			for (int i = 0; i < CHWnoField.Length; i++)
			{
				if (Char.IsDigit(CHWnoField[i]))
					no += CHWnoField[i];
			}

			//przechodzę o po znakach w poszukiwania liter, jeżeli znajdę to przypisuję do zmiennej
			for (int i = 0; i < CHWnoField.Length; i++)
			{
				if (Char.IsLetter(CHWnoField[i]))
					type += CHWnoField[i];
			}

			if (task == " [codelist]")
			{
				if (type == "Incident")
				{
					string folderName = type_inc_folder + no + " - " + idField + task;
					string dir = @"C:\EDI\CODELIST\" + folderName + @"\RT";
					Directory.CreateDirectory(dir);

					//plik tworze bez spacji w nazwie
					string rt_name = type_inc + no + "_" + idField.Replace(" ", "") + "_1.0_rt";

					string file_rt = dir + @"\" + rt_name;

					File.Create(file_rt);

					createdfolder = @"C:\EDI\CODELIST\" + folderName;
				}
				else
				{
					string folderName = type_srq_folder + no + " - " + idField + task;
					string dir = @"C:\EDI\CODELIST\" + folderName + @"\RT";
					Directory.CreateDirectory(dir);

					//plik tworze bez spacji w nazwie
					string rt_name = type_srq + no + "_" + idField.Replace(" ", "") + "_1.0_rt";

					string file_rt = dir + @"\" + rt_name;

					File.Create(file_rt);

					createdfolder = @"C:\EDI\CODELIST\" + folderName;
				}

			}
			else if (task == "")
			{
				if (type == "Incident")
				{
					string folderName = type_inc_folder + no + " - " + idField + task;
					string dir = @"C:\EDI\Other\" + folderName + @"\RT";
					Directory.CreateDirectory(dir);

					//plik tworze bez spacji w nazwie
					string rt_name = type_inc + no + "_" + idField.Replace(" ", "") + "_1.0_rt";

					string file_rt = dir + @"\" + rt_name;

					File.Create(file_rt);

					createdfolder = @"C:\EDI\Other\" + folderName;

					// jezeli wybrano opcje z formularzem to powiadom usera, ze opcja dostepna tylko dla SRQ
					if (form == true)
					{
						MessageBox.Show("The form is available for Service Requests only!", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else
				{
					//jezeli wybrano opcje z formularzem
					string folderName = type_srq_folder + no + " - " + idField + task;

					// nazwa dokumentu w przypadku generowania dla zadan SRQ
					string docName = type_srq_folder + no + " - EDI Deploy Request.docx";
					string dir = @"C:\EDI\Other\" + folderName + @"\RT";
					Directory.CreateDirectory(dir);

					string rt_name = type_srq + no + "_" + idField.Replace(" ", "") + "_1.0_rt";
					string exp_name = type_srq + no + "_" + idField.Replace(" ", "") + "_1.0_exp";
					string ffid_name = type_srq + no + "_" + idField.Replace(" ", "") + "_1.0_ffid";
					string fser_name = type_srq + no + "_" + idField.Replace(" ", "") + "_1.0_fser";
					string fror_name = type_srq + no + "_" + idField.Replace(" ", "") + "_1.0_fror";

					File.Create(dir + @"\" + rt_name);
					File.Create(dir + @"\" + exp_name);
					File.Create(dir + @"\" + ffid_name);
					File.Create(dir + @"\" + fser_name);
					File.Create(dir + @"\" + fror_name);

					createdfolder = @"C:\EDI\Other\" + folderName;
					fileDocName = docName;
					number = no;

					string file1 = exp_name;
					string file2 = ffid_name;
					string file3 = fser_name;
					string file4 = fror_name;

					// jezeli wybrano opcje z formularzem (dostepne tylko przy sekwencji SRQ)
					if (form == true)
					{
						string dirName = @"C:\EDI\Other\" + folderName + @"\";
						CreateForm(no, docName, dirName, file1, file2, file3, file4);

						messageSRQForm1 = "The EDI Deploy Request document generated successfully.";
					}
				}
			}

			else if (task == " [STD LW Setup]")
			{
				if (type != "Incident")
				{
					//jezeli wybrano opcje z formularzem
					string folderName = type_srq_folder + no + " - " + idField + task;

					// nazwa dokumentu w przypadku generowania dla zadan SRQ
					string docName = type_srq_folder + no + " - EDI Deploy Request.docx";
					string dir = @"C:\EDI\SETUPS\" + subdir + @"\" + folderName + @"\RT";
					Directory.CreateDirectory(dir);

					string rt_name = type_srq + no + "_" + idField.Replace(" ", "") + "_1.0_rt";
					string exp_name = type_srq + no + "_" + idField.Replace(" ", "") + "_1.0_exp";
					string ffid_name = type_srq + no + "_" + idField.Replace(" ", "") + "_1.0_ffid";
					string fser_name = type_srq + no + "_" + idField.Replace(" ", "") + "_1.0_fser";
					string fror_name = type_srq + no + "_" + idField.Replace(" ", "") + "_1.0_fror";

					File.Create(dir + @"\" + rt_name);
					File.Create(dir + @"\" + exp_name);
					File.Create(dir + @"\" + ffid_name);
					File.Create(dir + @"\" + fser_name);
					File.Create(dir + @"\" + fror_name);

					createdfolder = @"C:\EDI\SETUPS\" + subdir + @"\" + folderName;
					fileDocName = docName;
					number = no;

					string file1 = exp_name;
					string file2 = ffid_name;
					string file3 = fser_name;
					string file4 = fror_name;

					// jezeli wybrano opcje z formularzem (dostepne tylko przy sekwencji SRQ)
					if (form == true)
					{
						string dirName = @"C:\EDI\SETUPS\" + subdir + @"\" + folderName + @"\";
						CreateForm(no, docName, dirName, file1, file2, file3, file4);

						messageSRQForm1 = "The EDI Deploy Request document generated successfully.";
					}
				}
				else
				{
					MessageBox.Show("Please change the ticket type to SRQ.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}

			else if (task == "maps")
			{
				if (type != "Incident")
				{
					//jezeli wybrano opcje z formularzem
					string folderName = type_srq_folder + no + " - " + idField;

					// nazwa dokumentu w przypadku generowania dla zadan SRQ
					string docName = type_srq_folder + no + " - EDI Deploy Request.docx";
					string dir = @"C:\EDI\MAPS\" + folderName + @"\RT";
					Directory.CreateDirectory(dir);

					string rt_name = type_srq + no + "_" + idField.Replace(" ", "") + "_1.0_rt";
					string exp_name = type_srq + no + "_" + idField.Replace(" ", "") + "_1.0_exp";

					File.Create(dir + @"\" + rt_name);
					File.Create(dir + @"\" + exp_name);

					createdfolder = @"C:\EDI\MAPS\" + folderName;
					fileDocName = docName;
					number = no;

					string file1 = exp_name;
					string file2 = string.Empty;
					string file3 = string.Empty;
					string file4 = string.Empty;

					// jezeli wybrano opcje z formularzem (dostepne tylko przy sekwencji SRQ)
					if (form == true)
					{
						string dirName = @"C:\EDI\MAPS\" + folderName + @"\";
						CreateForm(no, docName, dirName, file1, file2, file3, file4);

						messageSRQForm1 = "The EDI Deploy Request document generated successfully.";
					}
				}
				else
				{
					MessageBox.Show("Please change the ticket type to SRQ.", "myEDI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}
	}
}
