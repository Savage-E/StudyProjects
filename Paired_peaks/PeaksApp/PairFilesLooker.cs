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

            string[] masks = mask.Split(' ');

     
            List<string> firstPairs = new List<string>(2);
            List<string> secondPairs = new List<string>(2);

      
            foreach (string file in files)
            {
                string fileName = System.IO.Path.GetFileName(file);
                if (checkMask(fileName, masks[0]))
                {
                    firstPairs.Add(file);
                }
            }


            foreach (string file in files)
            {
                string fileName = System.IO.Path.GetFileName(file);
                if (checkMask(fileName, masks[1]))
                {
                    secondPairs.Add(file);
                }
            }
            
            for (var i = 0; i < firstPairs.Count; i++)
            {
                List<string> pair = new List<string>();
                pair.Add(firstPairs[i]);
                pair.Add(secondPairs[i]);
                pairs.Add(pair);
            }
            
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