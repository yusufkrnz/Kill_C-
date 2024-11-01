//KİRALIK ARAÇ
public class KiralikArac
{
    public string Plaka { get; }
    public decimal GunlukUcret { get; }
    public bool Durum { get; private set; }

    // Yapıcı Metot: Plaka ve günlük ücret alır;
    // MusaitMi varsayılan olarak true
    public KiralikArac(string plaka, decimal gunlukUcret)
    {
        Plaka = plaka;
        GunlukUcret = gunlukUcret;
        Durum = true;
    }

    // Aracı kiralama metodu: MusaitMi'yi false yapar
    public void AraciKirala()
    {
        if (Durum)
        {
            Durum = false;
        }
    }

    // Aracı teslim etme metodu: MusaitMi'yi true yapar
    public void AraciTeslimEt()
    {
        Durum = true;
    }
}
