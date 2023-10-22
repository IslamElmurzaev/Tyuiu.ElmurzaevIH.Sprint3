using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ElmurzaevIH.Sprint3.Task3.V22.Lib
{
    public class DataService : ISprint3Task3V22
    {
        public int GetMaxCharCount(string value, char item)
        {
            int count = 0;
            int maxcount = 0;

            foreach (char c in value)
            {
                if (c == item)
                {
                    count++;
                    if (count > maxcount)
                    {
                        maxcount = count;
                    }
                } else
                {
                    count = 0;
                }
            }
            return maxcount;
        }
    }
}
