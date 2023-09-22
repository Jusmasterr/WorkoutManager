namespace WorkoutManager
{
    partial class Form2
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
            button1 = new Button();
            StartLabel = new Label();
            BackgroundBox = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BackgroundBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            button1.TabIndex = 7;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            StartLabel.Size = new Size(521, 71);
            StartLabel.TabIndex = 5;
            StartLabel.Text = "Workout Manager";
            // 
            // BackgroundBox
            // 
            BackgroundBox.BackColor = Color.FromArgb(206, 123, 145);
            BackgroundBox.BorderStyle = BorderStyle.FixedSingle;
            BackgroundBox.Location = new Point(-103, 47);
            BackgroundBox.Margin = new Padding(4);
            BackgroundBox.Name = "BackgroundBox";
            BackgroundBox.Size = new Size(1006, 113);
            BackgroundBox.TabIndex = 6;
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
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(StartLabel);
            Controls.Add(BackgroundBox);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)BackgroundBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label StartLabel;
        private PictureBox BackgroundBox;
        private PictureBox pictureBox1;
    }
}