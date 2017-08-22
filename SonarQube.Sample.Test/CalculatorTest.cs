using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SonarQube.Sample.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void test_Add_1_and_1_should_be_2()
        {
            var first = 1;
            var second = 1;
            var expected = 2;
            var actual = 0;

            var calculator = new Calculator();
            actual = calculator.Add(first, second);

            Assert.AreEqual(expected, actual);
        }
    }
}
