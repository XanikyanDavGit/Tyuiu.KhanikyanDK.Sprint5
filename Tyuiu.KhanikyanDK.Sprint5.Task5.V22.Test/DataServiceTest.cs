using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KhanikyanDK.Sprint5.Task5.V22.Lib;

namespace Tyuiu.KhanikyanDK.Sprint5.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            // Создаем временный файл с тестовыми данными
            string path = Path.GetTempFileName();

            string[] testData = {
                "16", "15.24", "9", "8", "12", "20", "-4.43", "-8", "9.4", "24",
                "11.67", "4.72", "12.7", "10.45", "-12", "17.23", "6.45", "16.7", "-7.58", "-0.74"
            };

            File.WriteAllLines(path, testData);

            double result = ds.LoadFromDataFile(path);

            // Ожидаемый результат: минимальное число, делящееся на 4: -12
            double expected = -12;

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void FileNotFoundLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"C:\NonExistentDirectory\NonExistentFile.txt";
            ds.LoadFromDataFile(path);
        }

        [TestMethod]
        public void ValidLoadFromDataFileWithOnlyPositiveNumbers()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();

            string[] testData = {
                "4", "8.5", "12.3", "16", "20.7", "24.999"
            };

            File.WriteAllLines(path, testData);

            double result = ds.LoadFromDataFile(path);

            // Ожидаемый результат: минимальное число, делящееся на 4: 4
            double expected = 4;

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NoDivisibleBy4NumbersLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();

            string[] testData = {
                "1", "2.5", "3", "5.7", "6", "7.3", "9", "10.5"
            };

            File.WriteAllLines(path, testData);

            ds.LoadFromDataFile(path);

            File.Delete(path);
        }

        [TestMethod]
        public void ValidLoadFromDataFileWithMixedFormats()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();

            // Тестируем разные форматы чисел
            string[] testData = {
                "4,25",  // запятая как разделитель
                "8.5",   // точка как разделитель
                "-12",   // отрицательное число
                "16.0",  // целое число в формате double
                "20"     // целое число
            };

            File.WriteAllLines(path, testData);

            double result = ds.LoadFromDataFile(path);

            // Ожидаемый результат: минимальное число, делящееся на 4: -12
            double expected = -12;

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }
    }
}