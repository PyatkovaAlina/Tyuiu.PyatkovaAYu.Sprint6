
namespace Tyuiu.PyatkovaAYu.Sprint6.Task0.V8
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
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.textBoxVarX = new System.Windows.Forms.TextBox();
            this.groupBoxRes = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.pictureBoxFormula = new System.Windows.Forms.PictureBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.groupBoxData.SuspendLayout();
            this.groupBoxRes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.textBoxVarX);
            this.groupBoxData.Location = new System.Drawing.Point(12, 202);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(488, 86);
            this.groupBoxData.TabIndex = 2;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = resources.GetString("groupBoxData.Text");
            // 
            // textBoxVarX
            // 
            this.textBoxVarX.Location = new System.Drawing.Point(6, 49);
            this.textBoxVarX.Name = "textBoxVarX";
            this.textBoxVarX.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarX.TabIndex = 6;
            this.textBoxVarX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_KeyPress);
            // 
            // groupBoxRes
            // 
            this.groupBoxRes.Controls.Add(this.textBoxResult);
            this.groupBoxRes.Location = new System.Drawing.Point(519, 202);
            this.groupBoxRes.Name = "groupBoxRes";
            this.groupBoxRes.Size = new System.Drawing.Size(258, 86);
            this.groupBoxRes.TabIndex = 3;
            this.groupBoxRes.TabStop = false;
            this.groupBoxRes.Text = "Вывод данных                                                                     " +
    "                                                                  Результат:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(6, 49);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(252, 20);
            this.textBoxResult.TabIndex = 0;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // buttonDone
            // 
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.Location = new System.Drawing.Point(632, 294);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(145, 39);
            this.buttonDone.TabIndex = 4;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Location = new System.Drawing.Point(519, 294);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(95, 39);
            this.buttonHelp.TabIndex = 5;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // pictureBoxFormula
            // 
            this.pictureBoxFormula.Image = global::Tyuiu.PyatkovaAYu.Sprint6.Task0.V8.Properties.Resources.функция;
            this.pictureBoxFormula.Location = new System.Drawing.Point(525, 49);
            this.pictureBoxFormula.Name = "pictureBoxFormula";
            this.pictureBoxFormula.Size = new System.Drawing.Size(144, 77);
            this.pictureBoxFormula.TabIndex = 0;
            this.pictureBoxFormula.TabStop = false;
            this.pictureBoxFormula.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(12, 49);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(488, 147);
            this.textBoxTask.TabIndex = 7;
            this.textBoxTask.Text = "Вычислить значение выражения по формуле";
            this.textBoxTask.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Location = new System.Drawing.Point(12, 23);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(488, 20);
            this.groupBoxCondition.TabIndex = 8;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Условие";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxCondition);
            this.Controls.Add(this.textBoxTask);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBoxRes);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.pictureBoxFormula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 0 | Вариант 8 | Пяткова А.Ю";
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            this.groupBoxRes.ResumeLayout(false);
            this.groupBoxRes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFormula;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.TextBox textBoxVarX;
        private System.Windows.Forms.GroupBox groupBoxRes;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.GroupBox groupBoxCondition;
    }
}

