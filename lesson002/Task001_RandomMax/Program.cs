int GetNumber()
{
    int number = new Random().Next(10, 100);

    int digitA = number / 10;
    int digitB = number % 10;

    //Console.WriteLine($"number: {number}  a: {digitA}  b: {digitB}");

    int max = digitA;
    if (digitB > max)
        max = digitB;
    return max;
}
System.Console.WriteLine(GetNumber());