using System;

namespace ScoreMoreLib
{
	public class Onderwerp
	{
		private Onderwerp parent;
		private string titel;

		public Onderwerp (Onderwerp parent, string titel)
		{
			this.parent = parent;
			this.titel = titel;
		}

		public Onderwerp getParent(){
			return parent;
		}

		public void setParent(Onderwerp parent){
			this.parent = parent;
		}

		public string getTitel(){
			return titel;
		}

		public void setTitel(string titel){
			this.titel = titel;
		}

		/// <summary>
		/// Schrijf Onderwerp naar het Onderwerp file.
		/// </summary>
		public void writeToFile(){

		}
	}
}

