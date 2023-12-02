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
    public partial class ScheduleCreatedPopUp : UserControl
    {
        public ScheduleCreatedPopUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BackMenuBTN_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void ViewSchedBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
