using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3

    // Напишіть простий валютний конвертер (без вибору валюти)

{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Value;

            Console.WriteLine("Enter your cash (UAN)");

            Value = double.Parse(Console.ReadLine());

            double currency = 27.86;

            Console.WriteLine("UAN = " + Value + " USD = " + Value * currency);

        }
    }
}
