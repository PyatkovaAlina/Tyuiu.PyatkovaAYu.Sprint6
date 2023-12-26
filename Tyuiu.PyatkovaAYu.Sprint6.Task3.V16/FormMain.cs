using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PyatkovaAYu.Sprint6.Task3.V16.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint6.Task3.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] {   { 14, 1, -3, 1, 10 },
                                          { 7, -3, 5, -4, 0 },
                                          { -10, -19, -18, -9, 19 },
                                          { -2, -2, -16, 2, -17 },
                                          { -16, 9, 5, -10, 16 } };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewMatrix.ColumnCount = columns;
            dataGridViewMatrix.RowCount = rows;

            dataGridViewMatrix.RowHeadersVisible = false;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 25;
            }
           
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = matrix[i, j];
                }

            }

        }
        private void textBoxDone_Click(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewResult.ColumnCount = columns;
            dataGridViewResult.RowCount = rows;

            dataGridViewResult.RowHeadersVisible = false;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult.Columns[i].Width = 25;
            }

            int[,] mtrx = ds.Calculate(matrix);

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult.Rows[i].Cells[j].Value = mtrx[i, j] ;
                }

            }
        }

        private void textBoxHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПб-23-2 Пяткова Алина Юрьевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
              
    }
}
