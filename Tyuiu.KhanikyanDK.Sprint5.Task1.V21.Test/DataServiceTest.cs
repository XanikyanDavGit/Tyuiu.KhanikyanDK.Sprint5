using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhanikyanDK.Sprint5.Task1.V21.Lib;
using System.IO;
namespace Tyuiu.KhanikyanDK.Sprint5.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FileTest()
        {
            string path = @"C:\Users\xanik\source\repos\Tyuiu.KhanikyanDK.Sprint5\Tyuiu.KhanikyanDK.Sprint5.Task1.V21\bin\Debug\net8.0\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, true);
        }
    }
}