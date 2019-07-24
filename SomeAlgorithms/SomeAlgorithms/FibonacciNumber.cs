using System;
using System.Collections.Generic;
using System.Text;

namespace SomeAlgorithms
{
    public static class FibonacciNumber
    {
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
