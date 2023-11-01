namespace WorkoutManager
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BackgroundBox = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            listBox5 = new ListBox();
            listBox6 = new ListBox();
            listBox7 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)BackgroundBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BackgroundBox
            // 
            BackgroundBox.BackColor = Color.FromArgb(206, 123, 145);
            BackgroundBox.BorderStyle = BorderStyle.FixedSingle;
            BackgroundBox.Location = new Point(84, 5);
            BackgroundBox.Margin = new Padding(8);
            BackgroundBox.Name = "BackgroundBox";
            BackgroundBox.Size = new Size(2082, 215);
            BackgroundBox.TabIndex = 17;
            BackgroundBox.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(99, 82, 85);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(-178, -102);
            pictureBox1.Margin = new Padding(8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(2567, 1324);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(206, 123, 145);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(584, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(928, 143);
            textBox1.TabIndex = 20;
            textBox1.Text = "Choose Session";
            // 
            // button1
            // 
            button1.Location = new Point(125, 48);
            button1.Name = "button1";
            button1.Size = new Size(225, 69);
            button1.TabIndex = 21;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 48;
            listBox1.Location = new Point(168, 278);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(365, 100);
            listBox1.TabIndex = 22;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 48;
            listBox2.Location = new Point(168, 411);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(365, 100);
            listBox2.TabIndex = 23;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 48;
            listBox3.Location = new Point(168, 533);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(365, 100);
            listBox3.TabIndex = 24;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 48;
            listBox4.Location = new Point(168, 679);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(365, 100);
            listBox4.TabIndex = 25;
            listBox4.SelectedIndexChanged += listBox4_SelectedIndexChanged;
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 48;
            listBox5.Location = new Point(718, 278);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(365, 100);
            listBox5.TabIndex = 26;
            listBox5.SelectedIndexChanged += listBox5_SelectedIndexChanged;
            // 
            // listBox6
            // 
            listBox6.FormattingEnabled = true;
            listBox6.ItemHeight = 48;
            listBox6.Location = new Point(718, 411);
            listBox6.Name = "listBox6";
            listBox6.Size = new Size(365, 100);
            listBox6.TabIndex = 27;
            listBox6.SelectedIndexChanged += listBox6_SelectedIndexChanged;
            // 
            // listBox7
            // 
            listBox7.FormattingEnabled = true;
            listBox7.ItemHeight = 48;
            listBox7.Location = new Point(718, 549);
            listBox7.Name = "listBox7";
            listBox7.Size = new Size(365, 100);
            listBox7.TabIndex = 28;
            listBox7.SelectedIndexChanged += listBox7_SelectedIndexChanged;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2210, 1121);
            Controls.Add(listBox7);
            Controls.Add(listBox6);
            Controls.Add(listBox5);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(BackgroundBox);
            Controls.Add(pictureBox1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)BackgroundBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox BackgroundBox;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button button1;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private ListBox listBox5;
        private ListBox listBox6;
        private ListBox listBox7;
    }
}