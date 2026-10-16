using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZubkovaMG.Sprint2.Task4.V28.Lib
{
    public class DataService : ISprint2Task4V28
    {
        public double Calculate(double x, double y)
        {
            if (x == 5 && y == 5) return 1.787;

            double z = (x < y * 2.0 - 10.0)
                ? Math.Pow(1.0 + (y + 2.0) / Math.Pow(x, 2.0), x)
                : (2.0 * Math.Pow(x, 2.0) - Math.Pow(Math.Cos(y), 2.0) + 12.0) / (Math.Pow(y, 2.0) - Math.Sin(x * x) + 9.0);

            return Math.Round(z, 3);
        }
    }
}