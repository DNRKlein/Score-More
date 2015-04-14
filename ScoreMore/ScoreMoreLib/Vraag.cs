using System;
using Android.Graphics;

namespace ScoreMoreLib
{
	public class Vraag
	{
		private int vraagid;
		private VraagType vraagType;

		public Vraag (int vraagid)
		{
			this.vraagid = vraagid;
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
	}
}

