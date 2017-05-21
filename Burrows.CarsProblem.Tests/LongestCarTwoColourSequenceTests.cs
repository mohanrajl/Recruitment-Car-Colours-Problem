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
        
        // New tests

        [Test]
        public void when_null()
        {
            Assert.AreEqual(0, CalculateLongestSequenceOfTwoCarColours(null));
        }

        [Test]
        public void when_all_cars_same()
        {
            Assert.AreEqual(0, CalculateLongestSequenceOfTwoCarColours(new[] { "Red", "Red", "Red" }));
        }

        [Test]
        public void when_some_cars_are_lowercase()
        {
            Assert.AreEqual(3, CalculateLongestSequenceOfTwoCarColours(new[] { "Red", "red", "blue" }));
        }

        // Given examples in Readme.md

        [Test]
        public void when_six_different_cars()
        {
            Assert.AreEqual(5, CalculateLongestSequenceOfTwoCarColours(new[] { "Red", "Green", "Red", "Red", "Green", "Blue" }));
        }

        [Test]
        public void when_eight_different_cars()
        {
            Assert.AreEqual(4, CalculateLongestSequenceOfTwoCarColours(new[] { "Blue", "Yellow", "Black", "Yellow", "Green", "Yellow", "Yellow", "Red" }));
        }

        /// <summary>
        /// Given a sequence of car colours, returns the length of longest streak containing just two colours.
        /// See read me for more information and examples.
        /// Complete this method however you wish.
        /// You may call other functions and classes, but please do not change this methods signature.
        /// </summary>
        /// <param name="carColours"></param>
        /// <returns>Longest sequence of two colours</returns>
        public static int CalculateLongestSequenceOfTwoCarColours(IEnumerable<string> carColours)
        {
            // If null then return 0
            if (carColours == null) return 0;
         
            // Convert to list and lowercase   
            var carColoursList = carColours.ToList().ConvertAll(colour => colour.ToLower());

            // If total cars is less than three then return total car count
            if (carColoursList.Count < 3) return carColoursList.Count;

            // If all cars are identical then return zero
            if (carColoursList.Distinct().Count() == 1) return 0;

            // To store all possible consequtive car colour counts
            var possibleSequenceCarColourCounts = new List<int>();

            for (int i = 0; i < carColoursList.Count; i++)
            {
                var colourList = new List<string>();
                for (int j = i; j < carColoursList.Count; j++)
                {
                    colourList.Add(carColoursList[j]);
                    
                    // If colourList contains 2 distinct colours
                    if (colourList.Distinct().Count() == 2)
                    {
                        possibleSequenceCarColourCounts.Add(colourList.Count);
                    }
                    else if (colourList.Distinct().Count() > 2)
                    {
                        break;
                    }
                }
            }

            // return the maximum possible sequence car colour counts
            return possibleSequenceCarColourCounts.Max();
        }
    }
}
