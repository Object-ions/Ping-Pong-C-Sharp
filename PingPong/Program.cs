using System.Collections.Generic;
using System;

namespace PingPong.Models
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine("Welcome to Ping Pong!");
            Console.WriteLine("Enter a number to play Ping Pong with an advanced AI");
            string userInput = Console.ReadLine();
            int userInputNumber = int.Parse(userInput);
            Dictionary<int,object> collection = GameClass.CountUp(userInputNumber);
            foreach (KeyValuePair<int, object> instance in collection)
            {
                Console.WriteLine($" > {instance.Value}");
            }
            Retry();
        }
        static void Retry()
        {
            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine("Would You Like To Play Again? (Y/N)");
            string userAnswerRetry = Console.ReadLine();
            if (userAnswerRetry == "y" || userAnswerRetry == "Y" || userAnswerRetry == "yes" || userAnswerRetry == "YES" || userAnswerRetry == "Yes")
            {
                Main();
            }
            else if (userAnswerRetry == "n" || userAnswerRetry == "N" || userAnswerRetry == "no" || userAnswerRetry == "NO" || userAnswerRetry == "No")
            {
                Console.WriteLine("Good Bye!");
            }
            else
            {
                Console.WriteLine("That's Not a Valid Answer");
                Console.WriteLine("Let's Try Again...");
                Console.WriteLine("Would You Like To Play Again? (Y/N)");
                string userAnswerRetry2 = Console.ReadLine();
                if (userAnswerRetry2 == "y" || userAnswerRetry2 == "Y" || userAnswerRetry2 == "yes" || userAnswerRetry2 == "YES" || userAnswerRetry2 == "Yes")
            {
                Main();
            }
            else
            {
                Console.WriteLine("Good Bye!");
            }
            }
        }
    }
}