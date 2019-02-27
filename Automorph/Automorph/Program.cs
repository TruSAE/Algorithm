using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Трус Алексей
//Автоморфные числа.Натуральное число называется автоморфным, если оно равно последним
//цифрам своего квадрата.Например, 25 \ :sup: '2' = 625. Напишите программу, которая получает на
//вход натуральное число N и выводит на экран все автоморфные числа, не превосходящие N.
namespace Automorph
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cn, sq, num, r, t;
            bool equal;
            Console.WriteLine("Введите число:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Список автоморфных чисел от 1 до " + n + ":");

            for (int i = 1; i <= n; i++)
            {
                cn = i;
                num = i;
                sq = cn * cn;
                t = 10;
                equal = false;
                while (cn > 0)
                {
                    r = sq % t;
                    if (num == r)
                    {
                        equal = true;
                        break;
                    }
                    cn = cn / 10;
                    t = t * 10;
                }
                if (equal == true)
                {
                    Console.WriteLine("{0} : {1}", num, sq);
                }
            }
            Console.ReadKey();

        }
    }
}
