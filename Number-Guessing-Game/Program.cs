using System;

namespace GuessingGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int min = 1;
            int max = 5;
            int guess;
            int guesses;
            int number;
            bool playAgain = true;
            string response;

            Console.WriteLine("\n\nWELCOME TO NUMBER GUESSING GAME\n\n");

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";

                number = rnd.Next(min, max);

                while (guess != number)
                {
                    Console.Write($"Enter a number between {min} - {max}: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    guesses++;

                    if (guess > number)
                    {
                        Console.WriteLine($"{guess} is greater than the right Number");
                    } 
                    else if (guess < number)
                    {
                        Console.WriteLine($"{guess} is lower than the right Number");
                    }
                }
                Console.WriteLine("\n\n--------CONGRATULATIONS!! YOU HAVE GUESSED THE RIGHT NUMBER!!--------\n\n");
                Console.WriteLine($"Number of Guesses: {guesses}");

                Console.Write("Do you want to play again? Y / N: ");
                response = Console.ReadLine();
                response = response.ToUpper();
                
               if (response == "Y")
                {
                    playAgain = true;
                }
               else if (response == "N")
                {
                    playAgain = false;
                }
               else if (response != "Y" || response != "N")
                {
                    Console.Write("Do you want to play again? Y / N: ");
                    response = Console.ReadLine();
                    response = response.ToUpper();

                }
               
               

                


            }

            Console.WriteLine("Thank you for playing!");


            Console.ReadKey();
        }

        
    }
}