namespace WorkoutManager
{
    partial class Form3
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
            button2 = new Button();
            richTextBox4 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            button1 = new Button();
            StartLabel = new Label();
            BackgroundBox = new PictureBox();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)BackgroundBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(26, 40, 31);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(223, 169, 183);
            button2.Location = new Point(309, 365);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(218, 46);
            button2.TabIndex = 23;
            button2.Text = "open schedule";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // richTextBox4
            // 
            richTextBox4.ForeColor = Color.Silver;
            richTextBox4.Location = new Point(309, 302);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(218, 39);
            richTextBox4.TabIndex = 21;
            richTextBox4.Text = "";
            richTextBox4.TextChanged += richTextBox4_TextChanged;
            // 
            // richTextBox3
            // 
            richTextBox3.ForeColor = Color.Silver;
            richTextBox3.Location = new Point(309, 257);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(218, 39);
            richTextBox3.TabIndex = 20;
            richTextBox3.Text = "";
            richTextBox3.TextChanged += richTextBox3_TextChanged;
            // 
            // richTextBox2
            // 
            richTextBox2.ForeColor = Color.Silver;
            richTextBox2.Location = new Point(309, 212);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(218, 39);
            richTextBox2.TabIndex = 19;
            richTextBox2.Text = "";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(26, 40, 31);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(223, 169, 183);
            button1.Location = new Point(13, 61);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(90, 46);
            button1.TabIndex = 17;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = false;
            // 
            // StartLabel
            // 
            StartLabel.AutoSize = true;
            StartLabel.BackColor = Color.FromArgb(206, 123, 145);
            StartLabel.BorderStyle = BorderStyle.FixedSingle;
            StartLabel.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            StartLabel.ForeColor = Color.FromArgb(26, 40, 31);
            StartLabel.Location = new Point(142, 61);
            StartLabel.Margin = new Padding(4, 0, 4, 0);
            StartLabel.Name = "StartLabel";
            StartLabel.Size = new Size(458, 71);
            StartLabel.TabIndex = 15;
            StartLabel.Text = "Show Schedule";
            StartLabel.Click += StartLabel_Click_1;
            // 
            // BackgroundBox
            // 
            BackgroundBox.BackColor = Color.FromArgb(206, 123, 145);
            BackgroundBox.BorderStyle = BorderStyle.FixedSingle;
            BackgroundBox.Location = new Point(-103, 47);
            BackgroundBox.Margin = new Padding(4);
            BackgroundBox.Name = "BackgroundBox";
            BackgroundBox.Size = new Size(1006, 113);
            BackgroundBox.TabIndex = 16;
            BackgroundBox.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(99, 82, 85);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(-103, 11);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1006, 428);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.ForeColor = Color.Silver;
            richTextBox1.Location = new Point(309, 167);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(218, 39);
            richTextBox1.TabIndex = 24;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(richTextBox4);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(button1);
            Controls.Add(StartLabel);
            Controls.Add(BackgroundBox);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)BackgroundBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox2;
        private Button button1;
        private Label StartLabel;
        private PictureBox BackgroundBox;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
    }
}