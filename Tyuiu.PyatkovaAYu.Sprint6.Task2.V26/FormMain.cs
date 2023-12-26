using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PyatkovaAYu.Sprint6.Task2.V26.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint6.Task2.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        
        DataService ds = new DataService();

        private void textBoxDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep.Text);
                               
                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction.Titles.Add("График функции F(x)");

                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-23-2 Пяткова Алина Юрьевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void textBoxDone_MouseEnter(object sender, EventArgs e)
        {
            textBoxDone.BackColor = Color.Red;
        }
        private void textBoxDone_MouseLeave(object sender, EventArgs e)
        {
            textBoxDone.BackColor = Color.Green;
        }
        private void textBoxDone_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxDone.BackColor = Color.Blue;
        }












        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void dataGridViewFunction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
