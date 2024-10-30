using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRestart;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bird = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            this.SuspendLayout();

            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F);
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skor: 0";

            // 
            // bird
            // 
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(100, 200);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(60, 60);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 1;
            this.bird.TabStop = false;
            this.bird.Click += new System.EventHandler(this.bird_Click);

            // 
            // pipeTop
            // 
            this.pipeTop.BackColor = System.Drawing.Color.Green;
            this.pipeTop.Location = new System.Drawing.Point(400, 0);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(80, 200);
            this.pipeTop.TabIndex = 2;
            this.pipeTop.TabStop = false;

            // 
            // pipeBottom
            // 
            this.pipeBottom.BackColor = System.Drawing.Color.Green;
            this.pipeBottom.Location = new System.Drawing.Point(400, 525);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(80, 300);
            this.pipeBottom.TabIndex = 3;
            this.pipeBottom.TabStop = false;

            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Arial", 14F);
            this.btnStart.Location = new System.Drawing.Point(1209, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 50);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Arial", 14F);
            this.btnRestart.Location = new System.Drawing.Point(1345, 12);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(145, 50);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Restart";
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);

            // 
            // Form1
            // 
            this.BackgroundImage = Image.FromFile(@"C:\Users\emin_\source\repos\WindowsFormsApp10\WindowsFormsApp10\resim\flappybird-stap1.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1519, 652);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnRestart);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown); // Yön tuşlarını dinlemek için
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

    }
}
