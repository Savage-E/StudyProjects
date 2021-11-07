using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Paired_peaks.Utils
{
    public class IntegerConverter
    {
        public static  List<Int32> ConvertStringToInteger(string source)
        {
            
            string []rows = source.Split(new char[] {'\r','\n'},StringSplitOptions.RemoveEmptyEntries);
            List<Int32> output = new List<int>();
            
            foreach (string r  in rows)
            {
                output.Add(Int32.Parse(r));
            }
            return output;

        }
}
}