void ThirdNumber(int number)
{
    if (number > 99)
    {
        string text = number.ToString();
        Console.WriteLine(text[2]);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}
ThirdNumber(32679);
