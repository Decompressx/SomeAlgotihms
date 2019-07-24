using System;
using System.Text;

namespace SomeAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Реверс строки
            string str = "Строка для реверса";
            Console.WriteLine(str);
            Console.WriteLine(str.Reverse());

            //Числа фибоначчи обычный метод
            Console.WriteLine("Числа фибоначчи через обычный метод");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(FibonacciNumber.Fibonacci(i));
            }            

            //Числа фибоначчи рекурсия
            Console.WriteLine("Число фибоначчи через рекурсию");
            Console.WriteLine(FibonacciNumberRecurse.Fibonacci(5));

            //Факториал
            Console.WriteLine("Факториал");
            Console.WriteLine(Factorial.GetFactorial(5));
        }
    }
}
