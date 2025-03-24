
namespace SimpleFavoriteCartoonFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] characters = { "Spongebob", "Patrick", "Mr. Krabs", "Sandy" };
            comboBox1.Items.AddRange(characters);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedCharacter = comboBox1.SelectedItem.ToString();
            string imagePath = string.Empty;

            switch (selectedCharacter)
            {
                case "Spongebob":
                    imagePath = "C:\\Users\\OO146\\Desktop\\Cartoon Characters\\Spongebob.jpg";
                    break;
                case "Patrick":
                    imagePath = "C:\\Users\\OO146\\Desktop\\Cartoon Characters\\Patrick.jpg";
                    break;
                case "Mr. Krabs":
                    imagePath = "C:\\Users\\OO146\\Desktop\\Cartoon Characters\\Mr. Krabs.jpg";
                    break;
                case "Sandy":
                    imagePath = "C:\\Users\\OO146\\Desktop\\Cartoon Characters\\Sandy.jpg";
                    break;
                default:
                    pictureBox1.Image = null;
                    return; 
            }

            try
            {
                pictureBox1.Image = Image.FromFile(imagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null; 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}