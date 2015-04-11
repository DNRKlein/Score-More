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
	[Activity]			
	public class MaakTrainingActivity : ListActivity
	{
		private ArrayAdapter adapter;
		private Onderwerp[] onderwerpenList;

		private Onderwerp pit_1 = new Onderwerp ("Mobile Applications", null);
		private Onderwerp if_5 = new Onderwerp ("ICT Foundation 5", null);

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			onderwerpenList = new Onderwerp[]{ pit_1, if_5 };
			string[] onderwerpTitels = {onderwerpenList[0].getTitel(), onderwerpenList[1].getTitel()};

			/*for(int i = 0; i < onderwerpenList.Length; i++){
				onderwerpTitels[i] = onderwerpenList[i].getTitel();
			}*/

			adapter = new ArrayAdapter<String> (this, Android.Resource.Layout.SimpleListItemActivated1, onderwerpTitels);
			ListAdapter = adapter;
		}
	}
}

