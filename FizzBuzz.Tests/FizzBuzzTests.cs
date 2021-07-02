using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FizzBuzz;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTester
    {
        [TestMethod]
        public void FizzBuzzMethod_MultiplesOfFifteen_FizzBuzz()
        {
          var FizzBuzzProcessor = new FizzBuzzProcessor();
          var ExampleResult = FizzBuzzProcessor.FizzBuzzMethod(15);
          Assert.AreEqual("fizzbuzz", ExampleResult[15]);
        }
    }
}