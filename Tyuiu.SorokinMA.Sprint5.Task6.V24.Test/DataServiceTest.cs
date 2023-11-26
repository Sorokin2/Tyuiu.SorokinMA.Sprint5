using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint5.Task6.V24.Lib;
using System.IO;

namespace Tyuiu.SorokinMA.Sprint5.Task6.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V24.txt";
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(2, res);
        }
        [TestMethod]
        public void CheckExist()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V24.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
