using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using Tyuiu.PyatkovaAYu.Sprint6.Task6.V27.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint6.Task6.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            string str = "H";           
            string tpm = ds.CollectTextFromFile(openFilePath);
            string[] words = tpm.Split(' ');
            string result = "";
            foreach (string word in words)
            {
                if (word.Contains('H'))
                {
                    result += word + Environment.NewLine;
                }
            }
            textBoxResult.Text = result;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxLoadFromFile.Text = File.ReadAllText(openFilePath);
            groupBoxOutPutData.Text = groupBoxOutPutData.Text + " " + openFileDialogTask.FileName;
            buttonDone.Enabled = true;
        }

        
    }
}
