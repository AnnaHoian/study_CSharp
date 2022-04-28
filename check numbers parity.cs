using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// перевірка числа на парність

namespace Homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value;

            value = int.Parse(Console.ReadLine());

            if(value % 2 == 0)
            {
                int result;

                result = value / 2;

                Console.WriteLine("чётное"); 
            }
            else
            {
                Console.WriteLine("нечётное");
            }
        }
    }
}
