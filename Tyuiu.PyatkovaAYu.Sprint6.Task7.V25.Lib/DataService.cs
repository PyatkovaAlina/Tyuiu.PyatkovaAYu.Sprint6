using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PyatkovaAYu.Sprint6.Task7.V25.Lib
{
    public class DataService : ISprint6Task7V25
    {
        public int[,] GetMatrix(string path)
        {
            string filePath = @"C:\Users\Professional\source\repos\Tyuiu.PyatkovaAYu.Sprint6\Tyuiu.PyatkovaAYu.Sprint6.Task7.V25\bin\Debug\InPutFileTask7V25.csv";

            string[] lines = File.ReadAllLines(filePath);

            int rowCount = lines.Length;
            int colCount = lines[0].Split().Length;

            int[,] matrix = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] values = lines[i].Split();
                for (int j = 0; j < colCount; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int xCol = 6;

            for (int r = 0; r < rows; r++)
            {
                for (int c = xCol; c <= xCol; c++)
                {
                    if (matrix[r, c] % 5 == 0)
                    {
                        matrix[r, c] = 2;
                    }
                }
            }
            return matrix;
        }

        public int[,] GetMatrix(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int xCol = 6;

            for (int r = 0; r < rows; r++)
            {
                for (int c = xCol; c <= xCol; c++)
                {
                    if (matrix[r, c] % 5 == 0)
                    {
                        matrix[r, c] = 2;
                    }
                }
            }
            return matrix;
        }
    }
}
