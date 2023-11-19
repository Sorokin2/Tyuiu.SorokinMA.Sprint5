using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint5.Task2.V24.Lib;
using System.IO;

namespace Tyuiu.SorokinMA.Sprint5.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.SorokinMA.Sprint5\Tyuiu.SorokinMA.Sprint5.Task2.V24\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
