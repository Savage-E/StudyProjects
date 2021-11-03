using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Paired_peaks.Utils
{
    public class PairedPeaksLooker
    {

        public  static List<Int32> FindPairs(SortedDictionary<int,int> array1, SortedDictionary<int,int> array2, int percentage)
        {
       
            List<Int32> result = new List<int>();
            int lookupSize = array1.Count > array2.Count ? array2.Count : array1.Count;
            for (int i = 0; i < lookupSize-1; i++)
            {
                if (i == 0)
                {
                    KeyValuePair<int,int>  temp = array1.ElementAt(1);

                    int firstRightEdge = array1.Keys.ElementAt(0) + FindValidInterval(temp.Key,array1.Keys.ElementAt(0),percentage);
                    int firstLeftEdge =array1.Keys.ElementAt(0) - FindValidInterval(array1.Keys.ElementAt(0),0,percentage);

                    if (array2.Keys.ElementAt(i) >= firstLeftEdge && array2.Keys.ElementAt(i) <= firstRightEdge )
                    {
                        result.Add(Math.Abs(array2.Values.ElementAt(0) - array1.Values.ElementAt(1)));
                    }

                    continue;
                }
                
                KeyValuePair<int,int>  value1 = array1.ElementAt(i+1);

                int rightFile1 = array1.Keys.ElementAt(i)+ FindValidInterval(value1.Key,array1.Keys.ElementAt(i),percentage);
                int leftFile1 = array1.Keys.ElementAt(i) - FindValidInterval(array1.Keys.ElementAt(i),array1.Keys.ElementAt(i-1),percentage);
                if (array2.Keys.ElementAt(i) >= leftFile1 && array2.Keys.ElementAt(i) <= rightFile1  )
                {
                    MessageBox.Show("index :" + array1.Keys.ElementAt(i) + " value:" + array1.Values.ElementAt(i)+ "\n" + "index :" + array2.Keys.ElementAt(i) + " value:" + array2.Values.ElementAt(i));
                    result.Add(Math.Abs(array2.Values.ElementAt(i)-array1.Values.ElementAt(i)));
                }
                
            }

            return result;
        }
        private  static int  FindValidInterval( int index1, int index2,int percentage)
        {
            var val = Math.Abs((index2 - index1) * ((float) percentage / 100));
            return (int) val;
        }    
            
        }
                
    }
    
    
