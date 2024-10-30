
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Örnek sayı dizisi
        List<double> numbers = new List<double> { 5, 3, 2, 8 };
        List<char> operators = new List<char> { '+', '-', '*', '/' };

        // Başlangıçta geçerli işlemlerin listesi
        List<string> validExpressions = new List<string>();

        // Tüm kombinasyonları bul
        GenerateExpressions(numbers, operators, "", validExpressions);

        // Geçerli ifadeleri ekrana yazdır
        Console.WriteLine("Geçerli ifadeler:");
        foreach (var expression in validExpressions)
        {
            Console.WriteLine(expression);
        }
    }

    static void GenerateExpressions(List<double> numbers, List<char> operators, string currentExpression, List<string> validExpressions)
    {
        // Eğer sayılar kalmadıysa, sonucu değerlendir
        if (numbers.Count == 0)
        {
            if (EvaluateExpression(currentExpression) > 0)
            {
                validExpressions.Add(currentExpression);
            }
            return;
        }

        // Sayıları ve operatörleri kullanarak yeni ifadeler oluştur
        for (int i = 0; i < numbers.Count; i++)
        {
            double number = numbers[i];

            // Mevcut ifadenin üzerine yeni sayı ekle
            string newExpression = currentExpression == "" ? number.ToString() : $"{currentExpression}{number}";

            // Sayıyı listeden çıkar
            List<double> remainingNumbers = new List<double>(numbers);
            remainingNumbers.RemoveAt(i);

            // Eğer mevcut ifade boş değilse operatör ekle
            if (!string.IsNullOrEmpty(currentExpression))
            {
                foreach (var op in operators)
                {
                    // Operatör ekleyerek yeni ifadeleri oluştur
                    GenerateExpressions(remainingNumbers, operators, $"{newExpression}{op}", validExpressions);
                }
            }
            else
            {
                // İlk sayı ekleme, operatör ekleme gerekmiyor
                GenerateExpressions(remainingNumbers, operators, newExpression, validExpressions);
            }
        }
    }

    static double EvaluateExpression(string expression)
    {
        try
        {
            // Basit bir ifade değerlendirme, kullanıcının daha karmaşık ifadeleri değerlendirmesi gerekir
            var dataTable = new System.Data.DataTable();
            return Convert.ToDouble(dataTable.Compute(expression, ""));
        }
        catch
        {
            return -1; // Hata durumunda negatif bir değer döndür
        }
    }
}
