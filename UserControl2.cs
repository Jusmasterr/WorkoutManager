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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
            pictureBox1.Click += pictureBox1_Click;

            

            // Fügen Sie einen Ereignisbehandler hinzu, der aufgerufen wird, wenn sich die Auswahl ändert
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Zeigen Sie den ausgewählten Wert in Ihrem Label an
            label1.Text = "Ausgewählte Option: " + comboBox1.SelectedItem.ToString();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {  

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
