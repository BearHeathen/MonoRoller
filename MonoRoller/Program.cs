using System;

namespace MonoRoller
{
	class MainClass
	{
		// DIE TYPES
		public const int D4 = 4;
		public const int D6 = 6;
		public const int D8 = 8;
		public const int D10 = 10;
		public const int D12 = 12;
		public const int D20 = 20;
		public const int D100 = 100;

		public static string numDice, dieType;
		public static int newNumDice, newDieType, newDie;

		public static void Main (string[] args)
		{

			// Dice Rolling application
			int myRoll = 0;
			char answer;
			bool playAgain = false;

			do {

				//Input
				Console.WriteLine("\nDice Roller");
				Console.WriteLine("-----------");
				Console.WriteLine();

				pickDice();

				Console.WriteLine("\nDo you wish to roll " + newNumDice + "D" +
					newDie + "?\n");
								
				answer = Console.ReadKey().KeyChar;

				//Processing
				if (answer == 'y' || answer == 'Y') {
					Console.WriteLine();
					Console.WriteLine();
					newNumDice = int.Parse(numDice);
					myRoll = rollDie(newNumDice, newDie);

					//Output
					printRoll(myRoll, newNumDice, newDie);
				} else {
					Console.WriteLine("Thank you!\n");
					playAgain = true;
				}

				Console.WriteLine("\nDo you wish to roll again?\n");
				answer = Console.ReadKey().KeyChar;

				if(answer == 'Y' || answer == 'y'){
					playAgain = false;

				}else{
					Console.WriteLine();
					Console.WriteLine("\nGoodbye!");
					playAgain = true;
				}

			} while (!playAgain);
		}

		public static void pickDice()
		{
			
			Console.WriteLine("Enter the number dice "
				+ "you would like to roll: ");
			numDice = Console.ReadLine();
			newNumDice = int.Parse (numDice);

			Console.WriteLine("You chose: " + newNumDice + " dice.");
			Console.WriteLine("");

			Console.WriteLine("Choose the die to roll: ");
			Console.WriteLine("------------------------");
			Console.WriteLine("1.) D4");
			Console.WriteLine("2.) D6");
			Console.WriteLine("3.) D8");
			Console.WriteLine("4.) D10");
			Console.WriteLine("5.) D12");
			Console.WriteLine("6.) D20");
			Console.WriteLine("7.) D100");
			Console.WriteLine("");
			dieType = Console.ReadLine();
			newDieType = int.Parse (dieType);

			switch(newDieType){
			case 1: newDie = D4;
				break;
			case 2: newDie = D6;
				break;
			case 3: newDie = D8;
				break;
			case 4: newDie = D10;
				break;
			case 5: newDie = D12;
				break;
			case 6: newDie = D20;
				break;
			case 7: newDie = D100;
				break;
			default: Console.WriteLine("Invalid die type\n");
				break;
			}
		}

		public static int rollDie(int numDice, int die)
		{
			int roll;
			int total = 0;
			Random rand = new Random();

			for(int i = 1; i < (numDice) + 1; i++){
				roll = (rand.Next(1, (die + 1)));
				Console.WriteLine("Roll " + i + ": " + roll + "\t");
				total += roll;

			}

			return total;
		}

		public static void printRoll(int roll, int numDice, int die)
		{
			Console.WriteLine("\nThe result of rolling " + numDice + "D" + die +
				" is: " + roll);
		}

	}
}
