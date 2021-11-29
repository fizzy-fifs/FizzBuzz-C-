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
    }
}
