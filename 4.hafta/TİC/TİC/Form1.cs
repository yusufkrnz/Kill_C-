using System;
using System.Windows.Forms;

namespace TİC
{
    public partial class Form1 : Form
    {
        private bool oyuncuSirasi = true; // true -> X, false -> O
        private int turSayisi = 0; // Tur sayısı, beraberlik kontrolü için

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Başlangıçta oyun butonlarını devre dışı bırak
            OyunButonlariniAktifEt(false);
        }

        private void lbl_skor_Click(object sender, EventArgs e)
        {
            // Skor etiketi tıklama olayına özel bir işlem yok
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            // Oyunu başlat
            OyunButonlariniAktifEt(true);
            btn_start.Enabled = false; // Başla butonunu devre dışı bırak
            turSayisi = 0;
            oyuncuSirasi = true; // İlk oyuncu X başlar
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            // Oyunu sıfırla
            OyunuSifirla();
        }

        // Tüm butonlar için ortak tıklama olayı
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Oyuncu sırasına göre X veya O ekleyin
            if (oyuncuSirasi)
                button.Text = "X";
            else
                button.Text = "O";

            button.Enabled = false; // Tıklanan butonu devre dışı bırak
            oyuncuSirasi = !oyuncuSirasi; // Oyuncu sırasını değiştir
            turSayisi++; // Tur sayısını artır

            KazananKontrolu(); // Kazananı kontrol et
        }

        private void KazananKontrolu()
        {
            bool kazananVarMi = false;

            // Satırları kontrol et
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (!button1.Enabled))
                kazananVarMi = true;
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (!button4.Enabled))
                kazananVarMi = true;
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (!button7.Enabled))
                kazananVarMi = true;

            // Sütunları kontrol et
            else if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (!button1.Enabled))
                kazananVarMi = true;
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (!button2.Enabled))
                kazananVarMi = true;
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (!button3.Enabled))
                kazananVarMi = true;

            // Çaprazları kontrol et
            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (!button1.Enabled))
                kazananVarMi = true;
            else if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (!button3.Enabled))
                kazananVarMi = true;

            if (kazananVarMi)
            {
                OyunButonlariniPasifEt();

                string kazanan = oyuncuSirasi ? "O" : "X";
                MessageBox.Show($"{kazanan} Kazandı!");
            }
            else if (turSayisi == 9)
            {
                MessageBox.Show("Berabere!");
            }
        }

        private void OyunButonlariniPasifEt()
        {
            foreach (Control kontrol in Controls)
            {
                if (kontrol is Button button && button != btn_restart && button != btn_start)
                {
                    button.Enabled = false;
                }
            }
        }

        private void OyunButonlariniAktifEt(bool aktifEt)
        {
            foreach (Control kontrol in Controls)
            {
                if (kontrol is Button button && button != btn_restart && button != btn_start)
                {
                    button.Enabled = aktifEt;
                    if (!aktifEt)
                        button.Text = ""; // Pasif hale getirirken buton metinlerini temizle
                }
            }
        }

        private void OyunuSifirla()
        {
            // Butonları temizle ve tekrar etkinleştir
            OyunButonlariniAktifEt(true);
            turSayisi = 0;
            oyuncuSirasi = true;
            btn_start.Enabled = true; // Başla butonunu tekrar etkinleştir
                                      // Tüm oyun butonlarının metinlerini temizle
            foreach (Control kontrol in Controls)
            {
                if (kontrol is Button button && button != btn_restart && button != btn_start)
                {
                    button.Text = ""; // X ve O'ları temizler
                }
            }
        }

        // Buton tıklama olaylarını tanımla
        private void button1_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button2_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button3_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button4_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button5_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button6_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button7_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button8_Click(object sender, EventArgs e) => button_Click(sender, e);
        private void button9_Click(object sender, EventArgs e) => button_Click(sender, e);
    }
}