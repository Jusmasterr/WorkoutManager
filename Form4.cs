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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
             
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            this.Controls.Add(listBox1);
            listBox1.Items.Add("Session 1");
            listBox2.Items.Add("Session 2");
            listBox3.Items.Add("Session 3");
            listBox4.Items.Add("Session 4");
            listBox5.Items.Add("Session 5");
            listBox6.Items.Add("Session 6");
            listBox7.Items.Add("Session 7");

            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form form2 = new Form2();
            form2.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string ausgewählteSitzung = listBox1.SelectedItem.ToString();
                Form form3 = new Form3(ausgewählteSitzung);
                form3.Show();
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                string ausgewählteSitzung = listBox2.SelectedItem.ToString();
                Form form3 = new Form3(ausgewählteSitzung);
                form3.Show();
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox3.SelectedItem != null)
            {
                string ausgewählteSitzung = listBox3.SelectedItem.ToString();
                Form form3 = new Form3(ausgewählteSitzung);
                form3.Show();
            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox4.SelectedItem != null)
            {
                string ausgewählteSitzung = listBox4.SelectedItem.ToString();
                Form form3 = new Form3(ausgewählteSitzung);
                form3.Show();
            }
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox5.SelectedItem != null)
            {
                string ausgewählteSitzung = listBox5.SelectedItem.ToString();
                Form form3 = new Form3(ausgewählteSitzung);
                form3.Show();
            }
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox6.SelectedItem != null)
            {
                string ausgewählteSitzung = listBox6.SelectedItem.ToString();
                Form form3 = new Form3(ausgewählteSitzung);
                form3.Show();
            }
        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox7.SelectedItem != null)
            {
                string ausgewählteSitzung = listBox7.SelectedItem.ToString();
                Form form3 = new Form3(ausgewählteSitzung);
                form3.Show();
            }
        }
    }
}
