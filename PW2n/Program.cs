using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace pr2
{

    internal class Program
    {
        static void Main()
        {
            int a = 0;
            do
            {
                Console.WriteLine(" Введите номер программы\n " +
                        "1.Игра 'Угадай число'\n " +
                        "2.Таблица умножения\n " +
                        "3.Вывод делителей числа\n " +
                        "4.Для выхода из программы введите 4");

                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    Console.WriteLine("Вы выбрали игру угадай число");
                    guessthenumber();
                }

                if (a == 2)
                {
                    Console.WriteLine("Вы выбрали таблицу умножения");
                    tablicha();
                }

                if (a == 3)
                {
                    Console.WriteLine("Вы выбрали программу по определителю делителей числа");
                    numberdelitel();
                }
            } while (a != 4);
            Console.WriteLine("Программа закончена");
        }
        static void guessthenumber()
        {
            int random;
            int num;
            Random rnd = new();
            random = rnd.Next(0, 101);
            num = Convert.ToInt32(Console.ReadLine());
            while (num != random)
            {
                if (random > num)
                {
                    Console.WriteLine("Введите число побольше");

                }
                else if (random < num)
                {
                    Console.WriteLine("Введите число поменьше");

                }
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Вы угадали число");
        }
        static void tablicha()
        {
            int[,] multiplication = new int[10, 10];

            for (int i = 1; i < multiplication.GetLength(0); i++)
            {
                for (int j = 1; j < multiplication.GetLength(1); j++)
                {
                    multiplication[i, j] = i * j;
                    Console.Write($"{multiplication[i, j]}\t|\t");
                }
                Console.WriteLine();
            }
        }
        static void numberdelitel()
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    Console.Write($"{i} \t");
                }
            }
            Console.WriteLine();
        }
    }
}
