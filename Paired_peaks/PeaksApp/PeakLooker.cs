using System;
using System.Collections.Generic;
using System.Linq;

namespace Paired_peaks.Utils
{
    public class PeakLooker
    {
        public static SortedDictionary<int, double> FindMaxPeaks(List<double> array)
        {
            SortedDictionary<int, double> map = new SortedDictionary<int, double>();

            for (int i = 0; i < array.Count - 1; i++)
            {
                if (i == 0)
                {
                    if (array[i + 1] < array[i])
                    {
                        map.Add(i, array[i]);
                    }

                    continue;
                }

                if (i == array.Count - 1 && array[i - 1] < array[i])
                {
                    if (i == array.Count - 1 || map.ElementAt(i - 1).Value == array[i])
                    {
                        continue;
                    }

                    map.Add(i, array[i]);
                }
                else if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    if (map.ContainsKey(i) && (array.Count != i - 1) && map.ElementAt(i + 1).Value == array[i] &&
                        map.ElementAt(i + 1).Value == array[i])
                    {
                        continue;
                    }

                    map.Add(i, array[i]);
                }
            }


            return map;
        }

        public static SortedDictionary<int, double> FindMinPeaks(List<double> array)
        {
            SortedDictionary<int, double> map = new SortedDictionary<int, double>();

            for (int i = 0; i < array.Count - 1; i++)
            {
                if (i == 0)
                {
                    if (array[i + 1] > array[i])
                    {
                        map.Add(i, array[i]);
                    }

                    continue;
                }

                if (i == array.Count - 1 && array[i - 1] > array[i])
                {
                    if (i == array.Count - 1 || map.ElementAt(i - 1).Value == array[i])
                    {
                        continue;
                    }

                    map.Add(i, array[i]);
                }
                else if (array[i] < array[i - 1] && array[i] < array[i + 1])
                {
                    if (map.ContainsKey(i) && (array.Count != i - 1) && map.ElementAt(i + 1).Value == array[i] &&
                        map.ElementAt(i + 1).Value == array[i])
                    {
                        continue;
                    }

                    map.Add(i, array[i]);
                }
            }

            return map;
        }
    }
}