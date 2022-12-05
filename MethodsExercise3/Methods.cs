/*
Use as many descriptive names as possible. I do not want to see myInt1 - 100!
For training purposes, most if not all the data for these methods can come from user input.
Each one of these methods should be called from Main() and declared in the Program class.
Be as creative as you want, the goal is to have working methods but if you want to make them look nice, go for it.
As in Num 6 w/ age and voting method, you can say “You may vote” or “Looks like you're too young this time!” based on their age.
This project should work in a manner where if someone forks/clones this from GitHub,
they can just press the play button and have every method run in sequence, so all interface dialogue should be in place already.
When finished, push this to GitHub!

*/

using System;
namespace MethodsExercise3
{
	public class Methods
	{
		public void Answer(int numbers)
		{
			//•	Write a method that will print to the console all numbers 1000 through -1000

			do
			{
				Console.WriteLine(numbers);
				--numbers;

			} while (numbers<= 1000 && numbers >=- 1000);


        }
    }
}

