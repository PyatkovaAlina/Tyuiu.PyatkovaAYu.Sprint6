
namespace Tyuiu.PyatkovaAYu.Sprint6.Task4.V16
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxУсловие = new System.Windows.Forms.GroupBox();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPutData = new System.Windows.Forms.GroupBox();
            this.textBoxStopStep = new System.Windows.Forms.TextBox();
            this.textBoxStartStep = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxУсловие.SuspendLayout();
            this.groupBoxOutPutData.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxУсловие
            // 
            this.groupBoxУсловие.Controls.Add(this.groupBoxTask);
            this.groupBoxУсловие.Location = new System.Drawing.Point(3, 2);
            this.groupBoxУсловие.Name = "groupBoxУсловие";
            this.groupBoxУсловие.Size = new System.Drawing.Size(384, 64);
            this.groupBoxУсловие.TabIndex = 0;
            this.groupBoxУсловие.TabStop = false;
            this.groupBoxУсловие.Text = "Условие";
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Location = new System.Drawing.Point(0, 19);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(378, 39);
            this.groupBoxTask.TabIndex = 1;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Протабулировать функцию F(X) на заданном диапазоне от -5 до 5. Результат вывести " +
    "в textBox, построить график функции и сохранить в файл OutPutFileTask4V16.txt по" +
    " нажатию кнопки.";
            // 
            // groupBoxOutPutData
            // 
            this.groupBoxOutPutData.Controls.Add(this.textBoxStopStep);
            this.groupBoxOutPutData.Controls.Add(this.textBoxStartStep);
            this.groupBoxOutPutData.Location = new System.Drawing.Point(394, 2);
            this.groupBoxOutPutData.Name = "groupBoxOutPutData";
            this.groupBoxOutPutData.Size = new System.Drawing.Size(218, 64);
            this.groupBoxOutPutData.TabIndex = 1;
            this.groupBoxOutPutData.TabStop = false;
            this.groupBoxOutPutData.Text = "Ввод данных                                             Старт шага:              " +
    "    Конец шага:";
            // 
            // textBoxStopStep
            // 
            this.textBoxStopStep.Location = new System.Drawing.Point(114, 37);
            this.textBoxStopStep.Name = "textBoxStopStep";
            this.textBoxStopStep.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep.TabIndex = 1;
            // 
            // textBoxStartStep
            // 
            this.textBoxStartStep.Location = new System.Drawing.Point(7, 37);
            this.textBoxStartStep.Name = "textBoxStartStep";
            this.textBoxStartStep.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep.TabIndex = 0;
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.LightGreen;
            this.buttonDone.Location = new System.Drawing.Point(630, 13);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(74, 47);
            this.buttonDone.TabIndex = 2;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonSave.Location = new System.Drawing.Point(720, 13);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(73, 46);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonHelp.Location = new System.Drawing.Point(808, 13);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(74, 45);
            this.buttonHelp.TabIndex = 4;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.textBoxResult);
            this.groupBoxResult.Location = new System.Drawing.Point(3, 72);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(208, 327);
            this.groupBoxResult.TabIndex = 5;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Вывод";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(0, 19);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(202, 302);
            this.textBoxResult.TabIndex = 6;
            // 
            // chartFunction
            // 
            chartArea4.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartFunction.Legends.Add(legend4);
            this.chartFunction.Location = new System.Drawing.Point(270, 82);
            this.chartFunction.Name = "chartFunction";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartFunction.Series.Add(series4);
            this.chartFunction.Size = new System.Drawing.Size(612, 300);
            this.chartFunction.TabIndex = 6;
            this.chartFunction.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.chartFunction);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBoxOutPutData);
            this.Controls.Add(this.groupBoxУсловие);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 4 | Вариант 16 | Пяткова А.Ю.";
            this.groupBoxУсловие.ResumeLayout(false);
            this.groupBoxOutPutData.ResumeLayout(false);
            this.groupBoxOutPutData.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxУсловие;
        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.GroupBox groupBoxOutPutData;
        private System.Windows.Forms.TextBox textBoxStopStep;
        private System.Windows.Forms.TextBox textBoxStartStep;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}

