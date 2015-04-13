<<<<<<< HEAD
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


﻿
=======
=======
<<<<<<< HEAD
>>>>>>> e791bdae7693d0e5fb84db80f6baea570a5dd781
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
		private List<Onderwerp> onderwerpenList;

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



			ListView listview = FindViewById<ListView> (Resource.Id.listview1);
			listview.Adapter = new SimpleListItemMulptipleChoiceAdapter (this, onderwerpenList);
<<<<<<< HEAD

			TextView textView = listview.FindViewById<TextView> (Android.Resource.Id.Text1);
=======
>>>>>>> e791bdae7693d0e5fb84db80f6baea570a5dd781
		}
	}
}

<<<<<<< HEAD
>>>>>>> origin/master
=======
=======
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


﻿
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
		private List<Onderwerp> onderwerpenList;

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



			ListView listview = FindViewById<ListView> (Resource.Id.listview1);
			listview.Adapter = new SimpleListItemMulptipleChoiceAdapter (this, onderwerpenList);

			TextView textView = listview.FindViewById<TextView> (Android.Resource.Id.Text1);
		}
	}
}

>>>>>>> origin/master
>>>>>>> 176bca71d06ef35e95007fe04580a392b9c4386a
>>>>>>> e791bdae7693d0e5fb84db80f6baea570a5dd781
