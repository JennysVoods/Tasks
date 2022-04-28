void NumberTwo(int ThreeDigitNumber)
{
    int digit = 0;
    if (ThreeDigitNumber > 99 && ThreeDigitNumber < 1000)
    {
        digit = (ThreeDigitNumber / 10) % 10;
        Console.WriteLine(digit);
    }
    else
    {
        Console.WriteLine("Number entered incorrectly");
    }
}
NumberTwo(4156);
