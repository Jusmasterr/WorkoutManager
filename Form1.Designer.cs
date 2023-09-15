namespace WorkoutManager
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
            components = new System.ComponentModel.Container();
            Ala = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Ala
            // 
            Ala.Location = new Point(478, 156);
            Ala.Margin = new Padding(4);
            Ala.Name = "Ala";
            Ala.Size = new Size(118, 36);
            Ala.TabIndex = 0;
            Ala.Text = "Elias";
            Ala.UseVisualStyleBackColor = true;
            Ala.Click += Ala_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(484, 355);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 1;
            label1.Text = "Elias isch ge";
            label1.Visible = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(label1);
            Controls.Add(Ala);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Ala;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}