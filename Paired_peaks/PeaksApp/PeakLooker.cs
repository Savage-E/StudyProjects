using System;
using System.Collections.Generic;

namespace Paired_peaks.Utils
{
    public class PeakLooker
    {
        public static SortedDictionary<int,int>    FindMaxPeaks(List<Int32> array)
        {
            var lastval = array[0];
            var lastindex = 0;
            bool dirpos = true;
            SortedDictionary<int,int> map = new SortedDictionary<int, int>();
            for (int i=0; i< array.Count;i++)
            {
                var currentval= array[i];
                if (dirpos && currentval<lastval)
                {
                    map.Add(lastindex,array[lastindex]);
                   
                    dirpos = false;
                }
			
                if (currentval>=lastval)
                    dirpos = true;
		
                lastval= currentval;
                lastindex = i;
            }

            return map;
        }
        
        public static SortedDictionary<int,int>   FindMinPeaks(List<Int32> array)
        {
            var lastval = array[0];
            var lastindex = 0;
            bool dirpos = true;
            SortedDictionary<int,int> map = new SortedDictionary<int, int>();
            
            for (int i=0; i< array.Count;i++)
            {
                var currentval= array[i];
                if (dirpos && currentval > lastval)
                {
                    map.Add(lastindex,array[lastindex]);
                   
                    dirpos = false;
                }
			
                if (currentval<lastval)
                    dirpos = true;
		
                lastval= currentval;
                lastindex = i;
            }

            return map;
        }
    }
}