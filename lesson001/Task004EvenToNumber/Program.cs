int numberN = 8; //предположили что работаем с целыми числами

int numberA = 1;

while (numberA <= numberN)
{
    if (numberA % 2 == 0)
    {
        Console.WriteLine(numberA);
        numberA++;
    }
    else
    {
        numberA++;
    }
}
