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
            bool keepPlaying = true;
            int limitGuesses = 5;
            int numberOfGuesses = 0;
            int randomNumber = random.Next(minNumber, maxNumber);

            while (keepPlaying)             
            {
                Console.WriteLine("Please enter the number you are thinking :");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (randomNumber > userNumber)
                {
                    Console.WriteLine("The number is to low");
                    Console.WriteLine($"You have only {limitGuesses - numberOfGuesses} left !");
                    numberOfGuesses++;
                }
                else if (randomNumber < userNumber)
                {
                    Console.WriteLine("The number is to high");
                    Console.WriteLine($"You have only {limitGuesses - numberOfGuesses} left !");
                    numberOfGuesses++;
                }
                else
                {
                    if (randomNumber == userNumber)
                    {
                        Console.WriteLine($"YOU WON !!! You tried : {numberOfGuesses} times");
                    }
                       
                    else
                    {
                        Console.WriteLine($"You Lost !!! You tried : {numberOfGuesses} times");
                    }
                    Console.WriteLine("Would you like to play again? Press y or n ");
                    string quit = Console.ReadLine();
                    if (quit == "n")
                    {
                        keepPlaying = false;
                        break;
                    }
                }
            }         
        }
    }
}