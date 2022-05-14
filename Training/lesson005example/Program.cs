// 25. Найти сумму чисел от 1 до А

using System.Diagnostics;

int a = 10000000;

double var1(int n)
{
    double[] arr = new double[n + 1];
    for (int i = 0; i <= n; i++)
    {
        arr[i] = i;
    }
    double res = 0;
    for (int i = 0; i <= n; i++)
    {
        res += arr[i];
    }
    return res;
}

double var2(int n)
{
    double res = 0;
    for (int i = 0; i <= n; i++)
    {
        res += i;
    }
    return res;
}

double var3(double n)
{
    return (n*(n+1))/2;
}

Stopwatch sw = new Stopwatch();
sw.Start();
Console.WriteLine(var1(a));
sw.Stop();
Console.WriteLine($"var1 {sw.ElapsedMilliseconds} ms");

sw = new Stopwatch();
sw.Start();
Console.WriteLine(var2(a));
sw.Stop();
Console.WriteLine($"var2 {sw.ElapsedMilliseconds} ms");

sw = new Stopwatch();
sw.Start();
Console.WriteLine(var3(a));
sw.Stop();
Console.WriteLine($"var3 {sw.ElapsedMilliseconds} ms");







// byte h = 255;
// byte s = 1;
// Console.WriteLine((byte)(h+s));
// Console.WriteLine(byte.MinValue);