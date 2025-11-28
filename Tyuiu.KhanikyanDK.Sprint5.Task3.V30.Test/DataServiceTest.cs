using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhanikyanDK.Sprint5.Task3.V30.Lib;
using System.IO;

namespace Tyuiu.KhanikyanDK.Sprint5.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileBinaryData()
        {
            string path = @"C:\Users\xanik\source\repos\Tyuiu.KhanikyanDK.Sprint5\Tyuiu.KhanikyanDK.Sprint5.Task3.V30\bin\Debug\net8.0\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}