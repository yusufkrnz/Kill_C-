//ÜRÜN 
public class Urun
{
    public string Ad { get; }
    public decimal Fiyat { get; }
    private decimal indirim;

    // İndirim get/set: 0 ile 50 arasında sınırlandırılmış
    public decimal Indirim
    {
        get { return indirim; }
        set { indirim = (value >= 0 && value <= 50) ? value : 0; }
    }

    // Yapıcı Metot: Ad ve fiyat ile başlatılır
    public Urun(string ad, decimal fiyat)
    {
        Ad = ad;
        Fiyat = fiyat;
        Indirim = 0; // Başlangıçta indirim yok
    }

    // İndirimli fiyatı döndüren metot
    public decimal IndirimliFiyat()
    {
        return Fiyat * (1 - Indirim / 100);
    }
}
