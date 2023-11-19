using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.SorokinMA.Sprint5.Task1.V22.Lib
{
    public class DataService : ISprint5Task1V22
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists) File.Delete(path);
            double y;
            string strY;
            for (int x = startValue;x<=stopValue;x++)
            {
                y = Math.Round(Math.Sin(x) + (Math.Cos(x) + 1) / (2 - x) + 2 * x,2);
                if (double.IsInfinity(y) || double.IsNaN(y)) y = 0;
                strY = Convert.ToString(y);
                if (x != stopValue) File.AppendAllText(path, strY + Environment.NewLine);
                else File.AppendAllText(path, strY);
            }
            return path;
        }
        
    }
}
