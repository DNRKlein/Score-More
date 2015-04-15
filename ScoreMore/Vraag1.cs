
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
using Android.Gestures;
using ScoreMoreLib;


namespace ScoreMore
{
	[Activity (Label = "Score-More", Icon = "@drawable/icon", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]	
	public class Vraag1 : Activity, GestureDetector.IOnGestureListener
	{
		private TextView vraag;
		//de list met de vragen
		private List<Vraag> vragen;

		//de vragen
		private Vraag vraag1;
		private Vraag vraag2;
		private Vraag vraag3;
		private Vraag vraag4;

		//twee onderwerpen voor het prototype
		Onderwerp pit_1 = new Onderwerp("Mobile Applications", null);
		Onderwerp if_5 = new Onderwerp ("ICT Foundation 5", null);

		//de huidige vraag, deze wordt steeds geupdate om hiermee de UI te updaten
		private Vraag huidigeVraag;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Button button5;
		private int vraagIndex = 0;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Vraag1Layout);
			vragen = new List<Vraag> ();
			vraag1 = new Vraag ("Wat is de vorm van een use case in een use case diagram", new string[] {
				"Ovaal",
				"Vierkant",
				"Rechthoek",
				"Zeshoek"
			}, pit_1);

			vraag2 = new Vraag ("Hoe noemt men degene die de use case uitvoert?", new string[]{ 
				"Actor", 
				"Chef", 
				"Uitvoerder", 
				"Dom" 
			}, pit_1);

			vraag3 = new Vraag ("Hoe heet de methode die wordt gebruikt bij het oplossen van een kortste-routeprobleem", new string[]{ 
				"Label Methode", 
				"Snelle Methode", 
				"Kortste Methode", 
				"Geen idee" 
			}, if_5);
			vraag4 = new Vraag ("Hoe heet de methode om de beginoplossing van een transportprobleem te optimaliseren", new string[] {
				"Stepping-Stone methode",
				"Heavy Stone Methode",
				"LightWeight Stone Methode",
				"Knikker Methode"
			}, if_5);

			Bundle extras = Intent.Extras;

			if (extras != null) {
				//hier de vragen toevoegen op basis van de Onderwerpen in de vorige activity
				string ond1 = (string) extras.Get("key0");
				string ond2 = (string) extras.Get ("key1");

				if (ond1 == pit_1.getTitel ()) {
					vragen.Add (vraag1);
					vragen.Add (vraag2);
				}
	
				if(ond2 == pit_1.getTitel ()) {
					vragen.Add (vraag1);
					vragen.Add (vraag2);
				}

				if (ond1 == if_5.getTitel ()) {
					vragen.Add (vraag3);
					vragen.Add (vraag4);
				}

				if (ond2 == if_5.getTitel ()) {
					vragen.Add (vraag3);
					vragen.Add (vraag4);
				}


			}


			button1 = FindViewById<Button> (Resource.Id.button1);
			button2 = FindViewById<Button> (Resource.Id.button2);
			button3 = FindViewById<Button> (Resource.Id.button3);
			button4 = FindViewById<Button> (Resource.Id.button4);
			button5 = FindViewById<Button> (Resource.Id.button5);
			vraag = FindViewById<TextView> (Resource.Id.textView1);
			gestureDetector = new GestureDetector (this);
			huidigeVraag = vragen [vraagIndex];
			Update ();






			button1.Click += delegate {
//				button1.SetBackgroundColor(Android.Graphics.Color.Green);
//				button1.SetOnClickListener(null);
//				button2.SetOnClickListener(null);
//				button3.SetOnClickListener(null);
//				button4.SetOnClickListener(null);

			};


			button2.Click += delegate {
//				button2.SetBackgroundColor(Android.Graphics.Color.Red);
//				button1.SetBackgroundColor(Android.Graphics.Color.Green);
//				button1.SetOnClickListener(null);
//				button2.SetOnClickListener(null);
//				button3.SetOnClickListener(null);
//				button4.SetOnClickListener(null);
			};

			button3.Click += delegate {
//				button3.SetBackgroundColor(Android.Graphics.Color.Red);
//				button1.SetBackgroundColor(Android.Graphics.Color.Green);
//				button1.SetOnClickListener(null);
//				button2.SetOnClickListener(null);
//				button3.SetOnClickListener(null);
//				button4.SetOnClickListener(null);
			};

			button4.Click += delegate {
//				button4.SetBackgroundColor(Android.Graphics.Color.Red);
//				button1.SetBackgroundColor(Android.Graphics.Color.Green);
//				button1.SetOnClickListener(null);
//				button2.SetOnClickListener(null);
//				button3.SetOnClickListener(null);
//				button4.SetOnClickListener(null);
			};

			button5.Click += delegate {
				StartActivity (typeof(FeedbackActivity));
			};
				
				

		}
		private GestureDetector gestureDetector;
		private static int swipe_grens = 100;
		private static int swipe_snelheid_grens = 100;



		public bool OnFling(MotionEvent e1,MotionEvent e2, float velocityX, float velocityY)
		{
			float verschilY = e2.GetY() - e1.GetY();
			float verschilX = e2.GetX() - e1.GetX(); 

			if (Math.Abs (verschilX) > Math.Abs (verschilY)) {
				if (Math.Abs (verschilX) > swipe_grens && Math.Abs (velocityX) > swipe_snelheid_grens) {
					if (verschilX > 0) {
						if (vraagIndex > 0 && vraagIndex < vragen.Count){
							vraagIndex -= 1; 
							huidigeVraag = vragen [vraagIndex];
							Update ();
						}
						return true;
					} else {
						if (vraagIndex > -1 && vraagIndex < vragen.Count - 1) {
							vraagIndex += 1; 
							huidigeVraag = vragen [vraagIndex];
							Update ();
						}
						return false;

					}
				} else {
					return true;
				}

			} else {
				return false;
			}



		}	

		public override bool OnTouchEvent(MotionEvent e)
		{
			gestureDetector.OnTouchEvent(e);
			return false;
		}

		public bool OnDown(MotionEvent e)
		{
			return false;
		}

		public void OnLongPress(MotionEvent e){
		}

		public bool OnScroll(MotionEvent e1, MotionEvent e2, float distanceX, float distanceY)
		{
			return false;
		}

		public void OnShowPress(MotionEvent e){
		}

		public bool OnSingleTapUp(MotionEvent e)
		{
			return false;
		}


	

		public void Update(){
			button1.Text = huidigeVraag.GetAntwoorden() [0];
			button2.Text = huidigeVraag.GetAntwoorden() [1];
			button3.Text = huidigeVraag.GetAntwoorden() [2];
			button4.Text = huidigeVraag.GetAntwoorden() [3];
			vraag.Text = huidigeVraag.GetVraag();
		}
	}
}


