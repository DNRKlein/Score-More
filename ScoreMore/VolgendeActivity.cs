
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
	[Activity (Label = "Score-More", Icon = "@drawable/icon")]		
	public class VolgendeActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Vraag1Layout);


			Button button1 = FindViewById<Button> (Resource.Id.button1);
			Button button2 = FindViewById<Button> (Resource.Id.button2);
			Button button3 = FindViewById<Button> (Resource.Id.button3);
			Button vorige = FindViewById<Button> (Resource.Id.button4);




			button1.Click += delegate {
				button1.SetBackgroundColor(Android.Graphics.Color.Green);
				button1.SetOnClickListener(null);
				button2.SetOnClickListener(null);
				button3.SetOnClickListener(null);

			};
			button2.Click += delegate {
				button2.SetBackgroundColor(Android.Graphics.Color.Red);
				button1.SetBackgroundColor(Android.Graphics.Color.Green);
				button1.SetOnClickListener(null);
				button2.SetOnClickListener(null);
				button3.SetOnClickListener(null);

			};
			button3.Click += delegate {
				button3.SetBackgroundColor(Android.Graphics.Color.Red);
				button1.SetBackgroundColor(Android.Graphics.Color.Green);
				button1.SetOnClickListener(null);
				button2.SetOnClickListener(null);
				button3.SetOnClickListener(null);

			};

			vorige.Click += delegate {
				StartActivity(typeof(Vraag1));
			};
		}
	}
}

