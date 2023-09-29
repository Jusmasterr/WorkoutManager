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
            this.button1 = new System.Windows.Forms.Button();
            this.StartLabel = new System.Windows.Forms.Label();
            this.BackgroundBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(31)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(169)))), ((int)(((byte)(183)))));
            this.button1.Location = new System.Drawing.Point(82, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(123)))), ((int)(((byte)(145)))));
            this.StartLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(31)))));
            this.StartLabel.Location = new System.Drawing.Point(236, 36);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(415, 60);
            this.StartLabel.TabIndex = 5;
            this.StartLabel.Text = "Create Schedule";
            // 
            // BackgroundBox
            // 
            this.BackgroundBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(123)))), ((int)(((byte)(145)))));
            this.BackgroundBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackgroundBox.Location = new System.Drawing.Point(34, 18);
            this.BackgroundBox.Name = "BackgroundBox";
            this.BackgroundBox.Size = new System.Drawing.Size(805, 91);
            this.BackgroundBox.TabIndex = 6;
            this.BackgroundBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(82)))), ((int)(((byte)(85)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(-82, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(969, 472);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox3
            // 
            this.richTextBox3.ForeColor = System.Drawing.Color.Silver;
            this.richTextBox3.Location = new System.Drawing.Point(586, 232);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(175, 32);
            this.richTextBox3.TabIndex = 11;
            this.richTextBox3.Text = "weight";
            this.richTextBox3.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // richTextBox4
            // 
            this.richTextBox4.ForeColor = System.Drawing.Color.Silver;
            this.richTextBox4.Location = new System.Drawing.Point(531, 268);
            this.richTextBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(175, 32);
            this.richTextBox4.TabIndex = 12;
            this.richTextBox4.Text = "repetitions";
            this.richTextBox4.TextChanged += new System.EventHandler(this.richTextBox4_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Benchpress",
            "Shoulderpress",
            "Legpress",
            "Legextension",
            "Lat-pulldown",
            "Bicep curls"});
            this.comboBox1.Location = new System.Drawing.Point(305, 245);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 28);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(31)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(169)))), ((int)(((byte)(183)))));
            this.button2.Location = new System.Drawing.Point(352, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 49);
            this.button2.TabIndex = 14;
            this.button2.Text = "create";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Workout day",
            "Rest day"});
            this.comboBox2.Location = new System.Drawing.Point(131, 133);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(109, 28);
            this.comboBox2.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(24, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(805, 41);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Monday";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 467);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.BackgroundBox);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label StartLabel;
        private PictureBox BackgroundBox;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private ComboBox comboBox1;
        private Button button2;
        private ComboBox comboBox2;
        private PictureBox pictureBox2;
        private Label label1;
    }
}