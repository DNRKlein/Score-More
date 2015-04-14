
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
	[Activity (Label = "Score-More", Icon = "@drawable/icon")]	
	public class Vraag1 : Activity, GestureDetector.IOnGestureListener
	{
		private TextView vraag;
		private List<Vraag> vragen;
		private Vraag vraag1;
		private Vraag vraag2;
		private Vraag vraag3;
		private Vraag vraag4;
		private Vraag huidigeVraag;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private int vraagIndex = 0;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Vraag1Layout);
			vragen = new List<Vraag> ();
			vraag1 = new Vraag ("Wat is de hoofdstad van Nederland?", new string[] {
				"Amsterdam",
				"Groningen",
				"Eindhoven",
				"Rotterdam"
			});
			vraag2 = new Vraag ("Wat is de hoofdstad van Duitsland?", new string[]{ "Berlijn", "München", "Hamburg", "Frankfurt" });
			vraag3 = new Vraag ("Wat is de hoofdstad van Italië?", new string[]{ "Rome", "Milaan", "Florence", "Venetië" });
			vraag4 = new Vraag ("Wat is de hoofdstad van Spanje?", new string[] {
				"Madrid",
				"Barcelona",
				"Lloret de Mar",
				"Malaga"
			});
			vragen.Add (vraag1);
			vragen.Add (vraag2);
			vragen.Add (vraag3);
			vragen.Add (vraag4);

			button1 = FindViewById<Button> (Resource.Id.button1);
			button2 = FindViewById<Button> (Resource.Id.button2);
			button3 = FindViewById<Button> (Resource.Id.button3);
			button4 = FindViewById<Button> (Resource.Id.button4);
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


