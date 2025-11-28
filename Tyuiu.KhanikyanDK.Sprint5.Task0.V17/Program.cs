using System;
using Tyuiu.KhanikyanDK.Sprint5.Task0.V17.Lib;

namespace Tyuiu.KhanikyanDK.Sprint5.Task0.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 5 | Выполнил: Ханикян Д. К. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 5                                                                *");
            Console.WriteLine("* Тема: Работа с файлами                                                  *");
            Console.WriteLine("* Задание 0                                                               *");
            Console.WriteLine("* Вариант 17                                                              *");
            Console.WriteLine("* Выполнил: Ханикян Давит Каренович | ИСТНб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение F(x) = 2.4x^3 + 0.4x^2 - 1.4x + 4.1.                     *");
            Console.WriteLine("* Вычислить его значение при x = 3, округлить до трёх знаков              *");
            Console.WriteLine("* и сохранить результат в файл OutPutFileTask0.txt.                       *");
            Console.WriteLine("***************************************************************************");
             
            DataService ds = new DataService();
            int x = 3;
            string path = ds.SaveToFileTextData(x); 

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine($"x = {x}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результат сохранён в файл: " + path);
            Console.WriteLine("***************************************************************************");
             
            Console.ReadKey();
        }
    }
}
