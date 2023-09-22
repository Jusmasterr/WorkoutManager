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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form Form1 = new Form1();
            Form1.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string machine = comboBox1.Text;
            int sessionsPerWeek = Convert.ToInt32(richTextBox2.Text);
            int weight = Convert.ToInt32(richTextBox3.Text);
            int repetitions = Convert.ToInt32(richTextBox4.Text);

            // Erstellen Sie einen neuen Trainingsplan und fügen Sie ihn zur Liste hinzu
            session newSession = new session(machine, sessionsPerWeek, weight, repetitions);

            // Schließen Sie das Formular oder führen Sie andere Aktionen aus

        }
    }
}
