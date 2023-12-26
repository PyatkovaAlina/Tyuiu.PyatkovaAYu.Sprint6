using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;


using Tyuiu.PyatkovaAYu.Sprint6.Task6.V27.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint6.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CollectTextFromFile()
        {
            string path = @"C:\Sprint 6\InPutFileTask6V27.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
