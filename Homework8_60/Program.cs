// Задача 60. Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно
// выводить массив, добавляя индексы каждого элемента.

int[,,] GetDemension()
{
    Console.WriteLine("Введите количество строк: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите глубину массива: ");
    int l = Convert.ToInt32(Console.ReadLine());
    int[,,] array = new int[m, n, l];
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j, k]} ({i}, {j}, {k})");
        }
        Console.WriteLine();
        }
    }
    Console.WriteLine();
}

void FillArray(int[,,] array)
{
    int count = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(1, 10);
                array[i, j, k] = count;
                count += 1;
                if (count >= 100) break;
            }
            if  (count >= 100) break;
        }
        if  (count >= 100) break;
    }
}

void CheckDoubleArray(int[,,] array)
{
    int count = 0;
    int temp = array[count,count,count];
    for (int i = 0; i < array.GetLength(0); i++);
    {
        for (int j = 0; j < array.GetLength(1); j++)
        if (count >= 100)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == temp)
                {
                    array[i, j, k] = new Random().Next(1, 10);
                    count = 0;
                    i = 0;
                    j = 0;
                    k = 0;
                }
            }
            Console.WriteLine("Массив слишком большой");
        }
    }
    count+=1;
}

int[,,] massiv = GetDemension();
FillArray(massiv);
PrintArray(massiv);
CheckDoubleArray(massiv);
PrintArray(massiv);