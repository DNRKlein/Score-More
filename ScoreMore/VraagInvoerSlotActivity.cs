
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
	[Activity (Label = "VraagInvoerSlotActivity")]			
	public class VraagInvoerSlotActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.VraaginvoerSlot);
				
			//Buttons Slot
			Button button_VraagReturn = FindViewById<Button> (Resource.Id.vraagreturn);
			Button button_VraagHoofdmenu = FindViewById<Button> (Resource.Id.vraaghoofdmenu);

			button_VraagReturn.Click += delegate {
				StartActivity (typeof(VraaginvoerActivity));
			};

			button_VraagHoofdmenu.Click += delegate {
				StartActivity (typeof(MainMenuActivity));
			};

		}
	}
}

