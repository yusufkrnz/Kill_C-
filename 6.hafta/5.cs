using System;

class OtoparkSistemi
{
    private string[,] katlar = new string[3, 10]; // 3 kat ve her kat 10 park yeri

    public string this[int kat, int parkYeri]
    {
        get
        {
            if (kat < 0 || kat >= 3 || parkYeri < 0 || parkYeri >= 10)
                throw new Exception("Geçersiz park yeri!");
            return katlar[kat, parkYeri] ?? "Empty";
        }
        set
        {
            if (kat < 0 || kat >= 3 || parkYeri < 0 || parkYeri >= 10)
                throw new Exception("Geçersiz park yeri!");
            katlar[kat, parkYeri] = value;
        }
    }
}
