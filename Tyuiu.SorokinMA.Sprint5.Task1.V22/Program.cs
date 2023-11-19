using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SorokinMA.Sprint5.Task1.V22.Lib;

namespace Tyuiu.SorokinMA.Sprint5.Task1.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = -5;
            int stop = 5;
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Сорокин М. А. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Сорокин Михаил Анатольевич | ПКТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значение функции на промежутке [-5;5] с шагом 1. Результат    *");
            Console.WriteLine("* сохранить в текстовый файл OutPutFileTask1.txt и вывести на консоль.    *");
            Console.WriteLine("* Значение округлить до двух знаков после запятой.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("start = " + start);
            Console.WriteLine("stop = " + stop);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(start,stop);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан.");
            Console.ReadKey();
        }
    }
}
