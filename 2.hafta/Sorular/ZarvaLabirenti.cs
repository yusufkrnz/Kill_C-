//ZarvaLabirenti
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int M = 5; // Labirentin satır sayısı
        int N = 5; // Labirentin sütun sayısı
        List<(int, int)> path = new List<(int, int)>();
        
        if (FindPath(0, 0, M, N, path))
        {
            Console.WriteLine("Şehir bulundu! Yolun adımları:");
            foreach (var step in path)
            {
                Console.WriteLine($"({step.Item1}, {step.Item2})");
            }
        }
        else
        {
            Console.WriteLine("Şehir kayboldu!");
        }
    }

    static bool FindPath(int x, int y, int M, int N, List<(int, int)> path)
    {
        // Hedef nokta
        if (x == M - 1 && y == N - 1)
        {
            path.Add((x, y));
            return true;
        }

        // Geçersiz hücre kontrolü
        if (x < 0 || x >= M || y < 0 || y >= N || !IsAccessible(x, y))
        {
            return false;
        }

        // Hücreyi ziyaret ettiğimizi işaretleyelim
        path.Add((x, y));

        // Aşağı, sağ, yukarı ve sola gitme
        if (FindPath(x + 1, y, M, N, path) || 
            FindPath(x, y + 1, M, N, path) || 
            FindPath(x - 1, y, M, N, path) || 
            FindPath(x, y - 1, M, N, path))
        {
            return true;
        }

        // Gerisi yol değilse geri dön
        path.RemoveAt(path.Count - 1);
        return false;
    }

    static bool IsAccessible(int x, int y)
    {
        return IsPrime(x) && IsPrime(y) && (x + y) % (x * y) == 0;
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}
