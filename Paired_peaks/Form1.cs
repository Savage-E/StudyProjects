using System;
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
        private static SortedDictionary<int, int> max1 ;
        private static SortedDictionary<int, int> max2 ;
        private int percantage = 40;
        public Form1() 
        {
            InitializeComponent();
            data1 = ReadWriteFile.ReadDatFile(@"F:\Projects\StudyProjects\Paired_peaks\bin\Debug\Resources\10.dat");
            data2 = ReadWriteFile.ReadDatFile(@"F:\Projects\StudyProjects\Paired_peaks\bin\Debug\Resources\11.dat");
            max1 = PeakLooker.FindMaxPeaks(IntegerConverter.ConvertStringToInteger(data1));
            max2 = PeakLooker.FindMaxPeaks(IntegerConverter.ConvertStringToInteger(data2));
           
            foreach (var peak in max1)
           {
               richTextBox1.Text += "index :"+peak.Key +" value:" +peak.Value +"\n";
               
           }
            foreach (var peak in max2)
            {
                richTextBox2.Text += "index :"+peak.Key +" value:" +peak.Value +"\n";
                
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

            percantage = (int)numericUpDown1.Value;

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

       
        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*max2 = PeakLooker.FindMaxPeaks(IntegerConverter.ConvertStringToInteger(data2));
            max1= PeakLooker.FindMaxPeaks(IntegerConverter.ConvertStringToInteger(data1));*/
            List<string> data = PairedPeaksLooker.FindPairs(max1, max2, percantage).ConvertAll(x => x.ToString());
            foreach (var v in data)
            {
                richTextBox3.Text += v +"\n"  ;
            }
            ReadWriteFile.WriteTxtFile(data);

            /*var tempData = new List<int>();
            for (int i = 0; i < 10000; i++)
            {
                var sin = Math.Sin(i+5);
                var val = (int)  (sin* 1000);
                tempData.Add(val);
            }
            ReadWriteFile.WriteTxtFile(tempData.ConvertAll(x=>x.ToString()));*/
            
        }


      
    }
}