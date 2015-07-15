using System;

namespace cheers
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Console.Write("What is your first name? ");
			string firstName = Console.ReadLine();
			string grandFinale = firstName + " is ... GRAND!";

			for (int i = 0; i < firstName.Length; i++) {
				string gimmeA = "Give me a ";
				string gimmeAn = "Give me an ";


				if(firstName[i] == char.Parse("a") || firstName[i] ==  char.Parse("e") || firstName[i] ==  char.Parse("i") || firstName[i] == char.Parse("o") || firstName[i] ==  char.Parse("u")) {
					Console.WriteLine (gimmeAn + firstName[i]);


				} else {
					Console.WriteLine (gimmeA + firstName[i]);

				}

			}
			Console.WriteLine (grandFinale);

		}
	}
}