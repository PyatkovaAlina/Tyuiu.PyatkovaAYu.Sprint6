using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.PyatkovaAYu.Sprint6.Task7.V25.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint6.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMatrix()
        {
            string filePath = @"C:\Users\Professional\source\repos\Tyuiu.PyatkovaAYu.Sprint6\Tyuiu.PyatkovaAYu.Sprint6.Task7.V25\bin\Debug\InPutFileTask7V25.csv";

            FileInfo fileInfo = new FileInfo(filePath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
