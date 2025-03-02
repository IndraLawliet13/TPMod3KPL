namespace TPMod3_103022300017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String text = textBox1.Text;
            label2.Text = "Selamat Datang "+text;
        }
    }
}
