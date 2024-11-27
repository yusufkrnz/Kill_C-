using System;
using System.Collections.Generic;

class Kitaplik
{
    private List<string> kitaplar = new List<string>();

    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= kitaplar.Count)
                return "Geçersiz indeks!";
            return kitaplar[index];
        }
        set
        {
            if (index >= 0 && index < kitaplar.Count)
                kitaplar[index] = value;
            else
                Console.WriteLine("Geçersiz indeks!");
        }
    }

    public void KitapEkle(string kitap) => kitaplar.Add(kitap);
}
