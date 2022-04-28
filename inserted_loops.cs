using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Вкладені цикли. Побудова фігури в консолі

namespace Inserted_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the height of figure: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Enter the width of figure: ");
            int width = int.Parse(Console.ReadLine());


            for (int i = 0; i < height; i++) // відповідає за кількість рядків, тобто, висоту
            {
                
                for (int j = 0; j < width; j++) // відповідає за кількість символів, тобто, ширину
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }

        }
    }
}
