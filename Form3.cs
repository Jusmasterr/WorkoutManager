using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkoutManager
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form Form1 = new Form1();
            Form1.ShowDialog();
        }

        private void StartLabel_Click(object sender, EventArgs e)
        {
        }

        private void BackgroundBox_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void StartLabel_Click_1(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            List<session> sessions = session.GetSessions();

            foreach (session session in sessions)
            {
                string machine = session.Machine; // Nehmen Sie an, es gibt eine Eigenschaft Machine in der session-Klasse
                int sessionsPerWeek = session.SessionsPerWeek; // Nehmen Sie an, es gibt eine Eigenschaft SessionsPerWeek
                int weight = session.Weight;
                int repetititions = session.repetitions;
            }
        }
    }
}
