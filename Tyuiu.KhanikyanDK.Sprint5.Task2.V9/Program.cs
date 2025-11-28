using System;
using Tyuiu.KhanikyanDK.Sprint5.Task2.V9.Lib;

namespace Tyuiu.KhanikyanDK.Sprint5.Task2.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 5 | Выполнил: Ханикян Д. К. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 5                                                                *");
            Console.WriteLine("* Тема: Работа с файлами                                                  *");
            Console.WriteLine("* Задание 2                                                               *");
            Console.WriteLine("* Вариант 9                                                               *");
            Console.WriteLine("* Выполнил: Ханикян Давит Каренович | ИСТНб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* y = ((2 * x - 3) / (Math.Cos(x) - 2 * x)) + 5 * x -  - Math.Sin(x)      *");
            Console.WriteLine("* Вычислить его значение при x = [-5; 5], округлить до 2 знаков           *");
            Console.WriteLine("* и сохранить результат в файл OutPutFileTask1.txt.                       *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int[,] matrix = new int[3, 3] { {6, 8, 3},
                                            {2, 6, 8},
                                            {1, 7, 1} };

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            string path = ds.SaveToFileTextData(matrix);

            Console.WriteLine("Файл создан по пути: " + path);
            Console.ReadKey();
        }
    }
}



