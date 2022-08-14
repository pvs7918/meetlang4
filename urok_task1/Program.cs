// Вывести сумму от 1 до N

int GetSumFrom1ToN(int N)
{
    int sum = 0;
    for (int i=1;i<=N;i++){
        sum+=i;
    }
    return sum;
}

Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine()!);
int sum = 0;



Console.Write($"Сумма от 1 до N равна: {GetSumFrom1ToN(N)}");