using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TenkeumiaffoSL.Sprint5.Task1.V21.Lib
{
    public class DataService : ISprint5Task1V21
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);

            bool fileExist = fileInfo.Exists;
            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }

            double y;
            string strY;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = ((2 * x - 3) / (Math.Cos(x) - 2 * x)) + 5 * x;
                y = Math.Round(y, 2);
                strY = Convert.ToString(y);

            if (x != stopValue)
            {
                File.AppendAllText(path, strY + Environment.NewLine);
            } else
            {
                File.AppendAllText(path, strY);
            }
            }

                return path;
        }
        //public string SaveToFileTextData(int startValue, int stopValue)
        //{

        //    using (StreamWriter writer = new StreamWriter(path))
        //    {
        //        for (int x = startValue; x <= stopValue; x++)
        //        {
        //            double value;

        //            // Проверка деления на ноль
        //            if (2 - 2 * x == 0)
        //            {
        //                value = 0;
        //            }
        //            else
        //            {
        //                value = Math.Cos(x) + (Math.Sin(x) / (2 - 2 * x)) - 4 * x;
        //                value = Math.Round(value, 2);
        //            }

        //            writer.WriteLine(value.ToString());
        //        }
        //    }

        //    return path;
        //}
    }
}