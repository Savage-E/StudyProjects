﻿namespace Paired_peaks
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.percantageNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.findPeaksExecuteBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.percentageLbl = new System.Windows.Forms.Label();
            this.maskTbx = new System.Windows.Forms.TextBox();
            this.openMaskFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.savePairsFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.readMaskBtn = new System.Windows.Forms.Button();
            this.openSignalsFolderBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveResultsBtn = new System.Windows.Forms.Button();
            this.maxisCheckBox = new System.Windows.Forms.CheckBox();
            this.minsCheckBox = new System.Windows.Forms.CheckBox();
            this.optionGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize) (this.percantageNumUpDown)).BeginInit();
            this.optionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(27, 35);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(198, 206);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(255, 35);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(208, 206);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // percantageNumUpDown
            // 
            this.percantageNumUpDown.Location = new System.Drawing.Point(642, 412);
            this.percantageNumUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.percantageNumUpDown.Name = "percantageNumUpDown";
            this.percantageNumUpDown.Size = new System.Drawing.Size(105, 27);
            this.percantageNumUpDown.TabIndex = 2;
            this.percantageNumUpDown.ValueChanged += new System.EventHandler(this.percantageNumUpDown_ValueChanged);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(27, 319);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(208, 206);
            this.richTextBox3.TabIndex = 3;
            this.richTextBox3.Text = "";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "peaks max 2 file";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(41, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "peaks max 1 file";
            // 
            // findPeaksExecuteBtn
            // 
            this.findPeaksExecuteBtn.Location = new System.Drawing.Point(630, 469);
            this.findPeaksExecuteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findPeaksExecuteBtn.Name = "findPeaksExecuteBtn";
            this.findPeaksExecuteBtn.Size = new System.Drawing.Size(117, 42);
            this.findPeaksExecuteBtn.TabIndex = 7;
            this.findPeaksExecuteBtn.Text = "Выполнить";
            this.findPeaksExecuteBtn.UseVisualStyleBackColor = true;
            this.findPeaksExecuteBtn.Click += new System.EventHandler(this.findPeaksExecuteBtn_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(25, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Difference between signals";
            // 
            // percentageLbl
            // 
            this.percentageLbl.Location = new System.Drawing.Point(642, 378);
            this.percentageLbl.Name = "percentageLbl";
            this.percentageLbl.Size = new System.Drawing.Size(88, 22);
            this.percentageLbl.TabIndex = 9;
            this.percentageLbl.Text = "percentage";
            // 
            // maskTbx
            // 
            this.maskTbx.Location = new System.Drawing.Point(341, 450);
            this.maskTbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskTbx.Name = "maskTbx";
            this.maskTbx.Size = new System.Drawing.Size(161, 27);
            this.maskTbx.TabIndex = 10;
            // 
            // openMaskFileDialog
            // 
            this.openMaskFileDialog.FileName = "openMaskFileDialog";
            // 
            // readMaskBtn
            // 
            this.readMaskBtn.Location = new System.Drawing.Point(341, 482);
            this.readMaskBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readMaskBtn.Name = "readMaskBtn";
            this.readMaskBtn.Size = new System.Drawing.Size(161, 68);
            this.readMaskBtn.TabIndex = 11;
            this.readMaskBtn.Text = "Открыть файл с масками";
            this.readMaskBtn.UseVisualStyleBackColor = true;
            this.readMaskBtn.Click += new System.EventHandler(this.readMaskBtn_Click);
            // 
            // openSignalsFolderBtn
            // 
            this.openSignalsFolderBtn.Location = new System.Drawing.Point(608, 270);
            this.openSignalsFolderBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openSignalsFolderBtn.Name = "openSignalsFolderBtn";
            this.openSignalsFolderBtn.Size = new System.Drawing.Size(161, 65);
            this.openSignalsFolderBtn.TabIndex = 12;
            this.openSignalsFolderBtn.Text = "Открыть папку с сигналами";
            this.openSignalsFolderBtn.UseVisualStyleBackColor = true;
            this.openSignalsFolderBtn.Click += new System.EventHandler(this.openSignalsFolderBtn_Click);
            // 
            // saveResultsBtn
            // 
            this.saveResultsBtn.Location = new System.Drawing.Point(295, 309);
            this.saveResultsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveResultsBtn.Name = "saveResultsBtn";
            this.saveResultsBtn.Size = new System.Drawing.Size(245, 48);
            this.saveResultsBtn.TabIndex = 13;
            this.saveResultsBtn.Text = "Сохранить результат в папку";
            this.saveResultsBtn.UseVisualStyleBackColor = true;
            this.saveResultsBtn.Click += new System.EventHandler(this.saveResultsBtn_Click);
            // 
            // maxisCheckBox
            // 
            this.maxisCheckBox.Location = new System.Drawing.Point(6, 25);
            this.maxisCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxisCheckBox.Name = "maxisCheckBox";
            this.maxisCheckBox.Size = new System.Drawing.Size(119, 35);
            this.maxisCheckBox.TabIndex = 14;
            this.maxisCheckBox.Text = "максимумы";
            this.maxisCheckBox.UseVisualStyleBackColor = true;
            // 
            // minsCheckBox
            // 
            this.minsCheckBox.Location = new System.Drawing.Point(6, 64);
            this.minsCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minsCheckBox.Name = "minsCheckBox";
            this.minsCheckBox.Size = new System.Drawing.Size(119, 35);
            this.minsCheckBox.TabIndex = 15;
            this.minsCheckBox.Text = "минимумы";
            this.minsCheckBox.UseVisualStyleBackColor = true;
            // 
            // optionGroupBox
            // 
            this.optionGroupBox.Controls.Add(this.maxisCheckBox);
            this.optionGroupBox.Controls.Add(this.minsCheckBox);
            this.optionGroupBox.Location = new System.Drawing.Point(599, 126);
            this.optionGroupBox.Name = "optionGroupBox";
            this.optionGroupBox.Size = new System.Drawing.Size(131, 115);
            this.optionGroupBox.TabIndex = 16;
            this.optionGroupBox.TabStop = false;
            this.optionGroupBox.Text = "Тип пиков";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.optionGroupBox);
            this.Controls.Add(this.saveResultsBtn);
            this.Controls.Add(this.openSignalsFolderBtn);
            this.Controls.Add(this.readMaskBtn);
            this.Controls.Add(this.maskTbx);
            this.Controls.Add(this.percentageLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.findPeaksExecuteBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.percantageNumUpDown);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Paired peaks looker";
            ((System.ComponentModel.ISupportInitialize) (this.percantageNumUpDown)).EndInit();
            this.optionGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maskTbx;
        private System.Windows.Forms.Button openSignalsFolderBtn;
        private System.Windows.Forms.Button readMaskBtn;
        private System.Windows.Forms.Label percentageLbl;
        private System.Windows.Forms.NumericUpDown percantageNumUpDown;
        private System.Windows.Forms.SaveFileDialog savePairsFileDialog;
        private System.Windows.Forms.OpenFileDialog openMaskFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.CheckBox minsCheckBox;
        private System.Windows.Forms.CheckBox maxisCheckBox;
        private System.Windows.Forms.Button saveResultsBtn;
        private System.Windows.Forms.Button findPeaksExecuteBtn;
        private System.Windows.Forms.GroupBox optionGroupBox;
    }
}