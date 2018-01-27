using System;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jackPot = 500; //Hard-coded the jackpot amount asked by product owner

            Console.WriteLine("Welcome to the Lucky Numbers game, press enter to see today jackpot!");//The start of the application
            Console.ReadLine();
            Console.WriteLine("Todays jackpot is {0}, press enter to get the game started.", jackPot);//Jackpot info
            Console.ReadLine();

            Console.WriteLine("Please enter a starting number: "); //Set a lowest number
            int startNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter a ending number: "); //Set as highest number
            int endingNumber = int.Parse(Console.ReadLine());
            if (endingNumber <= startNumber)
            {
                Console.WriteLine("Please enter a number higher than your first number: ");
                endingNumber = int.Parse(Console.ReadLine());
            }
           
            int[] userSixNumbers = new int[6];
            Console.WriteLine("Please enter 6 number of your choice: "); //User needs to input 6 numbers
            for (int i = 0; i < userSixNumbers.Length; i++)
            {
                userSixNumbers[i] = int.Parse(Console.ReadLine()); //This will fill the array with the users input
                if (userSixNumbers[i] < startNumber)
                {
                    Console.WriteLine("Please enter numbers higher than your staring numbers: ");
                    userSixNumbers[i] = int.Parse(Console.ReadLine());
                }
                else if (userSixNumbers[i] > endingNumber)
                {
                    Console.WriteLine("Please enter numbers lower than your ending numbers: ");
                    userSixNumbers[i] = int.Parse(Console.ReadLine());
                }
            } //What else do I need here to validate the range entered by the user=====================Remove when done====================>

            
            int[] randomSixNumbers = new int[6]; //Randomly generated numbers
            Random randomGen = new Random(); //Random method provided to us
            for (int i = 0; i < userSixNumbers.Length; i++)
            {
                for (int j = 0; j < randomSixNumbers.Length; i++)
                {
                    randomSixNumbers[j] = randomGen.Next(startNumber, endingNumber);
                    Console.WriteLine(randomSixNumbers[j]);

                    int countedNumbers = 0;
                    if (randomSixNumbers[j] == userSixNumbers[i])
                    {
                        countedNumbers++;
                    }
                }
            }



        }
    }
}
