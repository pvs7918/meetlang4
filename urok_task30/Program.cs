/*Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями
и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */


void FillArray(int []arr)
{
    Random rnd = new Random();
    
    for (int i=0;i<arr.Length;i++)
    {
        arr[i]=rnd.Next(0,2);
    }
}

void ViewArray(int []arr)
{
    string str = string.Empty;
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
    Console.WriteLine(str);
}

int size = 8;
int []arr = new int[size];
FillArray(arr);
ViewArray(arr);