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
using Android.Util;

namespace ScoreMore
{
	[Activity (Label = "Score-More", Icon = "@drawable/icon", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
	public class MaakTrainingActivity : Activity
	{
		//een lijst voor de onderwerpen en een voor de onderwerpen die aangevinkt worden
		private List<Onderwerp> onderwerpenList;
		private List<Onderwerp> checkedItems;

		private ListView listview;

		//onderwerpen
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

			listview = FindViewById<ListView> (Resource.Id.listview1);
			listview.Adapter = new SimpleListItemMulptipleChoiceAdapter (this, onderwerpenList);
			listview.ChoiceMode = ChoiceMode.Multiple;

			//kijken of de checkedItems wordt gevuld
			Button volgendeButton = FindViewById<Button> (Resource.Id.naarSubsButton);

			volgendeButton.Click += delegate {
				SparseBooleanArray checkedPositions = listview.CheckedItemPositions;
				for(int i = 0; i < onderwerpenList.Count; i++){
					if(checkedPositions.Get(i)){
						checkedItems.Add(onderwerpenList[i]); 
					}
				}

				if(checkedItems.Count == 0){
					Toast.MakeText(this, "U heeft geen onderwerp aangevinkt!", ToastLength.Long).Show();
				}

				//de gecheckte items meegeven aan de vraagactivity zodat daar gecontroleerd kan worden op onderwerp
				else{
					Intent vraagActivity = new Intent(this, typeof(Vraag1));
					for(int j = 0; j < checkedItems.Count; j++){
						vraagActivity.PutExtra("key" + j, checkedItems[j].getTitel());
					}
					StartActivity (vraagActivity);
				}
			};
		}
	}
}

