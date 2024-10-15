using System;
using System.Collections.Generic;

class MazeSolver
{
    // Hareket yönleri: yukarı, aşağı, sol ve sağ
    static int[] rowDirections = { -1, 1, 0, 0 };
    static int[] colDirections = { 0, 0, -1, 1 };

    // BFS algoritması ile en kısa yolu bulan fonksiyon
    static int ShortestPath(int[,] maze)
    {
        int n = maze.GetLength(0);  // Labirentin boyutunu alıyoruz (N x N)

        // Eğer başlangıç ya da bitiş noktası 0 ise, yol yoktur
        if (maze[0, 0] == 0 || maze[n - 1, n - 1] == 0)
            return -1;

        // Ziyaret edilen hücreleri takip etmek için visited matrisi
        bool[,] visited = new bool[n, n];

        // BFS kuyruk yapısı: her eleman (satır, sütun, adım sayısı) içerir
        Queue<(int, int, int)> queue = new Queue<(int, int, int)>();

        // Başlangıç hücresinden başlıyoruz
        queue.Enqueue((0, 0, 1));  // (0, 0) hücresinde başlıyoruz, adım sayısı 1
        visited[0, 0] = true;

        // Kuyruğu boşalana kadar işlem yap
        while (queue.Count > 0)
        {
            // Kuyruktan bir hücre al
            var (row, col, steps) = queue.Dequeue();

            // Eğer hazine noktasına ulaştıysak, adım sayısını döndür
            if (row == n - 1 && col == n - 1)
                return steps;

            // 4 farklı yöne (yukarı, aşağı, sol, sağ) hareket et
            for (int i = 0; i < 4; i++)
            {
                int newRow = row + rowDirections[i];
                int newCol = col + colDirections[i];

                // Eğer yeni pozisyon grid sınırları içindeyse ve geçilebilir bir hücreyse
                if (newRow >= 0 && newRow < n && newCol >= 0 && newCol < n &&
                    maze[newRow, newCol] == 1 && !visited[newRow, newCol])
                {
                    // Yeni hücreyi kuyrukta işlenmek üzere ekle ve ziyaret edildi olarak işaretle
                    queue.Enqueue((newRow, newCol, steps + 1));
                    visited[newRow, newCol] = true;
                }
            }
        }

        // Eğer kuyruk boşaldıysa ve hazineye ulaşamadıysak, yol yoktur
        return -1;
    }

    static void Main(string[] args)
    {
        // Örnek labirent
        int[,] maze = {
            { 1, 1, 0, 1 },
            { 0, 1, 0, 0 },
            { 1, 1, 1, 0 },
            { 0, 0, 1, 1 }
        };

        // Fonksiyonu çağır ve sonucu ekrana yazdır
        int result = ShortestPath(maze);
        if (result != -1)
            Console.WriteLine($"Hazineye ulaşmak için en kısa yol: {result} adım.");
        else
            Console.WriteLine("Hazineye ulaşmak mümkün değil.");
    }
}
