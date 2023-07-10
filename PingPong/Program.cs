using System.Collections.Generic;
using System;

namespace PingPong.Models
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine("Welcome to Ping Pong!");
            Console.WriteLine("Enter a number to play Ping Pong with an advanced AI");
            string userInput = Console.ReadLine();
            int userInputNumber = int.Parse(userInput);
            Dictionary<int,object> collection = GameClass.CountUp(userInputNumber);
            foreach (KeyValuePair<int, object> instance in collection)
            {
                Console.WriteLine($"{instance.Value}");
            }
        }
    }
}