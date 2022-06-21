namespace highLowNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You have to choose a number between 1 - 100");
            Console.WriteLine("Let's see if you can guess my number. Good Luck");
            Console.WriteLine("PS : You onlye have 6 attempts");
            Console.WriteLine("------------------------------------------");

            Random random = new Random();
            int minNumber = 0;
            int maxNumber = 4;
            int limitGuesses = 5;
            int numberOfGuesses = 0;
            int randomNumber = random.Next(minNumber, maxNumber);
            int number;

            for (int i = 0; i <= limitGuesses; i++)
            {
               
                Console.WriteLine("Please enter the number you are thinking :");
                bool userNumber = int.TryParse(Console.ReadLine(), out number);
                

                if (int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Please insert a whole number , like 1,2,3,4 ...");
                    return;
                }
                if (randomNumber > number)
                {
                    Console.WriteLine("The number is to low");
                    Console.WriteLine($"You have only {limitGuesses - numberOfGuesses} left !");
                    numberOfGuesses++;
                }
                if (randomNumber < number)
                {
                    Console.WriteLine("The number is to high");
                    Console.WriteLine($"You have only {limitGuesses - numberOfGuesses} left !");
                    numberOfGuesses++;
                }
                if (randomNumber == number)
                {
                    Console.WriteLine($"YOU WON !!! You tried : {numberOfGuesses} times");                   
                }
                if (limitGuesses == numberOfGuesses - 1)
                {
                    Console.WriteLine($"You Lost !!! You tried : {numberOfGuesses} times");
                    Console.WriteLine("Would you like to play again? Press y or n ");
                    string quit = Convert.ToString(Console.ReadLine());
                    if (quit == "y")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
               
            }
        }
    }
}