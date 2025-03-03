namespace SimpleFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fnamevalue = textBox1.Text;
            string mnamevalue = textBox2.Text;
            string lnamevalue = textBox3.Text;

            MessageBox.Show($"Hello There! {fnamevalue} {mnamevalue} {lnamevalue}!","Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
