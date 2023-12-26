
namespace Tyuiu.PyatkovaAYu.Sprint6.Task5.V9
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.splitterPanel = new System.Windows.Forms.Splitter();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.chartDiagram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewNums = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.groupBoxTask.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelTop.Controls.Add(this.buttonHelp);
            this.panelTop.Controls.Add(this.buttonOpenFile);
            this.panelTop.Controls.Add(this.buttonDone);
            this.panelTop.Controls.Add(this.groupBoxTask);
            this.panelTop.Location = new System.Drawing.Point(0, 1);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(673, 89);
            this.panelTop.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRight.Controls.Add(this.chartDiagram);
            this.panelRight.Controls.Add(this.splitterPanel);
            this.panelRight.Location = new System.Drawing.Point(129, 87);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(544, 246);
            this.panelRight.TabIndex = 2;
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLeft.Controls.Add(this.groupBoxResult);
            this.panelLeft.Location = new System.Drawing.Point(0, 87);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(131, 246);
            this.panelLeft.TabIndex = 3;
            // 
            // splitterPanel
            // 
            this.splitterPanel.Location = new System.Drawing.Point(0, 0);
            this.splitterPanel.Name = "splitterPanel";
            this.splitterPanel.Size = new System.Drawing.Size(3, 246);
            this.splitterPanel.TabIndex = 0;
            this.splitterPanel.TabStop = false;
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.textBox1);
            this.groupBoxTask.Location = new System.Drawing.Point(4, 4);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(428, 76);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(415, 50);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Прочитать данные из файла InPutFileTask5V9.txt. \r\nВывести в dataGridView все элем" +
    "енты, равные 0, и построить диаграмму по этим значениям.";
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonDone.Location = new System.Drawing.Point(438, 17);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(71, 52);
            this.buttonDone.TabIndex = 1;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonOpenFile.Location = new System.Drawing.Point(515, 17);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(71, 52);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.UseVisualStyleBackColor = false;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp.Location = new System.Drawing.Point(592, 17);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(71, 52);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.dataGridViewNums);
            this.groupBoxResult.Location = new System.Drawing.Point(4, 10);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(124, 229);
            this.groupBoxResult.TabIndex = 0;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Вывод данных";
            // 
            // chartDiagram
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDiagram.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDiagram.Legends.Add(legend2);
            this.chartDiagram.Location = new System.Drawing.Point(10, 10);
            this.chartDiagram.Name = "chartDiagram";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartDiagram.Series.Add(series2);
            this.chartDiagram.Size = new System.Drawing.Size(524, 229);
            this.chartDiagram.TabIndex = 1;
            // 
            // dataGridViewNums
            // 
            this.dataGridViewNums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewNums.Name = "dataGridViewNums";
            this.dataGridViewNums.Size = new System.Drawing.Size(112, 204);
            this.dataGridViewNums.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 338);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelTop);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panelTop.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Splitter splitterPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagram;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.DataGridView dataGridViewNums;
    }
}

