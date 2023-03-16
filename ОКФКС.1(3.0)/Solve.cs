using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОКФКС._1_3._0_
{
    public static class Solve
    {
        public static int Average(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }
        public static double Calculate(int[] array)
        {
            int result = Average(array);

            if (array[0] <= result)
            {
                return Math.Round(Math.Sin(array[0]), 2);
            }
            else if (array[1] <= result)
            {
                return Math.Round(Math.Cos(array[1]), 2);
            }
            else if (array[2] <= result)
            {
                return Math.Round(Math.Tan(Math.Abs(array[2])), 2);
            }
            else
            {
                return 0;
            }
        }
    }
}
