//1.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bir dizi tam sayı girin (virgül ile ayırarak): ");
        string[] input = Console.ReadLine().Split(',');
        int[] numbers = Array.ConvertAll(input, int.Parse);
        
        Array.Sort(numbers);
        
        Console.WriteLine("Sıralı dizi: " + string.Join(", ", numbers));
        
        Console.WriteLine("Kontrol edilecek bir sayı girin: ");
        int searchNumber = int.Parse(Console.ReadLine());
        
        bool found = BinarySearch(numbers, searchNumber);
        Console.WriteLine(found ? "Sayı dizide var." : "Sayı dizide yok.");
    }

    static bool BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;
        
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return true;
            if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return false;
    }
}
