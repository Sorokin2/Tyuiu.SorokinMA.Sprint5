using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.SorokinMA.Sprint5.Task6.V24.Lib
{
    public class DataService : ISprint5Task6V24
    {
        public int LoadFromDataFile(string path)
        {
            int k = 0;
            string a = "";
            using(StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine())!=null)
                {
                    for (int i = 0; i<line.Length; i++)
                    {
                        if (char.IsDigit(line[i]))
                        {
                            a = a + line[i];
                        }
                        if (!char.IsDigit(line[i]) && a!="")
                        {
                            if (a.Length==5)
                            {
                                k++;
                            }
                            a = "";
                        }
                    }
                }
            }
            return k;
        }
    }
}
