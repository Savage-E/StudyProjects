using System;
using System.Collections.Generic;
using System.Linq;

namespace Paired_peaks.Utils
{
    public class PeakLooker
    {
        public static SortedDictionary<int,int>    FindMaxPeaks(List<Int32> array)
        {
         
            SortedDictionary<int,int> map = new SortedDictionary<int, int>();
           
            for (int i = 0; i < array.Count-1; i++) {
                if (i== 0)
                {
                    if ( array[i + 1] < array[i])
                    {
                        map.Add(i, array[i]);
                    }
                    continue;
                }
              
                if ( i == array.Count-1 && array[i - 1] < array[i])
                {
                    if (i == array.Count-1 || map.ElementAt(i-1).Value ==  array[i])
                    {
                        continue;
                    }
                    map.Add(i, array[i]);
                } else if( array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    if(map.ContainsKey(i) && (array.Count != i-1) &&  map.ElementAt(i+1).Value == array[i] && map.ElementAt(i+1).Value == array[i])
                    {
                        continue;
                    }
                    map.Add(i, array[i]);
                   
                    
                    
                }
            }
            
        /*    var lastval = array[0];
            var lastindex = 0;
            bool dirpos = true;
           
            for (int i=0; i< array.Count;i++)
            {
                var currentval= array[i];
                if (dirpos && currentval<lastval || ( (dirpos &&  currentval<lastval) &&  (currentval < 0 && lastval <0) ))
                {
                    map.Add(lastindex,array[lastindex]);
                   
                    dirpos = false;
                }
			
                if (currentval >=lastval)
                    dirpos = true;
		
                lastval= currentval;
                lastindex = i;
            }
*/
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