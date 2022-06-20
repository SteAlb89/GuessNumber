using System;

namespace highLowNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You have to choose a number between 1 - 100");
            Console.WriteLine("Let's see if you can guess my number. Good Luck");

            Random random = new Random();
            int minNumber = 0;
            int maxNumber = 101;
            int limitGuesses = 5;
            int numberOfGuesses = 0;
            int randomNumber = random.Next(minNumber, maxNumber);

            for (int i = 0; i <= limitGuesses; i++)
            {
               
                Console.WriteLine("Please enter the number you are thinking :");
                int userNumber = Convert.ToInt32(Console.ReadLine());


                    if (randomNumber > userNumber)
                    {
                        Console.WriteLine("The number is to low");
                        Console.WriteLine($"You have only {limitGuesses - numberOfGuesses} left !");
                        numberOfGuesses++;
                    }
                if (randomNumber < userNumber)
                {
                    Console.WriteLine("The number is to high");
                    Console.WriteLine($"You have only {limitGuesses - numberOfGuesses} left !");
                    numberOfGuesses++;
                    if (randomNumber == userNumber)
                    {
                        Console.WriteLine($"YOU WON !!! You tried : {numberOfGuesses} times");
                    }
                    if (limitGuesses == 5)
                    {
                        Console.WriteLine($"You Lost !!! You tried : {numberOfGuesses} times");
                        Console.WriteLine("Would you like to play again? Press y or n ");
                        string quit = Convert.ToString(Console.ReadLine());
                        if (quit == "n")
                        {
                            break;
                        }
                    }
                }
            }          
        }
    }
}