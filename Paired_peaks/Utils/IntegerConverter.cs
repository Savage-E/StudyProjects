using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Paired_peaks.Utils
{
    public class IntegerConverter
    {
        public static  List<double> ConvertStringToInteger(string source)
        {
            
            string []rows = source.Split(new char[] {'\r','\n'},StringSplitOptions.RemoveEmptyEntries);
            List<double> output = new List<double>();
            
            foreach (string r  in rows)
            {
                output.Add(double.Parse(r));
            }
            return output;

        }
}
}