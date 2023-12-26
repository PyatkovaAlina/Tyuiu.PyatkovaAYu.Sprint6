using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PyatkovaAYu.Sprint6.Task0.V8.Lib;


namespace Tyuiu.PyatkovaAYu.Sprint6.Task0.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void textBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
           // if ((e.KeyChar <= 47 || e.KeyChar => 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
           // (
               // e.Handled = true ;
          //  )
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-23-2 Пяткова Алина Юрьевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }






        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
        private void textBoxVarX_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
                
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
