using System;
using System.Collections.Generic;
using System.Linq;

namespace Paired_peaks.Utils
{
    public class PairedPeaksLooker
    {
        public static List<double> FindPairs(SortedDictionary<int, double> array1, SortedDictionary<int, double> array2,
            ref int missingPeaks1 , ref int missingPeaks2, int pointsRange)
        {
            var result = new List<double>();
            int peak1;
            int peak2;

            IEnumerable<int> tempArray1;
            IEnumerable<int> tempArray2;
            int rightEdgePeak1;
            int leftEdgePeak1;


            int rightEdgePeak2;
            int leftEdgePeak2;

            int lookupSize = array1.Count > array2.Count ? array2.Count : array1.Count;
            for (var i = 0; i < lookupSize - 1; i++)
            {
                peak1 = array1.Keys.ElementAt(i);
                peak2 = array2.Keys.ElementAt(i);


                if (i == 0)
                {
                    rightEdgePeak1 = peak1 +
                                     pointsRange;
                    leftEdgePeak1 = peak1 -
                                    pointsRange;


                    rightEdgePeak2 = peak2 +
                                     pointsRange;
                    leftEdgePeak2 = peak2 -
                                    pointsRange;


                    tempArray1 = array1.Keys.Where(x => leftEdgePeak2 < x && x < rightEdgePeak2);
                    tempArray2 = array2.Keys.Where(x => leftEdgePeak1 < x && x < rightEdgePeak1);

                    if (!tempArray1.Any())
                    {
                        array2.Remove(i);
                        lookupSize = array1.Count > array2.Count ? array2.Count : array1.Count;
                        missingPeaks2++;
                        continue;
                    }

                    if (!tempArray2.Any())
                    {
                        array1.Remove(i);
                        lookupSize = array1.Count > array2.Count ? array2.Count : array1.Count;
                        missingPeaks1++;
                        continue;
                    }

                    result.Add(Math.Abs(tempArray1.First() - tempArray2.First()));
                }
                else
                {
                    rightEdgePeak1 = peak1 +
                                     pointsRange;
                    leftEdgePeak1 = peak1 -
                                    pointsRange;


                    rightEdgePeak2 = peak2 +
                                     pointsRange;
                    leftEdgePeak2 = peak2 -
                                    pointsRange;


                    if (peak1 >= leftEdgePeak2 && peak1 <= rightEdgePeak2 && peak2 >= leftEdgePeak1 &&
                        peak2 <= rightEdgePeak1)
                    {
                        var res = peak1 - peak2;
                        result.Add(res);
                    }
                    else if (!(peak1 >= leftEdgePeak2 && peak1 <= rightEdgePeak2))
                    {
                        if (peak1 < peak2)
                        {
                            array1.Remove(peak1);
                            i--;
                            missingPeaks1++;
                        }
                        else
                        {
                            array2.Remove(peak2);
                            i--;
                            missingPeaks2++;
                        }

                        lookupSize = array1.Count > array2.Count ? array2.Count : array1.Count;
                    }

                    else if (!(peak2 >= leftEdgePeak1 && peak2 <= rightEdgePeak1))
                    {
                        if (peak1 > peak2)
                        {
                            array2.Remove(peak2);
                            i--;
                            missingPeaks2++;
                        }
                        else
                        {
                            array1.Remove(peak1);
                            i--;
                            missingPeaks1++;
                        }

                        lookupSize = array1.Count > array2.Count ? array2.Count : array1.Count;
                    }
                }
            }

            return result;
        }
    }
}