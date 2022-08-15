/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int CalcNumberDigitsSum(int N)
{
    int remainder = N;
    int sum = 0;
    while (remainder > 0)
    {
        //текущая цифра
        sum += remainder % 10;
        //переходим к следующей цифре
        remainder /= 10;
    }
    return sum;
}

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма цифр в числе {N} равно: {CalcNumberDigitsSum(N)}");