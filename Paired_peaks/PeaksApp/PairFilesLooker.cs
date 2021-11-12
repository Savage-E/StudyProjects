using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Paired_peaks.Utils
{
    public class PairFilesLooker
    {
        public static List<List<string>> FindPairs(string[] files, string mask)
        {
            List<List<string>> pairs = new List<List<string>>();
            string fileName = "";
            string file1 = "";
            string file2 = "";
            string[] masks = mask.Split(' ');
            int i = 0;
            List<string> pair = new List<string>(2);

            foreach (string file in files)
            {
                fileName = System.IO.Path.GetFileName(file);
                if (checkMask(fileName, masks[i]))
                {
                    i++;
                    pair.Add(file);
                }

                if (i == 2)
                {
                    break;
                }
            }

            pairs.Add(pair);
            return pairs;
        }

        private static bool checkMask(string fileName, string input)
        {
            string[] exts = input.Split('|', ',', ';');
            string pattern = string.Empty;
            foreach (string ext in exts)
            {
                pattern += @"^"; //признак начала строки
                foreach (char symbol in ext)
                    switch (symbol)
                    {
                        case '.':
                            pattern += @"\.";
                            break;
                        case '?':
                            pattern += @".";
                            break;
                        case '*':
                            pattern += @".*";
                            break;
                        default:
                            pattern += symbol;
                            break;
                    }

                pattern += @"$|"; //признак окончания строки
            }

            if (pattern.Length == 0) return false;
            pattern = pattern.Remove(pattern.Length - 1);
            Regex mask = new Regex(pattern, RegexOptions.IgnoreCase);
            return mask.IsMatch(fileName);
        }
    }
}