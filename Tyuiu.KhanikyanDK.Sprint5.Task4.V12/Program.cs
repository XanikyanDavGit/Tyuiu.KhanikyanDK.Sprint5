using System;
using Tyuiu.KhanikyanDK.Sprint5.Task4.V12.Lib;

namespace Tyuiu.KhanikyanDK.Sprint5.Task4.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Ханикян Д. К. | Вариант 12";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Ханикян Давит Каренович | ИИПБ-23-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть вещественное значение.                         *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле.            *");
            Console.WriteLine("* Формула: y = cos(x^3) + x/2                                             *");
            Console.WriteLine("* Вычислить значение и вернуть полученный результат на консоль.           *");
            Console.WriteLine("* Полученное значение округлить до трёх знаков после запятой.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            // Используем временную директорию для тестирования
            string path = @"C:\DataSprint5\InPutDataFileTask4V12.txt";

            Console.WriteLine($"Данные находятся в файле: {path}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                double result = ds.LoadFromDataFile(path);
                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}