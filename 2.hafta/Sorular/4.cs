//4
using System;
using System.Data;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bir matematiksel ifade girin (örn: 3 + 4 * 2 / (1 - 5) ^ 2 ^ 3): ");
        string expression = Console.ReadLine();
        
        try
        {
            DataTable table = new DataTable();
            var result = table.Compute(expression, "");
            Console.WriteLine($"Sonuç: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message);
        }
    }
}

