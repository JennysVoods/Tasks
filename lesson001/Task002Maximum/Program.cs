int numberA = 22; //предположили что работаем с целыми числами
int numberB = 3;
int numberC = 9;
int max = numberA;

if (numberB > max)
    max = numberB;
if (numberC > max)
    max = numberC;

Console.Write("max = ");
Console.WriteLine(max);
