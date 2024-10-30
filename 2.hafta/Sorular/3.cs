//3
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Tam sayılar girin (0 ile bitirin): ");
        while (true)
        {
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
                break;
            numbers.Add(number);
        }

        var groups = FindConsecutiveGroups(numbers);
        foreach (var group in groups)
        {
            Console.WriteLine($"{group.Item1}-{group.Item2}");
        }
    }

    static List<(int, int)> FindConsecutiveGroups(List<int> numbers)
    {
        numbers.Sort();
        List<(int, int)> groups = new List<(int, int)>();
        
        for (int i = 0; i < numbers.Count; i++)
        {
            int start = numbers[i];
            while (i + 1 < numbers.Count && numbers[i + 1] == numbers[i] + 1)
            {
                i++;
            }
            int end = numbers[i];
            if (start != end)
                groups.Add((start, end));
        }
        return groups;
    }
}

