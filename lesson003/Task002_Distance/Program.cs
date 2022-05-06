double DistancePoints(double Xa, double Ya, double Xb, double Yb)
{
    double maxX = Xa;
    double minX = Xb;
    double maxY = Ya;
    double minY = Yb;
    if (Xb > Xa)
    {
        maxX = Xb;
        minX = Xa;
    }
    if (Yb > Ya)
    {
        maxY = Yb;
        minY = Ya;
    }
    return Math.Sqrt((Math.Pow((maxX - minX), 2)) + (Math.Pow((maxY - minY), 2)));
}


Console.WriteLine(DistancePoints(7, -5, 1, -1));
