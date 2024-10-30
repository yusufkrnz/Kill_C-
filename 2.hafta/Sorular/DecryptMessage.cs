
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // Fibonacci sayılarını hesaplamak için bir metot
    static List<int> Fibonacci(int n)
    {
        List<int> fib = new List<int> { 1, 1 };
        for (int i = 2; i < n; i++)
        {
            fib.Add(fib[i - 1] + fib[i - 2]);
        }
        return fib;
    }

    // Asal sayıları kontrol etmek için bir metot
    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    // Şifrelenmiş mesajı çözmek için bir metot
    static string DecryptMessage(string encryptedMessage)
    {
        int length = encryptedMessage.Length;
        List<int> fibonacciNumbers = Fibonacci(length);
        char[] decryptedMessage = new char[length];

        for (int i = 0; i < length; i++)
        {
            // Şifreli karakterin ASCII değerini al
            int encryptedAscii = (int)encryptedMessage[i];

            // Fibonacci sayısını kullanarak orijinal ASCII değerini bul
            int originalAscii;

            if (IsPrime(i + 1)) // pozisyon 1'den başladığı için i+1
            {
                // Pozisyon asal ise 100 ile mod
                originalAscii = (encryptedAscii + 100) % 100;
            }
            else
            {
                // Pozisyon asal değilse 256 ile mod
                originalAscii = (encryptedAscii + 256) % 256;
            }

            // Fibonacci ile bölündüğünde kalan olarak geri almak için
            originalAscii /= fibonacciNumbers[i];

            // ASCII karakterini elde et
            decryptedMessage[i] = (char)originalAscii;
        }

        return new string(decryptedMessage);
    }

    static void Main(string[] args)
    {
        // Şifreli mesajı burada tanımlayın
        string encryptedMessage = "Şifrelendmiş mesaj"; // Burada örnek bir şifreli mesaj kullanabilirsiniz.

        // Mesajı çöz
        string decryptedMessage = DecryptMessage(encryptedMessage);
        Console.WriteLine("Çözülmüş Mesaj: " + decryptedMessage);
    }
}
