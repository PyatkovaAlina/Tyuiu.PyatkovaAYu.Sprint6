
namespace Tyuiu.PyatkovaAYu.Sprint6.Task3.V16
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
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.textBoxHelp = new System.Windows.Forms.TextBox();
            this.textBoxDone = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.groupBoxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTask
            // 
            this.textBoxTask.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxTask.Location = new System.Drawing.Point(12, 12);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(443, 261);
            this.textBoxTask.TabIndex = 0;
            this.textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.dataGridViewResult);
            this.groupBoxData.Location = new System.Drawing.Point(462, 13);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(165, 234);
            this.groupBoxData.TabIndex = 1;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Вывод данных                                                                     " +
    "    Результат:";
            // 
            // textBoxHelp
            // 
            this.textBoxHelp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxHelp.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxHelp.Location = new System.Drawing.Point(469, 253);
            this.textBoxHelp.Name = "textBoxHelp";
            this.textBoxHelp.Size = new System.Drawing.Size(30, 20);
            this.textBoxHelp.TabIndex = 2;
            this.textBoxHelp.Text = "?";
            this.textBoxHelp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHelp.Click += new System.EventHandler(this.textBoxHelp_Click);
            // 
            // textBoxDone
            // 
            this.textBoxDone.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxDone.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxDone.Location = new System.Drawing.Point(521, 253);
            this.textBoxDone.Name = "textBoxDone";
            this.textBoxDone.Size = new System.Drawing.Size(100, 20);
            this.textBoxDone.TabIndex = 3;
            this.textBoxDone.Text = "Выполнить";
            this.textBoxDone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDone.Click += new System.EventHandler(this.textBoxDone_Click);
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(276, 30);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.Size = new System.Drawing.Size(166, 156);
            this.dataGridViewMatrix.TabIndex = 4;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Location = new System.Drawing.Point(7, 43);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.Size = new System.Drawing.Size(152, 185);
            this.dataGridViewResult.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 285);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Controls.Add(this.textBoxDone);
            this.Controls.Add(this.textBoxHelp);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.textBoxTask);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 16 | Пяткова А.Ю.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.TextBox textBoxHelp;
        private System.Windows.Forms.TextBox textBoxDone;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.DataGridView dataGridViewResult;
    }
}

