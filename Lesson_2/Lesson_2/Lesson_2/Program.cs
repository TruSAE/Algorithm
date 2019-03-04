using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Трус Алексей
//    Реализовать функцию перевода чисел из десятичной системы в двоичную, используя
//рекурсию.


namespace Lesson_2
{
    class Program
    {
       public static string Convert10to2(uint num, string res)
        {
            if (num < 2)
            {
                uint t = num % 2;
                res = res + t.ToString();

                
                string res2 = "";
                for (int i = res.Length - 1; i >= 0; i--)
                    res2 = res2 + res[i];
                return res2;
            }
            else
            {
                uint t = num % 2;
                res = res + t.ToString();
                return Convert10to2(num / 2, res);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число для его перевода в двоичную систему: ");
            var num = Convert.ToUInt32(Console.ReadLine());
            string res = Convert10to2(num, ""); // res = 10010

            Console.WriteLine($"Число {num} в двоичном формате:\n  {res}");

            Console.ReadKey();

        }
    }
}
