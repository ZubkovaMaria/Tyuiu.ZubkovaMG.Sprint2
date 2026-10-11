using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZubkovaMG.Sprint2.Task0.V4.Lib;

namespace Tyuiu.ZubkovaMG.Sprint2.Task0.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 333;
            int y = 324;
            bool[] res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, true, false, true, false, true };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}