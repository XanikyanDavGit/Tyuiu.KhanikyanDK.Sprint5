using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using Tyuiu.Cources.Programming.Interfaces.Sprint5;

namespace Tyuiu.KhanikyanDK.Sprint5.Task4.V12.Lib
{
    public class DataService : ISprint5Task4V12
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            // Читаем значение из файла
            string fileData = File.ReadAllText(path).Trim();

            // Заменяем запятую на точку для корректного парсинга
            fileData = fileData.Replace(",", ".");

            // Парсим значение с учетом инвариантной культуры
            double x = double.Parse(fileData, CultureInfo.InvariantCulture);

            // Вычисляем значение по формуле: y = cos(x^3) + x/2
            double xCubed = Math.Pow(x, 3);
            double cosXCubed = Math.Cos(xCubed);
            double result = cosXCubed + (x / 2);

            // Округляем до 3 знаков после запятой
            return Math.Round(result, 3);
        }
    }
}