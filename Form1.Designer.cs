﻿namespace WorkoutManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            StartLabel = new Label();
            BackgroundBox = new PictureBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BackgroundBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // StartLabel
            // 
            StartLabel.AutoSize = true;
            StartLabel.BackColor = Color.FromArgb(206, 123, 145);
            StartLabel.BorderStyle = BorderStyle.FixedSingle;
            StartLabel.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            StartLabel.ForeColor = Color.FromArgb(26, 40, 31);
            StartLabel.Location = new Point(239, 120);
            StartLabel.Margin = new Padding(4, 0, 4, 0);
            StartLabel.Name = "StartLabel";
            StartLabel.Size = new Size(521, 71);
            StartLabel.TabIndex = 0;
            StartLabel.Text = "Workout Manager";
            StartLabel.Click += StartLabel_Click;
            // 
            // BackgroundBox
            // 
            BackgroundBox.BackColor = Color.FromArgb(206, 123, 145);
            BackgroundBox.BorderStyle = BorderStyle.FixedSingle;
            BackgroundBox.Location = new Point(-6, 106);
            BackgroundBox.Margin = new Padding(4);
            BackgroundBox.Name = "BackgroundBox";
            BackgroundBox.Size = new Size(1006, 113);
            BackgroundBox.TabIndex = 1;
            BackgroundBox.TabStop = false;
            BackgroundBox.Click += BackgroundBox_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(26, 40, 31);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(223, 169, 183);
            button1.Location = new Point(348, 285);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(280, 48);
            button1.TabIndex = 3;
            button1.Text = "Create schedule";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(99, 82, 85);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(-6, 70);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1006, 428);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 54, 63);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1000, 562);
            Controls.Add(button1);
            Controls.Add(StartLabel);
            Controls.Add(BackgroundBox);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            Text = "Workout Manager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)BackgroundBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StartLabel;
        private PictureBox BackgroundBox;
        private Button button1;
        private PictureBox pictureBox1;
    }
}