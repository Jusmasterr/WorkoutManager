namespace WorkoutManager
{
    partial class ScheduleCreatedPopUp
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
            label1 = new Label();
            BackgroundBox = new PictureBox();
            BackMenuBTN = new Button();
            ViewSchedBTN = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BackgroundBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(66, 44);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(844, 50);
            label1.TabIndex = 0;
            label1.Text = "Your workout schedule has succesfully been created";
//            label1.Click += label1_Click;
            // 
            // BackgroundBox
            // 
            BackgroundBox.BackColor = Color.FromArgb(206, 123, 145);
            BackgroundBox.BorderStyle = BorderStyle.FixedSingle;
            BackgroundBox.Location = new Point(26, 19);
            BackgroundBox.Margin = new Padding(8);
            BackgroundBox.Name = "BackgroundBox";
            BackgroundBox.Size = new Size(916, 98);
            BackgroundBox.TabIndex = 7;
            BackgroundBox.TabStop = false;
            // 
            // BackMenuBTN
            // 
            BackMenuBTN.BackColor = Color.FromArgb(26, 40, 31);
            BackMenuBTN.FlatStyle = FlatStyle.Flat;
            BackMenuBTN.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BackMenuBTN.ForeColor = Color.FromArgb(223, 169, 183);
            BackMenuBTN.Location = new Point(46, 169);
            BackMenuBTN.Margin = new Padding(8);
            BackMenuBTN.Name = "BackMenuBTN";
            BackMenuBTN.Size = new Size(332, 63);
            BackMenuBTN.TabIndex = 40;
            BackMenuBTN.Text = "Back to menu";
            BackMenuBTN.UseVisualStyleBackColor = false;
            BackMenuBTN.Click += BackMenuBTN_Click;
            // 
            // ViewSchedBTN
            // 
            ViewSchedBTN.BackColor = Color.FromArgb(26, 40, 31);
            ViewSchedBTN.FlatStyle = FlatStyle.Flat;
            ViewSchedBTN.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ViewSchedBTN.ForeColor = Color.FromArgb(223, 169, 183);
            ViewSchedBTN.Location = new Point(578, 169);
            ViewSchedBTN.Margin = new Padding(8);
            ViewSchedBTN.Name = "ViewSchedBTN";
            ViewSchedBTN.Size = new Size(332, 63);
            ViewSchedBTN.TabIndex = 41;
            ViewSchedBTN.Text = "view schedule";
            ViewSchedBTN.UseVisualStyleBackColor = false;
            ViewSchedBTN.Click += ViewSchedBTN_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(99, 82, 85);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 8);
            pictureBox1.Margin = new Padding(8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(948, 271);
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
           // pictureBox1.Click += pictureBox1_Click;
            // 
            // ScheduleCreatedPopUp
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ViewSchedBTN);
            Controls.Add(BackMenuBTN);
            Controls.Add(label1);
            Controls.Add(BackgroundBox);
            Controls.Add(pictureBox1);
            Margin = new Padding(6);
            Name = "ScheduleCreatedPopUp";
            Size = new Size(970, 288);
            ((System.ComponentModel.ISupportInitialize)BackgroundBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox BackgroundBox;
        private Button BackMenuBTN;
        private Button ViewSchedBTN;
        private PictureBox pictureBox1;
    }
}
