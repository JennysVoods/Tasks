// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.


void RandomArray(double[] arr, int range)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble() + range;
    }
}

double[] MinMaxArray(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
        if (arr[i] < min)
            min = arr[i];
    }
    double[] MinMax = new double[2] { min, max };
    return MinMax;
}

double Difference(double[] MinMax)
{
    double diff = MinMax[1] - MinMax[0];
    return diff;
}

double[] array = new double[10]; //Задаем количество чисел в массиве
RandomArray(array, 10); //Задаем диапазон получения значений
double diff = Difference(MinMaxArray(array));
Console.WriteLine($"Difference between minimum and maximum number = {diff}");
