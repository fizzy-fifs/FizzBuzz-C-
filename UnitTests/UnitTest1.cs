using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ListNumbersUpToOne()
        {
            FizzBuzz fizzbuzz = new();
            string result = fizzbuzz.generate(1);
            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void ListNumbersUpToTwo()
        {
            FizzBuzz fizzbuzz = new();
            string result = fizzbuzz.generate(2);
            Assert.AreEqual("1, 2", result);
        }

        [TestMethod]
        public void ListNumbersUpToThree()
        {
            FizzBuzz fizzbuzz = new();
            string result = fizzbuzz.generate(3);
            Assert.AreEqual("1, 2, Fizz", result);
        }

        [TestMethod]
        public void ListNumbersUpToFive()
        {
            FizzBuzz fizzbuzz = new();
            string result = fizzbuzz.generate(5);
            Assert.AreEqual("1, 2, Fizz, 4, Buzz", result);
        }

        [TestMethod]
        public void ListNumbersUpToFifteen()
        {
            FizzBuzz fizzbuzz = new();
            string result = fizzbuzz.generate(15);
            Assert.AreEqual("1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz", result);
        }

        [TestMethod]
        public void ListNumbersUpToOneHundred()
        {
            FizzBuzz fizzbuzz = new();
            string result = fizzbuzz.generate(100);
            Assert.AreEqual("1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz, 16, 17, Fizz, 19, Buzz, Fizz, 22, 23, Fizz, Buzz, 26, Fizz, 28, 29, FizzBuzz, 31, 32, Fizz, 34, Buzz, Fizz, 37, 38, Fizz, Buzz, 41, Fizz, 43, 44, FizzBuzz, 46, 47, Fizz, 49, Buzz, Fizz, 52, 53, Fizz, Buzz, 56, Fizz, 58, 59, FizzBuzz, 61, 62, Fizz, 64, Buzz, Fizz, 67, 68, Fizz, Buzz, 71, Fizz, 73, 74, FizzBuzz, 76, 77, Fizz, 79, Buzz, Fizz, 82, 83, Fizz, Buzz, 86, Fizz, 88, 89, FizzBuzz, 91, 92, Fizz, 94, Buzz, Fizz, 97, 98, Fizz, Buzz", result);
        }
    }
}
