using System;

enum TrafikIsigi
{
    Kırmızı,
    Sarı,
    Yeşil
}

class Trafik
{
    public void DurumTavsiye(TrafikIsigi durum)
    {
        switch (durum)
        {
            case TrafikIsigi.Kırmızı:
                Console.WriteLine("Dur!");
                break;
            case TrafikIsigi.Sarı:
                Console.WriteLine("Hazır ol!");
                break;
            case TrafikIsigi.Yeşil:
                Console.WriteLine("Geç!");
                break;
        }
    }
}
