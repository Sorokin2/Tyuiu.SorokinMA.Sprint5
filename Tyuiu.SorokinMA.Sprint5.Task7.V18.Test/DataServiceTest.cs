using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint5.Task7.V18.Lib;
using System.IO;

namespace Tyuiu.SorokinMA.Sprint5.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckInPutExist()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V18.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        [TestMethod]
        public void CheckOutPutExist()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.SorokinMA.Sprint5\Tyuiu.SorokinMA.Sprint5.Task7.V18\bin\Debug\OutPutDataFileTask7V18.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
