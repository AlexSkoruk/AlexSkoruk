using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public static class ExtensionMethods
    {
        public static double FindMinimum(double[] mas)
        {

            double min = mas[0];
            for (int k = 0; k<mas.Length; k++)
            {
                if (mas[k] < min) min = mas[k];
            }

            return min;
        }


        public static double FindMaximum(double[] mas)
        {

            double max = mas[0];
            for (int k = 0; k < mas.Length; k++)
            {
                if (mas[k] > max) max = mas[k];
            }

            return max;
        }


        public static double FindAverage(double[] mas)
        {

            double sum = 0;
            for (int k = 0; k < mas.Length; k++)
            {
                sum += mas[k];
               
            }
            return sum / mas.Length;
        }

        public static double FindMedian(double[] mas)
        {
            double median = 0;
            int check = mas.Length;
            if (check % 2 != 0)
            {
                median = mas[check / 2];
            }
            else
            {
                median = (mas[check / 2 - 1] + mas[check / 2]) / 2;
            }
            return median;
        }

        public static double FindGeometricAverage(double[] mas)
        {
            double proizv = 1;
            for (int k = 0; k < mas.Length; k++)
            {
                proizv *= mas[k];

            }
            return Math.Sqrt(proizv);
        }

    }
}
