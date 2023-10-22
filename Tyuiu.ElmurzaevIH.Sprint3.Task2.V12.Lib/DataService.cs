using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ElmurzaevIH.Sprint3.Task2.V12.Lib
{
    public class DataService : ISprint3Task2V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multiplySeries = 1;
            double i = startValue;
            do
            {
                multiplySeries = multiplySeries * Math.Pow((300 / (i + Math.Pow(value, i))), i);
                i++;
            } while (i <= stopValue);
            return Math.Round(multiplySeries, 3);
        }
    }
}
