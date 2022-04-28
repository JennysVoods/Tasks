void SquareNumber(int numberA, int numberB)
{
    if(numberA > numberB)
    {
        if (numberB * numberB == numberA)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }
    else
    {
        if (numberA * numberA == numberB)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }
}

SquareNumber(8,9);