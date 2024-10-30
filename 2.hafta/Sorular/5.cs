//5
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("İki polinom girin (örn: 2x^2 + 3x - 5 ve x^2 - 4). Çıkmak için 'exit' yazın: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "exit")
                break;

            var polynomials = input.Split(new[] { " ve " }, StringSplitOptions.None);
            if (polynomials.Length == 2)
            {
                string poly1 = polynomials[0].Trim();
                string poly2 = polynomials[1].Trim();
                var resultSum = AddPolynomials(poly1, poly2);
                var resultSubtract = SubtractPolynomials(poly1, poly2);
                Console.WriteLine($"Toplam: {resultSum}");
                Console.WriteLine($"Fark: {resultSubtract}");
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen iki polinom girin.");
            }
        }
    }

    static string AddPolynomials(string poly1, string poly2)
    {
        // Burada polinom toplama işlemi için gerekli kodu ekleyin
        return $"({poly1}) + ({poly2})"; // Geçici sonuç
    }

    static string SubtractPolynomials(string poly1, string poly2)
    {
        // Burada polinom çıkarma işlemi için gerekli kodu ekleyin
        return $"({poly1}) - ({poly2})"; // Geçici sonuç
    }
}

