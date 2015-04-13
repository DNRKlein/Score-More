using System;
using System.Collections.Generic;
using System.Linq;

using Android.Widget;
using Android.App;
using Android.Views;

using ScoreMoreLib;

namespace ScoreMore
{
	public class SimpleListItemMulptipleChoiceAdapter : BaseAdapter<Onderwerp>
	{

		private List<Onderwerp> onderwerpenLijst;
		private readonly Activity activity;

		public SimpleListItemMulptipleChoiceAdapter (Activity activity, List<Onderwerp> onderwerpen)
		{
			onderwerpenLijst = onderwerpen;
			this.activity = activity;
		}

		public override long GetItemId(int position){
			return position;
		}

		public override Onderwerp this [int index]{
			get { return onderwerpenLijst [index]; }
		}

		public override int Count{
			get { return onderwerpenLijst.Count;}
		}

		public override View GetView(int position, View convertView, ViewGroup parent){
			View view = convertView;
			if (view == null) {
				view = activity.LayoutInflater.Inflate (Android.Resource.Layout.SimpleListItemMultipleChoice, null);
			}

			Onderwerp onderwerp = onderwerpenLijst [position];
			TextView textView = view.FindViewById<TextView> (Android.Resource.Id.Text1);
			textView.Text = onderwerp.getTitel();
			textView.SetTextSize(Android.Util.ComplexUnitType.Dip, (float) 40.0);

			return view;
		}
	}
}

