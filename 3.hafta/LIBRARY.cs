//Kutuphane
using System;
using System.Collections.Generic;

public class Kitap
{
    public string Ad { get; }
    public string Yazar { get; }

    // Kitap yapıcı metodu
    public Kitap(string ad, string yazar)
    {
        Ad = ad;
        Yazar = yazar;
    }

    // Kitap bilgilerini döndürme
    public string KitapBilgisi()
    {
        return $"{Ad} - {Yazar}";
    }
}

public class Kutuphane
{
    private List<Kitap> Kitaplar;

    // Yapıcı Metot: Kitaplar listesi boş başlatılır
    public Kutuphane()
    {
        Kitaplar = new List<Kitap>();
    }

    // Kitap ekleme metodu
    public void KitapEkle(Kitap yeniKitap)
    {
        this.Kitaplar.Add(yeniKitap);
        Console.WriteLine($"Kitap eklendi: {yeniKitap.KitapBilgisi()}");
    }

    // Tüm kitapları listeleme metodu
    public void KitaplariListele()
    {
        Console.WriteLine("Kütüphanedeki Kitaplar:");
        foreach (var kitap in Kitaplar)
        {
            Console.WriteLine(kitap.KitapBilgisi());
        }
    }
}
