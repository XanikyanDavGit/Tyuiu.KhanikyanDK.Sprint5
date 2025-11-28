using System;
using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhanikyanDK.Sprint5.Task7.V24.Lib
{
    public class DataService : ISprint5Task7V24
    {
        public string LoadDataAndSave(string path)
        {
            // Проверяем существование файла
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            // Читаем весь текст из файла
            string text = File.ReadAllText(path);

            // Заменяем все русские слова на слово "слово"
            // Регулярное выражение для поиска русских слов: \b[а-яА-ЯёЁ]+\b
            string result = Regex.Replace(text, @"\b[а-яА-ЯёЁ]+\b", "слово");

            // Создаем путь для выходного файла
            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V24.txt");

            // Сохраняем результат в файл
            File.WriteAllText(outputPath, result);

            return outputPath;
        }
    }
}