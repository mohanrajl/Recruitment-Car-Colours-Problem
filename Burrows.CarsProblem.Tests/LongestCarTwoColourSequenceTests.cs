using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Burrows.CarsProblem.Tests
{
    [TestFixture]
    public class LongestCarTwoColourSequenceTests
    {
        [Test]
        public void when_no_cars()
        {
            Assert.AreEqual(0, CalculateLongestSequenceOfTwoCarColours(new string[0]));
        }

        [Test]
        public void when_one_car()
        {
            Assert.AreEqual(1, CalculateLongestSequenceOfTwoCarColours(new[] {"Red"}));
        }

        [Test]
        public void when_two_identical_cars()
        {
            Assert.AreEqual(2, CalculateLongestSequenceOfTwoCarColours(new[] {"Red", "Red"}));
        }

        [Test]
        public void when_two_different_cars()
        {
            Assert.AreEqual(2, CalculateLongestSequenceOfTwoCarColours(new[] {"Red", "Blue"}));
        }

        // Your first failing test has been written for you here
        [Test]
        public void when_three_different_cars()
        {
            Assert.AreEqual(2, CalculateLongestSequenceOfTwoCarColours(new[] {"Red", "Blue", "Green"}));
        }

        // add more tests, feel free to refactor all the tests as you see fit
        
        /// <summary>
        /// Given a sequence of car colours, returns the length of longest streak containing just two colours.
        /// See read me for more information and examples.
        /// Complete this method however you wish.
        /// You may call other functions and classes, but please do not change this methods signature.
        /// </summary>
        /// <param name="carColours"></param>
        /// <returns></returns>
        public static int CalculateLongestSequenceOfTwoCarColours(IEnumerable<string> carColours)
        {
            return carColours.Count();
        }
    }
}
