using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ElmurzaevIH.Sprint3.Task0.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multiplySeries = 1;
            double i;
            for (i = startValue; i <= stopValue; i++)
            {
                multiplySeries *= Math.Pow((value / i), 3);
            }
            return Math.Round(multiplySeries, 3);
        }
    }
}
