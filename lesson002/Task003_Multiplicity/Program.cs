void Multiplicity(int numberA, int numberB)
{
    int number = 0;

    if (numberA % numberB == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        number = numberA % numberB;
        Console.WriteLine($"Не кратно, остаток {number}");
    }
}
Multiplicity(34, 5);