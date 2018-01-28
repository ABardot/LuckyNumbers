using System;

namespace LuckyNumbers //Adrien Bardot Lucky Numbers Project 2 Final Version WCCI Spring 2018
{
    class Program
    {
        private static void Main()
        {
            while (true) //The application MUST provide the user the opportunity to play the game again.
            {
                double jackPot = 500.00; //The application MUST provide a Hard-code value for the jackpot amount.

                Console.WriteLine("Welcome to the Lucky Numbers game, press enter to see today's jackpot!"); //The start of the application.
                Console.ReadLine();
                Console.WriteLine("Today's jackpot is ${0}, press enter to get the game started.", jackPot);
                Console.ReadLine(); //The application MUST present the jackpot amount to the user.

                Console.WriteLine("Please enter a starting number: "); //The application MUST ask the user for a starting number.
                int startNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter an ending number: "); //The application MUST ask the user for an ending number.
                int endingNumber = int.Parse(Console.ReadLine());
                if (endingNumber <= startNumber) //The application MUST validate 6 numbers entered by the user are with the range set.
                {
                    Console.WriteLine("Please enter a number higher than your first number: ");
                    endingNumber = int.Parse(Console.ReadLine()); //The application MUST set this number as the highest number in the number range.
                }

                int[] userSixNumbers = new int[6]; //The application MUST save the 6 user inputed numbers utilizing an array data structure.
                Console.WriteLine("Please enter 6 numbers of your choice: "); //The application MUST ask the user to input 6 numbers.
                for (int i = 0; i < userSixNumbers.Length; i++) //The Application MUST use a loop to populate the required array.
                {
                    userSixNumbers[i] = int.Parse(Console.ReadLine());
                    if (userSixNumbers[i] < startNumber) //The application MUST validate 6 numbers entered by the user are with the range set.
                    {
                        Console.WriteLine("Please enter numbers higher than your starting numbers: ");
                        userSixNumbers[i] = int.Parse(Console.ReadLine()); //The application MUST prompt the user to input a valid number until the number(s) entered are valid.
                    }
                    else if (userSixNumbers[i] > endingNumber) //The application MUST validate 6 numbers entered by the user are with the range set.
                    {
                        Console.WriteLine("Please enter numbers lower than your ending numbers: ");
                        userSixNumbers[i] = int.Parse(Console.ReadLine()); //The application MUST prompt the user to input a valid number until the number(s) entered are valid.
                    }
                }

                int[] randomSixNumbers = new int[6]; //The application MUST save randomly generated numbers utilizing an array data structure.
                Random randomGen = new Random(); //Random method
                int countedNumber = 0;
                for (int j = 0; j < userSixNumbers.Length; j++) //The application MUST randomly generate 6 numbers using a loop.
                {                                               //The application MUST use a loop to populate the required array.
                    randomSixNumbers[j] = randomGen.Next(startNumber, endingNumber);
                    Console.WriteLine("Lucky Numbers: {0} ", randomSixNumbers[j]); //The application MUST be displayed in the following format.
                    for (int i = 0; i < userSixNumbers.Length; i++) //The application MUST randomly generate 6 numbers using a loop.
                    {                                               //The application MUST display the random numbers to the console using a loop.
                        if (randomSixNumbers[j] == userSixNumbers[i]) //The application MUST count the number of correctly guessed numbers.
                        {
                            countedNumber++;
                        }
                    }
                }

                Console.WriteLine("You guessed {0} numbers correctly!", countedNumber); //The application MUST output to the console to notify the user.
                switch (countedNumber) //The application MUST calculate the user's winnings based on the number of numbers guessed correctly.
                {
                    case 1:
                        Console.WriteLine("You won $50"); //The application MUST display the user's winnings to the console.
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

                while (true) //This loop will continue to prompt the user until the loop results in a bool value of true(Y) or false(N).
                {
                    Console.Write("Do you want to try your luck again [Y/N]?");
                    string answer = Console.ReadLine().ToUpper(); //The application MUST provide the user the opportunity to play the game again.
                    if (answer == "Y")
                        break; //If the user says yes, the application MUST execute the program from the beginning.
                    if (answer == "N")
                        Console.WriteLine("Thanks for playing!");
                    return; //If the user says no, the application MUST display the following statement exactly as written below before exiting.
                }
            } //The application MUST provide the user the opportunity to play the game again.
        }
    }
}