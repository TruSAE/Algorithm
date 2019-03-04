using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Трус Алексей
//    Реализовать функцию возведения числа a в степень b:
//a.Без рекурсии.



namespace PowerNumber
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, которое требуется возвести в степень:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите показатель степени:");
            int b = Convert.ToInt32(Console.ReadLine());

            int i = 1, sum = 1;
            while (i <= b)
            {
                sum = sum * a;
                i++;
            }
            Console.WriteLine($"число  {a} в степени  {b} равно {sum}");

            
            Console.ReadKey();
        }
    }
}
