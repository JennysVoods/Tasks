void MultipleTwo(int number)
{
    int numberA = 7;
    int numberB = 23;
    if(number % numberA == 0 && number % numberB == 0)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
MultipleTwo(161);


