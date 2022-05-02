void DayOff(int day)
{
    if (day > 0 && day < 8)
    {
        if (day == 6 || day == 7)
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
        Console.WriteLine("Number entered incorrectly");
    }
}

DayOff(1);
