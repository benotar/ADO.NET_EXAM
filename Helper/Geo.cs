namespace exam2.Helper;

using M = Math;

public static class Geo
{
    private const double EarthRadius = 6371.0D;

    private const double Radian = M.PI / 180;

    public static double GetDistance(double latitude1, double longitude1, double latitude2, double longitude2)
    {
        var temp = 0.5 - M.Cos((latitude2 - latitude1) * Radian) / 2
                   + M.Cos(latitude1 * Radian) * M.Cos(latitude2 * Radian)
                                               * (1 - M.Cos((longitude2 - longitude1) * Radian)) / 2;

        return 2 * EarthRadius * M.Asin(M.Sqrt(temp));
    }
}