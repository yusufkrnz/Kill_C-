//KİŞİ
public class Kisi
{
    public string Ad { get; }
    public string Soyad { get; }
    public string TelefonNumarasi { get; }

    // Yapıcı Metot: Ad, soyad ve telefon numarası ile başlatılır
    public Kisi(string ad, string soyad, string telefonNumarasi)
    {
        Ad = ad;
        Soyad = soyad;
        TelefonNumarasi = telefonNumarasi;
    }

    // Kişinin bilgilerini döndürür: Tam adı ve telefon numarası
    public string KisiBilgisi()
    {
        return $"{Ad} {Soyad}, Telefon: {TelefonNumarasi}";
    }
}
