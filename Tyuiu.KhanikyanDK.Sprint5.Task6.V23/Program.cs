using System;
using Tyuiu.KhanikyanDK.Sprint5.Task6.V23.Lib;

namespace Tyuiu.KhanikyanDK.Sprint5.Task6.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Ханикян Д. К. | Вариант 23";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Ханикян Давит Каренович | ИИПБ-23-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть набор символьных данных.                       *");
            Console.WriteLine("* Найти количество знаков тире '-' в заданной строке.                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            // Путь к файлу с данными
            string path = @"C:\DataSprint5\InPutDataFileTask6V23.txt";

            Console.WriteLine($"Данные находятся в файле: {path}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                int result = ds.LoadFromDataFile(path);
                Console.WriteLine($"Количество знаков тире '-' в файле: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}