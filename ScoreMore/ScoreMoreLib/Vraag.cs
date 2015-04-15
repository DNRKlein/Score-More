using System;
using Android.Graphics;
using System.Collections.Generic;

namespace ScoreMoreLib
{
	public class Vraag
	{
		private VraagType vraagType;
		private string vraag;
		private string[] antwoorden;

		public Vraag (string vraag, string[] antwoorden)
		{
			this.vraag = vraag;
			this.antwoorden = antwoorden;

			
		}

		public string GetVraag(){
			return vraag;
		}

		public string[] GetAntwoorden(){
			return antwoorden;
		}

		public void Invoer(){
			switch (vraagType) {
			case VraagType.MeerkeuzeSingulier:
				//Haal invulscherm op en display;
				break;
			case VraagType.MeerkeuzeMultipel:
				//Haal invulscherm op en display;
				break;
			case VraagType.Open:
				//Haal invulscherm op en display;
				break;

			default:
				break;

			}
		}


		/*Swipe
		private void Grid_ManipulationStarted_1(object sender, ManipulationStartedRoutedEventArgs e)
		{
			initialpoint = e.Position;
		}
		//Swipe
		private void Grid_ManipulationDelta_1(object sender, ManipulationDeltaRoutedEventArgs e)
		{
			if (e.IsInertial) {
				Point currentpoint = e.Position;
				if (currentpoint.X - initialpoint.X >= 500) {//500 is the threshold value, where you want to trigger the swipe right event
					System.Diagnostics.Debug.WriteLine ("Swipe Right");
					e.Complete ();
				}
				if (currentpoint.X - initialpoint.X <= -500) {
					System.Diagnostics.Debug.WriteLine ("Swipe Left");
					e.Complete ();
				}
			}
		}*/
	}
}

