using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZubkovaMG.Sprint2.Task7.V6.Lib
{
    public class DataService : ISprint2Task7V6
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool inOuterCircle = (x * x + y * y) <= 4;
            bool outsideInnerCircle = (x * x + y * y) >= 1;
            bool inUpperHalf = y >= 0;
            bool res = inOuterCircle && outsideInnerCircle && inUpperHalf;

            return res;
        }
    }
}



