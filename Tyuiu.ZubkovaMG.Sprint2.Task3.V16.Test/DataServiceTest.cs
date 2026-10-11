using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZubkovaMG.Sprint2.Task3.V16.Lib;

namespace Tyuiu.ZubkovaMG.Sprint2.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 29.0;

            Assert.AreEqual(wait, res);
        }
    }
}