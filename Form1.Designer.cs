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
            this.StartLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.StartLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StartLabel.Font = new System.Drawing.Font("Fruity microfont", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartLabel.Location = new System.Drawing.Point(189, 9);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(432, 47);
            this.StartLabel.TabIndex = 0;
            this.StartLabel.Text = "Workout Manager";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartLabel);
            this.Name = "Form1";
            this.Text = "Workout Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label StartLabel;
    }
}