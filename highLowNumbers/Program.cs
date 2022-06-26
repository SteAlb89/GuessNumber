namespace highLowNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int minNumber = 1;
            int maxNumber = 100;         
            int numberOfGuesses = 1;
            int attempts = 6;
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"You have to choose a number between {minNumber} - {maxNumber}");
            Console.WriteLine("Let's see if you can guess my number. Good Luck! ");
            Console.WriteLine($"PS : You only have {attempts} attempts");
            
            //Create a random number
            //Create a variable to store the guess
            //Create a while loop untill we get our desired outcome 
            Random random = new Random();
            int randomNumber = random.Next(minNumber, maxNumber);
            bool playAgain = true;
            
            

            while (playAgain)
            {
                int number;
                int limitGuesses = 0;
                

                //create a for loop , for limit the user guesses
                for (int i = attempts-1; i >= limitGuesses; i--)
                {
                    //Asking the user to introduce a number
                    //Parse the result as an integer
                    //Adding condition to show if he is close to his own guess
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("Please enter the number you are thinking :");
                    Console.WriteLine("----------------------------------------------------");
                    bool validNumber = int.TryParse(Console.ReadLine(), out number);
                    int closerGuesses = Math.Abs(randomNumber - number);

                    if (!validNumber)
                    {
                        Console.WriteLine("Please insert a whole number , like 1,2,3,4 ...");
                        continue;
                    }
                    if (randomNumber > number)
                    { 
                        Console.WriteLine("The number is to low");
                        Console.WriteLine($"You have only {i} left !");
                        
                    }
                    if (randomNumber < number)
                    {
                        Console.WriteLine("The number is to high");
                        Console.WriteLine($"You have only {i} left !");
                        
                    }
                    if (randomNumber == number)
                    {
                        Console.WriteLine("Congratulation !!!");
                        Console.WriteLine($"YOU WON !!! You tried : {numberOfGuesses} times");
                        break;
                    }
                    if (closerGuesses <= 3) //this only works correctly if guessed number is smaller than the random numnber
                    {
                        Console.WriteLine("You are soooo close to my number !!! ");
                    }
                  
                    if (i == 0)
                    {
                        Console.WriteLine($"You Lost !!! You tried : {numberOfGuesses} times");

                    }
                    numberOfGuesses++;
                    
                }
                //create a response if the user want's to play again 
                Console.WriteLine("Would you like to play again? Press y or n ");
                string response = Console.ReadLine();
                response = response.ToLower();
                if (response == "y")
                {
                    playAgain = true;                   
                }
                else
                {                    
                    playAgain = false;
                }
                
            }
            //create a message to thanks for playing
            Console.WriteLine("Thanks for playing ! See you, next time !!! ");
        }
        
    }
}