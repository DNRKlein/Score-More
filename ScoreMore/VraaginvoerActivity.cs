
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
	[Activity (Label = "ScoreMore")]			
	public class VraaginvoerActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.VraagInvoerMain);

			//Buttons VraaginvoerOnderwerpKeuze


			
			// Buttons VraagInvoerMain. (later ook voor Open Vraag)
			Button button_Singulier = FindViewById<Button> (Resource.Id.singulier);
			Button button_Multipel = FindViewById<Button> (Resource.Id.multipel);

			button_Singulier.Click += delegate {
				SetContentView (Resource.Layout.Vraaginvoer1);
			};

			button_Multipel.Click += delegate {
				SetContentView (Resource.Layout.Vraaginvoer2);
			};

			//Buttons Singulier
			Button button_Toevoegen = FindViewById<Button> (Resource.Id.toevoegen);
			Button button_Antwoord = FindViewById<Button> (Resource.Id.antwoord);

			button_Toevoegen.Click += delegate {

			};

			//De vraag onthouden, werkt nog niet.
//			EditText edittext = FindViewById&lt;EditText&gt;(Resource.Id.edittext);
//			edittext.KeyPress += (object sender, View.KeyEventArgs e) =&gt; {
//				e.Handled = false;
//				if (e.Event.Action == KeyEventActions.Down && e.KeyCode == Keycode.Enter) {
//					Toast.MakeText (this, edittext.Text, ToastLength.Short).Show ();
//					e.Handled = true;
//				}
//			};

			button_Antwoord.Click += delegate {
				SetContentView(Resource.Layout.VraaginvoerSlot);
			};

			//Buttons Multipel



			//Buttons Slot
			Button button_VraagReturn = FindViewById<Button> (Resource.Id.vraagreturn);
			Button button_VraagHoofdmenu = FindViewById<Button> (Resource.Id.vraaghoofdmenu);

			button_VraagReturn.Click += delegate {
				SetContentView (Resource.Layout.vraaginvoerOnderwerpkeuze);
			};

			button_VraagHoofdmenu.Click += delegate {
				SetContentView(Resource.Layout.MainMenu);
			};

		}
	}
}

