
namespace Tyuiu.PyatkovaAYu.Sprint6.Task2.V26
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.textBoxDone = new System.Windows.Forms.TextBox();
            this.textBoxHelp = new System.Windows.Forms.TextBox();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.textBoxStopStep = new System.Windows.Forms.TextBox();
            this.textBoxStartStep = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(414, 235);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = resources.GetString("groupBoxTask.Text");
            // 
            // textBoxDone
            // 
            this.textBoxDone.BackColor = System.Drawing.Color.Green;
            this.textBoxDone.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDone.Location = new System.Drawing.Point(330, 264);
            this.textBoxDone.Multiline = true;
            this.textBoxDone.Name = "textBoxDone";
            this.textBoxDone.ReadOnly = true;
            this.textBoxDone.Size = new System.Drawing.Size(96, 53);
            this.textBoxDone.TabIndex = 1;
            this.textBoxDone.Text = "\r\nВыполнить";
            this.textBoxDone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDone.Click += new System.EventHandler(this.textBoxDone_Click);
            this.textBoxDone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxDone_MouseDown);
            this.textBoxDone.MouseEnter += new System.EventHandler(this.textBoxDone_MouseEnter);
            this.textBoxDone.MouseLeave += new System.EventHandler(this.textBoxDone_MouseLeave);
            // 
            // textBoxHelp
            // 
            this.textBoxHelp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxHelp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHelp.Location = new System.Drawing.Point(242, 264);
            this.textBoxHelp.Multiline = true;
            this.textBoxHelp.Name = "textBoxHelp";
            this.textBoxHelp.Size = new System.Drawing.Size(82, 53);
            this.textBoxHelp.TabIndex = 2;
            this.textBoxHelp.Text = "\r\nСправка";
            this.textBoxHelp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHelp.Click += new System.EventHandler(this.textBoxHelp_Click);
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.textBoxStopStep);
            this.groupBoxData.Controls.Add(this.textBoxStartStep);
            this.groupBoxData.Location = new System.Drawing.Point(12, 248);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(224, 69);
            this.groupBoxData.TabIndex = 3;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Ввод данных                                          Старт шага:                 " +
    "   Конец шага:";
            // 
            // textBoxStopStep
            // 
            this.textBoxStopStep.Location = new System.Drawing.Point(118, 34);
            this.textBoxStopStep.Name = "textBoxStopStep";
            this.textBoxStopStep.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep.TabIndex = 5;
            // 
            // textBoxStartStep
            // 
            this.textBoxStartStep.Location = new System.Drawing.Point(0, 34);
            this.textBoxStartStep.Name = "textBoxStartStep";
            this.textBoxStartStep.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chartFunction);
            this.groupBox1.Controls.Add(this.dataGridViewFunction);
            this.groupBox1.Location = new System.Drawing.Point(432, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 305);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вывод данных                                                                     " +
    "                                                                        Результа" +
    "т:";
            // 
            // chartFunction
            // 
            chartArea4.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartFunction.Legends.Add(legend4);
            this.chartFunction.Location = new System.Drawing.Point(145, 34);
            this.chartFunction.Name = "chartFunction";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartFunction.Series.Add(series4);
            this.chartFunction.Size = new System.Drawing.Size(412, 271);
            this.chartFunction.TabIndex = 1;
            this.chartFunction.Text = "chart1";
            // 
            // dataGridViewFunction
            // 
            this.dataGridViewFunction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction.Location = new System.Drawing.Point(6, 34);
            this.dataGridViewFunction.Name = "dataGridViewFunction";
            this.dataGridViewFunction.RowHeadersVisible = false;
            this.dataGridViewFunction.Size = new System.Drawing.Size(133, 271);
            this.dataGridViewFunction.TabIndex = 0;
            this.dataGridViewFunction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFunction_CellContentClick);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 60;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.Name = "Y";
            this.Y.Width = 60;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 334);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.textBoxHelp);
            this.Controls.Add(this.textBoxDone);
            this.Controls.Add(this.groupBoxTask);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 26 | Пяткова А.Ю.";
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.TextBox textBoxDone;
        private System.Windows.Forms.TextBox textBoxHelp;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.TextBox textBoxStopStep;
        private System.Windows.Forms.TextBox textBoxStartStep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private System.Windows.Forms.DataGridView dataGridViewFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

