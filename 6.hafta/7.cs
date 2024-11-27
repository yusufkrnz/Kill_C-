using System;

struct KarmaşıkSayı
{
    public double Gerçek { get; set; }
    public double Sanal { get; set; }

    public KarmaşıkSayı(double gerçek, double sanal)
    {
        Gerçek = gerçek;
        Sanal = sanal;
    }

    public static KarmaşıkSayı operator +(KarmaşıkSayı k1, KarmaşıkSayı k2) =>
        new KarmaşıkSayı(k1.Gerçek + k2.Gerçek, k1.Sanal + k2.Sanal);

    public static KarmaşıkSayı operator -(KarmaşıkSayı k1, KarmaşıkSayı k2) =>
        new KarmaşıkSayı(k1.Gerçek - k2.Gerçek, k1.Sanal - k2.Sanal);

    public override string ToString() => $"{Gerçek} + {Sanal}i";
}
