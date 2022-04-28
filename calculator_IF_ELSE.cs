using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_IF_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber;
            Console.WriteLine("Please, enter first number");
            firstNumber = double.Parse(Console.ReadLine());

            double secondNumber;
            Console.WriteLine("Please, enter second number");
            secondNumber = double.Parse(Console.ReadLine());

            string entered_operator;
            Console.WriteLine("Please, enter one value of next operator: + - * / ");
            entered_operator = Console.ReadLine();

            if (entered_operator == "+")
               {
                   double operation_result = firstNumber + secondNumber;
                   Console.WriteLine(firstNumber + " + " + secondNumber + " = " + operation_result);
               }
            else if (entered_operator == "-")
               {
                   double operation_result = firstNumber - secondNumber;
                   Console.WriteLine(firstNumber + " - " + secondNumber + " = " + operation_result);
               }
            else if (entered_operator == "*")
               {
                   double operation_result = firstNumber * secondNumber;
                   Console.WriteLine(firstNumber + " * " + secondNumber + " = " + operation_result);
               }
            else if (entered_operator == "/")
               {
                if (secondNumber == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    double operation_result_div = firstNumber / secondNumber;
                    Console.WriteLine(firstNumber + " / " + secondNumber + " = " + operation_result_div);
                }
                }
            else 
            {
                Console.WriteLine("You entered uncorrect operator");
            }

        }
    }
}
