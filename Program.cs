using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Пракикум 12 - Сакары Анны";

            //1. Вычислить значение функции для целых аргументов двумя способами (1-й способ: полный условный оператор; 2-й способ: тернарная операция):

            //Console.Write("введите значение для х: ");
            //double x = double.Parse(Console.ReadLine());
            //double y;
            //if (x > 0)
            //{
            //    y = Math.Pow(Math.Sin(x), 2) * x;
            //}
            //else
            //{
            //    y = 1 - 2 * Math.Sin(Math.Pow(x, 2));
            //}
            //Console.WriteLine($"y = {y}");


            //2 решение.

            //y = x > 0 ? Math.Pow(Math.Sin(x), 2) * x : 1 - 2 * Math.Sin(Math.Pow(x, 2));

            //2.  Используя случайное двузначное число, вывести на экран информацию о чётности или нечётности этого числа с использованием тернарной операции.

            //Random rnd = new Random();
            //int a = rnd.Next(10, 99);
            //Console.WriteLine(a);
            //string b;
            //b = (a % 2 == 0) ? "чётное" : "нечётное";
            //Console.WriteLine(b);

            //3. Даны три целых положительных числа.
            //Если все они чётные, каждое число увеличить на 1;
            //если хотя бы одо из них чётное, уменьшить на один;
            //если четных чисел нет, каждое число увеличить в 2 раза.
            //Console.Write("a= ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b= ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("c= ");
            //int c = int.Parse(Console.ReadLine());
            //if (a % 2 == 0 & b % 2 == 0 & c % 2 == 0)
            //{
            //    Console.WriteLine($"a= {a + 1} \nb= {b + 1} \nc= {c + 1} ");
            //}
            //else if (a % 2 == 0 | b % 2 == 0 | c % 2 == 0)
            //{
            //    Console.WriteLine($"a= {a - 1} \nb= {b - 1} \nc= {c - 1} ");
            //}
            //else if (a % 2 != 0 & b % 2 != 0 & c % 2 != 0)
            //{
            //    Console.WriteLine($"a= {a * 2} \nb= {b * 2} \nc= {c * 2} ");
            //}

            //4. По введённому номеру месяца выводится название поры года (зима, весна, лето, осень) и  сообщение: ссесия, каникулы, 1 семестр, 2 семестр.
            //Console.Write("введите номер месяца: ");
            //int a = int.Parse(Console.ReadLine());
            //switch (a)
            //{
            //    case 12:
            //        Console.WriteLine("Зима. Сессия. 1 семестр.");
            //        break;
            //    case 1:
            //        Console.WriteLine("Зима. Каникулы, 2 семестр.");
            //        break;
            //    case 2:
            //        Console.WriteLine("Зима. 2 семестр.");
            //        break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("Весна. 2 семестр.");
            //        break;
            //    case 6:
            //        Console.WriteLine("Лето. Сессия. 2 семестр.");
            //        break;
            //    case 7:
            //    case 8:
            //        Console.WriteLine("Лето. Каникулы.");
            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("Осень. 1 семестр.");
            //        break;
            //}



            Console.ReadKey();
        }
    }
}
