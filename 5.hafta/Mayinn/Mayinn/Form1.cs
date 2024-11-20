using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mayinn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void lbl_scor_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private Button[,] buttons; // 20x20 buton dizisi
        private int[,] grid; // 20x20 grid, mayın ve hücre değerlerini tutar
        private int remainingSafeCells; // Güvenli hücre sayısı


        private void CreateGrid()
        {
            int gridSize = 20; // Grid boyutu
            int buttonSize = 30; // Buton boyutu (30x30 piksel)

            buttons = new Button[gridSize, gridSize];
            grid = new int[gridSize, gridSize];
            panel1.Controls.Clear(); // Paneli temizle

            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    // Yeni bir buton oluştur
                    Button btn = new Button();
                    btn.Size = new Size(buttonSize, buttonSize);
                    btn.Location = new Point(j * buttonSize, i * buttonSize);
                    btn.Click += Button_Click; // Tıklama olayını bağla
                    btn.Tag = new Point(i, j); // Satır ve sütun bilgisi

                    // Panel'e ekle
                    panel1.Controls.Add(btn);

                    // Dizilere ekle
                    buttons[i, j] = btn;
                    grid[i, j] = 0; // Başlangıçta tüm hücreler boş
                }
            }
        }

        private void PlaceMines(int mineCount)
        {
            Random rand = new Random();
            int gridSize = 20;
            int placedMines = 0;

            while (placedMines < mineCount)
            {
                int x = rand.Next(0, gridSize);
                int y = rand.Next(0, gridSize);

                // Eğer bu hücrede mayın yoksa, yerleştir
                if (grid[x, y] != -1)
                {
                    grid[x, y] = -1; // -1 değeri mayını temsil eder
                    placedMines++;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            Point point = (Point)clickedButton.Tag;

            int x = point.X;
            int y = point.Y;

            if (grid[x, y] == -1)
            {
                // Mayına basıldı
                clickedButton.Text = "X";
                clickedButton.BackColor = Color.Red;
                MessageBox.Show("Mayına bastınız! Oyun bitti.");
                RestartGame();
            }
            else
            {
                // Mayın değil, çevredeki mayınları say
                int mineCount = CountSurroundingMines(x, y);
                clickedButton.Text = mineCount.ToString();
                clickedButton.Enabled = false; // Tıklanan buton tekrar tıklanamaz
                clickedButton.BackColor = Color.LightGray;

                remainingSafeCells--;
                lbl_scor.Text = $"SKOR : {remainingSafeCells}";

                if (remainingSafeCells == 0)
                {
                    MessageBox.Show("Tebrikler! Oyunu kazandınız.");
                    RestartGame();
                }
            }
        }

        private int CountSurroundingMines(int x, int y)
        {
            int count = 0;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int nx = x + i;
                    int ny = y + j;

                    // Hücre sınırlarını kontrol et
                    if (nx >= 0 && nx < 20 && ny >= 0 && ny < 20 && grid[nx, ny] == -1)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private void btn_start_restart_Click1(object sender, EventArgs e)
        {
            int mineCount = 40; // İstediğiniz mayın sayısını belirleyin
            remainingSafeCells = 400 - mineCount; // Güvenli hücre sayısı

            CreateGrid(); // Grid'i oluştur
            PlaceMines(mineCount); // Mayınları yerleştir
            lbl_scor.Text = $"SKOR : {remainingSafeCells}"; // Skoru güncelle

        }

        private void RestartGame()
        {
            btn_start_restart_Click1(null, null); // Oyunu yeniden başlat
        }


    }
}
