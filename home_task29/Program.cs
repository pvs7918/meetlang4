/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


void CreateRandomArray(int []arr, int MaxValue)
{
    Random rnd = new Random();
    
    for (int i=0;i<arr.Length;i++)
    {
        arr[i]=rnd.Next(1, MaxValue+1);
    }
}

void ViewRandomArray(int []arr)
{
    string str = "[";
    Console.WriteLine("Значения элементов массива: ");
    for (int i=0;i<arr.Length;i++)
    {
        if (i==0)
        {
            str+=arr[i];
        }
        else
        {
            str+=$", {arr[i]}";
        }
    }
    str += "]";
    Console.WriteLine(str);
}

int size = 8;
int []arr = new int[size];

Console.Write("Введите максимальное значение для элементов массива: ");
int MaxValue = int.Parse(Console.ReadLine()!);

CreateRandomArray(arr, MaxValue);
ViewRandomArray(arr);