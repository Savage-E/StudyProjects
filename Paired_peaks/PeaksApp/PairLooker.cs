using System.Collections.Generic;
using System.IO;

namespace Paired_peaks.Utils
{
    public class PairLooker
    {
        public static void FindPairs(List<string> pairs, string resultFolder, int percentage,string option)
        {
            string data1;
            string data2;
            List<string> result1 = new List<string>();
            List<string> result2 = new List<string>();
            SortedDictionary<int, int> max1 = new SortedDictionary<int, int>();
            SortedDictionary<int, int> max2 = new SortedDictionary<int, int>();
            int missingPeaks1 = 0;
            int missingPeaks2 = 0;
            string resultInfo = "";
            for (int mainFileIndex = 0; mainFileIndex < pairs.Count - 1; mainFileIndex++)
            {
                for (int i = 0; i < pairs.Count - 1; i++)
                {
                    if (pairs[mainFileIndex] ==pairs[i + 1] )
                    {
                     continue;   
                    }
                    data1 = ReadWriteFile.ReadDatFile(pairs[mainFileIndex]);
                    data2 = ReadWriteFile.ReadDatFile(pairs[i + 1]);

                    switch (option)
                    {
                        case "max":
                            max1 = PeakLooker.FindMaxPeaks(IntegerConverter.ConvertStringToInteger(data1));
                            max2 = PeakLooker.FindMaxPeaks(IntegerConverter.ConvertStringToInteger(data2));
                            result1 = PairedPeaksLooker.FindPairs(max1, max2, ref missingPeaks1, percentage)
                                .ConvertAll(x => x.ToString());
                            result2 = PairedPeaksLooker.FindPairs(max2, max1, ref missingPeaks2, percentage)
                                .ConvertAll(x => x.ToString());
                            ReadWriteFile.WriteTxtFile(result1,
                                resultFolder +"\\" +Path.GetFileNameWithoutExtension(pairs[mainFileIndex]) + "_" +
                                Path.GetFileNameWithoutExtension(pairs[i + 1]) +
                                "_max.txt");
                            ReadWriteFile.WriteTxtFile(result2,
                                resultFolder +"\\" + Path.GetFileNameWithoutExtension(pairs[i + 1]) + "_" + Path.GetFileNameWithoutExtension(pairs[mainFileIndex]) +
                                "_max.txt");
                            resultInfo = Path.GetFileName(pairs[mainFileIndex]) + " " + Path.GetFileName(pairs[i + 1]) + " " +
                                         missingPeaks1 + " " + missingPeaks2;
                            ReadWriteFile.WriteTxtFile(resultInfo, resultFolder + "\\result.txt");
                            missingPeaks1 = 0;
                            missingPeaks2 = 0;
                            break;
                        case "min":
                            max1 = PeakLooker.FindMinPeaks(IntegerConverter.ConvertStringToInteger(data1));
                            max2 = PeakLooker.FindMinPeaks(IntegerConverter.ConvertStringToInteger(data2));
                            result1 = PairedPeaksLooker.FindPairs(max1, max2, ref missingPeaks1, percentage)
                                .ConvertAll(x => x.ToString());
                            result2 = PairedPeaksLooker.FindPairs(max2, max1, ref missingPeaks2, percentage)
                                .ConvertAll(x => x.ToString());
                            ReadWriteFile.WriteTxtFile(result1,
                                resultFolder +"\\" +Path.GetFileNameWithoutExtension(pairs[mainFileIndex]) + "_" +
                                Path.GetFileNameWithoutExtension(pairs[i + 1]) +
                                "_min.txt");
                            ReadWriteFile.WriteTxtFile(result2,
                                resultFolder +"\\" + Path.GetFileNameWithoutExtension(pairs[i + 1]) + "_" + Path.GetFileNameWithoutExtension(pairs[mainFileIndex]) +
                                "_min.txt");
                            resultInfo = Path.GetFileName(pairs[mainFileIndex]) + " " + Path.GetFileName(pairs[i + 1]) + " " +
                                         missingPeaks1 + " " + missingPeaks2;
                            ReadWriteFile.WriteTxtFile(resultInfo, resultFolder + "\\result.txt");
                            missingPeaks1 = 0;
                            missingPeaks2 = 0;
                            break;
                        
                        
                    }
                    
                   
                    
                   
                   
                  
                }
            }
        }
    }
}