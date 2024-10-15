using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;

    class Program
    {
      

        static void Main()
        {
            string[] kelimeler = { "elma", "armut", "muz", "kiraz", "çilek" }; // Kelime havuzu
            Random rastgele = new Random();
            string gizliKelime = kelimeler[rastgele.Next(0, kelimeler.Length)];
            char[] tahminler = new char[gizliKelime.Length];
            for (int i = 0; i < tahminler.Length; i++) tahminler[i] = '_'; // Boşlukları çizgilerle doldur

            List<char> yanlisTahminler = new List<char>(); // Yanlış tahmin edilen harfler
            int yanlisHak = 6; // Yanlış tahmin hakkı

            while (yanlisHak > 0)
            {
                Console.Clear();
                Console.WriteLine("Adam Asmaca!");
                Console.WriteLine("Kelime: " + string.Join(" ", tahminler)); // Bulunan harfleri göster
                Console.WriteLine("Yanlış Tahminler: " + string.Join(", ", yanlisTahminler));
                Console.WriteLine($"Kalan Hak: {yanlisHak}");

                // Adam görselini çizen metod
                Cizim(6 - yanlisHak);

                char tahmin = '\0'; // Tahmin değişkenine başlangıç değeri ver
                bool gecerliGiris = false;

                // Kullanıcıdan geçerli bir giriş alana kadar döngü
                do
                {
                    Console.Write("Bir harf tahmin edin: ");
                    string input = Console.ReadLine()?.ToLower(); // Kullanıcıdan giriş al

                    // Boş veya geçersiz giriş kontrolü
                    if (!string.IsNullOrEmpty(input) && input.Length == 1)
                    {
                        tahmin = input[0];
                        gecerliGiris = true; // Geçerli bir harf girildi
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz giriş! Lütfen tek bir harf girin.");
                    }

                } while (!gecerliGiris); // Geçerli bir giriş olana kadar devam et

                if (gizliKelime.Contains(tahmin))
                {
                    for (int i = 0; i < gizliKelime.Length; i++)
                    {
                        if (gizliKelime[i] == tahmin)
                        {
                            tahminler[i] = tahmin; // Doğru tahmin edilen harfi yerine koy
                        }
                    }

                    // Kazanma durumu
                    if (!string.Join("", tahminler).Contains('_'))
                    {
                        Console.WriteLine("Tebrikler, kazandınız! Kelime: " + gizliKelime);
                        break;
                    }
                }
                else
                {
                    if (!yanlisTahminler.Contains(tahmin))
                    {
                        yanlisTahminler.Add(tahmin); // Yanlış tahmin edilen harfi listeye ekle
                        yanlisHak--; // Yanlış tahmin hakkını düşür
                    }
                }

                if (yanlisHak == 0)
                {
                    Console.WriteLine("Maalesef, kaybettiniz! Kelime: " + gizliKelime);
                    Cizim(6); // Tam adamı çiz
                }
            }

            Console.WriteLine("Oyunu bitirmek için bir tuşa basın...");
            Console.ReadKey(); // Ekranın hemen kapanmaması için
        }

        // Adamı çizen metod (6 adımda tamamlanır)
        static void Cizim(int adim)
        {
            switch (adim)
            {
                case 0:
                    Console.WriteLine("   +---+");
                    Console.WriteLine("   |   |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine(" =========");
                    break;
                case 1:
                    Console.WriteLine("   +---+");
                    Console.WriteLine("   |   |");
                    Console.WriteLine("   O   |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine(" =========");
                    break;
                case 2:
                    Console.WriteLine("   +---+");
                    Console.WriteLine("   |   |");
                    Console.WriteLine("   O   |");
                    Console.WriteLine("   |   |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine(" =========");
                    break;
                case 3:
                    Console.WriteLine("   +---+");
                    Console.WriteLine("   |   |");
                    Console.WriteLine("   O   |");
                    Console.WriteLine("  /|   |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine(" =========");
                    break;
                case 4:
                    Console.WriteLine("   +---+");
                    Console.WriteLine("   |   |");
                    Console.WriteLine("   O   |");
                    Console.WriteLine("  /|\\  |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine(" =========");
                    break;
                case 5:
                    Console.WriteLine("   +---+");
                    Console.WriteLine("   |   |");
                    Console.WriteLine("   O   |");
                    Console.WriteLine("  /|\\  |");
                    Console.WriteLine("  /    |");
                    Console.WriteLine("       |");
                    Console.WriteLine(" =========");
                    break;
                case 6:
                    Console.WriteLine("   +---+");
                    Console.WriteLine("   |   |");
                    Console.WriteLine("   O   |");
                    Console.WriteLine("  /|\\  |");
                    Console.WriteLine("  / \\  |");
                    Console.WriteLine("       |");
                    Console.WriteLine(" =========");
                    break;
            }
        }
    }


}

