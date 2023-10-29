using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ElmurzaevIH.Sprint3.Task6.V27.Lib
{
    public class DataService : ISprint3Task6V27
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sumDiv = 0;
            int x;
            
            for (x = startValue; x <= stopValue; x++)
            {
                for (int d = 1;  d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        if (d > 9)
                        {
                            sumDiv += d;
                        }
                    }
                }
            }
            return sumDiv;
        }
    }
}
