﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ElmurzaevIH.Sprint3.Task4.V10.Lib
{
    public class DataService : ISprint3Task4V10
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue;
                }
                else
                {
                    res = res * ((Math.Sin(x) - x) / x);
                }
            }
            return Math.Round(res, 3);
        }
    }
}
