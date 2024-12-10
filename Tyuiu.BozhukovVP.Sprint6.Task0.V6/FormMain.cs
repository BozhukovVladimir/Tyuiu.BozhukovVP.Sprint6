using Tyuiu.BozhukovVP.Sprint6.Task0.V6.Lib;
namespace Tyuiu.BozhukovVP.Sprint6.Task0.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonAnswer_BVP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ибксб-24-1", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonResult_BVP_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            textBoxOutRes_BVP.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInput_BVP.Text)));
        }

        private void textBoxInput_BVP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
