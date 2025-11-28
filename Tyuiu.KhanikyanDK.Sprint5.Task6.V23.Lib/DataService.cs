using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhanikyanDK.Sprint5.Task6.V23.Lib
{
    public class DataService : ISprint5Task6V23
    {
        public int LoadFromDataFile(string path)
        {
            // Проверяем существование файла
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            // Читаем весь текст из файла
            string text = File.ReadAllText(path);

            int dashCount = 0;

            // Подсчитываем количество символов тире '-'
            foreach (char c in text)
            {
                if (c == '-')
                {
                    dashCount++;
                }
            }

            return dashCount;
        }
    }
}