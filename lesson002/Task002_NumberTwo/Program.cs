int NumberTwo(int number)
{
    int digit = -1;
    if (number > 99 && number < 1000)
    {
        digit = (number / 10) % 10;
    }
    return digit;
}

int ThreeDigitNumber = 357;
System.Console.WriteLine(NumberTwo(ThreeDigitNumber));
