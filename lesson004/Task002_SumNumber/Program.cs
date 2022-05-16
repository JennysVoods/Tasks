// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int SumNumber(int num)
{
    string stringNum = num.ToString();
    int sum = 0;
    for (int i = 0; i < stringNum.Length; i++)
    {
        int numb = Convert.ToInt32(Convert.ToString(stringNum[i]));
        sum += numb;
    }
    return sum;
}
Console.WriteLine(SumNumber(1231));
