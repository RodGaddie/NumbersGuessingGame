using System;

namespace NumbersGuessingGame
{
    class Program
    {
        static int GetIntegerFromUser(string question)
        {
            int integerFromUser;
            bool success;
            do
            {
                Console.WriteLine(question);
                string userResponse = Console.ReadLine();
                success = int.TryParse(userResponse, out integerFromUser);
            } while (success == false);

            return integerFromUser;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a guessing game! The higher your score, the worse you did!");
            int max = GetIntegerFromUser("First start by picking a MAX number, for example, 10, 100, 50...etc ");
      
            Random random= new Random();
            int secretNumber = random.Next(1, max);

            Console.WriteLine($"Great lets get started, pick a number between 1 and {max}");
            int guess;
             int sum = 1;
            do
            {
                guess = GetIntegerFromUser("What is your guess?");
                if (guess < secretNumber)
                {
                    Console.WriteLine("Too Low!");
                }
                if (guess > secretNumber)
                {
                    Console.WriteLine("Too High!");
                }
                if (guess == secretNumber)
                {
                    Console.WriteLine($"Congratulations you guessed right!!  Your score is {sum}");
                }
                sum++;
            } while (guess != secretNumber);
        }
    }
}
