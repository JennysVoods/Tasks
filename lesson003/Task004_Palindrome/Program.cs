// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

// 1. Задать число : с клавиатуры/рандом
// 2. Проверить является ли число 5 значным
// 3. проверить палиндром или нет
// 4. Вывести ответ




int number = 14241;

// int Number()
// {
//     int number = new Random().Next(10000, 100000);
//     return number;
// }
// Console.WriteLine(Number());





int FiveNumber(int number)
{
    if (number > 9999 && number < 100000)
        return number;
    else
        return -1;
}

void Palindrom(int numb)
{
    if (numb == -1)
    {
        Console.WriteLine("Number entered incorrectly");
    }
    else
    {
        string digit = numb.ToString();
        if (digit.Reverse().SequenceEqual(digit))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

int num = FiveNumber(number); //Меняем аргумент в зависимости от ввода числа, при вводе случайного числа можно не использовать метод FiveNumber().
Palindrom(num);
