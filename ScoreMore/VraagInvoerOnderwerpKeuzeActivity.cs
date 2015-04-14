
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
	public class VraagInvoerOnderwerpKeuzeActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "Main" layout resource
			SetContentView (Resource.Layout.vraaginvoerOnderwerpkeuze);

			Button button_Vraaginvoervolgende = FindViewById<Button> (Resource.Id.vraaginvoervolgende);

			button_Vraaginvoervolgende.Click += delegate {
				StartActivity (typeof(VraaginvoerActivity));
			};
			

			Spinner spinner = FindViewById<Spinner> (Resource.Id.spinner);

			spinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs> (spinner_ItemSelected);
			var adapter = ArrayAdapter.CreateFromResource (
				this, Resource.Array.onderwerp_lijst, Android.Resource.Layout.SimpleSpinnerItem);

			adapter.SetDropDownViewResource (Android.Resource.Layout.SimpleSpinnerDropDownItem);
			spinner.Adapter = adapter;

			Spinner spinner1 = FindViewById<Spinner> (Resource.Id.spinner1);

			spinner1.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs> (spinner1_ItemSelected);
			var adapter1 = ArrayAdapter.CreateFromResource (
				this, Resource.Array.subonderwerp_lijst, Android.Resource.Layout.SimpleSpinnerItem);

			adapter.SetDropDownViewResource (Android.Resource.Layout.SimpleSpinnerDropDownItem);
			spinner1.Adapter = adapter1;
		}

		private void spinner_ItemSelected (object sender, AdapterView.ItemSelectedEventArgs e)
		{
			Spinner spinner = (Spinner)sender;

			string toast = string.Format ("Het gekozen onderwerp is {0}", spinner.GetItemAtPosition (e.Position));
			Toast.MakeText (this, toast, ToastLength.Long).Show ();
		}

		private void spinner1_ItemSelected (object sender, AdapterView.ItemSelectedEventArgs e)
		{
			Spinner spinner1 = (Spinner)sender;

			string toast = string.Format ("Het gekozen subonderwerp is {0}", spinner1.GetItemAtPosition (e.Position));
			Toast.MakeText (this, toast, ToastLength.Long).Show ();
		}
	}
}

