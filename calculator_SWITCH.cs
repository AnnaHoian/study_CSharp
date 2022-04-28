using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_SWITCH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Clear();

                double firstNumber, secondNumber;
                string entered_operator;

                try
                {
                    Console.WriteLine("Please, enter first number");
                    firstNumber = double.Parse(Console.ReadLine());

                    Console.WriteLine("Please, enter second number");
                    secondNumber = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("You entered wrong number");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Please, enter one value of next operator: + - * / ");
                entered_operator = Console.ReadLine();

                switch (entered_operator)
                {
                    case "+":
                        double operation_result = firstNumber + secondNumber;
                        Console.WriteLine(firstNumber + " + " + secondNumber + " = " + operation_result);
                        break;

                    case "-":
                        double operation_result_min = firstNumber - secondNumber;
                        Console.WriteLine(firstNumber + " - " + secondNumber + " = " + operation_result_min);
                        break;

                    case "*":
                        double operation_result_mult = firstNumber * secondNumber;
                        Console.WriteLine(firstNumber + " * " + secondNumber + " = " + operation_result_mult);
                        break;

                    case "/":
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("You can not divizion on zero");
                        }
                        else
                        {
                            double operation_result_div = firstNumber / secondNumber;
                            Console.WriteLine(firstNumber + " / " + secondNumber + " = " + operation_result_div);
                        }
                        break;

                    default:
                        Console.WriteLine("You entered uncorrect operator");
                        break;
                }

                Console.ReadLine();
            }
        }

    }
}