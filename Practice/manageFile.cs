using System;
using System.IO;

namespace Practice
{
	public class manageFile
	{
		public static void Main(string[] args) {
			testWriteText ();
			testReadText ();
		}

		public static void testWriteText() {
			string sentence = " ";
			StreamWriter myfile;
			myfile = File.CreateText("test.txt");
			do
			{
				Console.Write("Enter a sentence: ");
				sentence = Console.ReadLine();
				if (sentence.Length != 0) 
				{
					myfile.WriteLine(sentence);
				}
			}
			while(sentence.Length != 0);
			myfile.Close();
		}
		public static void testReadText() {
			Console.Write ("Enter name of file: ");
			string nameFile = Console.ReadLine ();

			StreamReader myfile;
			try { 
				myfile = File.OpenText (nameFile);
				string line = " ";
				do {
					line = myfile.ReadLine ();
					if (line != null) {
						Console.WriteLine (line);
					}
				} while (line != null);
			} catch (Exception e) {
				Console.WriteLine ("Error al intentar abir el fichero.");
			}
		}
	}
}

