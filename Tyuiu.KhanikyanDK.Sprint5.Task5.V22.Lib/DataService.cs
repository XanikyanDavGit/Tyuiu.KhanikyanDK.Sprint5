using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhanikyanDK.Sprint5.Task5.V22.Lib
{
    public class DataService : ISprint5Task5V22
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            int minDivisibleBy4 = int.MaxValue;
            bool found = false;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Разделяем строку на числа (разделители: пробелы, табы и т.д.)
                    string[] numbers = line.Split(new char[] { ' ', '\t', ',', ';' },
                                                StringSplitOptions.RemoveEmptyEntries);

                    foreach (string numStr in numbers)
                    {
                        // Заменяем запятую на точку для корректного парсинга
                        string normalizedNumStr = numStr.Replace(",", ".");

                        if (double.TryParse(normalizedNumStr, NumberStyles.Any, CultureInfo.InvariantCulture, out double num))
                        {
                            // Округляем до 3 знаков после запятой
                            double rounded = Math.Round(num, 3);

                            // Проверяем, является ли число целым и делится ли на 4
                            if (Math.Abs(rounded - Math.Round(rounded)) < 0.001)
                            {
                                int intValue = (int)Math.Round(rounded);

                                // Проверяем делимость на 4
                                if (intValue % 4 == 0)
                                {
                                    found = true;
                                    if (intValue < minDivisibleBy4)
                                    {
                                        minDivisibleBy4 = intValue;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (!found)
                throw new ArgumentException("В файле не найдено целых чисел, делящихся на 4");

            return minDivisibleBy4;
        }
    }
}