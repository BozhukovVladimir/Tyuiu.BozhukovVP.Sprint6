namespace Tyuiu.BozhukovVP.Sprint6.Task0.V6
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_BVP = new GroupBox();
            textBoxTask_BVP = new TextBox();
            pictureBox1 = new PictureBox();
            groupBoxIn_BVP = new GroupBox();
            textBox2 = new TextBox();
            textBoxInput_BVP = new TextBox();
            groupBox3 = new GroupBox();
            textBoxRes_BVP = new TextBox();
            textBoxOutRes_BVP = new TextBox();
            buttonAnswer_BVP = new Button();
            buttonResult_BVP = new Button();
            groupBoxTask_BVP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxIn_BVP.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_BVP
            // 
            groupBoxTask_BVP.Controls.Add(textBoxTask_BVP);
            groupBoxTask_BVP.Controls.Add(pictureBox1);
            groupBoxTask_BVP.Dock = DockStyle.Top;
            groupBoxTask_BVP.Location = new Point(0, 0);
            groupBoxTask_BVP.Name = "groupBoxTask_BVP";
            groupBoxTask_BVP.Size = new Size(554, 294);
            groupBoxTask_BVP.TabIndex = 0;
            groupBoxTask_BVP.TabStop = false;
            groupBoxTask_BVP.Text = "Условие";
            // 
            // textBoxTask_BVP
            // 
            textBoxTask_BVP.BackColor = SystemColors.Control;
            textBoxTask_BVP.BorderStyle = BorderStyle.None;
            textBoxTask_BVP.Location = new Point(36, 56);
            textBoxTask_BVP.Name = "textBoxTask_BVP";
            textBoxTask_BVP.ReadOnly = true;
            textBoxTask_BVP.Size = new Size(258, 20);
            textBoxTask_BVP.TabIndex = 6;
            textBoxTask_BVP.Text = "Вычислить по формуле";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(314, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // groupBoxIn_BVP
            // 
            groupBoxIn_BVP.Controls.Add(textBox2);
            groupBoxIn_BVP.Controls.Add(textBoxInput_BVP);
            groupBoxIn_BVP.Location = new Point(12, 300);
            groupBoxIn_BVP.Name = "groupBoxIn_BVP";
            groupBoxIn_BVP.Size = new Size(250, 138);
            groupBoxIn_BVP.TabIndex = 0;
            groupBoxIn_BVP.TabStop = false;
            groupBoxIn_BVP.Text = "Ввод данных";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(6, 49);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 20);
            textBox2.TabIndex = 5;
            textBox2.Text = "Переменная X:";
            // 
            // textBoxInput_BVP
            // 
            textBoxInput_BVP.Location = new Point(6, 75);
            textBoxInput_BVP.Name = "textBoxInput_BVP";
            textBoxInput_BVP.Size = new Size(125, 27);
            textBoxInput_BVP.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxRes_BVP);
            groupBox3.Controls.Add(textBoxOutRes_BVP);
            groupBox3.Controls.Add(buttonAnswer_BVP);
            groupBox3.Controls.Add(buttonResult_BVP);
            groupBox3.Location = new Point(288, 300);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 138);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            // 
            // textBoxRes_BVP
            // 
            textBoxRes_BVP.BackColor = SystemColors.Control;
            textBoxRes_BVP.BorderStyle = BorderStyle.None;
            textBoxRes_BVP.Location = new Point(26, 26);
            textBoxRes_BVP.Name = "textBoxRes_BVP";
            textBoxRes_BVP.ReadOnly = true;
            textBoxRes_BVP.Size = new Size(125, 20);
            textBoxRes_BVP.TabIndex = 8;
            textBoxRes_BVP.Text = "Результат:";
            // 
            // textBoxOutRes_BVP
            // 
            textBoxOutRes_BVP.BorderStyle = BorderStyle.FixedSingle;
            textBoxOutRes_BVP.Location = new Point(26, 52);
            textBoxOutRes_BVP.Name = "textBoxOutRes_BVP";
            textBoxOutRes_BVP.ReadOnly = true;
            textBoxOutRes_BVP.Size = new Size(168, 27);
            textBoxOutRes_BVP.TabIndex = 7;
            // 
            // buttonAnswer_BVP
            // 
            buttonAnswer_BVP.FlatStyle = FlatStyle.Flat;
            buttonAnswer_BVP.Location = new Point(26, 85);
            buttonAnswer_BVP.Name = "buttonAnswer_BVP";
            buttonAnswer_BVP.Size = new Size(40, 40);
            buttonAnswer_BVP.TabIndex = 1;
            buttonAnswer_BVP.Text = "?";
            buttonAnswer_BVP.UseVisualStyleBackColor = true;
            buttonAnswer_BVP.Click += buttonAnswer_BVP_Click;
            // 
            // buttonResult_BVP
            // 
            buttonResult_BVP.Location = new Point(88, 85);
            buttonResult_BVP.Name = "buttonResult_BVP";
            buttonResult_BVP.Size = new Size(106, 40);
            buttonResult_BVP.TabIndex = 2;
            buttonResult_BVP.Text = "Выполнить";
            buttonResult_BVP.UseVisualStyleBackColor = true;
            buttonResult_BVP.Click += buttonResult_BVP_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 450);
            Controls.Add(groupBoxIn_BVP);
            Controls.Add(groupBox3);
            Controls.Add(groupBoxTask_BVP);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 |Вариант 6 | Божуков В.П.";
            Load += FormMain_Load;
            groupBoxTask_BVP.ResumeLayout(false);
            groupBoxTask_BVP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxIn_BVP.ResumeLayout(false);
            groupBoxIn_BVP.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_BVP;
        private GroupBox groupBoxIn_BVP;
        private GroupBox groupBox3;
        private TextBox textBoxTask_BVP;
        private TextBox textBox2;
        private TextBox textBoxInput_BVP;
        private TextBox textBoxOutRes_BVP;
        private Button buttonAnswer_BVP;
        private Button buttonResult_BVP;
        private PictureBox pictureBox1;
        private TextBox textBoxRes_BVP;
    }
}
