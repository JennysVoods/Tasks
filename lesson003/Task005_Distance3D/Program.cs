double Distance3D(int Xa, int Ya, int Za, int Xb, int Yb, int Zb)
{
    double maxX = Xa;
    double minX = Xb;
    double maxY = Ya;
    double minY = Yb;
    double maxZ = Za;
    double minZ = Zb;
    if (minX > maxX)
    {
        maxX = Xb;
        minX = Xa;
    }
    if (minY > maxY)
    {
        maxY = Yb;
        minY = Ya;
    }
    if (minZ > maxZ)
    {
        maxZ = Zb;
        minZ = Za;
    }
    return Math.Sqrt(
        (Math.Pow((maxX - minX), 2)) + (Math.Pow((maxY - minY), 2)) + (Math.Pow((maxZ - minZ), 2))
    );
}
Console.WriteLine(Distance3D(7, -5, 0, 1, -1, 9));
