using System;

class SpiralMatrix
{
    static void Main(string[] args)
    {
        // Kullanıcıdan NxN boyutlarını alıyoruz
        Console.WriteLine("NxN matrisin boyutunu giriniz: ");
        int n = int.Parse(Console.ReadLine());

        // NxN boyutlarında bir matris oluşturuyoruz
        int[,] matris = new int[n, n];

        // Spiral şekilde sayıları yerleştirmek için değişkenler tanımlıyoruz
        int num = 1; // Matrise yerleştirilecek sayılar
        int sol = 0, sag = n - 1, ust = 0, alt = n - 1;

        // Sayıları matrisin içine spiral şekilde yerleştireceğiz
        // Bu işlem, tüm yönler boyunca (sağa, aşağı, sola, yukarı) devam edecek
        while (sol <= sag && ust <= alt)
        {
            // İlk olarak üst satırı sola doğru dolduruyoruz
            for (int i = sol; i <= sag; i++)
            {
                matris[ust, i] = num++;  // Sayıları sırayla yerleştiriyoruz
            }
            ust++;  // Üst sınırı bir satır aşağı indiriyoruz

            // Sonra sağ sütunu yukarıdan aşağıya doğru dolduruyoruz
            for (int i = ust; i <= alt; i++)
            {
                matris[i, sag] = num++;
            }
            sag--;  // Sağ sınırı bir sütun sola kaydırıyoruz

            // Eğer hala sol <= sağ ve üst <= alt koşullarını sağlıyorsa, bu sefer alt satırı sağdan sola dolduruyoruz
            if (ust <= alt)
            {
                for (int i = sag; i >= sol; i--)
                {
                    matris[alt, i] = num++;
                }
                alt--;  // Alt sınırı bir satır yukarı kaldırıyoruz
            }

            // Sol sütunu aşağıdan yukarıya dolduruyoruz
            if (sol <= sag)
            {
                for (int i = alt; i >= ust; i--)
                {
                    matris[i, sol] = num++;
                }
                sol++;  // Sol sınırı bir sütun sağa kaydırıyoruz
            }
        }

        // Matrisin tamamı spiral şekilde dolduruldu, şimdi matrisi yazdırıyoruz
        Console.WriteLine("Spiral Matris:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matris[i, j] + "\t");  // Sayıları tablarla hizalı şekilde yazdırıyoruz
            }
            Console.WriteLine();  // Her satırdan sonra bir alt satıra geçiyoruz
        }
    }
}
