using System;

struct GPSKonum
{
    public double Enlem { get; set; }
    public double Boylam { get; set; }

    public GPSKonum(double enlem, double boylam)
    {
        Enlem = enlem;
        Boylam = boylam;
    }

    public double Mesafe(GPSKonum diğeri)
    {
        double R = 6371; // Dünya'nın yarıçapı (km)
        double lat1 = Enlem * (Math.PI / 180);
        double lon1 = Boylam * (Math.PI / 180);
        double lat2 = diğeri.Enlem * (Math.PI / 180);
        double lon2 = diğeri.Boylam * (Math.PI / 180);

        double dlat = lat2 - lat1;
        double dlon = lon2 - lon1;

        double a = Math.Sin(dlat / 2) * Math.Sin(dlat / 2) +
                   Math.Cos(lat1) * Math.Cos(lat2) *
                   Math.Sin(dlon / 2) * Math.Sin(dlon / 2);

        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

        return R * c; // km cinsinden mesafe
    }
}
