using System;

namespace LuckyNumbers
{
    internal class Program
    {
        private static void Main()
        {
            while (true) //Start of my while loop to end or continue playing
            {
                double jackPot = 500.00; //Hard-coded the jackpot amount asked by product owner

                Console.WriteLine("Welcome to the Lucky Numbers game, press enter to see todays jackpot!");//The start of the application
                Console.ReadLine();
                Console.WriteLine("Todays jackpot is ${0}, press enter to get the game started.", jackPot);//Jackpot info
                Console.ReadLine();

                Console.WriteLine("Please enter a starting number: "); //User sets a lowest number
                int startNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter an ending number: "); //User sets a highest number
                int endingNumber = int.Parse(Console.ReadLine());
                if (endingNumber <= startNumber)
                {
                    Console.WriteLine("Please enter a number higher than your first number: "); //Validates if user higher number is lower than the start
                    endingNumber = int.Parse(Console.ReadLine());
                }

                int[] userSixNumbers = new int[6]; //Declared array for the six user inputs
                Console.WriteLine("Please enter 6 numbers of your choice: "); //Prompts user to input six numbers
                for (int i = 0; i < userSixNumbers.Length; i++)
                {
                    userSixNumbers[i] = int.Parse(Console.ReadLine()); //This will populate the array with the users input
                    if (userSixNumbers[i] < startNumber) //Validates if user input is higher than start number
                    {
                        Console.WriteLine("Please enter numbers higher than your starting numbers: ");
                        userSixNumbers[i] = int.Parse(Console.ReadLine()); //Prompts user to enter higher number than starting number
                    }
                    else if (userSixNumbers[i] > endingNumber)
                    {
                        Console.WriteLine("Please enter numbers lower than your ending numbers: ");
                        userSixNumbers[i] = int.Parse(Console.ReadLine()); //Prompts user to enter lower number than ending number
                    }
                }

                int[] randomSixNumbers = new int[6]; //Randomly generated numbers
                Random randomGen = new Random(); //Random method
                int countedNumber = 0;
                for (int j = 0; j < userSixNumbers.Length; j++)
                {
                    randomSixNumbers[j] = randomGen.Next(startNumber, endingNumber);
                    Console.WriteLine("Lucky Numbers: {0} ", randomSixNumbers[j]); //Lucky Numbers info
                    for (int i = 0; i < userSixNumbers.Length; i++) //Loop to check and see if userSixNumbers matches any randomSixNumbers
                    {
                        if (randomSixNumbers[j] == userSixNumbers[i])
                        {
                            countedNumber++;
                        }
                    }
                }

                Console.WriteLine("You guessed {0} numbers correctly", countedNumber);//Output with the correctly guessed numbers
                switch (countedNumber) //Switch statement to execute the winnings
                {
                    case 1:
                        Console.WriteLine("You won $50");
                        break;

                    case 2:
                        Console.WriteLine("You won $100");
                        break;

                    case 3:
                        Console.WriteLine("You won $150");
                        break;

                    case 4:
                        Console.WriteLine("You won $200");
                        break;

                    case 5:
                        Console.WriteLine("You won $250");
                        break;

                    case 6:
                        Console.WriteLine("You won $500");
                        break;

                    default:
                        Console.WriteLine("You won $0");
                        break;
                }

                while (true) //Continue asking until a correct answer is given
                {
                    Console.Write("Do you want to try your luck again? [Y/N]?");
                    string answer = Console.ReadLine().ToUpper();
                    if (answer == "Y")
                        break; //Exits the inner while-loop and continue in the outer while loop
                    if (answer == "N")
                        Console.WriteLine("Thanks for playing!");
                    return; //Exits the application or the main method
                }
            } //The whole application is a loop
        }
    }
}