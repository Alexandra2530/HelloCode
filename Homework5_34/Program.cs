// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.

void GetMassiv(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
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
int HonestNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}
int[] massiv = new int[4];
GetMassiv(massiv);
PrintArray(massiv);
Console.WriteLine("Количество четных чисел в массиве: " + HonestNumbers(massiv));
