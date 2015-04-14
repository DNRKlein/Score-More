
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


namespace ScoreMore
{
	[Activity (Label = "Vraag1")]			
	public class Vraag1 : Activity, GestureDetector.IOnGestureListener
	{
		private TextView vraag;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Vraag1Layout);





			Button button1 = FindViewById<Button> (Resource.Id.button1);
			Button button2 = FindViewById<Button> (Resource.Id.button2);
			Button button3 = FindViewById<Button> (Resource.Id.button3);
			Button button4 = FindViewById<Button> (Resource.Id.button4);
			vraag = FindViewById<TextView> (Resource.Id.textView1);
			gestureDetector = new GestureDetector (this);

			//			GestureDetector.SimpleOnGestureListener listener = new MyGestureListener();
			//			gestureDetector = new GestureDetector(this, listener);





			button1.Click += delegate {
				button1.SetBackgroundColor(Android.Graphics.Color.Green);
				button1.SetOnClickListener(null);
				button2.SetOnClickListener(null);
				button3.SetOnClickListener(null);
				button4.SetOnClickListener(null);

			};


			button2.Click += delegate {
				button2.SetBackgroundColor(Android.Graphics.Color.Red);
				button1.SetBackgroundColor(Android.Graphics.Color.Green);
				button1.SetOnClickListener(null);
				button2.SetOnClickListener(null);
				button3.SetOnClickListener(null);
				button4.SetOnClickListener(null);
			};

			button3.Click += delegate {
				button3.SetBackgroundColor(Android.Graphics.Color.Red);
				button1.SetBackgroundColor(Android.Graphics.Color.Green);
				button1.SetOnClickListener(null);
				button2.SetOnClickListener(null);
				button3.SetOnClickListener(null);
				button4.SetOnClickListener(null);
			};

			button4.Click += delegate {
				button4.SetBackgroundColor(Android.Graphics.Color.Red);
				button1.SetBackgroundColor(Android.Graphics.Color.Green);
				button1.SetOnClickListener(null);
				button2.SetOnClickListener(null);
				button3.SetOnClickListener(null);
				button4.SetOnClickListener(null);
			};
				

		}
		private GestureDetector gestureDetector;
		private static int swipe_grens = 100;
		private static int swipe_snelheid_grens = 100;
		private List<String> pagina = new List<String>{"Wat is de hoofdstad van Nederland?","Wat vindt u van deze app?"};
		private int i = 0;



		public bool OnFling(MotionEvent e1,MotionEvent e2, float velocityX, float velocityY)
		{
			float verschilY = e2.GetY() - e1.GetY();
			float verschilX = e2.GetX() - e1.GetX(); 

			if (Math.Abs (verschilX) > Math.Abs (verschilY)) {
				if (Math.Abs (verschilX) > swipe_grens && Math.Abs (velocityX) > swipe_snelheid_grens) {
					if (verschilX > 0) {
						String nu = "Swipe Rechts";
						Toast.MakeText (this, nu, ToastLength.Short).Show ();
						if (i > 0 && i < pagina.Count){
							i = i - 1; 
							vraag.Text = pagina[i];
						}
						return true;
					} else {
						String nu = "Swipe Links";
						Toast.MakeText (this, nu, ToastLength.Short).Show ();
						if (i > -1 && i < pagina.Count - 1) {
							i = i + 1;
							vraag.Text = pagina [i];
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


		public void SwipeRechts()
		{
			StartActivity(typeof(VolgendeActivity));
		}

		public void SwipeLinks()
		{
			StartActivity(typeof(Vraag1));
		}

	}
}


