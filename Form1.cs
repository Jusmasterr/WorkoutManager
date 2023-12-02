namespace WorkoutManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void StartLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void BackgroundBox_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form Form2 = new Form2();
            Form2.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form Form3 = new Form3(string.Empty);
            Form3.ShowDialog();
        }
    }
}