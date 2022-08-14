/* Задача 25: 
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит
число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


int MyPow(int A, int B)
{
    int res = 1;
    int i;

    for(i=1;i<=B;i++)
    {
        res*=A;
    }
    return res;
}

Console.Write("Введите A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите B: ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число {A} в степени {B} равно: {MyPow(A,B)}");