namespace WorkoutManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ala_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "und homosexuell";
        }
    }
}