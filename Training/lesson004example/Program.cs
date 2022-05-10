// Написать программу замену элементов массива на противоположные


// 0. Уточнение
// 1. - создать массив
//    - заполнить массив => два способа
//    - инверсия
//    - печать массива => в консоль и в файл


// 1. - создать массив
int[] CreateArray(int count)
{
    int[] result = new int[count];
    return result;
}

//    - заполнить массив  1 способ
void FillRandomArray(int[] array, int min, int max)
{
    int len = array.Length;

    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

//    - заполнить массив  2 способ
void FillArrayFromConsole(int[] array, int min, int max)
{
    int len = array.Length;

    for (int i = 0; i < len; i++)
    {
        Console.Write($"array[{i}]: ");
        string inputdata = Console.ReadLine();
        array[i] = Convert.ToInt32(inputdata); //конвертировали строку в интеджер
    }
}

//    -инверсия
int[] Inverse(int[] array)
{
    int len = array.Length;
    int[] result = new int[len];
    for (int i = 0; i < len; i++)
    {
        result[i] = -array[i];
    }
    return result;
}

//    - печать массива => в консоль и в файл

string ConvertArrayToString(int[] array)
{
    int len = array.Length;
    string result = String.Empty;
    for (int i = 0; i < len; i++)
    {
        result = result + $"{array[i]} ";
    }
    return result;
}


int[] inArr = CreateArray(10);
FillRandomArray(inArr, 0, 10);
string outStr = ConvertArrayToString(inArr);
Console.WriteLine(outStr);
File.WriteAllText("filein.txt", outStr);
int[] outArr = Inverse(inArr);
outStr = ConvertArrayToString(outArr);
Console.WriteLine(outStr);
File.WriteAllText("fileout.txt", outStr);