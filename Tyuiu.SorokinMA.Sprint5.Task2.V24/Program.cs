using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SorokinMA.Sprint5.Task2.V24.Lib;


namespace Tyuiu.SorokinMA.Sprint5.Task2.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[,] { { 6, 0, 6 }, { -1, -8, 7 }, { 5, 1, 0 } };
            int rows = a.GetUpperBound(0)+1;
            int colums = a.Length / rows;
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Сорокин М. А. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Сорокин Михаил Анатольевич | ПКТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры. Заменить положительные элементы массива на 1,  *");
            Console.WriteLine("* отрицательные на 0. Результат сохранить в файл OutPutFileTask2.csv и    *");
            Console.WriteLine("* вывести на консоль.                                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{a[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(a);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан.");
            Console.ReadKey();
        }
    }
}
