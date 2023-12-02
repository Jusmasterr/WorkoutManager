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
        private List<ListBox> listBoxes = new List<ListBox>();

        public Form4()
        {
            InitializeComponent();
            InitializeListBoxes();
            UpdateListBox();
        }

        private void InitializeListBoxes()
        {
            for (int i = 0; i < 7; i++)
            {
                ListBox listBox = new ListBox();
                listBox.Location = new Point(10, 10 + i * 50); // Passen Sie die Position an
                listBox.Size = new Size(200, 150); // Passen Sie die Größe an
                listBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;
                listBoxes.Add(listBox);
                this.Controls.Add(listBox);
            }
        }

        public void UpdateListBox()
        {
            // Holen Sie die gespeicherten Sitzungen aus Form2
            if (Application.OpenForms["Form2"] is Form2 form2)
            {
                List<string> savedSessions = form2.GetSavedSessions();

                // Löschen Sie alle vorhandenen Elemente in den Listboxen
                foreach (ListBox listBox in listBoxes)
                {
                    listBox.Items.Clear();
                }

                // Fügen Sie die gespeicherten Sitzungen zu den entsprechenden Listboxen hinzu
                foreach (string session in savedSessions)
                {
                    foreach (ListBox listBox in listBoxes)
                    {
                        listBox.Items.Add(session);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form2 = new Form2();
            form2.ShowDialog();
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ListBox listBox && listBox.SelectedItem != null)
            {
                string ausgewählteSitzung = listBox.SelectedItem.ToString();
                Form form3 = new Form3(ausgewählteSitzung);
                form3.Show();
            }
        }
    }
}
