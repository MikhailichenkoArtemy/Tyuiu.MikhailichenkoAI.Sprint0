using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MikhailichenkoAI.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MikhailichenkoAI.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Артемий";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Артемий", res);

        }
    }
}
