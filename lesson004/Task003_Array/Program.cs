// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


void FillRandomArray(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return ;
}

void PrintArray(int[] ar )
{
   for (int i = 0; i < ar.Length; i++)
   {
       Console.Write($"{ar[i]} ");
   }
}
int[] array = new int[8];
FillRandomArray(array,1,100);
PrintArray(array);