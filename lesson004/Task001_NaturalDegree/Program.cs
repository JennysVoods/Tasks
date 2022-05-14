// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int NaturalDegree(int A, int B)
{
    if(B < 0) return -1;
    if(A == 0) return 0;
    if(A == 1 || B == 0) return 1;
    if(B == 1) return A;
    int res = 1;
    for (int i = 0; i < B; i++)
    {
        res *= A;
    }
    return res;
}

int result = NaturalDegree(3,10);
if(result == -1) Console.WriteLine("Enter natural number B");
else {Console.WriteLine(result);}
