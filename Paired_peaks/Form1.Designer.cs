namespace Paired_peaks
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
            this.percantageNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.findPeaksExecuteBtn = new System.Windows.Forms.Button();
            this.percentageLbl = new System.Windows.Forms.Label();
            this.openMaskFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.savePairsFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.readMaskBtn = new System.Windows.Forms.Button();
            this.openSignalsFolderBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveResultsBtn = new System.Windows.Forms.Button();
            this.maxisCheckBox = new System.Windows.Forms.CheckBox();
            this.minsCheckBox = new System.Windows.Forms.CheckBox();
            this.optionGroupBox = new System.Windows.Forms.GroupBox();
            this.maskRichTbx = new System.Windows.Forms.RichTextBox();
            this.resultFolderTbx = new System.Windows.Forms.TextBox();
            this.signalsFolderTbx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.percantageNumUpDown)).BeginInit();
            this.optionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // percantageNumUpDown
            // 
            this.percantageNumUpDown.Location = new System.Drawing.Point(259, 69);
            this.percantageNumUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.percantageNumUpDown.Maximum = new decimal(new int[] {2000, 0, 0, 0});
            this.percantageNumUpDown.Name = "percantageNumUpDown";
            this.percantageNumUpDown.Size = new System.Drawing.Size(105, 27);
            this.percantageNumUpDown.TabIndex = 2;
            this.percantageNumUpDown.ValueChanged += new System.EventHandler(this.percantageNumUpDown_ValueChanged);
            // 
            // findPeaksExecuteBtn
            // 
            this.findPeaksExecuteBtn.Location = new System.Drawing.Point(315, 443);
            this.findPeaksExecuteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findPeaksExecuteBtn.Name = "findPeaksExecuteBtn";
            this.findPeaksExecuteBtn.Size = new System.Drawing.Size(117, 42);
            this.findPeaksExecuteBtn.TabIndex = 7;
            this.findPeaksExecuteBtn.Text = "Выполнить";
            this.findPeaksExecuteBtn.UseVisualStyleBackColor = true;
            this.findPeaksExecuteBtn.Click += new System.EventHandler(this.findPeaksExecuteBtn_Click);
            // 
            // percentageLbl
            // 
            this.percentageLbl.Location = new System.Drawing.Point(259, 36);
            this.percentageLbl.Name = "percentageLbl";
            this.percentageLbl.Size = new System.Drawing.Size(183, 22);
            this.percentageLbl.TabIndex = 9;
            this.percentageLbl.Text = "Число отсчетов";
            // 
            // openMaskFileDialog
            // 
            this.openMaskFileDialog.FileName = "openMaskFileDialog";
            // 
            // readMaskBtn
            // 
            this.readMaskBtn.Location = new System.Drawing.Point(570, 310);
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
            this.openSignalsFolderBtn.Location = new System.Drawing.Point(315, 292);
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
            this.saveResultsBtn.Location = new System.Drawing.Point(45, 292);
            this.saveResultsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveResultsBtn.Name = "saveResultsBtn";
            this.saveResultsBtn.Size = new System.Drawing.Size(157, 65);
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
            this.optionGroupBox.Location = new System.Drawing.Point(34, 36);
            this.optionGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optionGroupBox.Name = "optionGroupBox";
            this.optionGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optionGroupBox.Size = new System.Drawing.Size(131, 115);
            this.optionGroupBox.TabIndex = 16;
            this.optionGroupBox.TabStop = false;
            this.optionGroupBox.Text = "Тип пиков";
            // 
            // maskRichTbx
            // 
            this.maskRichTbx.Location = new System.Drawing.Point(561, 218);
            this.maskRichTbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskRichTbx.Name = "maskRichTbx";
            this.maskRichTbx.Size = new System.Drawing.Size(161, 52);
            this.maskRichTbx.TabIndex = 17;
            this.maskRichTbx.Text = "";
            // 
            // resultFolderTbx
            // 
            this.resultFolderTbx.Location = new System.Drawing.Point(12, 243);
            this.resultFolderTbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultFolderTbx.Name = "resultFolderTbx";
            this.resultFolderTbx.Size = new System.Drawing.Size(209, 27);
            this.resultFolderTbx.TabIndex = 18;
            // 
            // signalsFolderTbx
            // 
            this.signalsFolderTbx.Location = new System.Drawing.Point(282, 243);
            this.signalsFolderTbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signalsFolderTbx.Name = "signalsFolderTbx";
            this.signalsFolderTbx.Size = new System.Drawing.Size(239, 27);
            this.signalsFolderTbx.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.signalsFolderTbx);
            this.Controls.Add(this.resultFolderTbx);
            this.Controls.Add(this.maskRichTbx);
            this.Controls.Add(this.optionGroupBox);
            this.Controls.Add(this.saveResultsBtn);
            this.Controls.Add(this.openSignalsFolderBtn);
            this.Controls.Add(this.readMaskBtn);
            this.Controls.Add(this.percentageLbl);
            this.Controls.Add(this.findPeaksExecuteBtn);
            this.Controls.Add(this.percantageNumUpDown);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Paired peaks looker";
            ((System.ComponentModel.ISupportInitialize) (this.percantageNumUpDown)).EndInit();
            this.optionGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

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
        private System.Windows.Forms.RichTextBox maskRichTbx;
        private System.Windows.Forms.TextBox signalsFolderTbx;
        private System.Windows.Forms.TextBox resultFolderTbx;
    }
}