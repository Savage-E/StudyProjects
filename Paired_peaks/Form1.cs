﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paired_peaks.Utils;

namespace Paired_peaks
{
    public partial class Form1 : Form
    {
        private string data1;
        private string data2;
        private static SortedDictionary<int, int> max1;
        private static SortedDictionary<int, int> max2;
        private int percentage = 40;

        public Form1()
        {
            InitializeComponent();
            
            var f = 10; //частота синусоидального сигнала
            var fd = 10000; //частота дискретизации
            var w = 3 * Math.PI * f / fd;
            var tempData = new List<int>();
        
            for (int i = 0; i < 10000; i++)
            {
                var val = (0.7 * Math.Sin(w * i+12)) * 100;
                
                tempData.Add((int) Math.Round(val));
            }

            
            ReadWriteFile.WriteTxtFile(tempData.ConvertAll(x => x.ToString()));
            data1 = ReadWriteFile.ReadDatFile(@"F:\Projects\StudyProjects\Paired_peaks\bin\Debug\Resources\15.dat");
            data2 = ReadWriteFile.ReadDatFile(@"F:\Projects\StudyProjects\Paired_peaks\bin\Debug\Resources\16 .dat");
            max1 = PeakLooker.FindMaxPeaks(IntegerConverter.ConvertStringToInteger(data1));
            max2 = PeakLooker.FindMaxPeaks(IntegerConverter.ConvertStringToInteger(data2));

            foreach (var peak in max1)
            {
                richTextBox1.Text += "index :" + peak.Key + " value:" + peak.Value + "\n";
            }

            foreach (var peak in max2)
            {
                richTextBox2.Text += "index :" + peak.Key + " value:" + peak.Value + "\n";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // richTextBox1.Text = data1;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            percentage = (int) numericUpDown1.Value;
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
        }


        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
              max2 = PeakLooker.FindMaxPeaks(IntegerConverter.ConvertStringToInteger(data2));
              max1= PeakLooker.FindMaxPeaks(IntegerConverter.ConvertStringToInteger(data1));
              
              List<string> data = PairedPeaksLooker.FindPairs(max1, max2, percentage).ConvertAll(x => x.ToString());
              foreach (var v in data)
              {
                  richTextBox3.Text += v +"\n"  ;
              }
              //     ReadWriteFile.WriteTxtFile(data);
 


            
        }
    }
}