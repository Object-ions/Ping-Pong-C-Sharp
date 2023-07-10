using System.Collections.Generic;


namespace PingPong.Models
{
    public class GameClass
    {
        public static Dictionary<int, object> _gameResult = new Dictionary<int, object> {};
        // Business Logic goes here.

        public static Dictionary<int, object> CountUp(int userInputNumber)
        {
            _gameResult.Clear();

            for (int i = 1; i <= userInputNumber; i++)
            {
                if (i%3 == 0 && i%5 ==0)
                {
                    _gameResult.Add(i, "Ping Pong");
                }
                else if (i%5 == 0)
                {
                    _gameResult.Add(i, "Pong");
                }
                else if (i%3 == 0)
                {
                    _gameResult.Add(i, "Ping");
                }
                else
                {
                    _gameResult.Add(i, i);
                }
            }

            return _gameResult;
        }

    }
}