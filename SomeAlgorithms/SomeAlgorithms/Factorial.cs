using System;
using System.Collections.Generic;
using System.Text;

namespace SomeAlgorithms
{
    public static class Factorial
    {
        public static int GetFactorial(int i)
        {
            if (i <= 1)
                return 1;
            return i * GetFactorial(i - 1);
        }
    }
}
