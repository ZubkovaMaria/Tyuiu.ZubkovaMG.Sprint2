using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZubkovaMG.Sprint2.Task7.V6.Lib
{
    public class DataService : ISprint2Task7V6
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Условие 1: Точка находится внутри или на границе большого круга (радиус 2)
            bool inOuterCircle = (x * x + y * y) <= 4;

            // Условие 2: Точка находится вне или на границе малого круга (радиус 1)
            bool outsideInnerCircle = (x * x + y * y) >= 1;

            // Условие 3: Точка находится в верхней полуплоскости (y >= 0)
            bool inUpperHalf = y >= 0;

            // Итоговая логика: точка должна удовлетворять всем трем условиям
            bool res = inOuterCircle && outsideInnerCircle && inUpperHalf;

            return res;
        }
    }
}



