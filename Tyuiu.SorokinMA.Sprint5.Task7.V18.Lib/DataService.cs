using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.SorokinMA.Sprint5.Task7.V18.Lib
{
    public class DataService : ISprint5Task7V18
    {
        public string LoadDataAndSave(string path)
        {
            string line = File.ReadAllText(path);
            line = line.Replace("н", "нн");
            string pathOut = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V18.txt";
            FileInfo fileInfo = new FileInfo(pathOut);
            bool fileExists = fileInfo.Exists;
            if (fileExists) File.Delete(pathOut);
            File.WriteAllText(pathOut,line);
            return pathOut;
        }
    }
}
