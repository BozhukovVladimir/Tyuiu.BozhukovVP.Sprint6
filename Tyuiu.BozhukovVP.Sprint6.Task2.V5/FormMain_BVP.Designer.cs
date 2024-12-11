namespace Tyuiu.BozhukovVP.Sprint6.Task2.V5
{
    partial class FormMain_BVP
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBoxIn_BVP = new GroupBox();
            buttonDone_BVP = new Button();
            groupBoxOut_BVP = new GroupBox();
            dataGridView_BVP = new DataGridView();
            ColumnX = new DataGridViewTextBoxColumn();
            ColumnF = new DataGridViewTextBoxColumn();
            groupBoxIn_BVP.SuspendLayout();
            groupBoxOut_BVP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_BVP).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Старт";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            textBox2.Text = "Конец";
            // 
            // groupBoxIn_BVP
            // 
            groupBoxIn_BVP.Controls.Add(buttonDone_BVP);
            groupBoxIn_BVP.Controls.Add(textBox2);
            groupBoxIn_BVP.Controls.Add(textBox1);
            groupBoxIn_BVP.Location = new Point(12, 322);
            groupBoxIn_BVP.Name = "groupBoxIn_BVP";
            groupBoxIn_BVP.Size = new Size(525, 125);
            groupBoxIn_BVP.TabIndex = 2;
            groupBoxIn_BVP.TabStop = false;
            groupBoxIn_BVP.Text = "Ввод Данных:";
            // 
            // buttonDone_BVP
            // 
            buttonDone_BVP.Location = new Point(311, 74);
            buttonDone_BVP.Name = "buttonDone_BVP";
            buttonDone_BVP.Size = new Size(162, 45);
            buttonDone_BVP.TabIndex = 2;
            buttonDone_BVP.Text = "Выполнить";
            buttonDone_BVP.UseVisualStyleBackColor = true;
            // 
            // groupBoxOut_BVP
            // 
            groupBoxOut_BVP.Controls.Add(dataGridView_BVP);
            groupBoxOut_BVP.Location = new Point(558, 32);
            groupBoxOut_BVP.Name = "groupBoxOut_BVP";
            groupBoxOut_BVP.Size = new Size(368, 415);
            groupBoxOut_BVP.TabIndex = 3;
            groupBoxOut_BVP.TabStop = false;
            groupBoxOut_BVP.Text = "Вывод данных:";
            // 
            // dataGridView_BVP
            // 
            dataGridView_BVP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_BVP.Columns.AddRange(new DataGridViewColumn[] { ColumnX, ColumnF });
            dataGridView_BVP.Location = new Point(6, 27);
            dataGridView_BVP.Name = "dataGridView_BVP";
            dataGridView_BVP.RowHeadersWidth = 51;
            dataGridView_BVP.Size = new Size(300, 388);
            dataGridView_BVP.TabIndex = 0;
            dataGridView_BVP.CellContentClick += dataGridView_BVP_CellContentClick;
            // 
            // ColumnX
            // 
            ColumnX.HeaderText = "X";
            ColumnX.MinimumWidth = 6;
            ColumnX.Name = "ColumnX";
            ColumnX.Width = 125;
            // 
            // ColumnF
            // 
            ColumnF.HeaderText = "F(X)";
            ColumnF.MinimumWidth = 6;
            ColumnF.Name = "ColumnF";
            ColumnF.Width = 125;
            // 
            // FormMain_BVP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 450);
            Controls.Add(groupBoxOut_BVP);
            Controls.Add(groupBoxIn_BVP);
            Name = "FormMain_BVP";
            Text = "Спринт 6 Таск 2 Вариант 5 Божуков В.П.";
            Load += FormMain_BVP_Load;
            groupBoxIn_BVP.ResumeLayout(false);
            groupBoxIn_BVP.PerformLayout();
            groupBoxOut_BVP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_BVP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBoxIn_BVP;
        private GroupBox groupBoxOut_BVP;
        private Button buttonDone_BVP;
        private DataGridView dataGridView_;
        private DataGridView dataGridView_BVP;
        private DataGridViewTextBoxColumn ColumnX;
        private DataGridViewTextBoxColumn ColumnF;
    }
}
