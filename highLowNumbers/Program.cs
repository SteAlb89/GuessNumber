namespace highLowNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNumber = 0;
            int maxNumber = 4;
            
            int numberOfGuesses = 0;
            Console.WriteLine($"You have to choose a number between {minNumber} - {maxNumber}");
            Console.WriteLine("Let's see if you can guess my number. Good Luck! ");
            Console.WriteLine("PS : You only have {numberOfGuesses} attempts");
            Console.WriteLine("----------------------------------------------------");

            Random random = new Random();
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
                        continue;
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
                        Console.WriteLine("Congratulation !!!");
                        Console.WriteLine($"YOU WON !!! You tried : {numberOfGuesses} times");
                        numberOfGuesses++;
                        break;                      
                    }
                    if (i == 0)
                    {
                        Console.WriteLine($"You Lost !!! You tried : {numberOfGuesses} times");

                    }                   
                }
                Console.WriteLine("Would you like to play again? Press y or n ");
                string quit = Console.ReadLine();
                quit = quit.ToLower();
                if (quit == "y")
                {
                    playAgain = true;
                }
                else
                {
                    Console.WriteLine("You should enter y or n , not other letters ! Thank you !");
                    playAgain = false;
                }
                
            }
            Console.WriteLine("Thank for playing ! See you, next time !!! ");
        }
        
    }
}