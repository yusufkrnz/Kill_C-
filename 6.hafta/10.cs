using System;

enum HavaDurumu
{
    Güneşli,
    Yağmurlu,
    Bulutlu,
    Fırtınalı
}

class Hava
{
    public void TavsiyeVer(HavaDurumu durum)
    {
        switch (durum)
        {
            case HavaDurumu.Güneşli:
                Console.WriteLine("Güneş gözlüğü tak!");
                break;
            case HavaDurumu.Yağmurlu:
                Console.WriteLine("Şemsiye al!");
                break;
            case HavaDurumu.Bulutlu:
                Console.WriteLine("Dışarıda olmak rahatlayıcı olabilir.");
                break;
            case HavaDurumu.Fırtınalı:
                Console.WriteLine("Dışarı çıkma, evde kal!");
                break;
        }
    }
}
