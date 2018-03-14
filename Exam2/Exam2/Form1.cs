using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Text.RegularExpressions;
using System.IO;

namespace Exam2
{
	public partial class Form1 : Form
	{
		string confIDRegEx = "^CONF_(ARTS | BUSINESS | LAW)$";

		readonly int FirstNameMinLength = 2;
		readonly int SurnameMinLength = 2;

		readonly string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
				+ System.IO.Path.DirectorySeparatorChar + @"Registration.bin";

		public Form1()
		{
			InitializeComponent();
			//confIDRegEx = ConfigurationManager.AppSettings["ConfID"];

			//Configuration Manager is reported as obsolete on StackOverflow
			// have created a mysettings class to try to 
			//define an application scope setting but it's throwing a stack overflow exception
			//no idea how to fix... 

			//MySettings setting = new MySettings();
			//confIDRegEx = setting.ConfID;

			//hard coded the regex pattern to test remainder of app

		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			if (!ValidateConfIDField())
			{
				MessageBox.Show("Conference ID field is invalid. Registration Failed");
				txtConfID.Focus();
			}
			else
			{
				// validate firstname and surname are both 2 chars+ in length
				bool fNameValid = ValidateFirstName(), surnameValid = ValidateSurname();

				if (!fNameValid || !surnameValid)
				{
					string msg;
					if (!fNameValid && !surnameValid)
					{
						msg = "Firstname and surname are invalid";
						txtSurname.Focus();
					}
					else if (!fNameValid)
					{
						msg = "Firstname is invalid";
						txtFirstName.Focus();
					}
					else
					{
						msg = "Surname is invalid";
						txtSurname.Focus();
					}

					MessageBox.Show(msg);
				}
				else
				{
					SaveRegistrationInfo();
				}
			}


		}



		private bool ValidateConfIDField()
		{
			bool confIDIsValid = false;

			string confID = txtConfID.Text;

			if (Regex.IsMatch(confID, confIDRegEx))
			{
				confIDIsValid = true;
			}

			return confIDIsValid;
		}

		private bool ValidateSurname()
		{
			return txtSurname.Text.Length >= SurnameMinLength;
		}

		private bool ValidateFirstName()
		{
			return txtFirstName.Text.Length >= FirstNameMinLength;
		}

		private void SaveRegistrationInfo()
		{
			using (Stream fs = File.Open(filePath, FileMode.OpenOrCreate))
			{
				using (BinaryWriter writer = new BinaryWriter(fs))
				{
					try
					{
						writer.Write(txtFirstName.Text);
						writer.Write(txtSurname.Text);
						writer.Write(txtOrg.Text);
						writer.Write(txtConfID.Text);
						MessageBox.Show("Binary file created and written to successfully");
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
			}
		}


	}
}
