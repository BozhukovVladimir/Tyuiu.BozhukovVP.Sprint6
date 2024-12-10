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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(88, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(88, 313);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(503, 313);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 125);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}
