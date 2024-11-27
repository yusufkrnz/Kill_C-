using System;

enum CalisanRolü
{
    Müdür,
    Yazılımcı,
    Tasarımcı,
    Testci
}

class MaaşHesaplama
{
    public double MaaşHesapla(CalisanRolü rol)
    {
        switch (rol)
        {
            case CalisanRolü.Müdür:
                return 10000;
            case CalisanRolü.Yazılımcı:
                return 8000;
            case CalisanRolü.Tasarımcı:
                return 7000;
            case CalisanRolü.Testci:
                return 6000;
            default:
                return 0;
        }
    }
}
