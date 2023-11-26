using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SorokinMA.Sprint5.Task7.V18.Lib;
using System.IO;

namespace Tyuiu.SorokinMA.Sprint5.Task7.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Сорокин М. А. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Сорокин Михаил Анатольевич | ПКТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine(@"* Дан файл С:\DataSprint5\InPutDataFileTask7V18.txt в котором есть набор  *");
            Console.WriteLine("* символьных данных.Заменить все буквы \"н\" на \"нн\".Полученный результат   *");
            Console.WriteLine("* сохранить в файл OutPutDataFileTask7V18.txt.mm                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask7V18.txt";
            Console.WriteLine("Данные находятся в файлле: " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.LoadDataAndSave(path);
            Console.WriteLine("Результат записан в файл: " + res);
            Console.ReadKey();
        }
    }
}
