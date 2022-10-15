// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

void GetMassiv(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-1000, 1001);
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
int GetSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 !=0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

int[] massiv = new int[4];
GetMassiv(massiv);
PrintArray(massiv);
Console.WriteLine("Сумма чисел на нечетных позициях равна " + GetSum(massiv));
