namespace WorkoutManager
{
    partial class UserControl2
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            BackgroundBox = new PictureBox();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            richTextBox4 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            label1 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)BackgroundBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // BackgroundBox
            // 
            BackgroundBox.BackColor = Color.FromArgb(206, 123, 145);
            BackgroundBox.BorderStyle = BorderStyle.FixedSingle;
            BackgroundBox.Location = new Point(29, 20);
            BackgroundBox.Margin = new Padding(4);
            BackgroundBox.Name = "BackgroundBox";
            BackgroundBox.Size = new Size(299, 57);
            BackgroundBox.TabIndex = 7;
            BackgroundBox.TabStop = false;
            BackgroundBox.Click += BackgroundBox_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(99, 82, 85);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(4, 5);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(349, 473);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Benchpress", "Shoulderpress", "Legpress", "Legextension", "Lat-pulldown", "Bicep curls" });
            comboBox1.Location = new Point(69, 182);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(218, 33);
            comboBox1.TabIndex = 16;
            // 
            // richTextBox4
            // 
            richTextBox4.ForeColor = Color.Silver;
            richTextBox4.Location = new Point(69, 262);
            richTextBox4.Margin = new Padding(2);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(218, 39);
            richTextBox4.TabIndex = 15;
            richTextBox4.Text = "repetitions";
            // 
            // richTextBox3
            // 
            richTextBox3.ForeColor = Color.Silver;
            richTextBox3.Location = new Point(69, 219);
            richTextBox3.Margin = new Padding(2);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(218, 39);
            richTextBox3.TabIndex = 14;
            richTextBox3.Text = "weight";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 145);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 18;
            label1.Text = "Machine";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(26, 40, 31);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(223, 169, 183);
            button3.Location = new Point(115, 307);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(126, 51);
            button3.TabIndex = 19;
            button3.Text = "Submit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(richTextBox4);
            Controls.Add(richTextBox3);
            Controls.Add(BackgroundBox);
            Controls.Add(pictureBox1);
            Name = "UserControl2";
            Size = new Size(357, 482);
            Load += UserControl2_Load;
            ((System.ComponentModel.ISupportInitialize)BackgroundBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private PictureBox BackgroundBox;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox3;
        private Label label1;
        private Button button3;
    }
}
