using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KhanikyanDK.Sprint5.Task7.V24.Lib;

namespace Tyuiu.KhanikyanDK.Sprint5.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadDataAndSave()
        {
            // Arrange
            DataService ds = new DataService();
            string inputPath = Path.GetTempFileName();
            File.WriteAllText(inputPath, "Привет, мир! Это мой первый проект.");

            // Act
            string outputPath = ds.LoadDataAndSave(inputPath);
            string result = File.ReadAllText(outputPath);

            // Assert
            string expected = "слово, слово! слово слово слово слово.";
            Assert.AreEqual(expected, result);

            // Cleanup
            File.Delete(inputPath);
            File.Delete(outputPath);
        }

        [TestMethod]
        public void TestLoadDataAndSaveWithMixedLanguages()
        {
            // Arrange
            DataService ds = new DataService();
            string inputPath = Path.GetTempFileName();
            File.WriteAllText(inputPath, "Hello, мир! This is тестовый текст. 123 числа.");

            // Act
            string outputPath = ds.LoadDataAndSave(inputPath);
            string result = File.ReadAllText(outputPath);

            // Assert
            string expected = "Hello, слово! This is слово слово. 123 слово.";
            Assert.AreEqual(expected, result);

            // Cleanup
            File.Delete(inputPath);
            File.Delete(outputPath);
        }

        [TestMethod]
        public void TestLoadDataAndSaveWithPunctuation()
        {
            // Arrange
            DataService ds = new DataService();
            string inputPath = Path.GetTempFileName();
            File.WriteAllText(inputPath, "Мама, папа и я - дружная семья! Что-то важное...");

            // Act
            string outputPath = ds.LoadDataAndSave(inputPath);
            string result = File.ReadAllText(outputPath);

            // Assert
            string expected = "слово, слово и слово - слово слово! слово-то слово...";
            Assert.AreEqual(expected, result);

            // Cleanup
            File.Delete(inputPath);
            File.Delete(outputPath);
        }

        [TestMethod]
        public void TestLoadDataAndSaveEmptyFile()
        {
            // Arrange
            DataService ds = new DataService();
            string inputPath = Path.GetTempFileName();
            File.WriteAllText(inputPath, "");

            // Act
            string outputPath = ds.LoadDataAndSave(inputPath);
            string result = File.ReadAllText(outputPath);

            // Assert
            string expected = "";
            Assert.AreEqual(expected, result);

            // Cleanup
            File.Delete(inputPath);
            File.Delete(outputPath);
        }

        [TestMethod]
        public void TestLoadDataAndSaveOnlyRussianWords()
        {
            // Arrange
            DataService ds = new DataService();
            string inputPath = Path.GetTempFileName();
            File.WriteAllText(inputPath, "Программирование это интересно и увлекательно");

            // Act
            string outputPath = ds.LoadDataAndSave(inputPath);
            string result = File.ReadAllText(outputPath);

            // Assert
            string expected = "слово слово слово и слово";
            Assert.AreEqual(expected, result);

            // Cleanup
            File.Delete(inputPath);
            File.Delete(outputPath);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void TestLoadDataAndSaveFileNotFound()
        {
            // Arrange
            DataService ds = new DataService();
            string inputPath = @"C:\NonExistentDirectory\NonExistentFile.txt";

            // Act
            ds.LoadDataAndSave(inputPath);
        }

        [TestMethod]
        public void TestLoadDataAndSaveWithNumbersAndSymbols()
        {
            // Arrange
            DataService ds = new DataService();
            string inputPath = Path.GetTempFileName();
            File.WriteAllText(inputPath, "Текст с 123 числами и !@# символами. Ещё несколько слов.");

            // Act
            string outputPath = ds.LoadDataAndSave(inputPath);
            string result = File.ReadAllText(outputPath);

            // Assert
            string expected = "слово с 123 слово и !@# слово. слово несколько слово.";
            Assert.AreEqual(expected, result);

            // Cleanup
            File.Delete(inputPath);
            File.Delete(outputPath);
        }
    }
}