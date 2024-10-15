using System;

class MatrixMultiplication
{
    static void Main(string[] args)
    {
        // Kullanıcıdan NxN matrisin boyutunu alıyoruz
        Console.WriteLine("NxN matrisin boyutunu giriniz: ");
        int n = int.Parse(Console.ReadLine());

        // İlk matrisi alıyoruz
        int[,] matris1 = new int[n, n];
        Console.WriteLine("Birinci matrisi giriniz: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"matris1[{i},{j}] = ");
                matris1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // İkinci matrisi alıyoruz
        int[,] matris2 = new int[n, n];
        Console.WriteLine("İkinci matrisi giriniz: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"matris2[{i},{j}] = ");
                matris2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Çarpım sonucunu tutacak matris
        int[,] sonuc = new int[n, n];

        // İki matrisin çarpımı: her hücre için ilgili satır ve sütun elemanlarını çarpar ve toplarız
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    sonuc[i, j] += matris1[i, k] * matris2[k, j];
                }
            }
        }

        // Sonuç matrisini yazdırıyoruz
        Console.WriteLine("Matrislerin çarpımının sonucu:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(sonuc[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
