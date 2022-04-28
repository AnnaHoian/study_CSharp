using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    // Введіть три числа та виведіть на екран значення суми та множення цих чисел
    
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue, thirdValue;

            Console.WriteLine("Enter first value");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter first value");
            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter first value");
            thirdValue = double.Parse(Console.ReadLine());

            double sum = firstValue + secondValue + thirdValue;

            double multiplication = firstValue * secondValue * thirdValue;

            Console.WriteLine("Sum = " + sum + " Multiplication = " + multiplication);

        }
    }
}
