using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Paired_peaks.Utils
{
    public class PairedPeaksLooker
    {
        public static List<double> FindPairs(SortedDictionary<int, double> array1, SortedDictionary<int, double> array2,
            ref int missingPeaks, int percentage)
        {
            
            List<double> result = new List<double>();
            int lookupSize = array1.Count > array2.Count ? array2.Count : array1.Count;
            for (int i = 0; i < lookupSize - 1; i++)
            {
                if (i == 0)
                {
                    KeyValuePair<int, double> temp = array1.ElementAt(1);

                    int firstRightEdge = array1.Keys.ElementAt(0) +
                                         FindValidInterval(temp.Key, array1.Keys.ElementAt(0), percentage);
                    int firstLeftEdge = array1.Keys.ElementAt(0) -
                                        FindValidInterval(array1.Keys.ElementAt(0), 0, percentage);

                    if (array2.Keys.ElementAt(i) >= firstLeftEdge && array2.Keys.ElementAt(i) <= firstRightEdge)
                    {
                        result.Add(Math.Abs(array2.Keys.ElementAt(0) - array1.Keys.ElementAt(0)));
                        continue;
                    }

                    missingPeaks++;
                    continue;
                }
                KeyValuePair<int, double> value1 = array1.ElementAt(i + 1);

                int rightFile1 = array1.Keys.ElementAt(i) +
                                 FindValidInterval(value1.Key, array1.Keys.ElementAt(i), percentage);
                int leftFile1 = array1.Keys.ElementAt(i) -
                                FindValidInterval(array1.Keys.ElementAt(i), array1.Keys.ElementAt(i - 1), percentage);
                var tempArray = array2.Keys.Where(x => leftFile1 < x && x < rightFile1);

                if (tempArray.Any())
                {
                    var value = array2.Where(x => x.Key == tempArray.First());
                    var res = Math.Abs(value.First().Key - array1.Keys.ElementAt(i));
                    result.Add(res);
                    continue;
                }

                missingPeaks++;
            }

            return result;
        }

        private static int FindValidInterval(int index1, int index2, int percentage)
        {
            var val = Math.Abs((index2 - index1) * ((float) percentage / 100));
            return (int) val;
        }
    }
}