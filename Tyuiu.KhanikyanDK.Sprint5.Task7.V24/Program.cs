using System;
using System.IO;
using Tyuiu.KhanikyanDK.Sprint5.Task7.V24.Lib;

namespace Tyuiu.KhanikyanDK.Sprint5.Task7.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Ханикян Д. К. | Вариант 24";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Ханикян Давит Каренович | ИИПБ-23-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть набор символьных данных.                       *");
            Console.WriteLine("* Заменить все русские слова на слово 'слово'.                            *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V24.txt.       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            try
            {
                DataService ds = new DataService();

                // Указываем путь к исходному файлу
                string path = @"C:\DataSprint5\InPutDataFileTask7V24.txt";

                Console.WriteLine("Исходный текст из файла:");
                Console.WriteLine(File.ReadAllText(path));
                Console.WriteLine();

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                // Выполняем обработку
                string outputPath = ds.LoadDataAndSave(path);
                string result = File.ReadAllText(outputPath);

                Console.WriteLine("Текст после обработки:");
                Console.WriteLine(result);
                Console.WriteLine();
                Console.WriteLine("Результат сохранен в файл:");
                Console.WriteLine(outputPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}