﻿
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
	[Activity (Label = "Score-More")]			
	public class VraagInvoer1Activity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Vraaginvoer1);

			// Create your application here

//			Button button_Antwoord = FindViewById<Button> (Resource.Id.antwoord);
			Button button_Toevoegen = FindViewById<Button> (Resource.Id.toevoegen);

//			button_Antwoord.Click += delegate {
//				StartActivity (typeof(VraaginvoerActivity));
//			};

			button_Toevoegen.Click += delegate {
				StartActivity (typeof(VraagInvoerSlotActivity));
			};
	
		}
	}
}
