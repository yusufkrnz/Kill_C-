
using System;

class Program
{
    // Enerji maliyet matrisi
    static int[,] energyCost;
    static int N;

    static void Main(string[] args)
    {
        // Örnek enerji maliyet matrisi
        energyCost = new int[,]
        {
            { 1, 3, 1, 5 },
            { 2, 1, 4, 2 },
            { 3, 4, 1, 1 },
            { 2, 2, 1, 0 }
        };

        N = energyCost.GetLength(0); // NxN boyutunu al
        int minEnergy = FindMinEnergyPath();
        Console.WriteLine($"En az enerji harcaması: {minEnergy}");
    }

    static int FindMinEnergyPath()
    {
        int[,] dp = new int[N, N];

        // Başlangıç hücresinin enerji maliyetini ayarla
        dp[0, 0] = energyCost[0, 0];

        // İlk satırı doldur
        for (int j = 1; j < N; j++)
        {
            dp[0, j] = dp[0, j - 1] + energyCost[0, j];
        }

        // İlk sütunu doldur
        for (int i = 1; i < N; i++)
        {
            dp[i, 0] = dp[i - 1, 0] + energyCost[i, 0];
        }

        // Dinamik programlama ile geri kalan hücreleri doldur
        for (int i = 1; i < N; i++)
        {
            for (int j = 1; j < N; j++)
            {
                dp[i, j] = Math.Min(dp[i - 1, j], Math.Min(dp[i, j - 1], dp[i - 1, j - 1])) + energyCost[i, j];
            }
        }

        // (N-1, N-1) noktasındaki en az enerji maliyetini döndür
        return dp[N - 1, N - 1];
    }
}
