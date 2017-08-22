using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonarQube.Sample
{
    public class Calculator
    {
        public int Add(int first, int second)
        {
            var total = 0;
            total =+ second;
            return first + second;
        }

        public int Minus(int first, int second)
        {
            return first - second;
        }
    }
}
