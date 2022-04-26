int GetNumber()
{
    int number = new Random().Next(10, 100);

    int a = number / 10;
    int b = number % 10;

    //Console.WriteLine($"number: {number}  a: {a}  b: {b}");

    int max = a;
    if (b > max)
        max = b;
    return max;
}
System.Console.WriteLine(GetNumber());