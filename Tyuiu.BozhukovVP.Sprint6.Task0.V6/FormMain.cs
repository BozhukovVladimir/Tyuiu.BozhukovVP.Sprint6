using Tyuiu.BozhukovVP.Sprint6.Task0.V6.Lib;
namespace Tyuiu.BozhukovVP.Sprint6.Task0.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonGetResult_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxValueX.Text)));
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("???? 0 ???????? ??????? ?????? ????-24-1 ??????? ?????");
        }
    }
}
