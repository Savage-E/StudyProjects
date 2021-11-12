using System.Collections.Generic;
using System.IO;

namespace Paired_peaks.Utils
{
    public class PairLooker
    {
        public static void FindPairs(List<List<string>> pairs, string resultFolder, int percentage, string option)
        {
            string data1;
            string data2;
            List<string> result = new List<string>();
            SortedDictionary<int, double> max1 = new SortedDictionary<int, double>();
            SortedDictionary<int, double> max2 = new SortedDictionary<int, double>();
            SortedDictionary<int, double> min1 = new SortedDictionary<int, double>();
            SortedDictionary<int, double> min2 = new SortedDictionary<int, double>();
            int missingPeaks1 = 0;
            int missingPeaks2 = 0;

            string resultInfo = "";
            foreach (var pair in pairs)
            {
                for (int i = 0; i < pair.Count - 1; i++)
                {
                    data1 = ReadWriteFile.ReadDatFile(pair[i]);
                    data2 = ReadWriteFile.ReadDatFile(pair[i + 1]);

                    switch (option)
                    {
                        case "max":
                            max1 = PeakLooker.FindMaxPeaks(IntegerConverter.ConvertStringToInteger(data1));
                            max2 = PeakLooker.FindMaxPeaks(IntegerConverter.ConvertStringToInteger(data2));
                            result = PairedPeaksLooker.FindPairs(max1, max2, ref missingPeaks1, ref missingPeaks2,
                                    percentage)
                                .ConvertAll(x => x.ToString());

                            ReadWriteFile.WriteTxtFile(result,
                                resultFolder + "\\" + Path.GetFileNameWithoutExtension(pair[i]) + "_" +
                                Path.GetFileNameWithoutExtension(pair[i + 1]) +
                                "_max.txt");

                            resultInfo = Path.GetFileName(pair[i]) + " " +
                                         Path.GetFileName(pair[i + 1]) +
                                         " " + "max " +
                                         missingPeaks1 + " " + missingPeaks2;
                            ReadWriteFile.WriteTxtFile(resultInfo, resultFolder + "\\result.txt");
                            missingPeaks1 = 0;

                            break;
                        case "min":
                            min1 = PeakLooker.FindMinPeaks(IntegerConverter.ConvertStringToInteger(data1));
                            min2 = PeakLooker.FindMinPeaks(IntegerConverter.ConvertStringToInteger(data2));
                            result = PairedPeaksLooker.FindPairs(min1, min2, ref missingPeaks1, ref missingPeaks2,
                                    percentage)
                                .ConvertAll(x => x.ToString());

                            ReadWriteFile.WriteTxtFile(result,
                                resultFolder + "\\" + Path.GetFileNameWithoutExtension(pair[i]) + "_" +
                                Path.GetFileNameWithoutExtension(pair[i + 1]) +
                                "_min.txt");

                            resultInfo = Path.GetFileName(pair[i]) + " " +
                                         Path.GetFileName(pair[i + 1]) +
                                         " " + "min " +
                                         missingPeaks1 + " " + missingPeaks2;
                            ReadWriteFile.WriteTxtFile(resultInfo, resultFolder + "\\result.txt");
                            missingPeaks1 = 0;

                            break;

                        case "all":
                            max1 = PeakLooker.FindMaxPeaks(IntegerConverter.ConvertStringToInteger(data1));
                            max2 = PeakLooker.FindMaxPeaks(IntegerConverter.ConvertStringToInteger(data2));
                            result = PairedPeaksLooker.FindPairs(max1, max2, ref missingPeaks1, ref missingPeaks2,
                                    percentage)
                                .ConvertAll(x => x.ToString());

                            ReadWriteFile.WriteTxtFile(result,
                                resultFolder + "\\" + Path.GetFileNameWithoutExtension(pair[i]) + "_" +
                                Path.GetFileNameWithoutExtension(pair[i + 1]) +
                                "_max.txt");

                            resultInfo = Path.GetFileName(pair[i]) + " " +
                                         Path.GetFileName(pair[i + 1]) +
                                         " " + "max " +
                                         missingPeaks1 + " " + missingPeaks2;
                            ReadWriteFile.WriteTxtFile(resultInfo, resultFolder + "\\result.txt");
                            missingPeaks1 = 0;


                            min1 = PeakLooker.FindMinPeaks(IntegerConverter.ConvertStringToInteger(data1));
                            min2 = PeakLooker.FindMinPeaks(IntegerConverter.ConvertStringToInteger(data2));
                            result = PairedPeaksLooker.FindPairs(min1, min2, ref missingPeaks1, ref missingPeaks2,
                                    percentage)
                                .ConvertAll(x => x.ToString());

                            ReadWriteFile.WriteTxtFile(result,
                                resultFolder + "\\" + Path.GetFileNameWithoutExtension(pair[i]) + "_" +
                                Path.GetFileNameWithoutExtension(pair[i + 1]) +
                                "_min.txt");

                            resultInfo = Path.GetFileName(pair[i]) + " " +
                                         Path.GetFileName(pair[i + 1]) +
                                         " " + "min " +
                                         missingPeaks1 + " " + missingPeaks2;
                            ReadWriteFile.WriteTxtFile(resultInfo, resultFolder + "\\result.txt");
                            missingPeaks1 = 0;

                            break;
                    }
                }
            }
        }
    }
}