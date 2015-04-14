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

using ScoreMoreLib;

namespace ScoreMore
{
	[Activity (Label = "Score-More", Icon = "@drawable/icon")]
	public class MaakTrainingActivity : Activity
	{
		private List<Onderwerp> onderwerpenList;
		private List<Onderwerp> checkedItems;

		private Onderwerp pit_1 = new Onderwerp ("Mobile Applications", null);
		private Onderwerp if_5 = new Onderwerp ("ICT Foundation 5", null);
		private Onderwerp pit_2 = new Onderwerp ("Embedded Applications", null);
		private Onderwerp if_6 = new Onderwerp ("ICT Foundation 6", null);

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.MaakTraining);

			onderwerpenList = new List<Onderwerp>();
			onderwerpenList.Add (pit_1);
			onderwerpenList.Add (if_5);
			onderwerpenList.Add (pit_2);
			onderwerpenList.Add (if_6);

			checkedItems = new List<Onderwerp> ();

			ListView listview = FindViewById<ListView> (Resource.Id.listview1);
			listview.Adapter = new SimpleListItemMulptipleChoiceAdapter (this, onderwerpenList);
			listview.ChoiceMode = ChoiceMode.Multiple;

			//listview.ItemClick += OnListItemClick;

			//kijken of de checkedItems wordt gevuld
			Button volgendeButton = FindViewById<Button> (Resource.Id.naarSubsButton);

			volgendeButton.Click += delegate {
				StartActivity (typeof(Vraag1));
			};
		}


//		public void OnListItemClick(object sender, AdapterView.ItemClickEventArgs e){
//			var listview = sender as ListView;
//			Onderwerp check = onderwerpenList [e.Position];
//			//Toast.MakeText (this, check.getTitel (), ToastLength.Short).Show ();
//			checkedItems.Add (check);
//		}
	}
}

