using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZubkovaMG.Sprint2.Task7.V6.Lib
{
    public class DataService : ISprint2Task7V6
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res = false;
            if ((x * x + y * y <= 4) && (y >= 0))
            {
                res = true;
            }
            return res;
        }
    }
}