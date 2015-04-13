<<<<<<< HEAD
﻿using System;
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
	public class MaakTrainingActivity : Activity
	{
		private Onderwerp[] onderwerpenList;

		private Onderwerp pit_1 = new Onderwerp ("Mobile Applications", null);
		private Onderwerp if_5 = new Onderwerp ("ICT Foundation 5", null);

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.MaakTraining);

			onderwerpenList = new Onderwerp[]{ pit_1, if_5 };
			string[] onderwerpTitels = {onderwerpenList[0].getTitel(), onderwerpenList[1].getTitel()};

			/*for(int i = 0; i < onderwerpenList.Length; i++){
				onderwerpTitels[i] = onderwerpenList[i].getTitel();
			}*/
			RunOnUiThread(() =>
				{
				ListView listview = FindViewById<ListView> (Resource.Id.listview1);
				listview.Adapter = new ArrayAdapter<String> (this, Android.Resource.Layout.SimpleListItem1, onderwerpTitels);
				});
		}
	}
}

=======
﻿using System;
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
	public class MaakTrainingActivity : Activity
	{
		private Onderwerp[] onderwerpenList;

		private Onderwerp pit_1 = new Onderwerp ("Mobile Applications", null);
		private Onderwerp if_5 = new Onderwerp ("ICT Foundation 5", null);

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.MaakTraining);

			onderwerpenList = new Onderwerp[]{ pit_1, if_5 };
			string[] onderwerpTitels = {onderwerpenList[0].getTitel(), onderwerpenList[1].getTitel()};

			/*for(int i = 0; i < onderwerpenList.Length; i++){
				onderwerpTitels[i] = onderwerpenList[i].getTitel();
			}*/

			ListView listview = FindViewById<ListView> (Resource.Id.listview1);
			listview.Adapter = new ArrayAdapter<String> (this, Android.Resource.Layout.SimpleListItem1, onderwerpTitels);
			
		}
	}
}

>>>>>>> fb683cd046985978de714056ee7882c790d51bbb
