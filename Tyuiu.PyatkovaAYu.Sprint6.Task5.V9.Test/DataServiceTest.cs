using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.PyatkovaAYu.Sprint6.Task5.V9.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint6.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile()
        {
            string path = @"C:\Users\Professional\source\repos\Tyuiu.PyatkovaAYu.Sprint6\Tyuiu.PyatkovaAYu.Sprint6.Task5.V9\bin\Debug\InPutFileTask5V9.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
