int Quarter(int x, int y)
{
    if (x != 0 && y != 0)
    {
        int num = 0;
        if (x > 0 && y > 0)
            num = 1;
        if (x > 0 && y < 0)
            num = 2;
        if (x < 0 && y < 0)
            num = 3;
        if (x < 0 && y > 0)
            num = 4;
        return num;
    }
    else
        return -1;
}
int number = Quarter(-1,2); 

if (number == -1)
{
    Console.WriteLine("Number entered incorrectly");
}
else
{
    Console.WriteLine(number);
}
