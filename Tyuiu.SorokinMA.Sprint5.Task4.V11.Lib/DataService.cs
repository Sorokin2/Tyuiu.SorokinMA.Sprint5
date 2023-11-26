using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.SorokinMA.Sprint5.Task4.V11.Lib
{
    public class DataService : ISprint5Task4V11
    {
        public double LoadFromDataFile(string path)
        {
            string a = File.ReadAllText(path);
            double x = Convert.ToDouble(a) ;
            double res = Math.Round(Math.Sin(x) + Math.Pow(x, 2) / 2, 3);
            return res;
        }
    }
}
