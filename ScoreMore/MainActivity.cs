using System;
using System.IO;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ScoreMore
{
	[Activity (Label = "Studentklasse", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		//int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.registreren);

			// Get our button from the layout resource,
			// and attach an event to it

			Button button_registreren = FindViewById<Button> (Resource.Id.but_registreren);
			EditText inv_email = FindViewById<EditText> (Resource.Id.inv_email);
			EditText inv_wachtwoord = FindViewById<EditText> (Resource.Id.inv_wachtwoord);
			EditText her_wachtwoord = FindViewById<EditText> (Resource.Id.her_wachtwoord);
			TextView txt_waarschuwing = FindViewById<TextView> (Resource.Id.txt_waarschuwing);

			button_registreren.Click += delegate {
				// Zodra de gebruiker op registreren klikt
				// Controleer of alles juist is ingevuld

				// Controleer of alles is ingevuld
				if (inv_email.Text == "" || inv_wachtwoord.Text == "" || her_wachtwoord.Text == "")
				{
					txt_waarschuwing.Text = String.Format("Niet alles is ingevuld!");
					return;}
				else{
					txt_waarschuwing.Text = String.Format("Stage 1 completed.");
				}

				// Controleren of beide wachtwoorden overeenkomen
				if (inv_wachtwoord.Text != her_wachtwoord.Text) {
					txt_waarschuwing.Text = String.Format("Wachtwoorden komen niet overeen!");
					return;
				}
				else{
					txt_waarschuwing.Text = String.Format("Stage 2 completed.");
				}

				// Controleren of wachtwoord lang genoeg is 
				// Minimum is 5 karakters.
				if (inv_wachtwoord.Text.Length < 5)
				{
					txt_waarschuwing.Text = String.Format("Wachtwoord is te kort");
					return;
				}else{
					txt_waarschuwing.Text = String.Format("Stage 3 completed.");
				}

				// Controleren of het emailadres geldig is.
				if (inv_email.Text.IndexOf("@") == -1)
				{
					txt_waarschuwing.Text = String.Format("Geen geldig emailadres");
					return;
				}else{
					txt_waarschuwing.Text = String.Format("Stage 4 completed.");
				}

				// Controleren of het account al bestaat.


				// Aanmaken van een studentobject.
				string email_value = inv_email.Text;
				string wachtwoord_value = inv_wachtwoord.Text;

				new Student(email_value, wachtwoord_value);
				txt_waarschuwing.Text = String.Format("Het account is aangemaakt met de naam {0}", inv_email.Text);

				// overschakelen naar mainscreen --
			};
		}
	}
}



