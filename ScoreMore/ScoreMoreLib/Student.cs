using System;
using System.IO;

namespace ScoreMoreLib
{
	public class Student
	{
		private string email;
		private string wachtwoord;
		private bool administrator;

		//private list<int> groep;
		//private list<int> panel;
		//private list<int> trainingsresultaten;

		public void saveAccount(string email, string wachtwoord){
			string account_info = String.Format("{0}, {1}", email, wachtwoord);

			// Opslaan van data in account.txt
			using (StreamWriter w = File.AppendText("Accounts.txt"))
			{
				w.WriteLine(account_info);
				w.Close();
			}
		}

		public Student (string email_value, string wachtwoord_value){
			email = email_value;
			wachtwoord = wachtwoord_value; 
			administrator = false; 		// variabele die bepaalt of een gebruiker beheerder is of niet.

			// wegschrijven van de data in de 'database'
			saveAccount (email, wachtwoord);
		}



		// opvragen of veranderen van e-mail.
		public string gsStudentEmail{
			get {
				return this.email;
			}
			set {
				this.email = value;
			}
		}

		// opvragen of veranderen van wachtwoord.
		public string gsStudentWachtwoord {
			get {
				return this.wachtwoord;
			}
			set {
				this.wachtwoord = value;
			}
		}

		// opvragen of veranderen van gebruikersstatus.
		public bool gsStudentAdmin {
			get {
				return this.administrator;
			}
			set {
				this.administrator = value;
			}
		}
	}
}

