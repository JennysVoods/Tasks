int Multiplicity(int numberA, int numberB)
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
    return;
}

int digitA = 16;
int digitB = 4;
