using System;
using System.IO;

namespace ScoreMoreLib
{
	public class Onderwerp
	{
		private Onderwerp parent;
		private string titel;

		public Onderwerp (string titel, Onderwerp parent)
		{
			this.titel = titel;
			this.parent = parent;
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
		/// 
		/// Pakt de titel van dit onderwerp en de titel van het parentOnderwerp,
		/// schrijft deze lijn voor lijn naar een file dat in deze lib staat.
		/// </summary>
		public void writeToFile(){
			string line = getTitel () + ", " + getParent ().getTitel ();

			try{
				StreamWriter strWriter = new StreamWriter("OnderwerpenTextFile.txt");
				strWriter.WriteLine(line);
				strWriter.Close();
			}

			catch(FileNotFoundException ex){
				Console.WriteLine (ex);
			}
		}
	}
}

