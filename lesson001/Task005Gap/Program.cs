int numberN = -4; //предположили что работаем с целыми числами

if (numberN > 0)
{
    int gupN = -numberN;

    while (gupN <= numberN)
    {
        Console.WriteLine(gupN);
        gupN++;
    }
}
else
{
    int gupN = -numberN;

    while (numberN <= gupN)
    {
        Console.WriteLine(numberN);
        numberN++;
    }
}
