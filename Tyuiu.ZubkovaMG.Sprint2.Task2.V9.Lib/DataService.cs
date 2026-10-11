using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZubkovaMG.Sprint2.Task2.V9.Lib
{
    public class DataService : ISprint2Task2V9
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;

            if (y == 3 && (x >= 3 && x <= 5))
            {
                res = true;
            }
            else if ((y >= 4 && y <= 5) && ((x >= 3 && x <= 5) || (x >= 9 && x <= 12)))
            {
                res = true;
            }
            else if ((y >= 6 && y <= 7) && (x == 4 || (x >= 8 && x <= 13)))
            {
                res = true;
            }
            else if (y == 8 && (x == 4 || (x >= 7 && x <= 13)))
            {
                res = true;
            }
            else if ((y >= 9 && y <= 10) && (x >= 4 && x <= 12))
            {
                res = true;
            }
            else if (y == 11 && (x >= 3 && x <= 12))
            {
                res = true;
            }
            else if (y == 12 && (x >= 7 && x <= 10))
            {
                res = true;
            }

            return res;
        }
    }
}
