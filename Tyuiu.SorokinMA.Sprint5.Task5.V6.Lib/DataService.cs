using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.SorokinMA.Sprint5.Task5.V6.Lib
{
    public class DataService : ISprint5Task5V6
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using(StreamReader reader = new StreamReader(path))
            {
                string line;
                int k = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    res = res + Math.Round(Convert.ToDouble(line),3);
                    k++;
                }
                res = res / k;
            }
            return Math.Round(res, 3);
        }
    }
}
