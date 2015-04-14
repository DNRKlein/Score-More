
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
	[Activity (Label = "Score-More", Icon = "@drawable/icon", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]		
	public class VraagInvoer1Activity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Vraaginvoer1);

			// Meerkeuzevraag met 1 goed antwoord

//			Button button_Antwoord = FindViewById<Button> (Resource.Id.antwoord);
			Button button_Toevoegen = FindViewById<Button> (Resource.Id.toevoegen);

//			button_Antwoord.Click += delegate {
//				new EditText
//			};

			button_Toevoegen.Click += delegate {
				StartActivity (typeof(VraagInvoerSlotActivity));
			};
	
		}
	}
}

