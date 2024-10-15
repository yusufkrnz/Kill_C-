using System;

class PrimeSum
{
    // Asal sayıyı kontrol eden fonksiyon
    static bool AsalMi(int sayi)
    {
        if (sayi <= 1)
            return false;  // 1 ve 1'den küçük sayılar asal değildir

        for (int i = 2; i <= Math.Sqrt(sayi); i++)
        {
            if (sayi % i == 0)  // Eğer herhangi bir böleni varsa asal değildir
                return false;
        }
        return true;  // Asal sayıdır
    }

    static void Main(string[] args)
    {
        // Kullanıcıdan N sayısını alıyoruz
        Console.WriteLine("Bir sayı giriniz: ");
        int n = int.Parse(Console.ReadLine());

        int toplam = 0;

        // 2'den N'ye kadar tüm sayıları kontrol ediyoruz
        for (int i = 2; i <= n; i++)
        {
            if (AsalMi(i))  // Eğer i asal ise toplam değişkenine ekliyoruz
            {
                toplam += i;
            }
        }

        // Sonucu yazdırıyoruz
        Console.WriteLine($"1'den {n}'ye kadar olan asal sayıların toplamı: {toplam}");
    }
}
