using System;

namespace highLowNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int lowNumber = 1;
            int highNumber = 101;

            int randomNumber = random.Next(lowNumber, highNumber);
            Console.WriteLine($"You have to enter a number and try to guess what number the computer choose ");
            Console.WriteLine("Hint - The number supposed to be between 1 - 100: ");

            int userNumber = Convert.ToInt32(Console.ReadLine());


            if (randomNumber > userNumber)
            {

                Console.WriteLine("Your number is to low: ");

            }
            if (randomNumber < userNumber)
            {
                Console.WriteLine("Your number is to high");
            }
            if (randomNumber ==  userNumber)
            {
                Console.WriteLine("You win !!!");
            }
            Console.WriteLine(randomNumber);
        }
    }
}