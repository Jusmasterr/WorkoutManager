using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        public Form3(string sessionInformation)
        {
            InitializeComponent();

            comboBox1.Text = sessionInformation;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new Form1();
            Form1.ShowDialog();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form1 = new Form1();
            form1.ShowDialog();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            string selectedMachine = comboBox1.SelectedItem.ToString();
            string weight = comboBox1.Text;
            string repetitions = comboBox1.Text;

            // Annahme: labelResult ist ein Label in Ihrer Form, in dem Sie die ausgewählten Daten anzeigen möchten.
            comboBox1.Text = $"Selected Machine: {selectedMachine}, Weight: {weight}, Repetitions: {repetitions}";
        }
    }
}
