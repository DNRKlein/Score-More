
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
	[Activity (Label = "ScoreMore")]			
	public class VraagInvoer2Activity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Vraaginvoer2);

			//Buttons Multipel

//			Button button_Antwoord2 = FindViewById<Button> (Resource.Id.antwoord2);
//			Button button_Goede_Antwoord2 = FindViewById<Button> (Resource.Id.goede_antwoord2);
			Button button_Toevoegen2 = FindViewById<Button> (Resource.Id.toevoegen2);

//			button_Antwoord2.Click += delegate {
//				
//			};
//
//			button_Goede_Antwoord2.Click += delegate {
//
//			};
//
			button_Toevoegen2.Click += delegate {
				StartActivity (typeof(VraagInvoerSlotActivity));
			};

		}
	}
}

