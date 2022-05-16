// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

void ThreeDigitArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(99, 1000);
    }
}

int EvenNumberArray(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] % 2 == 0) count++;
    }
    return count;
}


int[] array = new int[10];
ThreeDigitArray(array);
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"{array[i]} ");
// }
int EvenCount = EvenNumberArray(array);
// Console.WriteLine();
Console.WriteLine($"Number of even numbers = {EvenCount}");
