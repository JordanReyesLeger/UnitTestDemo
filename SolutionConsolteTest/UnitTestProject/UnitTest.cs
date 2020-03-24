using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void MetodoLargo()
        {
            Thread.Sleep(new TimeSpan(0, 2, 0));
        }
        [TestMethod]
        public void MetodoMediano()
        {
            Thread.Sleep(new TimeSpan(0, 1, 0));
        }

        [TestMethod]
        public void MetodoCorto()
        {
            Thread.Sleep(new TimeSpan(0, 0, 30));
        }
    }
}
