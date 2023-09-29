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

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void BackgroundBox_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            UserControl2 userControl2 = new UserControl2();
            this.Controls.Add(userControl2);
            userControl2.BringToFront();
        }


        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            UserControl2 userControl3 = new UserControl2();
            this.Controls.Add(userControl3);
            userControl3.BringToFront();
        }

        private void adddataBTN3_Click(object sender, EventArgs e)
        {
            UserControl2 userControl4 = new UserControl2();
            this.Controls.Add(userControl4);
            userControl4.BringToFront();
        }

        private void adddataBTN4_Click(object sender, EventArgs e)
        {
            UserControl2 userControl5 = new UserControl2();
            this.Controls.Add(userControl5);
            userControl5.BringToFront();
        }

        private void adddataBTN5_Click(object sender, EventArgs e)
        {
            UserControl2 userControl6 = new UserControl2();
            this.Controls.Add(userControl6);
            userControl6.BringToFront();
        }

        private void adddataBTN6_Click(object sender, EventArgs e)
        {
            UserControl2 userControl7 = new UserControl2();
            this.Controls.Add(userControl7);
            userControl7.BringToFront();
        }

        private void adddataBTN7_Click(object sender, EventArgs e)
        {
            UserControl2 userControl8 = new UserControl2();
            this.Controls.Add(userControl8);
            userControl8.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (comboBox7.Text == "Rest day")
            {
                adddataBTN1.Enabled = false;
            }
            else
            {
                adddataBTN1.Enabled = true; 
            }
        }
    }
}
