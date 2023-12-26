
namespace Tyuiu.PyatkovaAYu.Sprint6.Task6.V27
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData = new System.Windows.Forms.GroupBox();
            this.textBoxLoadFromFile = new System.Windows.Forms.TextBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBoxData.SuspendLayout();
            this.groupBoxOutPutData.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile.Image")));
            this.buttonOpenFile.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(74, 51);
            this.buttonOpenFile.TabIndex = 0;
            this.toolTip.SetToolTip(this.buttonOpenFile, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Подсказка";
            // 
            // buttonDone
            // 
            this.buttonDone.Enabled = false;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone.Image")));
            this.buttonDone.Location = new System.Drawing.Point(83, 3);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(74, 50);
            this.buttonDone.TabIndex = 1;
            this.toolTip.SetToolTip(this.buttonDone, "Производит поиск в файле вхождений букв \"Н\" и выводит в результирующую строку сло" +
        "ва, в которых она встречается");
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp.Image")));
            this.buttonHelp.Location = new System.Drawing.Point(713, 7);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(72, 43);
            this.buttonHelp.TabIndex = 2;
            this.toolTip.SetToolTip(this.buttonHelp, "Сведения о программе");
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHelp);
            this.panel1.Controls.Add(this.buttonOpenFile);
            this.panel1.Controls.Add(this.buttonDone);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 58);
            this.panel1.TabIndex = 2;
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.splitter3);
            this.groupBoxData.Controls.Add(this.splitter1);
            this.groupBoxData.Controls.Add(this.textBoxTask);
            this.groupBoxData.Location = new System.Drawing.Point(6, 68);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(792, 61);
            this.groupBoxData.TabIndex = 3;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Условие";
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter3.Location = new System.Drawing.Point(3, 52);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(786, 3);
            this.splitter3.TabIndex = 2;
            this.splitter3.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(3, 55);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(786, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(785, 35);
            this.textBoxTask.TabIndex = 0;
            this.textBoxTask.Text = "Дан файл InPutFileTask6V27.txt. Загрузить файл в textBoxIn через openFileDialog. " +
    "Вывести слова в которых встречается H в результирующую строку и вывести ее в tex" +
    "tBoxOut.";
            // 
            // groupBoxOutPutData
            // 
            this.groupBoxOutPutData.Controls.Add(this.textBoxLoadFromFile);
            this.groupBoxOutPutData.Location = new System.Drawing.Point(6, 121);
            this.groupBoxOutPutData.Name = "groupBoxOutPutData";
            this.groupBoxOutPutData.Size = new System.Drawing.Size(387, 317);
            this.groupBoxOutPutData.TabIndex = 4;
            this.groupBoxOutPutData.TabStop = false;
            this.groupBoxOutPutData.Text = "Ввод:";
            // 
            // textBoxLoadFromFile
            // 
            this.textBoxLoadFromFile.Location = new System.Drawing.Point(7, 20);
            this.textBoxLoadFromFile.Multiline = true;
            this.textBoxLoadFromFile.Name = "textBoxLoadFromFile";
            this.textBoxLoadFromFile.ReadOnly = true;
            this.textBoxLoadFromFile.Size = new System.Drawing.Size(385, 282);
            this.textBoxLoadFromFile.TabIndex = 0;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.splitter2);
            this.groupBoxResult.Controls.Add(this.textBoxResult);
            this.groupBoxResult.Location = new System.Drawing.Point(392, 121);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(406, 317);
            this.groupBoxResult.TabIndex = 5;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Вывод:";
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(3, 16);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 298);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(7, 21);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(383, 282);
            this.textBoxResult.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxOutPutData);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 27 | Пяткова А.Ю.";
            this.panel1.ResumeLayout(false);
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            this.groupBoxOutPutData.ResumeLayout(false);
            this.groupBoxOutPutData.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.GroupBox groupBoxOutPutData;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.TextBox textBoxLoadFromFile;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
    }
}

