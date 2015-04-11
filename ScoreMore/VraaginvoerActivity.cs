
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
	[Activity (Label = "VraaginvoerActivity")]			
	public class VraaginvoerActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.VraagInvoerMain);

			// Buttons VraagInvoerMain. (later ook voor Open Vraag)
			Button button_Singulier = FindViewById<Button> (Resource.Id.singulier);
			Button button_Multipel = FindViewById<Button> (Resource.Id.multipel);

			button_Singulier.Click += delegate {
				SetContentView (Resource.Layout.Vraaginvoer1);
			};

			button_Multipel.Click += delegate {
				SetContentView (Resource.Layout.Vraaginvoer2);
			};
		}
	}
}

