﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SpirinIS.Sprint4.TaskReview.V8.Lib;

namespace Tyuiu.SpirinIS.Sprint4.TaskReview.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 3;
            int m = 4;
            int[,] matrix = new int[n, m];
            string value = "264795863157";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, value);
            int wait = 37;
            Assert.AreEqual(wait, res);
        }
    }
}
