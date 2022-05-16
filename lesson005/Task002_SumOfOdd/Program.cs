// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

void RandomArray(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max+1);
    }
}

int SumOfOdd(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] % 2 != 0) sum += numbers[i];
    }
    return sum;
}

int[] array = new int[10];
RandomArray(array,10, 99);
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"{array[i]} ");
// }
// Console.WriteLine();
int SumNumber = SumOfOdd(array);
Console.WriteLine($"Sum of odd numbers = {SumNumber}");