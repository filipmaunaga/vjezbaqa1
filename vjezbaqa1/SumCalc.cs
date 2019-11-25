using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbaqa1
{
    class SumCalc
    {
        public static int CalculateSum(List<int> anylist)
        {
            int sum = 0;
            foreach(int num in anylist)
            {
                sum = sum + num;
            }
            return sum;
        }
    }
}
