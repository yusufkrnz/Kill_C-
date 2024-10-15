using System;
using System.Collections.Generic;

class TechCityRescue
{
    // Hareket yönleri için yukarı, aşağı, sol ve sağ yönlerini tanımlıyoruz
    static int[] rowDirections = { -1, 1, 0, 0 };
    static int[] colDirections = { 0, 0, -1, 1 };

    // DFS algoritması ile komşu düğümleri dolaşan fonksiyon
    static int DFS(int[,] grid, bool[,] visited, int row, int col, int n)
    {
        // Grid sınırlarını aşmamak için kontrol
        if (row < 0 || row >= n || col < 0 || col >= n)
            return 0;

        // Eğer bu düğüm zaten ziyaret edildiyse veya kurtarılamaz bir düğümse (0 ise) geri dön
        if (visited[row, col] || grid[row, col] == 0)
            return 0;

        // Bu düğümü ziyaret ettik
        visited[row, col] = true;

        // Şu anki düğümü kurtardığımız için sayacı 1 olarak başlatıyoruz
        int count = 1;

        // Yukarı, aşağı, sol ve sağ yönlerdeki tüm komşuları ziyaret et
        for (int i = 0; i < 4; i++)
        {
            int newRow = row + rowDirections[i];
            int newCol = col + colDirections[i];

            // DFS ile komşu düğümleri kontrol et
            count += DFS(grid, visited, newRow, newCol, n);
        }

        return count;  // Bulduğumuz toplam kurtarılabilecek düğüm sayısını döndür
    }

    // Tüm robotlar için grid üzerindeki düğümleri kurtaran fonksiyon
    static int MaxNodesRescued(int[,] grid, List<(int, int)> startingPoints)
    {
        int n = grid.GetLength(0);  // Grid'in boyutunu alıyoruz (N x N)

        // Ziyaret edilen düğümleri takip etmek için bir visited matrisi
        bool[,] visited = new bool[n, n];

        // Kurtarılan düğüm sayısını tutacak değişken
        int totalRescued = 0;

        // Her robot için başlangıç noktasından başlayarak DFS ile düğümleri ziyaret et
        foreach (var point in startingPoints)
        {
            int row = point.Item1;
            int col = point.Item2;

            // Robotun başlangıç pozisyonundan DFS başlat ve kurtardığı düğümleri topla
            totalRescued += DFS(grid, visited, row, col, n);
        }

        return totalRescued;  // Toplam kurtarılan düğüm sayısını döndür
    }

    static void Main(string[] args)
    {
        // Örnek grid (1'ler kurtarılabilir düğümleri, 0'lar kurtarılamayan düğümleri temsil eder)
        int[,] grid = {
            { 1, 1, 0, 1 },
            { 0, 1, 0, 0 },
            { 1, 1, 1, 0 },
            { 0, 0, 1, 1 }
        };

        // Robotların başlangıç noktalarını liste olarak tanımlıyoruz
        List<(int, int)> startingPoints = new List<(int, int)> {
            (0, 0),  // Robot 1'in başlangıç pozisyonu
            (2, 2),  // Robot 2'nin başlangıç pozisyonu
            (3, 3)   // Robot 3'ün başlangıç pozisyonu
        };

        // Fonksiyonu çağır ve sonucu ekrana yazdır
        int result = MaxNodesRescued(grid, startingPoints);
        Console.WriteLine($"Toplam kurtarılan düğüm sayısı: {result}");
    }
}
