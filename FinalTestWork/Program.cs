// Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

string[] GetString()
{
    Console.WriteLine("Введите значение через запятую: ");
    return Console.ReadLine().Split(",");
}

int GetLength(string[] arr, int n)
{
    int len = 0;
    for (int k = 0; k < arr.Length; k++)
    {
        if (arr[k].Length <= n)
            len++;
    }
    return len;
}

string[] FindLess(string[] inputMassiv, int n)
{
    string[] result = new string[GetLength(inputMassiv, n)];
    for (int i = 0, j = 0; i < inputMassiv.Length; i++)
    {
        if (inputMassiv[i].Length <= n)
        {
            result[j] = inputMassiv[i];
            j++;
        }
    }
    return result;
}

string[] input = GetString();
string[] output = FindLess(input, 3);

Console.WriteLine($"{string.Join(", ", input)} -> {string.Join(", ", output)}");
