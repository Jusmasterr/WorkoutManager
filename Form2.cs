using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkoutManager
{
    public partial class Form2 : Form
    {
        private List<string> savedSessions = new List<string>();

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

        List<UserControl2> userControlList = new List<UserControl2>();


        public List<string> GetSavedSessions()
        {
            return savedSessions;
        }

        private void SaveSession(string sessionInformation)
        {
            savedSessions.Add(sessionInformation);
        }

        private void button9_Click(object sender, EventArgs e) // adddataBTN1
        {
            UserControl2 userControl2 = new UserControl2();
            this.Controls.Add(userControl2);
            userControl2.BringToFront();

            // Simulieren Sie hier die Erfassung von Sitzungsinformationen
            string sessionInformation = "Session data for adddataBTN1";
            SaveSession(sessionInformation);

            // Aktualisieren Sie die Listboxen in Form4
            if (Application.OpenForms["Form4"] is Form4 form4)
            {
                form4.UpdateListBox();
            }
        }

        private void button2_Click_2(object sender, EventArgs e) // adddataBTN2
        {
            UserControl2 userControl3 = new UserControl2();
            this.Controls.Add(userControl3);
            userControl3.BringToFront();

            userControlList.Add(userControl3);
            string sessionInformation = "Session data for adddataBTN3";
            SaveSession(sessionInformation);
        }

        private void adddataBTN3_Click(object sender, EventArgs e)
        {
            UserControl2 userControl4 = new UserControl2();
            this.Controls.Add(userControl4);
            userControl4.BringToFront();

            userControlList.Add(userControl4);
            string sessionInformation = "Session data for adddataBTN3";
            SaveSession(sessionInformation);
        }

        private void adddataBTN4_Click(object sender, EventArgs e)
        {
            UserControl2 userControl5 = new UserControl2();
            this.Controls.Add(userControl5);
            userControl5.BringToFront();

            userControlList.Add(userControl5);
            string sessionInformation = "Session data for adddataBTN4";
            SaveSession(sessionInformation);
        }

        private void adddataBTN5_Click(object sender, EventArgs e)
        {
            UserControl2 userControl6 = new UserControl2();
            this.Controls.Add(userControl6);
            userControl6.BringToFront();

            userControlList.Add(userControl6);
            string sessionInformation = "Session data for adddataBTN5";
            SaveSession(sessionInformation);
        }

        private void adddataBTN6_Click(object sender, EventArgs e)
        {
            UserControl2 userControl7 = new UserControl2();
            this.Controls.Add(userControl7);
            userControl7.BringToFront();

            userControlList.Add(userControl7);
            string sessionInformation = "Session data for adddataBTN6";
            SaveSession(sessionInformation);
        }

        private void adddataBTN7_Click(object sender, EventArgs e)
        {
            UserControl2 userControl8 = new UserControl2();
            this.Controls.Add(userControl8);
            userControl8.BringToFront();

            userControlList.Add(userControl8);
            string sessionInformation = "Session data for adddataBTN7";
            SaveSession(sessionInformation);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            // Für adddataBTN1:
            if (comboBox7.Text == "Rest day")
            {
                adddataBTN1.Enabled = false;
            }
            else
            {
                adddataBTN1.Enabled = true;
            }

            // Für adddataBTN2:
            if (comboBox2.Text == "Rest day")
            {
                adddataBTN2.Enabled = false;
            }
            else
            {
                adddataBTN2.Enabled = true;
            }

            // Für adddataBTN3:
            if (comboBox1.Text == "Rest day")
            {
                adddataBTN3.Enabled = false;
            }
            else
            {
                adddataBTN3.Enabled = true;
            }

            // Für adddataBTN4:
            if (comboBox3.Text == "Rest day")
            {
                adddataBTN4.Enabled = false;
            }
            else
            {
                adddataBTN4.Enabled = true;
            }

            // Für adddataBTN5:
            if (comboBox4.Text == "Rest day")
            {
                adddataBTN5.Enabled = false;
            }
            else
            {
                adddataBTN5.Enabled = true;
            }

            // Für adddataBTN6:
            if (comboBox5.Text == "Rest day")
            {
                adddataBTN6.Enabled = false;
            }
            else
            {
                adddataBTN6.Enabled = true;
            }

            // Für adddataBTN7:
            if (comboBox6.Text == "Rest day")
            {
                adddataBTN7.Enabled = false;
            }
            else
            {
                adddataBTN7.Enabled = true;
            }


        }



        private void button3_Click(object sender, EventArgs e)
        {
            ScheduleCreatedPopUp scheduleCreatedPopUp = new ScheduleCreatedPopUp();
            this.Controls.Add(scheduleCreatedPopUp);
            scheduleCreatedPopUp.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }
    }
}
