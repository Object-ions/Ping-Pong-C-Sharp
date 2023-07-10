using System.Collections.Generic;
using System;

namespace PingPong.Models
{
    public class GameClass
    {
        public static Dictionary<int, object> _gameResult = new Dictionary<int, object> {};
        // Business Logic goes here.

        public static Dictionary<int, object> CountUp(int userInput)
        {
            _gameResult.Clear();

            for (int i = 1; i <= userInput; i++)
            {
                _gameResult.Add(i, i);
            }

            return _gameResult;
        }

    }
}