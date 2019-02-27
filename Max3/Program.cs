using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Трус Алексей
//    Написать функцию нахождения максимального из трёх чисел.

namespace Max3
{
    class Program
    {
        static double Max(double a, double b, double c)
            {
                double max = 0;
                if (a >= b && a >= c) { max = a; }
                else
                {
                    if (b >= a && b >= c) { max = b; }
                    else
                    {
                        if (c >= b && c >= a) { max = c; }
                    }
                }
                return max;

            }

            static void Main(string[] args)
            {
            Console.WriteLine("Введите числа для сравнения:");
                double a, b, c;
                Console.Write("a = ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.Write("b = ");
                b = Convert.ToDouble(Console.ReadLine());

                Console.Write("c = ");
                c = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("max = " + Max(a, b, c).ToString());
                Console.ReadKey();

            }
        }

    }
