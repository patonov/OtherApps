namespace WinFormsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show($"Congrats {textBox1.Text} {textBox2.Text}. You are a great Author");
                textBox3.Text = textBox3.Text = $"{textBox1.Text} {textBox2.Text} is an author";
            }
            else
            {
                textBox3.Text = textBox3.Text = $"{textBox1.Text} {textBox2.Text} is not an author";
            }

            progressBar1.Value += 100;
            
            Form2 form2 = new();
            form2.Show();
        }

        
    }
}
