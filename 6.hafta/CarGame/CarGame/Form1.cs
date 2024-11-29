using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarGame
{
    public partial class Form1 : Form
    {
        private int arabaHiz = 10; // Arabanın hareket hızı
        private int engelHiz = 5; // Engellerin hareket hızı
        private bool solaHareket = false; // Sola hareket kontrolü
        private bool sagaHareket = false; // Sağa hareket kontrolü
        private int skor = 0;

        public Form1()
        {
            InitializeComponent();
            OyunBaslangicAyarla();
            this.KeyPreview = true; // Klavye olaylarını formda almak için
        }

        private void OyunBaslangicAyarla()
        {
            // Araba başlangıç pozisyonu
            pictureBox1.Top = this.ClientSize.Height - pictureBox1.Height - 10;
            pictureBox1.Left = (this.ClientSize.Width - pictureBox1.Width) / 2;

            // Engeller başlangıç pozisyonları
            engel_1.Top = -engel_1.Height;
            engel_1.Left = this.ClientSize.Width / 3;

            engel_2.Top = -engel_2.Height * 2;
            engel_2.Left = 2 * (this.ClientSize.Width / 3);

            // Skoru sıfırla
            skor = 0;
            lbl_Scor.Text = "Skor: " + skor;

            // Timer durdur
            timer1.Stop();
        }

        // Klavye tuşlarına basıldığında harekete geçme
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // A tuşuna basıldığında sola hareket
            if (e.KeyCode == Keys.A)
                solaHareket = true;

            // D tuşuna basıldığında sağa hareket
            if (e.KeyCode == Keys.D)
                sagaHareket = true;
        }

        // Klavye tuşlarından kaldırıldığında harekete son verme
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // A tuşu bırakıldığında sola hareketi durdur
            if (e.KeyCode == Keys.A)
                solaHareket = false;

            // D tuşu bırakıldığında sağa hareketi durdur
            if (e.KeyCode == Keys.D)
                sagaHareket = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Araba hareketi
            if (solaHareket && pictureBox1.Left > 0) // Sol hareket (A tuşu)
            {
                pictureBox1.Left -= arabaHiz; // Araba sola hareket eder
            }

            if (sagaHareket && pictureBox1.Right < this.ClientSize.Width) // Sağ hareket (D tuşu)
            {
                pictureBox1.Left += arabaHiz; // Araba sağa hareket eder
            }

            // Engellerin hareketi
            engel_1.Top += engelHiz;
            engel_2.Top += engelHiz;

            // Engeller yukarıdan aşağıya doğru tekrar belirmeli
            if (engel_1.Top > this.ClientSize.Height)
            {
                engel_1.Top = -engel_1.Height;
                engel_1.Left = new Random().Next(0, this.ClientSize.Width - engel_1.Width);
                skor++;
            }

            if (engel_2.Top > this.ClientSize.Height)
            {
                engel_2.Top = -engel_2.Height;
                engel_2.Left = new Random().Next(0, this.ClientSize.Width - engel_2.Width);
                skor++;
            }

            // Skoru güncelle
            lbl_Scor.Text = "Skor: " + skor;

            // Çarpışma kontrolü
            if (pictureBox1.Bounds.IntersectsWith(engel_1.Bounds) || pictureBox1.Bounds.IntersectsWith(engel_2.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Oyun Bitti! Skorunuz: " + skor);
                OyunBaslangicAyarla();
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            OyunBaslangicAyarla();
            timer1.Start(); // Zamanlayıcı başlat
        }
    }
}


