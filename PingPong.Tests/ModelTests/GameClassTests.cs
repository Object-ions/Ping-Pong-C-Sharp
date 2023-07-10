using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong.Models;
using System.Collections.Generic;

namespace PingPong.Models.Tests
{
    [TestClass]
    public class GameClassTests
    {
        [TestMethod]
        public void CountUp_FillsGameResult_UpToInputNumber()
        {
            // Arrange
            int input = 10;

            // Act
            var result = GameClass.CountUp(input);

            // Assert
            for (int i = 1; i <= input; i++)
            {
                Assert.IsTrue(result.ContainsKey(i));
                Assert.AreEqual(i, result[i]);
            }
        }
    }
}