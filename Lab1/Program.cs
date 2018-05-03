using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
	/* Lab 1
	 * Task: Calculate the perimeter, area, and volume of various classrooms at Grand Circus.
	 * The application will:
	 * 1. Prompt for user input.
	 * 2. Display the perimeter, area, and volume of the classroom.
	 * 3. Prompt the user to continue.
	 * Build specifications:
	 * 1. Assume the rooms are perfect triangles and the user will enter valid numeric data.
	 * 2. The application should accept decimal entries.
	 */
	class Program
	{
		static void Main(string[] args)
		{
			bool run = true;
			while (run == true)
			{
				Console.WriteLine("Welcome to Grand Circus' Room Detail Generator! \nPlease enter a length:");
				var length = float.Parse(Console.ReadLine());
				Console.WriteLine("Now enter a width:");
				var width = float.Parse(Console.ReadLine());
				Console.WriteLine("Thanks for that. Lastly, enter a height:");
				var height = float.Parse(Console.ReadLine());

				float perimeter = (length + width) * 2;
				float area = (width * length);
				float volume = (length * height * width);
				Console.WriteLine(perimeter + " is the perimeter. \n" + area + " is the area. \n" + volume + " is the volume.");
				Console.ReadLine();

				run = Continue();
			}
		}
		public static bool Continue()
		{
			Console.WriteLine("Do you wish to continue? y/n");
			string input = Console.ReadLine();
			input = input.ToLower();
			bool goOn;
			if (input == "y")
			{
				goOn = true;
			}
			else if (input == "n")
			{
				goOn = false;
			}
			else
			{
				Console.WriteLine("I don't understand that, let's try again");
				goOn = Continue();
			}
			return goOn;
		}
	}
}