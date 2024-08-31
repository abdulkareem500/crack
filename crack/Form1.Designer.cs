namespace crack
{
    partial class crack
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
            b = new Button();
            pictureBox1 = new PictureBox();
            l = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // b
            // 
            b.Location = new Point(45, 434);
            b.Name = "b";
            b.Size = new Size(469, 45);
            b.TabIndex = 0;
            b.Text = "import - detect";
            b.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(45, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(469, 375);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // l
            // 
            l.BorderStyle = BorderStyle.FixedSingle;
            l.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            l.Location = new Point(45, 521);
            l.Name = "l";
            l.Size = new Size(469, 87);
            l.TabIndex = 2;
            l.Text = "............";
            l.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // crack
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 661);
            Controls.Add(l);
            Controls.Add(pictureBox1);
            Controls.Add(b);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "crack";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button b;
        private PictureBox pictureBox1;
        private Label l;
    }
}
