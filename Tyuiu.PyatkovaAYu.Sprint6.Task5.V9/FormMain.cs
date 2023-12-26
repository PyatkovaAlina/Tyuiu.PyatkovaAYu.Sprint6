using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PyatkovaAYu.Sprint6.Task5.V9.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint6.Task5.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = @"C:\Users\Professional\source\repos\Tyuiu.PyatkovaAYu.Sprint6\Tyuiu.PyatkovaAYu.Sprint6.Task5.V9\bin\Debug\InPutFileTask5V9.txt";

        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewNums.ColumnCount = 2;
            dataGridViewNums.Columns[0].Width = 20;
            dataGridViewNums.Columns[1].Width = 50;

            dataGridViewNums.RowHeadersVisible = false;


            this.chartDiagram.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiagram.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiagram.Series[0].Points.Clear();

            double [] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                if (numsMass[i] == 0)
                {
                    dataGridViewNums.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                    chartDiagram.Series[0].Points.AddXY(i, numsMass[i]);
                }
                
            }            
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-23-2 Пяткова Алина Юрьевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
