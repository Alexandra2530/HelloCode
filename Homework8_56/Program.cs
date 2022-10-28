// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] GetDemension()
{
    Console.WriteLine("Введите количество строк: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m, n];
    if (m == n) GetDemension();
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindfSum(int[,] array, int[,] arraySum)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
            if (j == array.GetLength(1) - 1)
            {
                arraySum[i, 0] = sum;
            }
        }
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void CheckLine(int[,] array)
{
    int min = array[0, 0];
    for (int i = 1; i < array.GetLength(0); i++)
    {
        if (array[i, 0] < min)
        {
            min = array[i, 0];
        }
    }
    for (int j = 0; j < array.GetLength(0); j++)
    {
        if (min == array[j, 0])
        {
            Console.WriteLine($"Строка с наименьшей суммой {j + 1}");
        }
    }
}

int[,] massiv = GetDemension();
FillArray(massiv);
PrintArray(massiv);
int[,] sumMassiv = new int[massiv.GetLength(0), 1];
FindfSum(massiv, sumMassiv);
CheckLine(sumMassiv);
