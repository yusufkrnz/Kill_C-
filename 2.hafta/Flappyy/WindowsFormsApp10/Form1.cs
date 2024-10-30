using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        private double gravity = 0.5; // Kuşun düşme hızı
        private int lift = 8; // Zıplama kuvveti
        private double velocity = 0; // Kuşun mevcut hızı
        private int pipeSpeed = 10; // Boruların hareket hızı
        private int pipeFrequency = 20; // Boruların eklenme sıklığı (ms)
        private int score = 0; // Skor
        private Random random = new Random(); // Rastgele sayılar için
        private Timer pipeTimer; // Borular için yeni bir timer

        public Form1()
        {
            InitializeComponent();
            InitializePipeTimer(); // Borular için timer'ı başlat
        }

        private void InitializePipeTimer()
        {
            pipeTimer = new Timer();
            pipeTimer.Interval = pipeFrequency; // Boruların eklenme sıklığı
            pipeTimer.Tick += new EventHandler(GeneratePipes); // Timer tick olayına bağla
            pipeTimer.Start(); // Timer'ı başlat
        }

        private void GeneratePipes(object sender, EventArgs e)
        {
            ResetPipes(); // Boruları sıfırla
        }

        private void MoveBirdUp()
        {
            velocity = -lift; // Kuşu yukarı doğru hareket ettir
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up)
            {
                MoveBirdUp();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"C:\Users\emin_\source\repos\WindowsFormsApp10\WindowsFormsApp10\resim\flappybird-stap1.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            ResetGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            velocity += gravity; // Yer çekimi etkisini hız üzerine ekle
            bird.Top += (int)velocity; // Kuşun yukarı hareket etmesini sağla

            // Boruların sola hareket etmesi
            pipeTop.Left -= pipeSpeed;
            pipeBottom.Left -= pipeSpeed;

            // Eğer borular ekranın solundan çıkarsa, yeniden konumlandır ve skor artır
            if (pipeTop.Right < 0)
            {
                score++;
                label1.Text = "Skor: " + score;
                ResetPipes(); // Boruları yeniden konumlandır
            }

            // Çarpışma kontrolü
            if (bird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                bird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                bird.Top < 0 || bird.Bottom > this.ClientSize.Height)
            {
                EndGame();
            }
        }

        private void EndGame()
        {
            timer1.Stop();
            pipeTimer.Stop(); // Boru timer'ı durdur
            btnRestart.Visible = true;
            MessageBox.Show("Oyun Bitti! Skor: " + score);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();  // Oyunu başlat
            btnStart.Visible = false;  // Start butonunu gizle
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetGame();  // Oyunu sıfırla
        }

        private void ResetGame()
        {
            bird.Location = new Point(100, 200);  // Kuşun başlangıç pozisyonu
            score = 0;  // Skor sıfırlanır
            label1.Text = "Skor: 0";  // Skor etiketini güncelle
            btnRestart.Visible = false;  // Restart butonunu gizle
            timer1.Start();  // Timer'ı başlat
            ResetPipes();  // Boruları sıfırla
        }

        private void ResetPipes()
        {
            // Rastgele yüksekliği ayarlama
            int pipeHeight = random.Next(100, 300);
            pipeTop.Location = new Point(this.ClientSize.Width, 0);  // Üst borunun sol konumu
            pipeTop.Size = new Size(80, pipeHeight);  // Üst borunun boyu

            pipeBottom.Location = new Point(this.ClientSize.Width, pipeHeight + 150);  // Alt borunun konumu
            pipeBottom.Size = new Size(80, this.ClientSize.Height - pipeHeight - 150);  // Alt borunun boyu
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Space || keyData == Keys.Up)
            {
                MoveBirdUp();
                return true;
            }
            else if (keyData == Keys.Down)
            {
                if (bird.Top < this.ClientSize.Height - bird.Height)
                {
                    bird.Top += 10;  // Kuşu aşağı hareket ettir
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void bird_Click(object sender, EventArgs e)
        {
            // Bu metot boş bırakılabilir
        }
    }
}
