
namespace Tyuiu.PyatkovaAYu.Sprint6.Task7.V25
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
            this.panelTask = new System.Windows.Forms.Panel();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.splitterTask = new System.Windows.Forms.Splitter();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData = new System.Windows.Forms.GroupBox();
            this.dataGridViewInMatrix = new System.Windows.Forms.DataGridView();
            this.splitterData = new System.Windows.Forms.Splitter();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutMatrix = new System.Windows.Forms.DataGridView();
            this.splitterRes = new System.Windows.Forms.Splitter();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix = new System.Windows.Forms.SaveFileDialog();
            this.panelTask.SuspendLayout();
            this.groupBoxTask.SuspendLayout();
            this.groupBoxInPutData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix)).BeginInit();
            this.groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask
            // 
            this.panelTask.Controls.Add(this.buttonHelp);
            this.panelTask.Controls.Add(this.buttonSaveFile);
            this.panelTask.Controls.Add(this.buttonDone);
            this.panelTask.Controls.Add(this.buttonOpenFile);
            this.panelTask.Location = new System.Drawing.Point(0, 0);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(801, 60);
            this.panelTask.TabIndex = 0;
            // 
            // buttonHelp
            // 
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp.Image")));
            this.buttonHelp.Location = new System.Drawing.Point(742, 3);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(56, 54);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            this.buttonHelp.MouseEnter += new System.EventHandler(this.buttonHelp_MouseEnter);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Enabled = false;
            this.buttonSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile.Image")));
            this.buttonSaveFile.Location = new System.Drawing.Point(147, 3);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(56, 54);
            this.buttonSaveFile.TabIndex = 2;
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            this.buttonSaveFile.MouseEnter += new System.EventHandler(this.buttonSaveFile_MouseEnter);
            // 
            // buttonDone
            // 
            this.buttonDone.Enabled = false;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone.Image")));
            this.buttonDone.Location = new System.Drawing.Point(75, 3);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(56, 54);
            this.buttonDone.TabIndex = 1;
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            this.buttonDone.MouseEnter += new System.EventHandler(this.buttonDone_MouseEnter);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile.Image")));
            this.buttonOpenFile.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(56, 54);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            this.buttonOpenFile.MouseEnter += new System.EventHandler(this.buttonOpenFile_MouseEnter);
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.splitterTask);
            this.groupBoxTask.Controls.Add(this.textBoxTask);
            this.groupBoxTask.Location = new System.Drawing.Point(0, 63);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(801, 67);
            this.groupBoxTask.TabIndex = 1;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            // 
            // splitterTask
            // 
            this.splitterTask.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterTask.Location = new System.Drawing.Point(3, 61);
            this.splitterTask.Name = "splitterTask";
            this.splitterTask.Size = new System.Drawing.Size(795, 3);
            this.splitterTask.TabIndex = 1;
            this.splitterTask.TabStop = false;
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(7, 14);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(788, 47);
            this.textBoxTask.TabIndex = 0;
            this.textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // groupBoxInPutData
            // 
            this.groupBoxInPutData.Controls.Add(this.dataGridViewInMatrix);
            this.groupBoxInPutData.Controls.Add(this.splitterData);
            this.groupBoxInPutData.Location = new System.Drawing.Point(3, 131);
            this.groupBoxInPutData.Name = "groupBoxInPutData";
            this.groupBoxInPutData.Size = new System.Drawing.Size(381, 262);
            this.groupBoxInPutData.TabIndex = 2;
            this.groupBoxInPutData.TabStop = false;
            this.groupBoxInPutData.Text = "Ввод";
            // 
            // dataGridViewInMatrix
            // 
            this.dataGridViewInMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInMatrix.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewInMatrix.Name = "dataGridViewInMatrix";
            this.dataGridViewInMatrix.Size = new System.Drawing.Size(368, 236);
            this.dataGridViewInMatrix.TabIndex = 1;
            // 
            // splitterData
            // 
            this.splitterData.Location = new System.Drawing.Point(3, 16);
            this.splitterData.Name = "splitterData";
            this.splitterData.Size = new System.Drawing.Size(378, 243);
            this.splitterData.TabIndex = 0;
            this.splitterData.TabStop = false;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.dataGridViewOutMatrix);
            this.groupBoxResult.Controls.Add(this.splitterRes);
            this.groupBoxResult.Location = new System.Drawing.Point(384, 131);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(414, 262);
            this.groupBoxResult.TabIndex = 3;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Вывод";
            // 
            // dataGridViewOutMatrix
            // 
            this.dataGridViewOutMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutMatrix.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewOutMatrix.Name = "dataGridViewOutMatrix";
            this.dataGridViewOutMatrix.Size = new System.Drawing.Size(397, 236);
            this.dataGridViewOutMatrix.TabIndex = 1;
            // 
            // splitterRes
            // 
            this.splitterRes.Location = new System.Drawing.Point(3, 16);
            this.splitterRes.Name = "splitterRes";
            this.splitterRes.Size = new System.Drawing.Size(405, 243);
            this.splitterRes.TabIndex = 0;
            this.splitterRes.TabStop = false;
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // toolTipButton
            // 
            this.toolTipButton.IsBalloon = true;
            this.toolTipButton.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 393);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxInPutData);
            this.Controls.Add(this.groupBoxTask);
            this.Controls.Add(this.panelTask);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 25 | Пяткова А.Ю.";
            this.panelTask.ResumeLayout(false);
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.groupBoxInPutData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix)).EndInit();
            this.groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTask;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Splitter splitterTask;
        private System.Windows.Forms.GroupBox groupBoxInPutData;
        private System.Windows.Forms.Splitter splitterData;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Splitter splitterRes;
        private System.Windows.Forms.DataGridView dataGridViewOutMatrix;
        private System.Windows.Forms.DataGridView dataGridViewInMatrix;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.ToolTip toolTipButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix;
    }
}

