void NegativeFourDigit(int number)
{
    int digit = 0;
    if(number > -10000 && number < -999)
    {
        digit = -number;
        digit = (digit / 10) % 10;
        Console.WriteLine(digit);
    }
    else
    {
        Console.WriteLine("Number entered incorrectly");
    }
}
NegativeFourDigit(-9118);