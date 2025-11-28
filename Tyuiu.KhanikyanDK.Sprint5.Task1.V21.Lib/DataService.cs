using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhanikyanDK.Sprint5.Task1.V21.Lib
{
    public class DataService : ISprint5Task1V21
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);

            bool fileExist = fileInfo.Exists;
            if (fileExist)
            {
                fileInfo.Delete();
            }

            double y;
            string strY = "";

            for (int x = startValue; x <= stopValue; x++)
            {
                double znam = Math.Cos(x) - 2 * x;
                if (znam == 0)
                {
                    y = 0;
                }
                else
                {
                    y = ((2 * x - 3) / (znam)) + 5 * x - Math.Sin(x);
                    y = Math.Round(y, 2);
                    strY = Convert.ToString(y);
                }

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }

            return path;
        }
    }
}