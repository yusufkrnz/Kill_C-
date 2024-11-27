using System;
using System.Collections.Generic;

class OgrenciNotSistemi
{
    private Dictionary<string, int> notlar = new Dictionary<string, int>();

    public int this[string dersAdi]
    {
        get
        {
            if (notlar.ContainsKey(dersAdi))
                return notlar[dersAdi];
            else
                throw new Exception("Ders bulunamadı!");
        }
        set
        {
            if (notlar.ContainsKey(dersAdi))
                notlar[dersAdi] = value;
            else
                throw new Exception("Ders bulunamadı!");
        }
    }

    public void DersEkle(string dersAdi, int notu) => notlar[dersAdi] = notu;
}
