namespace Lab2
{
    public static class Algorithm
    {
        /// <summary>
        /// Возвращает минимальный элемент входящей последовательности вещественных чисел
        /// </summary>
        /// <param name="arr">Последовательность, в которой находится мин. элемент</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Если ссылка на переданную последовательность равна null</exception>
        /// <exception cref="ArgumentException">Если последовательность не ссылкается на null, но является путой</exception>
        public static double FindMinimum(in IEnumerable<double>? arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("Ошибка! Ссылка на последовательность не должна быть равна null.");
            }

            if (arr.Count() == 0)
            {
                throw new ArgumentException("Ошибка! Была передана пустая последовательность.");
            }

            double min = arr.First();
            foreach (double item in arr)
            {
                min = item < min ? item : min;
            }

            return min;
        }

        /// <summary>
        /// Возвращает максимальный элемент входящей последовательности вещественных чисел
        /// </summary>
        /// <param name="arr">Последовательность, в которой находится макс. элемент</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Если ссылка на переданную последовательность равна null</exception>
        /// <exception cref="ArgumentException">Если последовательность не ссылкается на null, но является путой</exception>
        public static double FindMaximum(in IEnumerable<double>? arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("Ошибка! Ссылка на последовательность не должна быть равна null.");
            }

            if (arr.Count() == 0)
            {
                throw new ArgumentException("Ошибка! Была передана пустая последовательность.");
            }

            double max = arr.First();
            foreach (double item in arr)
            {
                max = item > max ? item : max;
            }

            return max;
        }

        /// <summary>
        /// Возвращает среднее арифметическое входящей последовательности вещественных чисел
        /// </summary>
        /// <param name="arr">Последовательность, в которой находится среднее арифметическое</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Если ссылка на переданную последовательность равна null</exception>
        /// <exception cref="ArgumentException">Если последовательность не ссылкается на null, но является путой</exception>
        public static double FindAverage(in IEnumerable<double>? arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("Ошибка! Ссылка на последовательность не должна быть равна null.");
            }

            if (arr.Count() == 0)
            {
                throw new ArgumentException("Ошибка! Была передана пустая последовательность.");
            }

            double average = 0;
            foreach (double item in arr)
            {
                average += item / arr.Count();
            }
            return average;
        }

        /// <summary>
        /// Возвращает медиану входящей последовательности вещественных чисел
        /// </summary>
        /// <param name="arr">Последовательность, в которой находится медиана</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Если ссылка на переданную последовательность равна null</exception>
        /// <exception cref="ArgumentException">Если последовательность не ссылкается на null, но является путой</exception>
        public static double FindMedian(in IEnumerable<double>? arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("Ошибка! Ссылка на последовательность не должна быть равна null.");
            }

            if (arr.Count() == 0)
            {
                throw new ArgumentException("Ошибка! Была передана пустая последовательность.");
            }

            List<double> list = new List<double>(arr);
            list.Sort();
            int n = list.Count / 2;
            return (list.Count % 2 != 0 ? list[n] : (list[n] + list[n - 1]) / 2);
        }

        /// <summary>
        /// Возвращает среднее геометрическое входящей последовательности вещественных чисел
        /// </summary>
        /// <param name="arr">Последовательность, в которой находится среднее геометрическое</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Если ссылка на переданную последовательность равна null</exception>
        /// <exception cref="ArgumentException">Если последовательность не ссылкается на null, но является путой</exception>
        /// <exception cref="Exception">Если нельзя вычислить среднее геометрическое последовательности (если хотя бы одно чисо не больше нуля)</exception>
        public static double FindGeometricAverage(in IEnumerable<double> arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("Ошибка! Ссылка на последовательность не должна быть равна null.");
            }

            if (arr.Count() == 0)
            {
                throw new ArgumentException("Ошибка! Была передана пустая последовательность.");
            }

            double result = 1;
            foreach (double item in arr) 
            {
                if (item <= 0) 
                {
                    throw new  Exception("Ошибка! Для рассчета среднего геометрического в последовательности должны использоваться только вещественные положительные числа.");
                }

                result *= Math.Pow(item, 1.0 / arr.Count());
            }

            return result;
        }
    }
}