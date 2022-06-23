namespace highLowNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You have to choose a number between 1 - 100");
            Console.WriteLine("Let's see if you can guess my number. Good Luck! ");
            Console.WriteLine("PS : You only have 6 attempts");
            Console.WriteLine("----------------------------------------------------");

            Random random = new Random();
            int minNumber = 0;
            int maxNumber = 4;
            int numberOfGuesses = 0;
            int randomNumber = random.Next(minNumber, maxNumber);
            
            bool playAgain = true;

            while (playAgain)
            {
                int number;
                int limitGuesses = 0;
                

                for (int i = 5; i >= limitGuesses; i--)
                {
                    Console.WriteLine("Please enter the number you are thinking :");
                    bool userNumber = int.TryParse(Console.ReadLine(), out number);

                    if (!userNumber)
                    {
                        Console.WriteLine("Please insert a whole number , like 1,2,3,4 ...");
                        playAgain = true;
                    }
                    if (randomNumber > number)
                    { 
                        Console.WriteLine("The number is to low");
                        Console.WriteLine($"You have only {i} left !");
                        numberOfGuesses++;
                    }
                    if (randomNumber < number)
                    {
                        Console.WriteLine("The number is to high");
                        Console.WriteLine($"You have only {i} left !");
                        numberOfGuesses++;
                    }
                    if (randomNumber == number)
                    {
                        Console.WriteLine($"YOU WON !!! You tried : {numberOfGuesses} times");
                        numberOfGuesses++;

                    }
                    if (i == 0)

                       
                    {
                        Console.WriteLine($"You Lost !!! You tried : {numberOfGuesses} times");
                        Console.WriteLine("Would you like to play again? Press y or n ");
                        i = 0;
                        string quit = Console.ReadLine();
                        quit = quit.ToLower();
                        if (quit == "y")
                        {
                            playAgain = true;
                        }
                        else
                        {
                            playAgain = false;
                        }
                    }
                }
                
                Console.WriteLine("Thank for playing ! See you, next time !!! ");
            }
        }
    }
}