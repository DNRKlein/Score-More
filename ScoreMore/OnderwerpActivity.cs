
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;

namespace ScoreMore
{
	[Activity (Label = "OnderwerpActivity")]			
	public class OnderwerpActivity : ListActivity
	{
		private ArrayAdapter adapter;
		//private ListView listview;

		private string[] itemList;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			//achtergrondkleur van deze activity  
			this.Window.DecorView.SetBackgroundColor (Color.White);
			//this.Window.DecorView.Text

			itemList = new string[] {"item 1", "item 2", "item 3"};
			//listview = FindViewById<ListView> (Resource.Id.onderwerp_listview);

			adapter = new ArrayAdapter<String>(this.ApplicationContext, Resource.Layout.ListOnderwerpheader, Resource.Id.onderwerp_textview, itemList);
			ListAdapter = adapter;
		}
	}
}

