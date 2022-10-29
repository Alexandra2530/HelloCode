// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int GetDemension(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
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

void FillArray(int[,] array, int n)
{
    int num = 1;
    for (int delta = 0; delta < n - 2; delta++)
    {
        for (int i = 0 + delta; i < n - delta; i++)
        {
            array[0 + delta, i] = num;
            num++;
        }
        num--;
        for (int i = 0 + delta; i < n - delta; i++)
        {
            array[i, n - 1 - delta] = num;
            num++;
        }
        num--;
        for (int i = n - 1 - delta; i >= 0 + delta; i--)
        {
            array[n - 1 - delta, i] = num;
            num++;
        }
        num--;
        for (int i = n - 1 - delta; i >= 1 + delta; i--)
        {
            array[i, 0 + delta] = num;
            num++;
        }
    }
}

int n = GetDemension("Введите количество строк/столбцов");
int[,] massiv = new int[n, n];
FillArray(massiv, n);
PrintArray(massiv);
