using System;
using Tyuiu.KhanikyanDK.Sprint5.Task3.V30.Lib;

namespace Tyuiu.KhanikyanDK.Sprint5.Task3.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 5 | Выполнил: Ханикян Д. К. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 5                                                                *");
            Console.WriteLine("* Тема: Работа с бинарными файлами                                        *");
            Console.WriteLine("* Задание 3                                                               *");
            Console.WriteLine("* Вариант 30                                                              *");
            Console.WriteLine("* Выполнил: Ханикян Давит Каренович | ИСТНб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить    *");
            Console.WriteLine("* в бинарный файл OutPutFileTask3.bin и вывести на консоль. Округлить     *");
            Console.WriteLine("* до трёх знаков после запятой.                                           *");
            Console.WriteLine("* y = (x^3 - 1) / (4x^2)                                                  *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int x = 3;

            double y = (Math.Pow(x, 3) - 1) / (4 * Math.Pow(x, 2));
            y = Math.Round(y, 3);

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            string path = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл создан по пути: " + path);
            Console.WriteLine("Значение y = " + y);
            Console.ReadKey();
        }
    }
}