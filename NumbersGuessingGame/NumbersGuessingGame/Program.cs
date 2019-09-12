﻿using System;

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
            int max = GetIntegerFromUser("First start by picking a range you want to guess from");
      
            Random random= new Random();
            int secrestNumber = random.Next(0, max);

            int userInput = GetIntegerFromUser($"Great lets get started, pick a number between 1 and {max}");

            

        }
    }
}