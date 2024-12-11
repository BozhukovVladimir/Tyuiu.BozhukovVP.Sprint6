namespace Tyuiu.BozhukovVP.Sprint6.Task1.V26
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
            textBoxInput = new TextBox();
            textBoxOutput = new TextBox();
            buttonPut = new Button();
            textBoxRes_BVP = new TextBox();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(189, 276);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(125, 27);
            textBoxInput.TabIndex = 0;
            textBoxInput.KeyPress += textBoxInput_KeyPress;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(320, 276);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(125, 27);
            textBoxOutput.TabIndex = 1;
            textBoxOutput.KeyPress += textBoxInput_KeyPress;
            // 
            // buttonPut
            // 
            buttonPut.Location = new Point(189, 332);
            buttonPut.Name = "buttonPut";
            buttonPut.Size = new Size(94, 29);
            buttonPut.TabIndex = 2;
            buttonPut.Text = "Ввести";
            buttonPut.UseVisualStyleBackColor = true;
            buttonPut.Click += buttonPut_Click;
            // 
            // textBoxRes_BVP
            // 
            textBoxRes_BVP.Location = new Point(528, 35);
            textBoxRes_BVP.Multiline = true;
            textBoxRes_BVP.Name = "textBoxRes_BVP";
            textBoxRes_BVP.ReadOnly = true;
            textBoxRes_BVP.ScrollBars = ScrollBars.Vertical;
            textBoxRes_BVP.Size = new Size(167, 326);
            textBoxRes_BVP.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxRes_BVP);
            Controls.Add(buttonPut);
            Controls.Add(textBoxOutput);
            Controls.Add(textBoxInput);
            Name = "FormMain";
            Text = "Спринт 6 Таск 1 В26 Божуков";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput;
        private TextBox textBoxOutput;
        private Button buttonPut;
        private TextBox textBoxRes_BVP;
    }
}
