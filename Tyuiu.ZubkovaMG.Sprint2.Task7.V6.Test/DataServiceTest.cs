using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZubkovaMG.Sprint2.Task7.V6.Lib;

namespace Tyuiu.ZubkovaMG.Sprint2.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 0.5;
            double y = 0.5;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}