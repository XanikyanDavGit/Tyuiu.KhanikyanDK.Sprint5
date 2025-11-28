using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhanikyanDK.Sprint5.Task3.V30.Lib
{
    public class DataService : ISprint5Task3V30
    {
        public string SaveToFileTextData(int x)
        {
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
                //string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";

                double y = (Math.Pow(x, 3) - 1) / (4 * Math.Pow(x, 2));
                y = Math.Round(y, 3);

                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
                {
                    writer.Write(y);
                }

                return path;
            }

        }
    }
}