void SquareTable(int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine(Math.Pow(i, 2));
    }
}

SquareTable(10);
