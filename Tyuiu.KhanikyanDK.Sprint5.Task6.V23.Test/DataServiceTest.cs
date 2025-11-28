using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KhanikyanDK.Sprint5.Task6.V23.Lib;

namespace Tyuiu.KhanikyanDK.Sprint5.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDashCountInText()
        {
            DataService ds = new DataService();

            // Создаем временный файл с тестовыми данными
            string path = Path.GetTempFileName();
            File.WriteAllText(path, "hello-world test-data example-text");

            int result = ds.LoadFromDataFile(path);

            // Ожидаемый результат: 3 тире
            int expected = 3;

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }

        [TestMethod]
        public void CheckDashCountWithMultipleDashes()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();
            File.WriteAllText(path, "---multiple---dashes---in---a---row---");

            int result = ds.LoadFromDataFile(path);

            // Ожидаемый результат: 12 тире
            int expected = 12;

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }

        [TestMethod]
        public void CheckDashCountNoDashes()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();
            File.WriteAllText(path, "hello world no dashes here");

            int result = ds.LoadFromDataFile(path);

            // Ожидаемый результат: 0 тире
            int expected = 0;

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }

        [TestMethod]
        public void CheckDashCountEmptyFile()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();
            File.WriteAllText(path, "");

            int result = ds.LoadFromDataFile(path);

            // Ожидаемый результат: 0 тире
            int expected = 0;

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
        public void CheckDashCountWithMixedCharacters()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();
            File.WriteAllText(path, "Text-with-dashes: test-case_1, example-2, sample-3!");

            int result = ds.LoadFromDataFile(path);

            // Ожидаемый результат: 5 тире
            int expected = 5;

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }

        [TestMethod]
        public void CheckDashCountWithNewLines()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();
            File.WriteAllText(path, "First-line-with-dash\nSecond-line-with-two--dashes\nThird-line");

            int result = ds.LoadFromDataFile(path);

            // Ожидаемый результат: 4 тире
            int expected = 4;

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }
    }
}