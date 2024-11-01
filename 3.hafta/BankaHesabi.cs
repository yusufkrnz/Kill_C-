//banka
public class BankaHesabi
{
    public string HesapNumarasi { get; }
    public decimal Bakiye { get; private set; }

    // Yapıcı Metot: Hesap numarasını ve başlangıç bakiyesini alır
    public BankaHesabi(string hesapNumarasi, decimal ilkBakiye)
    {
        HesapNumarasi = hesapNumarasi;
        Bakiye = ilkBakiye;
    }

    // Para yatırma işlemi: Miktar kadar bakiyeyi artırır
    public void ParaYatir(decimal miktar)
    {
        if (miktar > 0)
        {
            Bakiye += miktar;
        }
    }

    // Para çekme işlemi: Bakiyeyi miktar kadar azaltır, eğer bakiye yetersizse işlem yapılmaz
    public void ParaCek(decimal miktar)
    {
        if (miktar > 0 && Bakiye >= miktar)
        {
            Bakiye -= miktar;
        }
    }
}
