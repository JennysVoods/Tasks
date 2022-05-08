void SquareNumber(int numberA, int numberB)
{
    if (numberB * numberB == numberA || numberA * numberA == numberB)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

SquareNumber(5, 25);
