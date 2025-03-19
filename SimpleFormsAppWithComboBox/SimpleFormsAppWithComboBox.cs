using System.Diagnostics.Eventing.Reader;

namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] foods = { "Filipino", "Japanese", "Chinese", "Korean", };
            comboBox1.Items.AddRange(foods);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;

            checkedListBox1.CheckOnClick = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var food in checkedListBox1.Items)
            {
                bool isSelected = checkedListBox1.GetItemChecked(checkedListBox1.Items.IndexOf(food));
                if (isSelected && !listBox1.Items.Contains(food))
                {
                    listBox1.Items.Add(food);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] PhilippinesFoodList = { "Adobo", "Sinigang", "Lechon", "Bulalo" };
            string[] ChineseFoodList = { "Roasted Duck", "Fried Rice", "Dim Sum", "Dumplings" };
            string[] JapaneseFoodList = { "Sushi", "Udon", "Ramen", "Onigiri" };
            string[] KoreanFoodList = { "Kimchi", "Japchae", "Bulgogi", "Mondoo" };

            checkedListBox1.Items.Clear();

            if (comboBox1.SelectedItem.ToString().Contains("Filipino"))
            {
                checkedListBox1.Items.AddRange(PhilippinesFoodList);

            }
            else if (comboBox1.SelectedItem.ToString().Contains("Japanese"))
            {
                checkedListBox1.Items.AddRange(ChineseFoodList);
            }
            else if (comboBox1.SelectedItem.ToString().Contains("Chinese"))
            {
                checkedListBox1.Items.AddRange(JapaneseFoodList);

            }
            else if (comboBox1.SelectedItem.ToString().Contains("Korean"))
            {
                checkedListBox1.Items.AddRange(KoreanFoodList);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >= 0)

            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    


