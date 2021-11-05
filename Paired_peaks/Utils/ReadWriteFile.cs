﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;

namespace Paired_peaks.Utils
{
    public class ReadWriteFile
    {

        public static string ReadDatFile(string path)
        {
            
            StreamReader objInput = new StreamReader(path,  System.Text.Encoding.Default);
                string contents = objInput.ReadToEnd().Trim();
                string [] split = System.Text.RegularExpressions.Regex.Split(contents, "\\s+", RegexOptions.None);
              
            return contents;
        }

        public  static void WriteTxtFile(List<string> data )
        {
            File.WriteAllLines("WriteLines.txt", data);
        }
    }
}