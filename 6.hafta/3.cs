using System;

class SatrançTahtası
{
    private string[,] tahta = new string[8, 8];

    public string this[int satir, int sutun]
    {
        get
        {
            if (satir < 0 || satir >= 8 || sutun < 0 || sutun >= 8)
                throw new Exception("Geçersiz kare!");
            return tahta[satir, sutun] ?? "Boş";
        }
        set
        {
            if (satir < 0 || satir >= 8 || sutun < 0 || sutun >= 8)
                throw new Exception("Geçersiz kare!");
            tahta[satir, sutun] = value;
        }
    }

    public void TaşYerleştir(int satir, int sutun, string tas)
    {
        if (satir >= 0 && satir < 8 && sutun >= 0 && sutun < 8)
            tahta[satir, sutun] = tas;
        else
            Console.WriteLine("Geçersiz kare!");
    }
}
