
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
	[Activity (Label = "FeedbackActivity")]			
	public class FeedbackActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.trainingFeedback);

			Button button_mainMenu = FindViewById<Button> (Resource.Id.but_hoofdmenu);

			// Create your application here
			button_mainMenu.Click += delegate {
				StartActivity(typeof(MainMenuActivity));
			};
		}
	}
}

