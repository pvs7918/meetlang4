/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/


int CalcNumbersDigitCount(int N)
{
    int cnt = 0;
    int remainder=N;
    
    while (remainder>0)
    {
        if (remainder<10)
        {
            cnt+=1;
            break;
        }
        else
        {
            remainder/=10;
            cnt+=1;
        }
    }

    return cnt;
}

Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Количество цифр в числе {N} равно: {CalcNumbersDigitCount(N)}");