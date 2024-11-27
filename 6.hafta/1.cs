using System;
using System.Collections.Generic;

class OverloadingExamples
{
    // 1.1 Matematiksel İşlemleri Çeşitlendiren Bir Fonksiyon
    public int Topla(int a, int b) => a + b;

    public int Topla(int a, int b, int c) => a + b + c;

    public int Topla(int[] sayilar) => sayilar.Length > 0 ? sayilar.Sum() : 0;

    // 1.2 Farklı Şekillerin Alanını Hesaplama
    public int Alan(int kenar) => kenar * kenar; // Karenin alanı

    public int Alan(int uzunKenar, int kisaKenar) => uzunKenar * kisaKenar; // Dikdörtgenin alanı

    public double Alan(double yaricap) => Math.PI * yaricap * yaricap; // Dairenin alanı

    // 1.3 Zaman Farkını Farklı Formatlarda Hesaplama
    public int TarihFarkiGun(DateTime t1, DateTime t2) => Math.Abs((t2 - t1).Days);

    public int TarihFarkiSaat(DateTime t1, DateTime t2) => Math.Abs((int)(t2 - t1).TotalHours);

    public (int Yil, int Ay, int Gun) TarihFarkiDetay(DateTime t1, DateTime t2)
    {
        var fark = t2 - t1;
        int yil = fark.Days / 365;
        int ay = (fark.Days % 365) / 30;
        int gun = (fark.Days % 365) % 30;
        return (yil, ay, gun);
    }
}
