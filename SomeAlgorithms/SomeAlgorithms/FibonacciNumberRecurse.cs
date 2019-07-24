using System;
using System.Collections.Generic;
using System.Text;

namespace SomeAlgorithms
{
    public static class FibonacciNumberRecurse
    {
        public static int Fibonacci(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(number - 2) + Fibonacci(number - 1);
            }
        }
    }
}
