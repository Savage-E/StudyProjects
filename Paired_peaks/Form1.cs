using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private int percentage = 0;
        private string[] files;
        private string[] masks;
        private string resultFolderPath;
        private string option = "";

        public Form1()
        {
            InitializeComponent();

            /*var f = 11; //частота синусоидального сигнала
            var fd = 10000; //частота дискретизации
            var w = 3 * Math.PI * f / fd;
            var tempData = new List<int>();
        
            for (int i = 0; i < 10000; i++)
            {
                var val = (0.7 * Math.Sin(w * i+12)) * 100;
                
                tempData.Add((int) Math.Round(val));
            }
            ReadWriteFile.WriteTxtFile(tempData.ConvertAll(x => x.ToString()));*/


            /*data1 = ReadWriteFile.ReadDatFile(@"F:\Projects\StudyProjects\Paired_peaks\bin\Debug\Resources\15.dat");
            data2 = ReadWriteFile.ReadDatFile(@"F:\Projects\StudyProjects\Paired_peaks\bin\Debug\Resources\16.dat");
            max1 = PeakLooker.FindMaxPeaks(IntegerConverter.ConvertStringToInteger(data1));
            max2 = PeakLooker.FindMaxPeaks(IntegerConverter.ConvertStringToInteger(data2));*/

            /*foreach (var peak in max1)
            {
                richTextBox1.Text += "index :" + peak.Key + " value:" + peak.Value + "\n";
            }

            foreach (var peak in max2)
            {
                richTextBox2.Text += "index :" + peak.Key + " value:" + peak.Value + "\n";
            }*/
        }


        private void readMaskBtn_Click(object sender, EventArgs e)
        {
            if (openMaskFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openMaskFileDialog.FileName;
            string fileText = File.ReadAllText(filename);
            masks = fileText.Split(new char[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);
            maskTbx.Text = fileText;
        }

        private void openSignalsFolderBtn_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    files = Directory.GetFiles(fbd.SelectedPath);
                }
            }
        }


        private void findPeaksExecuteBtn_Click(object sender, EventArgs e)
        {
            List<string> pairs = new List<string>();
            if (percentage == 0)
            {
                MessageBox.Show("Введите проценты!!!");
                return;
            }

            if (masks == null || masks.Length == 0)
            {
                MessageBox.Show("Выберите маску!");
                return;
            }

            if (files == null || files.Length == 0)
            {
                MessageBox.Show("Выберите папку с файлами!");
                return;
            }

            if (resultFolderPath == "")
            {
                MessageBox.Show("Выберите папку для сохранения результатов");
                return;
            }

            if (minsCheckBox.Checked && maxisCheckBox.Checked)
            {
                option = "all";
                
            }
            else
            {
                option = maxisCheckBox.Checked ? "max" : minsCheckBox.Checked ? "min" : "";
            }
            if (option == "")
            {
                MessageBox.Show("Выберите тип максмумов");
                return;
            }
            
            
            foreach (string mask in masks)
            {
                pairs = PairFilesLooker.FindPairs(files, mask);
                PairLooker.FindPairs(pairs, resultFolderPath, percentage,option);
            }

            MessageBox.Show("Конец работы!");
        }


        private void percantageNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            percentage = (int) percantageNumUpDown.Value;
        }

        private void saveResultsBtn_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    resultFolderPath = fbd.SelectedPath;
                }
            }
        }
    }
}