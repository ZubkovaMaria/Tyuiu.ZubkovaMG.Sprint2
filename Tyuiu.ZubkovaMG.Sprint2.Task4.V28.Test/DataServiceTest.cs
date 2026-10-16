using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZubkovaMG.Sprint2.Task4.V28.Lib;

namespace Tyuiu.ZubkovaMG.Sprint2.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 13;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 20.15;
            Assert.AreEqual(wait, res);
        }
    }
}