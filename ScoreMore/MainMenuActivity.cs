
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ScoreMore
{
	[Activity]			
	public class MainMenuActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.MainMenu);

			//Button naar training starten scherm
			Button button_menutraining = FindViewById<Button> (Resource.Id.menu_training);

			//Button naar vraag invoeren scherm
			Button button_menuvraag = FindViewById<Button> (Resource.Id.menu_vraag);

			//Button naar groepen scherm
			Button button_menugroepen = FindViewById<Button> (Resource.Id.menu_groepen);

			//Button naar panel scherm
			Button button_menupanel = FindViewById<Button> (Resource.Id.menu_panel);

			button_menutraining.Click += delegate {
				StartActivity(typeof(MaakTrainingActivity));
			};

			button_menuvraag.Click += delegate {
				StartActivity(typeof(VraaginvoerActivity));
			};
		}
	}
}

