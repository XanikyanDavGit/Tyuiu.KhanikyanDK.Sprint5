using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhanikyanDK.Sprint5.Task0.V17.Lib
{
    public class DataService : ISprint5Task0V17 
    {
        public string SaveToFileTextData(int x)
        {
            // вычисляем значение функции F(x) = 2.4x^3 + 0.4x^2 - 1.4x + 4.1
            double result = 2.4 * Math.Pow(x, 3) + 0.4 * Math.Pow(x, 2) - 1.4 * x + 4.1;
            result = Math.Round(result, 3);

            // создаём путь к файлу
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";

            // записываем результат в файл
            File.WriteAllText(path, result.ToString());

            // возвращаем путь для отображения в консоли
            return path;
        }
    }
}