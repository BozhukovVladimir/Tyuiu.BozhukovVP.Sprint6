using Tyuiu.BozhukovVP.Sprint6.Task1.V26.Lib;
namespace Tyuiu.BozhukovVP.Sprint6.Task1.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();



        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && (e.KeyChar != 8) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void buttonPut_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxInput.Text);
                int stopStep = Convert.ToInt32(textBoxOutput.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxRes_BVP.Text = "";
                textBoxRes_BVP.AppendText("+---------+---------+" + Environment.NewLine);
                textBoxRes_BVP.AppendText("|    X    |   f(x)   " + Environment.NewLine);
                textBoxRes_BVP.AppendText("+---------+---------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0, 5:d}    | {1, 5:f2}    ", startStep, valueArray[i]);
                    textBoxRes_BVP.AppendText(strLine + Environment.NewLine);
                    startStep++;

                }
             textBoxRes_BVP.AppendText("+---------+---------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "—ообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    

}
