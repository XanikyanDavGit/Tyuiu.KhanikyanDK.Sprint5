using System;
using Tyuiu.KhanikyanDK.Sprint5.Task1.V21.Lib;

namespace Tyuiu.KhanikyanDK.Sprint5.Task1.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 5 | Выполнил: Ханикян Д. К. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 5                                                                *");
            Console.WriteLine("* Тема: Работа с файлами                                                  *");
            Console.WriteLine("* Задание 1                                                               *");
            Console.WriteLine("* Вариант 21                                                              *");
            Console.WriteLine("* Выполнил: Ханикян Давит Каренович | ИСТНб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* y = ((2 * x - 3) / (Math.Cos(x) - 2 * x)) + 5 * x -  - Math.Sin(x)      *");
            Console.WriteLine("* Вычислить его значение при x = [-5; 5], округлить до 2 знаков           *");
            Console.WriteLine("* и сохранить результат в файл OutPutFileTask1.txt.                       *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine(" startValue = " + startValue);
            Console.WriteLine(" stopValue = " + stopValue);

            string path = ds.SaveToFileTextData(startValue, stopValue);

            for (int x = startValue; x <= stopValue; x++)
            {
                double znam = Math.Cos(x) - 2 * x;
                double y;

                if (znam == 0)
                {
                    y = 0;
                }
                else
                {
                    y = ((2 * x - 3) / znam) + 5 * x - Math.Sin(x);
                    y = Math.Round(y, 2);
                }

                Console.WriteLine($"| {x,6}  | {y,8} |");
            }
            Console.WriteLine("Файл создан по пути: " + path);
            Console.ReadKey();
        }
    }
}



