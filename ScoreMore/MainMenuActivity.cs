
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

			//Button naar vraag invoeren scherm
			Button button_menuvraag = FindViewById<Button> (Resource.Id.menu_vraag);
			button_menuvraag.Click += delegate {
				StartActivity(typeof(VraaginvoerActivity));
			};
		}
	}
}

