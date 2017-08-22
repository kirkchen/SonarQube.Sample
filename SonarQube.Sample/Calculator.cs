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
            first =+ second;
            return first;
        }

        public int Minus(int first, int second)
        {
            return first - second;
        }
    }
}
