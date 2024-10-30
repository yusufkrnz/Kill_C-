//Time
using System;

class Program
{
    static void Main(string[] args)
    {
        // Şu anki tarihi al
        DateTime now = DateTime.Now;

        // 2000 ile 3000 yılları arasındaki tarihleri kontrol et
        for (int year = 2000; year <= 3000; year++)
        {
            for (int month = 1; month <= 12; month++)
            {
                // O ayın gün sayısını al
                int daysInMonth = DateTime.DaysInMonth(year, month);

                for (int day = 1; day <= daysInMonth; day++)
                {
                    // Geçerli tarih
                    DateTime date = new DateTime(year, month, day);

                    // Şu andan sonraki tarihlere odaklan
                    if (date > now)
                    {
                        // Tarih koşullarını kontrol et
                        if (IsPrime(day) && IsSumOfDigitsEven(month) && IsYearConditionMet(year))
                        {
                            Console.WriteLine(date.ToString("dd/MM/yyyy"));
                        }
                    }
                }
            }
        }
    }

    // Asal sayı kontrolü
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    // Ayın basamaklarının toplamının çift olma durumu
    static bool IsSumOfDigitsEven(int month)
    {
        int sum = 0;
        while (month > 0)
        {
            sum += month % 10;
            month /= 10;
        }
        return sum % 2 == 0;
    }

    // Yılın rakamları toplamının, yılın dörtte birinden küçük olup olmadığını kontrol et
    static bool IsYearConditionMet(int year)
    {
        int sumOfDigits = 0;
        int tempYear = year;

        while (tempYear > 0)
        {
            sumOfDigits += tempYear % 10;
            tempYear /= 10;
        }

        return sumOfDigits < (year / 4);
    }
}
