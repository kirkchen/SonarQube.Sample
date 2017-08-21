using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SonarQube.Sample.Test
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        public void test_Add_should_be_correct(int first, int second, int expected)
        {            
            var actual = 0;

            var calculator = new Calculator();
            actual = calculator.Add(first, second);

            Assert.Equal(expected, actual);
        }
    }
}
