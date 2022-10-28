// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

int[,] GetDemension()
{
    Console.WriteLine("Произведение двух матриц");
    Console.WriteLine();
    Console.WriteLine("Введите количество строк и столбцов: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m, m];
    return array;
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

void MultiplicationArray(int[,] array1, int[,] array2, int[,] array3)
{
    for (int i = 0; i < array1.GetLength (0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(1); k++)
            {
                array3[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
}

int[,] massiv1 = GetDemension();
int[,] massiv2 = new int[massiv1.GetLength(0), massiv1.GetLength(1)];
int[,] massiv3 = new int[massiv1.GetLength(0), massiv1.GetLength(1)];

FillArray(massiv1);
FillArray(massiv2);
PrintArray(massiv1);
PrintArray(massiv2);
MultiplicationArray(massiv1, massiv2, massiv3);
PrintArray(massiv3);
