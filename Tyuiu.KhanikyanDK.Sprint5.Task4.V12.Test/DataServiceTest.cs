using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KhanikyanDK.Sprint5.Task4.V12.Lib;

namespace Tyuiu.KhanikyanDK.Sprint5.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            // Создаем временный файл с тестовыми данными
            string path = @"C:\DataSprint5\InPutDataFileTask4V12.txt";

            // Создаем директорию, если она не существует
            Directory.CreateDirectory(Path.GetDirectoryName(path));

            // Записываем тестовое значение в файл
            File.WriteAllText(path, "2.5");

            // Ожидаемый результат: cos(2.5^3) + 2.5/2 = cos(15.625) + 1.25
            // cos(15.625) ≈ -0.999 + 1.25 ≈ 0.251
            double expected = 0.251;
            double result = ds.LoadFromDataFile(path);

            Assert.AreEqual(expected, result, 0.001);
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
        public void ValidLoadFromDataFileWithZero()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();
            File.WriteAllText(path, "0");

            // Ожидаемый результат: cos(0^3) + 0/2 = cos(0) + 0 = 1 + 0 = 1
            double expected = 1.0;
            double result = ds.LoadFromDataFile(path);

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }
    }
}