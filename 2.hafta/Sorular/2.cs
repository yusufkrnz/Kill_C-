//2
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Pozitif tam sayılar girin (0 ile bitirin): ");
        while (true)
        {
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
                break;
            if (number > 0)
                numbers.Add(number);
        }

        if (numbers.Count > 0)
        {
            double average = CalculateAverage(numbers);
            double median = CalculateMedian(numbers);
            Console.WriteLine("Ortalama: " + average);
            Console.WriteLine("Medyan: " + median);
        }
        else
        {
            Console.WriteLine("Hiç sayı girilmedi.");
        }
    }

    static double CalculateAverage(List<int> numbers)
    {
        double sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }
        return sum / numbers.Count;
    }

    static double CalculateMedian(List<int> numbers)
    {
        numbers.Sort();
        int count = numbers.Count;
        if (count % 2 == 0)
        {
            return (numbers[count / 2 - 1] + numbers[count / 2]) / 2.0;
        }
        else
        {
            return numbers[count / 2];
        }
    }
}
