using System;

struct Zaman
{
    public int Saat { get; set; }
    public int Dakika { get; set; }

    public Zaman(int saat, int dakika)
    {
        Saat = (saat >= 0 && saat < 24) ? saat : 0;
        Dakika = (dakika >= 0 && dakika < 60) ? dakika : 0;
    }

    public int ToplamDakika() => Saat * 60 + Dakika;

    public static int ZamanFarki(Zaman z1, Zaman z2)
    {
        int dakika1 = z1.ToplamDakika();
        int dakika2 = z2.ToplamDakika();
        return Math.Abs(dakika2 - dakika1);
    }
}
