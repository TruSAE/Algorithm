using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Трус Алексей
//    Написать функцию, генерирующую случайное число от 1 до 100:
//a.С использованием стандартной функции rand().
namespace Random_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Запустить генератор случайных чисел? y/n");
            char x = Convert.ToChar(Console.ReadLine());
            if (x == 'y')
            {
                Console.Clear();
                RandoMe();
            }
            

            Console.ReadKey();

        }

        private static void RandoMe()
        {
            Random q = new Random(100);

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(q.Next(100));
            }
        }
    }
}
