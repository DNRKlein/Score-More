
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
	public class VraaginvoerActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.VraagInvoerMain);

			//Buttons VraaginvoerOnderwerpKeuze


			
			// Buttons VraagInvoerMain. (later ook voor Open Vraag)
			Button button_Singulier = FindViewById<Button> (Resource.Id.singulier);
			Button button_Multipel = FindViewById<Button> (Resource.Id.multipel);

			button_Singulier.Click += delegate {
				StartActivity(typeof(VraagInvoer1Activity));
			};

			button_Multipel.Click += delegate {
				StartActivity(typeof(VraagInvoer2Activity));
			};
		}
	}
}

